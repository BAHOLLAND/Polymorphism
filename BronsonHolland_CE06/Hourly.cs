using System;
namespace BronsonHolland_CE06
{
    public class Hourly : Employee
    {
        public decimal payPerHour;
        public decimal hoursPerWeek;

        public Hourly(string name, string address, decimal payPerHour, decimal hoursPerWeek)
            : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.payPerHour = payPerHour;
            this.hoursPerWeek = hoursPerWeek;
        }
    }
}
