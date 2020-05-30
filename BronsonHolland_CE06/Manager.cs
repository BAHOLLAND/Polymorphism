using System;
namespace BronsonHolland_CE06
{
    public class Manager : Salaried
    {
        public decimal bonus;

        public Manager(string name, string address, decimal salary, decimal bonus) : base(name, address, salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
            this.bonus = bonus;
        }
    }
}
