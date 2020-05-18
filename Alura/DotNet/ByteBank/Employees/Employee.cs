using System;

namespace ByteBank.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployee { get; private set; }

        public string Name { get; set; }
        public string PersonID { get; private set; }
        public double Salary { get; protected set; }

        public Employee(double salary, string personID)
        {
            Console.WriteLine("Create Emproyee");

            PersonID = personID;
            Salary = salary;

            TotalEmployee++;
        }

        public abstract void IncreaseSalary();

        public abstract double GetBonus();
    }
}
