using System;

namespace MangoInfoApp
{
    class MangoEventArgs : EventArgs
    {
        public MangoEventArgs(string type, int number)
        {
            MangoInfo = type;
            Number = number;
        }
        public string MangoInfo { get; private set; }
        public int Number { get; private set; }
    }

}