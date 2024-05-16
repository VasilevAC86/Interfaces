using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface INUgol
    {
        double Height { get; set; } // Высота
        double Base { get; set; } // Основание
        double Ugol { get; set; } // Угол между основанием и смежной стороной
        int Count { get; set; } // Кол-во сторон
        List<double> Length { get; set; } // Длины сторон
        double S();
        double P();
    }
}
