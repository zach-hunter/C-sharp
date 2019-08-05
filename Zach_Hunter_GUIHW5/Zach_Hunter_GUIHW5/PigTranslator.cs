using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW5
{
    public class PigTranslator : Translator
    {/// <summary>
    /// Prepares words for translating into Pig based languages. 
    /// </summary>
    /// <param name="input">
    /// String to be broken down into words and prepared for translation
    /// </param>
    /// <returns>
    /// Returns a tuple with the contents: (preparedString, punctuationAtEndOfWord, ifWordStartedWithVowel, ifWordContainedPunctuation)
    /// </returns>
        public List<Tuple<string, string, bool, bool>> PigTranslate(string input)
        {
            var temp = new List<Tuple<string, string, bool, bool>>(); //Tuple order: word, punctuation, startedWithVowel, containsPunct
            var words = this.Translate(input);
            bool containsPunct = false;
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length - NumberOne; i++)
                {
                    if (symbols.Contains(word[i]))
                    {
                        containsPunct = true;
                    }
                }
                if (containsPunct)
                {
                    temp.Add(new Tuple<string, string, bool, bool>(word, $"{string.Empty}", false, true));
                    containsPunct = false;
                }
                else
                {
                    string punct = "";
                    var tempword = word;
                    if (symbols.Contains(tempword.Substring(tempword.Length - NumberOne)))
                    {
                        punct = tempword[tempword.Length - NumberOne].ToString();
                        tempword = tempword.Substring(0, word.Length - NumberOne); //remove punctuation
                    } //else no punctuation, doNothing();
                    if (vowels.Contains(tempword.Substring(0, NumberOne))) //if word starts with vowel, add it to tuple
                    {
                        temp.Add(new Tuple<string, string, bool, bool>(tempword, punct, true, false));
                    }
                    else  //keep putting constanants to back of the word until a vowel is first, then add to tuple
                    {
                        for (int i = 0; i < tempword.Length; i++)
                        {
                            if (i > 0) //only ignores 'Y' if it's the first character of the word, otherwise is considered a vowel
                            {
                                var newVowels = $"{vowels}Yy";
                                if (!newVowels.Contains(tempword.Substring(0, NumberOne)))
                                {
                                    tempword = $"{tempword.Substring(NumberOne)}{tempword.Substring(0, NumberOne)}";
                                } 
                            } else
                            {
                                if (!vowels.Contains(tempword.Substring(0, NumberOne)))
                                {
                                    tempword = $"{tempword.Substring(NumberOne)}{tempword.Substring(0, NumberOne)}";
                                }
                            }
                        }
                        temp.Add(new Tuple<string, string, bool, bool>(tempword, punct, false, false));
                    }
                }
            }
            return temp;
        }  
    }
}
