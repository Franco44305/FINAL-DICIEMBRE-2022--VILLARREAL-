using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Recetas
    {
        public List<Ingredientes> IngredientesReceta { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string Autor { get; set; }


        public virtual string RetornarMensaje()
        {
            Recetas receta = new Recetas();

            return $"{Nombre} + {receta.Autor}";
        }
    }
}
