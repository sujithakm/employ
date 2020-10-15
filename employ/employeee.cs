using System;
using System.Collections.Generic;
using System.Text;

namespace employ
{
   public class employeee
    {
        private string name;
        private string address;
        private int age;
        private int salary;
        public void setName(string name)
        {
            this.name = name;

        }
        public string getname()
        {
            return name;
        }
        public void setage(int age)
        {
            this.age = age;

        }
        public int getAge()
        {
            return age;
        }
        public void setsalary(int salary)
        {
            this.salary = salary;

        }
        public int getsalary()
        {
            return salary;
        }
        public void setaddress(string address)
        {
            this.address = address;

        }
        public string getaddress()
        {
            return address;
        }
        


    }
}
