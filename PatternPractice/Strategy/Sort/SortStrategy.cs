using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Strategy.Sort
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list");
        }
    }

    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("ShellSorted list");
            PrintArray(list);
            Console.WriteLine();
            int count = list.Count;
            int k = 1;
            for (int h = count / 2; h > 0; h = h / 2)
            {
                for (int i = h; i < count; i++)
                {
                    string temp = list[i];
                    if (temp.CompareTo(list[i - h]) < 0)
                    {
                        for(int j = 0; j < i; j += h)
                        {
                            if (temp.CompareTo(list[j]) < 0)
                            {
                                temp = list[j];
                                list[j] = list[i];
                                list[i] = temp;
                            }
                        }
                    }
                }
                PrintArray(list);
                Console.WriteLine("第" + (k++) + "趟" + " 增量" + h);
            }
            
        }
       
        private static void PrintArray(List<string> array)
        {
            if (array == null || array.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("[" + array[i] + "]" + ",");
            }
        }
    }

    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSorted list");
        }
    }

    class SortedList
    {
        private SortStrategy sortStrategy;
        private List<string> _list = new List<string>();
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Add(string item)
        {
            _list.Add(item);
        }

        public void Sort()
        {
            this.sortStrategy.Sort(_list);
            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }

    [Description("Stategy.Sort")]
    class App
    {
        public static void Main()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("Michael Xu");
            sortedList.Add("Zixuan Xu");
            sortedList.Add("Henry He");
            sortedList.Add("Lenmon Tree");
            sortedList.Add("Jeff Richer");
            sortedList.Add("Kristorfer");
            sortedList.Add("Martin");
            sortedList.Add("Alex Liu");           

            sortedList.SetSortStrategy(new ShellSort());
            sortedList.Sort();

            sortedList.SetSortStrategy(new QuickSort());
            sortedList.Sort();

            sortedList.SetSortStrategy(new MergeSort());
            sortedList.Sort();
        }
    }
}
