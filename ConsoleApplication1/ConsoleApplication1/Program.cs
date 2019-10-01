using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github");
        }
        public static bool IsOdd(int n)
        {
            if (n %2 == 1)
                return true;

            return false;
        }
        public static bool IsEven(int n)
        {
            if (n %2 == 1)
                return false;
            return true;
        }
    }
}
