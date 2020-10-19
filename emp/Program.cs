using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace emp
{
    class Program
    {
        static void Main(string[] args)
        {
            emp1 employe1 = new emp1();

            Console.WriteLine("Enter First Employee Details");
            Console.WriteLine("==============================");
            Console.WriteLine("Enter First Name");
            employe1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Second Name");
            employe1.LastName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            employe1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary");
            employe1.Salary = Convert.ToInt32(Console.ReadLine());
            emp1 employe2 = new emp1();
            Console.WriteLine("==============================");
            Console.WriteLine("Enter second Employee Details");
            Console.WriteLine("==============================");
            Console.WriteLine("Enter First Name");
            employe2.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Second Name");
            employe2.LastName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            employe2.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary");
            employe2.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==============================");



            string fileName = Directory.GetCurrentDirectory(); 
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("\t\t\tOUTPUT");
                writer.WriteLine("\t\t==============================");

                writer.WriteLine("\t\t||FNAME\tLName\tAge\tSalary");
                writer.WriteLine("\t\t||" + employe1.FirstName + "\t" + employe1.LastName + "\t" + employe1.Age + "\t" + employe1.Salary );
                writer.WriteLine("\t\t||" + employe2.FirstName + "\t" + employe2.LastName + "\t" + employe2.Age + "\t" + employe2.Salary );

            }


        }
    }
}
