using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class Program
    {
        static void Main(string[] args)
        {

        }
       // Input: float x
       // Output: int a that is smallest but not smaller than x
       // Idea: a = (Int) x then a = a + 1 
       // If x is negative then a is unchanged
        public static int Ceil(float x)
        {
            int a = (int) x;
            if (x > 0)
                if(x > a)
                a = a + 1;
            return a;
        }
       // Input: float x
       // Output: int a that is largest but not larger than x
       // Idea: a = (Int) x 
       // If x is negative then a = a-1
       // if x == a then is unchange
        public static int Floor(float x)
        {
            int a = (int)x;
            if(x<0 && x !=a)
                a = a - 1;
            return a;
        }
    }
}
