using System;
namespace EmpMgnt
{
    class Employee
    {
        int Id;
        string Name;
        decimal Salary;
        public Employee(int id,
        string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            string str = "";
            str += "Id: " + Id;
            str += "\nName: " + Name;
            str += "\nSalary: " + Salary;
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101,
            "Ram Kumar", 15750.75M);
            Console.WriteLine(e1.ToString());
        }
    }
}