using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class SalesAssociate
    {
        private decimal _Bonus = 0.01M;

        public SalesAssociate(string name, int BaseSalary) : base(name, BaseSalary)
        {
        }

        private decimal CalculateBonus(decimal TotalSales)
        {
            return TotalSales * _Bonus;
        }
    }
}
