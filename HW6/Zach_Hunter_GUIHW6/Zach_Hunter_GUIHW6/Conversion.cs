using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW6
{
    public class Conversion : IConvertable, IComparable
    {
        private string fromUnit = string.Empty;
        private double fromValue = 0.0;
        private string toUnit = string.Empty;
        private double toValue = 0.0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromUnit">
        /// Unit to convert from
        /// </param>
        /// <param name="fromValue">
        /// Value of the unit converting from
        /// </param>
        /// <param name="toUnit">
        /// Unit to convert to
        /// </param>
        /// <param name="toValue">
        /// Value of the unit converting to
        /// </param>
        public Conversion(string fromUnit, double fromValue, string toUnit, double toValue)
        {
            FromUnit = fromUnit;
            FromValue = fromValue;
            ToUnit = toUnit;
            ToValue = toValue;
        }

        public string FromUnit
        {
            get => this.fromUnit;
            set => this.fromUnit = value ?? string.Empty;
        }

        public double FromValue
        {
            get => this.fromValue;
            set => this.fromValue = value;
        }

        public string ToUnit
        {
            get => this.toUnit;
            set => this.toUnit = value ?? string.Empty;
        }

        public double ToValue
        {
            get => this.toValue;
            set => this.toValue = value;
        }
        /// <summary>
        /// Makes the display name for conversions
        /// </summary>
        public string ConversionName => $"{this.FromUnit} and {this.ToUnit}";
        /// <summary>
        /// Converts from 1st unit to 2nd unit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double ConvertFrom(double value)
        {
            return value * this.fromValue;
        }
        /// <summary>
        /// Converts to 2nd unit from 1st unit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double ConvertTo(double value)
        {
            return value * this.toValue;
        }

        public override string ToString()
        {
            return $"{this.FromValue}{this.FromUnit} equals {this.ToValue}{this.ToUnit}";
        }
        /// <summary>
        /// Must match both conversion names and both conversion values to equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var conversion = obj as Conversion;
            if (conversion == null) { return false; }
            if (object.ReferenceEquals(this, conversion)) { return true; }
            return this.FromUnit.Equals(conversion.FromUnit) && this.FromValue == conversion.FromValue && this.ToUnit.Equals(conversion.ToUnit) && this.ToValue == conversion.ToValue;
        }
        public override int GetHashCode() => this.FromUnit.GetHashCode() ^ this.FromValue.GetHashCode() ^ this.ToUnit.GetHashCode() ^ this.ToValue.GetHashCode();

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
