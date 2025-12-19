using System;
using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow.Handlers
{
    public class DepartmentManagerHandler : LeaveApproverBase
    {
        public override Task<bool> HandleAsync(LeaveRequest request, CancellationToken ct = default)
        {
            if (request.LeaveDays > 3 && request.LeaveDays <= 7)
            {
                request.Status = LeaveStatus.Approved;
                request.logs.Add(new Log("Level3: Department Manager Approval", DateTimeOffset.UtcNow, "Department Manager", LeaveStatus.Approved, "Approved by Department Manager"));
                return Task.FromResult(true);
            }
            else if (request.LeaveDays > 7)
            {
                request.logs.Add(new Log("Level3: Department Manager Approval", DateTimeOffset.UtcNow, "Department Manager", LeaveStatus.Padding, "Forwarded to General Manager"));
                return Task.FromResult(true);
            }
            
            return Task.FromResult(true);
        }
    }
}
