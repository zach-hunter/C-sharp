using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW6
{
    interface IConvertable
    {/// <summary>
    /// Calculates going from 1st unit to 2nd unit
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
        double ConvertTo(double value);
        /// <summary>
        /// Calculates going from 2nd unit to 1st unit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        double ConvertFrom(double value);
       
       
    }
}
