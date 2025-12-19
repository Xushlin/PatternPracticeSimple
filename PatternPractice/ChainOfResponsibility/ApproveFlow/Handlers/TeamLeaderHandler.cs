using System;
using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers
{
    public class TeamLeaderHandler : LeaveApproverBase
    {
        public override Task<bool> HandleAsync(LeaveRequest request, CancellationToken ct = default)
        {
            if (request.LeaveDays <= 1)
            {
                request.Status = LeaveStatus.Approved;
                request.logs.Add(new Log("Level1: Team Leader Approval", DateTimeOffset.UtcNow, "Team Leader", LeaveStatus.Approved, "Approved by Team Leader"));
                return Task.FromResult(true);
            }

            request.logs.Add(new Log("Level1: Team Leader Approval", DateTimeOffset.UtcNow, "Team Leader", LeaveStatus.Padding, "Forwarded to Manager"));
            return Task.FromResult(true);
        }
    }
}
