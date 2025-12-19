using System;
using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers
{
    public class TeamLeaderHandler : LeaveApproverBase
    {
        public override Task<bool> HandleAsync(LeaveRequest request, CancellationToken ct = default)
        {
            Console.WriteLine($"TeamLeaderHandler: LeaveDays = {request.LeaveDays}");
            if (request.LeaveDays <= 1)
            {
                request.Status = LeaveStatus.Approved;
                request.logs.Add(new Log("Level1: Team Leader Approval", DateTimeOffset.UtcNow, "Team Leader", LeaveStatus.Approved, "Approved by Team Leader"));
                // 已批准，但仍可继续给 HR 备案：这里选择继续
                return Task.FromResult(true);
            }

            request.logs.Add(new Log("Level1: Team Leader Approval", DateTimeOffset.UtcNow, "Team Leader", LeaveStatus.Padding, "Forwarded to Manager"));
            // 未处理，继续传递给下一个处理者
            return Task.FromResult(true);
        }
    }
}
