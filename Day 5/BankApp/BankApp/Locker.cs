using System;

namespace BankApp
{
    public class Locker
    {
        private int _number;
        private string _lockType;
        private string _password;
        private double _amount;
        private DateTime _lastOpened;

        public Locker()
        {

        }
        public void CreateLocker(int number, string locktype, string password, double amount, DateTime lastOpened)
        {
            _number = number;
            _lockType = locktype;
            _password = password;
            _amount = amount;
            _lastOpened = lastOpened;
        }
    }
}