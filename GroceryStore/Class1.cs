using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
 
{
    public abstract class Employee
    {
        public string _name { get; set; }
        public int _BaseSalary { get; set; }

        public Employee(string name, int BaseSalary)
        {
            this._name = name;
            this._BaseSalary = BaseSalary;

            

        }

    }
}
