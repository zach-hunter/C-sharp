using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW5
{
    interface ITranslatable
    {/// <summary>
    /// Accepts a string and returns a string. Used for translating
    /// </summary>
    /// <param name="input">
    /// String
    /// </param>
    /// <returns>
    /// String
    /// </returns>
        List<string> Translate(string input);
        
    }
}
