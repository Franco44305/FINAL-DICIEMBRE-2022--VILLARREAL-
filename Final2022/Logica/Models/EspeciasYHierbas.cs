using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    internal class EspeciasYHierbas : Ingredientes
    {
        public string LugarOrigen { get; set; }
        public TipoSabores TipoSabor { get; set; }
        public int Gramos { get; set; }
    }
}
