using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    internal static class NameScoreCalculator
    {
        public static int CalculateNameScore(string name)
        {
            List<char> letters = name.ToCharArray().ToList();

            ConcurrentBag<int> characterScores = new ConcurrentBag<int>();
            Parallel.ForEach(letters, letter =>
            {
                int score;
                if (!LetterScores.TryGetValue(letter.ToString().ToUpper(), out score))
                {
                    throw new ArgumentException(string.Format("Invalid Character: {0}", letter));
                }
                characterScores.Add(score);
            });

            return characterScores.Sum();
        }

        private static ConcurrentDictionary<string, int> LetterScores = new ConcurrentDictionary<string, int>(new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("A", 1),
            new KeyValuePair<string, int>("B", 2),
            new KeyValuePair<string, int>("C", 3),
            new KeyValuePair<string, int>("D", 4),
            new KeyValuePair<string, int>("E", 5),
            new KeyValuePair<string, int>("F", 6),
            new KeyValuePair<string, int>("G", 7),
            new KeyValuePair<string, int>("H", 8),
            new KeyValuePair<string, int>("I", 9),
            new KeyValuePair<string, int>("J", 10),
            new KeyValuePair<string, int>("K", 11),
            new KeyValuePair<string, int>("L", 12),
            new KeyValuePair<string, int>("M", 13),
            new KeyValuePair<string, int>("N", 14),
            new KeyValuePair<string, int>("O", 15),
            new KeyValuePair<string, int>("P", 16),
            new KeyValuePair<string, int>("Q", 17),
            new KeyValuePair<string, int>("R", 18),
            new KeyValuePair<string, int>("S", 19),
            new KeyValuePair<string, int>("T", 20),
            new KeyValuePair<string, int>("U", 21),
            new KeyValuePair<string, int>("V", 22),
            new KeyValuePair<string, int>("W", 23),
            new KeyValuePair<string, int>("X", 24),
            new KeyValuePair<string, int>("Y", 25),
            new KeyValuePair<string, int>("Z", 26)
        });
    }
}
