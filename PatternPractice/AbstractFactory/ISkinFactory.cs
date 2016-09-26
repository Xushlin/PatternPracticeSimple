using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.AbstractFactory
{
    public interface ISkinFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
        ILabel CreateLabel();
    }
}
