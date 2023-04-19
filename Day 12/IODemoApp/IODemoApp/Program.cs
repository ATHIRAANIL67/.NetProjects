using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo tempdata = new DirectoryInfo("D:\\.NetUST\\Day 12\\FileDemo\\TestPrg1");
            tempdata.Create();
        }
    }
}
