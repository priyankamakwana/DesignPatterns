using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Employee
    {
        private int empId;
        private string empName;
        public double salary;
        public int grade;
        private string company = "XYZ";

        IEmail email;

        public Employee(int empId, string empName, IEmail email)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployee()
        {
            email.sendEmail();
        }
    }

    interface IEmail
    {
        void sendEmail();
    }

    class OutlookEmailService : IEmail
    {
        public void sendEmail()
        {
            Console.WriteLine("Outlook Email Service");
        }
    }

    class WebEmailService : IEmail
    {
        public void sendEmail()
        {
            Console.WriteLine("Web Email Service");
        }
    }

    class test1
    {
        static void Main(string[] strs)
        {
            Employee emp1 = new Employee(100, "qwerty", new WebEmailService());
            emp1.NotifyEmployee();
            emp1.salary = 10000;            
            Employee emp2 = new Employee(100, "asdfgh", new OutlookEmailService());
            emp2.NotifyEmployee();
        }
    }
}
