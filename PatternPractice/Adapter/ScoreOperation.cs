using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Adapter
{
    //抽象成绩操作类：目标接口 
    public interface IScoreOperation
    {
        int[] Sort(int[] array); //成绩排序  
        int Search(int[] array, int key); //成绩查找  
    }

    public class QuickSortAdaptee
    {
        public int[] QuickSort(int[] array)
        {
            Sort(array, 0, array.Length - 1);

            return array;
        }

        public void Sort(int[] array, int p, int r)
        {
            int q = 0;
            if (p < r)
            {
                q = Partition(array, p, r);
                Sort(array, p, q - 1);
                Sort(array, q + 1, r);
            }
        }

        public int Partition(int[] a, int p, int r)
        {
            int x = a[r];
            int j = p - 1;
            for (int i = p; i <= r - 1; i++)
            {
                if (a[i] <= x)
                {
                    j++;
                    Swap(a, j, i);
                }
            }
            Swap(a, j + 1, r);
            return j + 1;
        }

        public void Swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
    }

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
                    return 1; //找到元素返回1    
                }
            }
            return -1; //未找到元素返回-1  
        }
    }

    //操作适配器：适配器  
    public class OperationAdapter : IScoreOperation
    {
        private QuickSortAdaptee sortObj; //定义适配者QuickSort对象  
        private BinarySearchAdaptee searchObj; //定义适配者BinarySearch对象  

        public OperationAdapter()
        {
            sortObj = new QuickSortAdaptee();
            searchObj = new BinarySearchAdaptee();
        }

        public int[] Sort(int[] array)
        {
            return sortObj.QuickSort(array); //调用适配者类QuickSort的排序方法  
        }

        public int Search(int[] array, int key)
        {
            return searchObj.BinarySearch(array, key); //调用适配者类BinarySearch的查找方法  
        }
    }

    [Description("7.Adapter")]
    public static class App
    {
        public static void Main()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("========Adapter =====");
            Console.WriteLine("==============================");

            IScoreOperation scoreOperation=ObjectBuildFactory<IScoreOperation>.Instance(ConfigManager.AdapterKey);

            int[] array = {50, 30, 56, 90, 100, 89, 80, 70, 60, 67, 88, 99, 95};
            int[] result;
            int score;

            Console.WriteLine("Sort result:");
            result = scoreOperation.Sort(array);
            string sortResult = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                sortResult += result[i] + ",";
            }

            Console.WriteLine(sortResult);

            Console.WriteLine("Find score=90:");
            score = scoreOperation.Search(result, 90);
            if (score != -1)
            {
                Console.WriteLine("Found the score=90 ");
            }
            else
            {
                Console.WriteLine("Not found the score=90 ");
            }

            Console.WriteLine("Find score=92:");
            score = scoreOperation.Search(result, 92);
            if (score != -1)
            {
                Console.WriteLine("Found the score=90 ");
            }
            else
            {
                Console.WriteLine("Not found the score=92 ");
            }

        }
    }
}
