using Logica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logic
    {
        List<Usuarios> usuarios = new List<Usuarios>();
        List<Recetas> recetas = new List<Recetas>();
        List<Ingredientes> ingredientes = new List<Ingredientes>();
        List<VIPs> vips = new List<VIPs>();
        public bool CargarActualizarCliente(int Numero, string Nombre, string NickName, string Contraseña)
        {
            foreach (var user in usuarios)
            {
                if (user.Numero == Numero)
                {
                    user.Numero = Numero;
                    user.Nombre = Nombre;
                    user.NickName = NickName;
                    user.Contraseña = Contraseña;
                    return true;
                }
            }
            Usuarios usuario = new Usuarios()
            {
                Numero = Numero,
                Nombre = Nombre,
                NickName = NickName,
                Contraseña = Contraseña
            };
            return true;

        }
        public bool CargarActualizarCliente(int Numero, string Nombre,
            string NickName, string Contraseña, List<int> CodsIngredientesFavs)
        {
            foreach (var user in vips)
            {
                if (user.Numero == Numero)
                {
                    user.Numero = Numero;
                    user.Nombre = Nombre;
                    user.NickName = NickName;
                    user.Contraseña = Contraseña;
                    user.CodigosIngredientesFavoritos = CodsIngredientesFavs;
                    return true;
                };
            }
            VIPs usuario = new VIPs()

            {
                Numero = Numero,
                Nombre = Nombre,
                NickName = NickName,
                Contraseña = Contraseña,
                CodigosIngredientesFavoritos = CodsIngredientesFavs
            };
            return true;
        }
        public bool AgregarReceta(int numero, int RecetaFavs, string Nickname, string contraseña)
        {
            bool resultado = ValidarUsuario(Nickname, contraseña);
            if (resultado == false)
            {
                return false;
            }
            foreach (var rec in recetas)
            {
                if (rec.Codigo == RecetaFavs)
                {
                    foreach (var cliente in vips)
                    {
                        if (cliente.Numero == numero)
                        {
                            cliente.CodigosRecetasFavoritas.Add(RecetaFavs);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool AgregarUsuarioFavorito(int Numero, string nickname, string Nickname, string contraseña)
        {
            bool resultado = ValidarUsuario(Nickname, contraseña);
            if (resultado == false)
            {
                return false;
            }
            foreach (var user in vips)
            {
                if (user.Numero == Numero)
                {
                    user.UsuariosFavoritos.Add(nickname);
                    return true;
                }
            }
            return false;
        }
        public List<string> FiltrarPorTexto(string palabra, string Nickname, string contraseña)
        {
            List<string> ListadoFiltrado = new List<string>();
            bool resultado = ValidarUsuario(Nickname, contraseña);
            if (resultado == true)
            {
                
                foreach (var rec in recetas)
                {
                    if (rec.Nombre == palabra)
                    {
                        ListadoFiltrado.Add(rec.Nombre);
                    }
                }
                foreach (var ing in ingredientes)
                {
                    if (ing.Nombre == palabra)
                    {
                        ListadoFiltrado.Add(ing.Nombre);
                    }
                }
                return ListadoFiltrado;
            }
            else
            {
                return ListadoFiltrado;
            }
            
        }
        public bool ValidarUsuario(string nickname, string contraseña)
        {
            foreach (var user in usuarios)
            {
                if (user.NickName == nickname && user.Contraseña == contraseña)
                {
                 return true;
                }
            }
            return false;
        }
    }
}
