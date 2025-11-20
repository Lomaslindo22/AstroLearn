using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroLearn.Modelos
{
    public abstract class ObjetoAstronomico
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Atributo1 { get; set; }
        public double Atributo2 { get; set; }
        public string Atributo3 { get; set; }
        public string Descripcion { get; set; }

        public ObjetoAstronomico(string nombre, string tipo, double a1, double a2, string a3, string descripcion)
        {
            Nombre = nombre;
            Tipo = tipo;
            Atributo1 = a1;
            Atributo2 = a2;
            Atributo3 = a3;
            Descripcion = descripcion;
        }
    }
}
