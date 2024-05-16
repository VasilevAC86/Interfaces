using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Scale2:IConverter
    {
        public int t { get; set; }
        public string NameScale1 { get; set; }
        public string NameScale2 { get; set; }
        public string ScaleIn()
        {
            return NameScale1;
        }
        public string ScaleOut()
        {
            return NameScale2;
        }
        public double Convert()
        {
            return 273.15 + t;
        }
    }
}
