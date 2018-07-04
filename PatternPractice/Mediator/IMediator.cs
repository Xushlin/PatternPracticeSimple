using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Mediator
{
    public interface IMediator
    {
        void ComponentChanged(Component component);
    }
}
