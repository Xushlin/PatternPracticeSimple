using System;
using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers
{
    public class ProjectManagerHandler : LeaveApproverBase
    {
        public override Task<bool> HandleAsync(LeaveRequest request, CancellationToken ct = default)
        {
            if (request.LeaveDays > 1 && request.LeaveDays <= 3)
            {
                request.Status = LeaveStatus.Approved;
                request.logs.Add(new Log("Level2: Manager Approval", DateTimeOffset.UtcNow, "Manager", LeaveStatus.Approved, "Approved by Manager"));
                return Task.FromResult(true);
            }
            else if (request.LeaveDays > 3)
            {
                request.logs.Add(new Log("Level2: Manager Approval", DateTimeOffset.UtcNow, "Manager", LeaveStatus.Padding, "Forwarded to Department Manager"));
                return Task.FromResult(true);
            }
            
            return Task.FromResult(true);
        }
    }
}
