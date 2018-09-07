using System;
using System.ComponentModel;

namespace PatternPractice.Adapter.ScoreOperation
{
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
            var sortResult = string.Empty;
            for (var i = 0; i < result.Length; i++)
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
