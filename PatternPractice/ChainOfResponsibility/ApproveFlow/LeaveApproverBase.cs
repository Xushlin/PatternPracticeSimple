using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    public abstract class LeaveApproverBase : ILeaveApprover
    {
        private ILeaveApprover _nextApprover;

        public LeaveApproverBase SetNext(ILeaveApprover nextApprover)
        {
            _nextApprover = nextApprover;
            return (LeaveApproverBase)_nextApprover;
        }

        public async Task ApproveAsync(LeaveRequest request, CancellationToken ct = default)
        {
            var shouldBeContinue = await HandleAsync(request, ct);
            if (shouldBeContinue && _nextApprover != null)
            {
                await _nextApprover.ApproveAsync(request, ct);
            }
        }

        public abstract Task<bool> HandleAsync(LeaveRequest request, CancellationToken ct = default);
    }
}
