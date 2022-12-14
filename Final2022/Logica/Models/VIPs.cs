using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    internal class VIPs : Usuarios
    {
        public List<int> CodigosIngredientesFavoritos { get; set; }
        public List<int> CodigosRecetasFavoritas { get; set; }
        public List<string> UsuariosFavoritos { get; set; }
    }
}
