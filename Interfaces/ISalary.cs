using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISalary
    {
        int CalculateSalary();
        string Name { get; set; } // Имя сотрудника
        int Days { get; set; }  // Кол-во рабочих дней
    }
}
