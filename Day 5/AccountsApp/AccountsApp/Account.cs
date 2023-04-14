using System;
namespace AccountsApp
{
    public class Account
    {
        public int id;
        public decimal balance;
        public string name;
        public Account()
        {

        }
        public void createAcc(int id1, string name1, decimal balance1)
        {
            id = id1;
            name = name1;
            balance = balance1;
        }
        public void displayDetails()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine("*************************************");
            Console.WriteLine("Account Id: " +id);
            Console.WriteLine("Account Name: " + name);
            Console.WriteLine("Opening Balance : " + balance);
        }
        public void deposit(decimal amount)
        {
            balance = balance + amount;
            Console.WriteLine("{0} Deposited",amount);
        }

        public void withdraw(decimal amount)
        {
            if (balance - amount < 500)
                Console.WriteLine("Insufficient Balance");
            else
                this.balance -= amount;
            Console.WriteLine("{0} Withdrawn", amount);
        }

    }
}