/*
Code Challenge1

FEE COLLECTION

Write a program to determine the fee amount to be collected from a student. 
The input to the program is the type of the student, tuition fee, bus fee, hostel fee.

Refer the table below for fee details.

Student Type										Student Type denoted as									Fee Details

Merit Seat Day Scholar						        MSDS													Tuition fee + Bus fee

Merit Seat Hosteller							    MSH														Tuition fee + Hostel fee

Management Seat Day Scholar			                MGSDS													150% of Tuition fee + Bus fee

Management Seat Hosteller				            MGSH													150% of Tuition fee + Hostel fee

Input and Output Format:

Input consists of a string (student type), tuition fee(float), bus fee(float) and hostel fee(float). 

All floating-point numbers are displayed correct to 2 decimal places.

Refer sample input and output for formatting specifications.

All text in bold corresponds to input and the rest corresponds to output.

Sample Input and Output:

Enter the student type

MSH

Enter tuition fee

40000

Enter bus fee

12000

Enter hostel fee

50000

The fees to be paid by the student is Rs.90000








 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            double tuitionFee, busFee, hostelFee;
            Console.WriteLine("Student Type");
            Console.WriteLine("1.MSDS\n2.MSH\n3.MGSDS\n4.MGSH");
            Console.Write("Enter choice:");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tuition fee");
            tuitionFee =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter bus fee");
            busFee =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter hostel fee");
            hostelFee =double.Parse(Console.ReadLine());
            double totalFee=0;
            if (choice == 1)
                totalFee = tuitionFee + busFee;
            else if (choice == 2)
                totalFee = tuitionFee + hostelFee;
            else if (choice == 3)
                totalFee = ((tuitionFee) * 150 / 100) + busFee;
            else if (choice == 4)
                totalFee = ((tuitionFee) * 150 / 100) + hostelFee;
            else 
                Console.WriteLine("Invalid choice");

            Console.WriteLine("The fees to be paid by the student is Rs." +string.Format("{0:0.00}",totalFee));
        }        
    }
}
