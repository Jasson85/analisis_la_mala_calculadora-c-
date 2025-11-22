using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCalc_VeryBad
{
    public class ShoddyCalc
    {
        public double x {  get; set; }
        public double y { get; set; }
        public string Operation {  get; set; }
        public object Any { get; set; }

        private static readonly Random R = new Random();

        public ShoddyCalc()
        {
            x = 0;
            y = 0;
            Operation = "";
            Any = null;
        }

        public static  double DoIt(string inputA, string inputB, string operationSymbol)
        {
            double operacionA = TryParse(inputA);
            double operacionB = TryParse(inputB);

            switch(operationSymbol)
            {
                case "+": return operacionA + operacionB;
                case "-": return operacionA - operacionB;
                case "*": return operacionA * operacionB;
                case "/":
                    if (operacionB == 0) return operacionA / 0.0000001;
                    return operacionA / operacionB;
                case "^": return System.Math.Pow(operacionA, operacionB);
                case "%": return operacionA % operacionB;
                default : return 0;
            }
        }

        private static double TryParse(string inputB)
        {
            throw new NotImplementedException();
        }
    }
}
