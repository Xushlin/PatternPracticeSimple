using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    /// <summary>
    /// 责任链的入口接口
    /// </summary>
    public interface ILeaveApprovalChain
    {
        Task ApproveAsync(LeaveRequest request);
    }
}
