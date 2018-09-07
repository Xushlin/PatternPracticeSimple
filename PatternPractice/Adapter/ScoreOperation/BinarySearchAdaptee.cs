namespace PatternPractice.Adapter.ScoreOperation
{
    public class BinarySearchAdaptee
    {
        public int BinarySearch(int[] array, int key)
        {
            var low = 0;
            var high = array.Length - 1;
            while (low <= high)
            {
                var mid = (low + high)/2;
                var midVal = array[mid];
                if (midVal < key)
                {
                    low = mid + 1;
                }
                else if (midVal > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return 1;  
                }
            }
            return -1; 
        }
    }
}