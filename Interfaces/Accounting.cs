using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Accounting
    {           
        public double Taxes(ISalary obj, int days)
        {       

            return (obj.CalculateSalary() / obj.Days) * days * 0.13;
        }
    }
}
