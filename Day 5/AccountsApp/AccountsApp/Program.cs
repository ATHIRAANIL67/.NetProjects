using System;

namespace AccountsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do {
                Console.WriteLine("************************************************");
                Console.WriteLine("**************Accounts Application**************");
                Console.WriteLine("************************************************\n\n");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account Details");
                Console.WriteLine("3. Deposit Account");
                Console.WriteLine("4. Withdraw Account");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter your choice: ");
                ch=int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Account ID: ");
                        int id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name: ");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter Opening Balance: ");
                        decimal balance=decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.createAcc(id, name, balance);
                        break;
                    case 2:
                        if (a != null)
                        {
                            a.displayDetails();
                        }
                        else
                        {
                            Console.WriteLine("Create Account First");
                        }
                        break;
                    case 3:
                        if ((a != null))
                        {
                            a.deposit(5000);
                        }
                        else
                        {
                            Console.WriteLine("Create Account First");
                        }
                        break;
                    case 4:
                        if ((a != null))
                        {
                            a.withdraw(5000);
                        }
                        else
                        {
                            Console.WriteLine("Create Account First");
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            
            }while(ch!=0);
        }
    }
}
