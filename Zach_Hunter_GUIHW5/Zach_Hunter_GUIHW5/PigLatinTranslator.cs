using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW5
{
    public class PigLatinTranslator : PigTranslator
    {/// <summary>
     /// Takes a string and converts all the words into PigLatin, exluding words with embedded symbols or numbers
     /// </summary>
     /// <param name="input">
     /// String to be converted to PigLatin
     /// </param>
     /// <returns>
     /// Returns a list of words translated into PigGreek
     /// </returns>
        public List<string> PigLatin(string input)
        {
            var list = new List<string>();
            var words = this.PigTranslate(input);
            foreach (Tuple<string, string, bool, bool> entry in words)
            {
                if (entry.Item4)  //contains embedded punctuation, add to list unmodified
                {
                    list.Add(entry.Item1);
                }
                else if (entry.Item3)  //started with vowel, add way to end, then punctuation, then add to list
                {
                    list.Add($"{entry.Item1}way{entry.Item2}");
                }
                else //started with consonant, add ay to end, then punctuation, then add to list
                {
                    list.Add($"{entry.Item1}ay{entry.Item2}");
                }
            }
            return list;
        }
        public override string ToString()
        {
            return @"Converts all words in a string to Pig Latin. Returns a list";
        }
    }
}
