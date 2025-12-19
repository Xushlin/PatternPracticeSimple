using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    [Description("1.2.1 Chain Of Responsibility - Approve Flow (With DI)")]
    public class App
    {
        public static async Task Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("方式1: 使用接口集合注入");
            Console.WriteLine("========================================\n");
            await RunWithInterfaceInjection();
            
            Console.WriteLine("\n\n========================================");
            Console.WriteLine("方式2: 使用工厂方法显式注入");
            Console.WriteLine("========================================\n");
            await RunWithExplicitInjection();
            
            Console.WriteLine("\n\n========================================");
            Console.WriteLine("方式3: 传统方式（不使用DI）");
            Console.WriteLine("========================================\n");
            await RunWithoutDependencyInjection();
        }

        /// <summary>
        /// 方式1: 使用接口集合注入（最灵活）
        /// </summary>
        private static async Task RunWithInterfaceInjection()
        {
            // 配置依赖注入容器
            var services = new ServiceCollection();
            services.AddLeaveApprovalChain();  // 使用接口集合注入
            
            // 构建服务提供者
            var serviceProvider = services.BuildServiceProvider();
            
            // 从容器中获取责任链
            var approvalChain = serviceProvider.GetRequiredService<ILeaveApprovalChain>();
            
            // 执行审批
            await ExecuteApproval(approvalChain, "Alice", 10);
        }

        /// <summary>
        /// 方式2: 使用工厂方法显式注入（更明确）
        /// </summary>
        private static async Task RunWithExplicitInjection()
        {
            // 配置依赖注入容器
            var services = new ServiceCollection();
            services.AddLeaveApprovalChainExplicit();  // 使用工厂方法
            
            // 构建服务提供者
            var serviceProvider = services.BuildServiceProvider();
            
            // 从容器中获取责任链
            var approvalChain = serviceProvider.GetRequiredService<ILeaveApprovalChain>();
            
            // 执行审批
            await ExecuteApproval(approvalChain, "Bob", 5);
        }

        /// <summary>
        /// 方式3: 传统方式（不使用依赖注入）
        /// </summary>
        private static async Task RunWithoutDependencyInjection()
        {
            var leaveApprover = new Handlers.TeamLeaderHandler();
            leaveApprover.SetNext(new Handlers.ProjectManagerHandler())
                         .SetNext(new Handlers.DepartmentManagerHandler())
                         .SetNext(new Handlers.GeneralManagerHandler())
                         .SetNext(new Handlers.HRHandler());

            var leaveRequest = new LeaveRequest
            {
                EmployeeName = "Charlie", 
                LeaveDays = 2, 
                Reason = "Vacation"
            };
            
            await leaveApprover.ApproveAsync(leaveRequest);

            PrintLogs(leaveRequest);
        }

        /// <summary>
        /// 执行审批流程的辅助方法
        /// </summary>
        private static async Task ExecuteApproval(ILeaveApprovalChain chain, string employeeName, int leaveDays)
        {
            var leaveRequest = new LeaveRequest
            {
                EmployeeName = employeeName, 
                LeaveDays = leaveDays, 
                Reason = "Vacation"
            };
            
            await chain.ApproveAsync(leaveRequest);
            
            PrintLogs(leaveRequest);
        }

        /// <summary>
        /// 打印审批日志
        /// </summary>
        private static void PrintLogs(LeaveRequest request)
        {
            Console.WriteLine($"员工: {request.EmployeeName}, 请假天数: {request.LeaveDays}天");
            Console.WriteLine($"最终状态: {request.Status}\n");
            
            foreach (var item in request.logs)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}
