using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Casio : BasicCalculator, ScientificCalculator {

        public Casio() { }

        
        
    public int sum (int x, int y)
    {
            Console.WriteLine();
            Console.WriteLine("Addition of " + x + " and " + y);
            Console.WriteLine(x + y);
            return 0;
        }

    public int sub(int x, int y)
    {
            Console.WriteLine();
            Console.WriteLine("Subtraction of " + x + " and " + y);
            Console.WriteLine(x - y);
            return 0;
        }

    public int multiply(int x, int y)
    {
            Console.WriteLine();
            Console.WriteLine("Multiply of " + x + " and " + y);
            Console.WriteLine(x * y);
            return 0;
        }

    public int division(int x, int y)
    {
            Console.WriteLine();
            Console.WriteLine("Division of " + x + " by " + y);
            Console.WriteLine(x / y);
            return 0;
        }

  
        public int XtoY(int x, int y)
        {
            Console.WriteLine();
            Console.WriteLine("Value of X before swap : " + x);
            Console.WriteLine("Value of Y before swap : " + y);
            int temp1 = x;
            x = y;
            y = temp1;
            Console.WriteLine("Value of X after sawap : " + x);
            Console.WriteLine("Value of Y after sawap : " + y);
            return 0;
        }

    }
}