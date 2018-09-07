namespace PatternPractice.Adapter.ScoreOperation
{
    public interface IScoreOperation
    {
        int[] Sort(int[] array); 
        int Search(int[] array, int key); 
    }
}