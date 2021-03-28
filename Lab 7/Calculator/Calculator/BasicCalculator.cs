using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
        public interface BasicCalculator
        {

            int sum(int x, int y);
            int sub(int x, int y);
            int multiply(int x, int y);
            int division(int x, int y);

        }
}
