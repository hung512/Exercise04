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
        public static int Rand1()
        {
            int kq = 2;
            int kq2;
            for (int i = 2; i <= 31; i++)
            {
                kq *= 2;
            }
            Random rd = new Random();
            Console.Write("random từ 0 đến (2^31)-1: ");
            return kq2 = rd.Next(0, kq - 1);
        }

        public static float Rand2()
        {
            Random rd = new Random();
            float f = (float)rd.NextDouble();
            Console.Write("random từ giữa 0 đến 1: ");
            return f;

        }
        public static long Factorial(long n)
        {
            Console.Write("Factorial của {0}: ", n);
            long kq = 1;
            if (n == 0) return 1;
            else if (n < 0)
            {
                Console.Write("kq ra 0 => vô nghiệm ,");
                return 0;
            }
            else
            {
                for (long i = 1; i <= n; i++)
                {
                    kq *= i;
                }
                return kq;
            }
        }
    }
}
