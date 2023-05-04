namespace GroupEmployee
{
    internal class Employee
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public Employee()
        { }
        public Employee(string name, string city)
        {
            _name = name;
            _city = city;
        }
    }
}

