using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Casio c = new Casio();
            c.sum(2, 3);
            c.sub(10, 5);
            c.multiply(2, 3);
            c.division(8, 4);

            c.XtoY(10, 20);


        }
    }
}
