namespace PatternPractice.AbstractFactory
{
    public class SpringSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public ITextBox CreateTextBox()
        {
            return new SpringTextBox();
        }

        public ILabel CreateLabel()
        {
            return new SpringLabel();
        }
    }
}