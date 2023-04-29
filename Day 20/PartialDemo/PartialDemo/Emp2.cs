using System;

namespace PartialDemo
{
    internal partial class Emp
    {
        public void Display()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(Name);
        }
    }
}