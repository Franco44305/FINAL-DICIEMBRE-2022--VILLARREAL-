using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    internal class Bebidas : Ingredientes
    {
        public int Mililitros { get; set; }
        public TipoBebidas TipoBebida { get; set; }
        public int GraduacionAlcoholica { get; set; }
    }
}
