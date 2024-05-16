using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Manager : ISalary,IInput
    {        
        public int Days { get; set; }
        public string Name { get; set; }
        public int CalculateSalary()
        {
            return Days * 1000;
        }
        public void Print()
        {
            Console.WriteLine("Имя сотрудника: " + Name + "\n" + "Кол-во рабочих дней: " + Days + "\n" + "Зарплата: " + CalculateSalary());
        }
    }
}
