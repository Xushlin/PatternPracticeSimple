using Microsoft.Extensions.DependencyInjection;
using PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    /// <summary>
    /// 依赖注入扩展方法
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 注册请假审批责任链（按顺序注册）
        /// </summary>
        public static IServiceCollection AddLeaveApprovalChain(this IServiceCollection services)
        {
            // 方式1: 按顺序注册所有处理器到接口集合
            // 注意：注册顺序很重要！按照审批流程的顺序注册
            services.AddTransient<ILeaveApprover, TeamLeaderHandler>();
            services.AddTransient<ILeaveApprover, ProjectManagerHandler>();
            services.AddTransient<ILeaveApprover, DepartmentManagerHandler>();
            services.AddTransient<ILeaveApprover, GeneralManagerHandler>();
            services.AddTransient<ILeaveApprover, HRHandler>();

            // 注册责任链
            services.AddTransient<ILeaveApprovalChain, LeaveApprovalChain>();

            return services;
        }

        /// <summary>
        /// 注册请假审批责任链（使用具体类型，更明确）
        /// </summary>
        public static IServiceCollection AddLeaveApprovalChainExplicit(this IServiceCollection services)
        {
            // 方式2: 显式注册每个处理器的具体类型
            services.AddTransient<TeamLeaderHandler>();
            services.AddTransient<ProjectManagerHandler>();
            services.AddTransient<DepartmentManagerHandler>();
            services.AddTransient<GeneralManagerHandler>();
            services.AddTransient<HRHandler>();

            // 使用工厂方法创建责任链，显式控制顺序
            services.AddTransient<ILeaveApprovalChain>(sp =>
            {
                var handlers = new ILeaveApprover[]
                {
                    sp.GetRequiredService<TeamLeaderHandler>(),
                    sp.GetRequiredService<ProjectManagerHandler>(),
                    sp.GetRequiredService<DepartmentManagerHandler>(),
                    sp.GetRequiredService<GeneralManagerHandler>(),
                    sp.GetRequiredService<HRHandler>()
                };
                
                return new LeaveApprovalChain(handlers);
            });

            return services;
        }
    }
}
