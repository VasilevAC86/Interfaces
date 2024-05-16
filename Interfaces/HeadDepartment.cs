using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class HeadDepartment:ISalary
    {
        public int Days { get; set; }
        public string Name { get; set; }
        public int CalculateSalary()
        {
            return Days * 2500;
        }
        public void Print()
        {
            Console.WriteLine("Имя сотрудника: " + Name + "\n" + "Кол-во рабочих дней: " + Days + "\n" + "Зарплата: " + CalculateSalary());
        }
    }
}
