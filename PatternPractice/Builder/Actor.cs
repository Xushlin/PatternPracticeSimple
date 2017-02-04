namespace PatternPractice.Builder
{
    public class Actor
    {
        public string Type { get; set; }
        public string Sex { get; set; } 
        public string Face { get; set; }
        public string Costume { get; set; }
        public string Hairstyle { get; set; }

        public override string ToString()
        {
            return $"[Type]={Type},[Sex]={Sex},[Face]={Face},[Costume]={Costume},[Hairstyle]={Hairstyle}";
        }
    }
}
