using System;

namespace employ
{
    class Program
    {
        static void Main(string[] args)
        {
            employeee emp = new employeee();
            employeee emp2 = new employeee();
            Console.WriteLine("enter first employee details!");
            Console.WriteLine("Enter Name!");
            emp.setName(Console.ReadLine());
            Console.WriteLine("Enter Address!");
            emp.setaddress(Console.ReadLine());
            Console.WriteLine("Enter salary");
            emp.setsalary(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Age");
            emp.setage(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("========================================");
            Console.WriteLine("enter second employee details!");
            
            Console.WriteLine("Enter Name!");
            emp2.setName(Console.ReadLine());
            Console.WriteLine("Enter Address!");
            emp2.setaddress(Console.ReadLine());
            Console.WriteLine("Enter salary");
            emp2.setsalary(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Age");
            emp2.setage(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("========================================");
            Console.WriteLine("\t\t\tOUTPUT");
            Console.WriteLine("\t\t==============================");

            Console.WriteLine("\t\t||FNAME\tAddress\tAge\tSalary");
            

            Console.Write("\t\t"+emp.getname());
            Console.Write("\t" + emp.getaddress());
            Console.Write("\t"+emp.getAge());
            Console.Write("\t" + emp.getsalary());
            Console.WriteLine("\n");
            Console.Write("\t\t" + emp2.getname());
            Console.Write("\t" + emp2.getaddress());
            Console.Write("\t" + emp2.getAge());
            Console.Write("\t" + emp2.getsalary());









        }


    }
}
