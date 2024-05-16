using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IConverter
    {
        string ScaleIn(); // Шкала из которой проходит конвертация
        string ScaleOut(); // Шкала в которую проходит конвертация
        double Convert();
    }
}
