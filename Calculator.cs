using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class Calculator
    {
        //suma resta mult div

      
        public virtual int Suma(int op1, int op2)
        {
            return op1 + op2;
        }

        static int Resta(int op1, int op2)
        {
            return op1 - op2;
        }

        static int Mult(int op1, int op2)
        {
            return op1 * op2;
        }

        static double Div(int op1, int op2)
        {
            return op1 / op2;
        }

    }

    //public class CalculatorSi : Calculator {
    //    public override int Suma(int op1, int op2)
    //    {
    //        return base.Suma(op1, op2);
    //    }
    }
}
