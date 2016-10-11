using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCompany
{
    public class Employee
    {
        #region Member Variables
        private string m_firstName;
        private string m_lastName;
        private decimal m_salary;
        #endregion

        public Employee(string first, string last, decimal salary)
        {
            this.m_firstName = first;
            this.m_lastName = last;
            this.m_salary = salary;
        }

        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public decimal Salary
        {
            get { return m_salary; }
            set { m_salary = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} with a payroll of {2}", m_firstName, m_lastName, m_salary);
        }
    }
    public class Department
    {
        private Employee[] emps;
        private string name;
        public Department(Employee[] theEmps, string name)
        {
            emps = theEmps;
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        // declaring a nested delegate type that accepts an Employee instance
        public delegate void EmployeeCallback(Employee emp);

        // This method accepts an EmployeeCallback instance thus
        // providing the Callback mechanism
        public void ProcessEmployees(EmployeeCallback callback)
        {
            foreach (Employee emp in emps)
            {
                callback(emp);
            }
        }
    }

    public class Sys
    {
        private static void UpdatePayroll(Employee emp)
        {
            emp.Salary *= 1.2m;
            Console.WriteLine("The Employee {0} {1}'s salary increated to {2}", emp.FirstName, emp.LastName, emp.Salary);
        }
        
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Paul", "Brodzinski", 7000m);
            Employee emp2 = new Employee("Terry", "Carter", 2000m);
            Employee emp3 = new Employee("Mario", "Pipkin", 50000m);

            Employee[] emps = new Employee[3] { emp1, emp2, emp3 };

            Department dep = new Department(emps, "LPO");

            foreach (Employee emp in emps)
                Console.WriteLine(emp.ToString());

            Console.WriteLine("Creating the delegate object");
            Department.EmployeeCallback updateCallback = new Department.EmployeeCallback(UpdatePayroll);

            Console.WriteLine("calling the method ProcessEmployees()");
            dep.ProcessEmployees(updateCallback);

            Console.ReadLine();
        }
    }
}