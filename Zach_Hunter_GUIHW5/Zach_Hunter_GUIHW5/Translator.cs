using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW5
{
    public class Translator : ITranslatable
    {/// <summary>
    /// Constants used for comparisons 
    /// </summary>
        public const string symbols = @"\|!#$%&/()=?@£§€{}.-;<>_,^*[]+:1234567890";
        public const int NumberOne = 1;
        public const string vowels = @"aAeEiIoOuU";
        public const char space = ' ';
        /// <summary>
        /// Splits a string into words using spaces as delimeters 
        /// </summary>
        /// <param name="input">
        /// String to be broken down into words
        /// </param>
        /// <returns>
        /// A list of words
        /// </returns>
        public List<string> Translate(string input)
        {
            List<string> temp = new List<string>();
            var temparray = input.Split(space);
            foreach (string word in temparray)
            {
                temp.Add(word);
            }
            return temp;
        }
    }
}
