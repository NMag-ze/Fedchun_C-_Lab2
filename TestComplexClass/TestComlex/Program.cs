using System;
using ComplexClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComlex
{
    class Program
    {
        //LabWork2\ComplexClass\ComplexClass\bin\Debug\ComplexClass.dll
        static void Main(string[] args)
        {
            Complex t1 = new Complex(1.0, 1.0);
            Complex t2 = new Complex(2.0, 3.0), t3;
            t3 = Complex.sum(t1, t2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

        }
    }
}
