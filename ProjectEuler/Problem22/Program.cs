using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileContents = File.ReadAllText("p022_names.txt");
            var names = fileContents.Split(',').Select(fc => fc.Replace("\"", string.Empty)).OrderBy(fc => fc).ToArray();

            ConcurrentDictionary<int, int> nameScores = new ConcurrentDictionary<int, int>();

            Parallel.For(0, names.Length, i =>
            {
                int score = NameScoreCalculator.CalculateNameScore(names[i]);
                nameScores.TryAdd(i + 1, score);
            });

            int finalScore = nameScores.Select(ns => ns.Key * ns.Value).Sum();

            Console.WriteLine("Final score is: {0}", finalScore);

            Console.Read();
        }
    }
}
