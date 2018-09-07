namespace PatternPractice.Adapter.ScoreOperation
{
    public class OperationAdapter : IScoreOperation
    {
        private readonly QuickSortAdaptee _quickSortAdaptee; 
        private readonly BinarySearchAdaptee _binarySearchAdaptee; 

        public OperationAdapter()
        {
            _quickSortAdaptee = new QuickSortAdaptee();
            _binarySearchAdaptee = new BinarySearchAdaptee();
        }

        public int[] Sort(int[] array)
        {
            return _quickSortAdaptee.QuickSort(array); 
        }

        public int Search(int[] array, int key)
        {
            return _binarySearchAdaptee.BinarySearch(array, key);
        }
    }
}