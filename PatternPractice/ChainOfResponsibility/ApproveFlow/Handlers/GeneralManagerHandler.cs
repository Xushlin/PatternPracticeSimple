using System;
using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers
{
    public class GeneralManagerHandler: LeaveApproverBase
    {
        public override Task<bool> HandleAsync(LeaveRequest request, CancellationToken ct = default)
        {
            if (request.LeaveDays > 7)
            {
                request.Status = LeaveStatus.Approved;
                request.logs.Add(new Log("Level4: General Manager Approval", DateTimeOffset.UtcNow, "General Manager", LeaveStatus.Approved, "Approved by General Manager"));
                return Task.FromResult(true);
            }
            
            return Task.FromResult(true);
        }
    }
}
