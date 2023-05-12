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

        public static List<int> Reverse(List<int> list)
        {
            List<int> result = new List<int>();            
            for(int i = 0; i < list.Count; i++)
            {                
                result.Add( list[list.Count - 1 -i]);               
            }
            return result;
        }
        public static List<int> Order(List<int> list)
        {
            List<int> result = new List<int>();
            int size = list.Count;
            for (int i = 0; i < size; i++)
            {               
                for(int j = 0; j < size-i-1; j++)
                {
                    if (list[j] <= list[j + 1]) continue;
                    (list[j], list[j+1]) = (list[j+1], list[j]);
                }
                
            }
            return list;
        }
    }
}
