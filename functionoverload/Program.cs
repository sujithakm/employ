using System;

namespace functionoverload
{
    class sum
    {

        public int addd(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int addd(int a, int b,int c)
        {
            int sum = a + b+c;
            return sum;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            sum s = new sum();

            int sum1 = s.addd(2,4);
            Console.WriteLine("sum of two integer=" + sum1);
            int sum2 = s.addd(2, 4,5);
            Console.WriteLine("sum of two integer=" + sum2);
        }
    }
}
