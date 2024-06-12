using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    public class Employee
    {
        private int employeeID;
        private string FullName;
        private double Salary;

        public int getEmployeeID()
        {
            return this.employeeID;
        }

        //constructor
        public Employee(int employeeID, String FullName, double Salary)
        {
            this.employeeID = employeeID;
            this.FullName = FullName;
            this.Salary = Salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Employee Name: " + FullName);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee(101, "Saman", 50000);
            em.DisplayEmployeeInfo();
            Console.WriteLine("Reading the employee id: "+em.getEmployeeID());  
        }
    }
}
