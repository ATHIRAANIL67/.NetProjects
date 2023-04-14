using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Locker l = null;
            Bank b = null;
            do
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("**************Bank Application**************");
                Console.WriteLine("************************************************\n\n");
                Console.WriteLine("1.Add Locker ");
                Console.WriteLine("2.Delete Locker ");
                Console.WriteLine("3.Display Lockers ");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice: ");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter number: ");
                        int _number=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter locktype: ");
                        string _locktype=Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string _password=Console.ReadLine();
                        Console.WriteLine("Enter amount: ");
                        double _amount=double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter last opened date: ");
                        DateTime _lastOpened = DateTime.Parse(Console.ReadLine());
                        l=new Locker();
                        l.CreateLocker(_number,_locktype,_password,_amount,_lastOpened);
                        break;
                     case 2:
                        b = new Bank();
                        if (b != null)
                            b.AddLockerToBank();
                        else
                            Console.WriteLine("Create Locker First");
                        break;
                    case 3:
                        if(b!= null)
                            b.

                }
            } while (ch != 0);
        }
    }
