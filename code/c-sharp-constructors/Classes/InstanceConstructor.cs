using System;

namespace c_sharp_constructors
{
    public class Staff
    {
        private string _fullName;
        private string _title;
        private int _salary;

        public Staff(string fullName, string title)
        {
            _fullName = fullName;
            _title = title;
        }

        public Staff(string fullName, string title, int salary)
        {
            _fullName = fullName;
            _title = title;
            _salary = salary;
        }
    }
}