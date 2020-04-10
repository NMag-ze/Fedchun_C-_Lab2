using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    //dll-библиотека для работы с комплексными числами
    public class Complex
    {
        double re, im;
        public Complex(double r,double i)
        {
            re = r;
            im = i;
        }

        public static Complex sum(Complex C1, Complex C2)
        {
            return new Complex(C1.re + C2.re, C1.im + C2.im);
        }
        public override string ToString()
        {
            return $" {re} + {im} ";
        }

    }
}
