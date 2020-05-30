using System;
namespace BronsonHolland_CE06
{
    public class Salaried : Employee
    {
        public decimal salary;

        public Salaried(string name, string address, decimal salary) : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }
    }
}
