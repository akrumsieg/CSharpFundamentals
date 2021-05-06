using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public abstract class Person
    {
        //PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        //CONSTRUCTORS
        public Person() { }
        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        //METHODS
        public virtual void WhoAmI()
        {
            Console.WriteLine("I am a person");
        }

        public abstract void AbstractMethod();
    }

    //NEW CLASS
    public class Customer : Person //inherits from Person class
    {
        //PROPERTIES
        public bool IsPremium { get; set; }

        //CONSTRUCTORS
        public Customer() { }
        public Customer(bool isPremium)
        {
            IsPremium = isPremium;
        }

        //METHODS
        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine("I am a customer");
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method override customer");
        }
    }

    //NEW CLASS
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        } //challenge: remove set and calculate years based on hire date

        //constructor and constructor with inheritance
        public Employee(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
        }
        public Employee(int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email) : base(firstName, lastName, phoneNumber, email)
        {
            EmployeeNumber = employeeNumber;
            HireDate = hireDate;
        }

        public override void WhoAmI()
        {
            //base.WhoAmI();
            Console.WriteLine("I am an employee");
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method override employee");
        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int employeeNumber, decimal salary) : base(employeeNumber)
        {
            Salary = salary;
        }
    }
}