using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class FiveCorners:INUgol
    {
        public double Height { get; set; } // Высота
        public double Base { get; set; } // Основание
        public double Ugol { get; set; } // Угол между основанием и смежной стороной
        public int Count { get; set; } // Кол-во сторон
        public List<double> Length { get; set; } // Длины сторон
        public double S()
        {
            double ans = P() / 2;
            foreach (var a in Length) 
            {
                ans *= ans - a;
            }
            return Math.Sqrt(ans);
        }
        public double P()
        {
            double ans = 0;
            foreach (var a in Length)
            {
                ans += a;
            }
            return ans;
        }
    }
}
