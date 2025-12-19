using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    /// <summary>
    /// 责任链配置类 - 通过依赖注入构建责任链（使用接口注入）
    /// </summary>
    public class LeaveApprovalChain : ILeaveApprovalChain
    {
        private readonly ILeaveApprover _firstHandler;

        public LeaveApprovalChain(IEnumerable<ILeaveApprover> handlers)
        {
            // 将所有处理器按顺序连接成责任链
            var handlerList = handlers.ToList();
            
            if (handlerList.Count == 0)
            {
                throw new System.ArgumentException("至少需要一个处理器", nameof(handlers));
            }

            // 构建责任链
            for (int i = 0; i < handlerList.Count - 1; i++)
            {
                ((LeaveApproverBase)handlerList[i]).SetNext(handlerList[i + 1]);
            }

            _firstHandler = handlerList[0];
        }

        public async Task ApproveAsync(LeaveRequest request)
        {
            await _firstHandler.ApproveAsync(request);
        }
    }
}
