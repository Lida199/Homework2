using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Company
    {
        public bool isForeign { get; set; }
        public Company(bool isForeign)
        {
            this.isForeign = isForeign;
        }

        public double toGovernment(double income)
        {
            double governmentAmount = 0;

            if (!isForeign) {
                governmentAmount = income * 18.0 / 100.0;
                Console.WriteLine($"18% is sent to the government: {governmentAmount}");
            } else
            {
                governmentAmount = income * 5.0 / 100.0;
                Console.WriteLine($"5% is sent to the government: {governmentAmount}");
            }

            return governmentAmount;
        }
    } 
}
