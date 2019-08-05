using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW6
{
    public class Conversions
    {
        private List<Conversion> conversionObjects = new List<Conversion>();
        /// <summary>
        /// A list of conversion objects
        /// </summary>
        public List<Conversion> ConversionObjects
        {
            get => this.conversionObjects;
            set => conversionObjects = value;
        }
        /// <summary>
        /// Adds a conversion object to the list
        /// </summary>
        /// <param name="conversion"></param>
        public void Add(Conversion conversion)
        {
            this.conversionObjects.Add(conversion);
        }
    }
}
