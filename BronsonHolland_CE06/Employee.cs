using System;
namespace BronsonHolland_CE06
{
    public class Employee : IComparable
    {
        public string name;
        public string address;

        public Employee(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
