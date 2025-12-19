using PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    [Description("1.2.1 Chain Of Responsibility - Approve Flow")]
    public class App
    {
        public static async Task Main()
        {
            var leaveApprover = new TeamLeaderHandler();
            leaveApprover.SetNext(new ProjectManagerHandler())
                         .SetNext(new DepartmentManagerHandler())
                         .SetNext(new GeneralManagerHandler())
                         .SetNext(new HRHandler());

            var leaveRequest = new LeaveRequest{EmployeeName = "Michael Xu", LeaveDays = 10, Reason = "Vacation"};
            await leaveApprover.ApproveAsync(leaveRequest);

            foreach (var item in leaveRequest.logs)
            {
                Console.WriteLine(item);
                Console.WriteLine("=============================================");
            }            
        }
    }
}
