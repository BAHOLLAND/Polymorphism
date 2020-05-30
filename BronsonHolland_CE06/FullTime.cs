using System;
namespace BronsonHolland_CE06
{
    public class FullTime : Hourly
    {
        //Name, address, payPerHour, and a constant 40 for hours need to be passed to FullTime’s parent constructor.
        public FullTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour, hoursPerWeek)
        {
            this.name = name;
            this.address = address;
            this.payPerHour = payPerHour;
        }
    }
}
