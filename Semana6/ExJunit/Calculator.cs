using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExJunit
{
    public class Calculator
    {
        public static int Sum(List<int> list)
        {
            int sum = 0;
            list.ForEach(x => sum += x );
            return sum;
        }
    }
}
