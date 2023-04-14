using System;
namespace AccountsApp
{
    public class Account
    {
        public int id;
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Length > 15)
                    throw new ArgumentException("Name is tooooo big");
                _name = value; 
            }
        }

        private decimal _balance;    //field
        public decimal Balance     //property
        {
            get
            {
                return _balance;
            }
        }

        public Account()
        {

        }
        public void createAcc(int id1, string name1, decimal balance1)
        {
            id = id1;
            _name = name1;
            _balance = balance1;
        }
        public void displayDetails()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine("*************************************");
            Console.WriteLine("Account Id: " +id);
            Console.WriteLine("Account Name: " + _name);
            Console.WriteLine("Opening Balance : " + _balance);
        }
        public void deposit(decimal amount)
        {
            _balance = _balance + amount;
            Console.WriteLine("{0} Deposited",amount);
        }

        public void withdraw(decimal amount)
        {
            if (_balance - amount < 500)
                Console.WriteLine("Insufficient Balance");
            else
                this._balance -= amount;
            Console.WriteLine("{0} Withdrawn", amount);
        }

    }
}