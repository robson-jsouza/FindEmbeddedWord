using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEmbeddedWord
{
    class Solution
    {

        string find_embedded_word(string[] words, string string1)
        {
            string returningWord = null;
            foreach (var word in words)
            {
                bool exists = true;
                for (int index = 0; index < word.Length; index++)
                {
                    var occurencesOfACharInWord = word.Count(y => y == word[index]);
                    var occurencesOfACharInString1 = string1.Count(y => y == word[index]);

                    if (!string1.Contains(word[index]) || occurencesOfACharInString1 < occurencesOfACharInWord)
                    {
                        exists = false;
                        break;
                    }
                }
                if (exists)
                {
                    returningWord = word;
                    break;
                }
            }

            return returningWord;
        }

        static void Main(String[] args)
        {
            string[] words = new string[] { "cat", "baby", "dog", "bird", "car", "ax" };
            string string1 = "tcabnihjs";
            string string2 = "tbcanihjs";
            string string3 = "baykkjl";
            string string4 = "bbabylkkj";
            string string5 = "ccc";
            string string6 = "breadmaking";

            var solution = new Solution();
            var result = solution.find_embedded_word(words, string6);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
