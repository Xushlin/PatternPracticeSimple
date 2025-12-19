using System.Threading;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    public interface ILeaveApprover
    {
        Task ApproveAsync(LeaveRequest request, CancellationToken ct = default);
    }
}
