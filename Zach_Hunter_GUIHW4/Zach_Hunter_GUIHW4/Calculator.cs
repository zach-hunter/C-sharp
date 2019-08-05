using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zach_Hunter_GUIHW4
{
    public class Calculator
    {
        private double currentValue = 0.0;

        private string op = string.Empty;


        public double CurrentValue
        {
            get
            {
                return this.currentValue;
            }
            set
            {
                this.currentValue = value;
            }
        }

        public string Op
        {
            get
            {
                return this.op;
            }
            set
            {
                this.op = value;
            }
        }

        public double DoMath(double secondValue)
        {
            switch(Op)
            {
                case "+":
                    return currentValue + secondValue;
                case "-":
                    return currentValue - secondValue;
                case "*":
                    return currentValue * secondValue;
                case "/":
                    return currentValue / secondValue;
                default:
                    return 0;

            }
        }


    }
}
