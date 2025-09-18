using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class MicroFinance: IFinanceOpeations
    {
        public double CalculateLoanPercent(int Month, double AmountPerMonth)
        {
            var FixedPercentPerMonth = 1.1;
            var FixedTarif = 4;
            return (FixedPercentPerMonth * Month * AmountPerMonth) + Month * FixedTarif;
        }

        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
