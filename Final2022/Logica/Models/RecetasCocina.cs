using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class RecetasCocina : Recetas
    {
        public override string RetornarMensaje()
        {
            RecetasCocina receta = new RecetasCocina();

            return base.RetornarMensaje();
        }
    }
}
