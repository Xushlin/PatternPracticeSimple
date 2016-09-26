namespace PatternPractice.AbstractFactory
{
    public class SummerSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SummerButton();
        }

        public ITextBox CreateTextBox()
        {
            return new SummerTxtBox();
        }

        public ILabel CreateLabel()
        {
            return new SummerLabel();
        }
    }
}