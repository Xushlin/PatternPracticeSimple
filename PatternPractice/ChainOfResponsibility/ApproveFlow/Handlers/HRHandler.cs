using System;
using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers
{

    public class HRHandler : LeaveApproverBase
    {
        public override Task<bool> HandleAsync(LeaveRequest request, CancellationToken ct = default)
        {
            Console.WriteLine($"HRHandler: LeaveDays = {request.LeaveDays}");
            // HR 最终备案
            request.logs.Add(new Log("HR Record", DateTimeOffset.UtcNow, "HR", request.Status, "Recorded by HR"));
            // HR 备案后，流程结束
            return Task.FromResult(false);
        }
    }
}
