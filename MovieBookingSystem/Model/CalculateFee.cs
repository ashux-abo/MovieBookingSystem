using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem.Model
{
    internal class CalculateFee
    {
        private double price;
        private double change;
        private double payment;
        public CalculateFee(double price, double payment)
        {
            this.price = price;
            this.payment = payment;
        }
        public double CalculateTotalFee()
        {
            if (payment < price)
            {
                throw new InvalidOperationException("Payment is less than the price.");
            }
            change = payment - price;
            return change;
        }
        public double GetChange()
        {
            return change;
        }
    }
}
