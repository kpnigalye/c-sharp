using System;

namespace abstract_classes
{
    public abstract class CarHeader
    {
        private string _header;
        public string Header
        {
            get
            {
                return _header;
            }

            private set
            {
                _header = Header;
            }
        }

        public CarHeader(string header)
        {
            _header = header;
        }

        public virtual void PrintHeader()
        {
            Console.WriteLine(Header);
            Console.WriteLine("------------");
        }
    }
}













