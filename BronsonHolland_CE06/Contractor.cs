using System;
namespace BronsonHolland_CE06
{
    public class Contractor : Hourly
    {
        public decimal noBenefitsBonus;

        public Contractor(string name, string address, decimal payPerHour, decimal hoursPerWeek, decimal noBenefitsBonus)
            : base(name, address, payPerHour, hoursPerWeek)
        {
            this.name = name;
            this.address = address;
            this.payPerHour = payPerHour;
            this.hoursPerWeek = hoursPerWeek;
            this.noBenefitsBonus = noBenefitsBonus;
        }
    }
}
