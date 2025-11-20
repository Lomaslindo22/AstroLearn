using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroLearn
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }

        public Usuario(string nombre, string contrasena, string correo)
        {
            NombreUsuario = nombre;
            Contrasena = contrasena;
            Correo = correo;
        }
    }
}

//Clase base para la creación de usuarios