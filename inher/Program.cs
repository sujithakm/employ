using System;
using System.ComponentModel.DataAnnotations;

namespace inher
{
    class area
    {
        public int length = Convert.ToInt32(Console.ReadLine());
       public int width = Convert.ToInt32(Console.ReadLine());

    }
    class arearec:area
    {
        int A;
        public int areaofrec()
        {
            A = length * width;
            return A;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int area;
            arearec rec = new arearec();
            area=Convert.ToInt32(rec.areaofrec());
            Console.WriteLine("length="+rec.length +"width="+ rec.width);
            Console.WriteLine("area=" + area);

        }
    }
}
