using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public double Divide(int a, int b) => a / b;

        public void DoSomething(object arg, string strArg)
        {
            if (arg is null)
            {
                throw new ArgumentNullException(nameof(arg));
            }



            if (string.IsNullOrWhiteSpace(strArg))
            {
                throw new ArgumentException("Hodnota nesmie byt prazdna", nameof(strArg));
            }
        }

    }
}

