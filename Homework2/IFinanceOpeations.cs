using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal interface IFinanceOpeations
    {
        double CalculateLoanPercent(int Month, double AmountPerMonth);
        bool CheckUserHistory();
    }
}
