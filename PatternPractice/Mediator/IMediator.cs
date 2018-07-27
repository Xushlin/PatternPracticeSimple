using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Mediator
{
    public interface IMediator
    {
        void ComponentChanged(IComponent component);
    }
}
