using System;
namespace BronsonHolland_CE06
{
    public class PartTime : Hourly
    {
        public PartTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour, hoursPerWeek)
        {
            this.name = name;
            this.address = address;
            this.payPerHour = payPerHour;
            this.hoursPerWeek = hoursPerWeek;
        }
    }
}
