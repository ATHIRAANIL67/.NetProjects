using System;
namespace OOPSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp e1=new Emp(1);
            Emp e2 = new Emp(2);
            Console.WriteLine(e1.EmpID);
            Console.WriteLine(e2.EmpID);
            //Console.WriteLine(e1.EmpName); 
            //Console.WriteLine(e2.EmpName);
            //Console.WriteLine(e1.EmpSalary);
            //Console.WriteLine(e2.EmpSalary);

        }
    }
}
