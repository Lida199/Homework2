using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Bank: IFinanceOpeations
    {
        public double CalculateLoanPercent(int Month, double AmountPerMonth)
        {
            var FixedPercentPerMonth = 1.05;
            return FixedPercentPerMonth * Month * AmountPerMonth;
        }

        public bool CheckUserHistory()
        {
            List<bool> Options = new List<bool>([true, false]);
            return Options[new Random().Next(0,2)];
        }
    }
}
