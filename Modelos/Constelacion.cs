using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroLearn.Modelos
{
    public class Constelacion:ObjetoAstronomico
    {
        public Constelacion(string nombre, double a1, double a2, string a3, string descripcion)
        : base(nombre, "Constelación", a1, a2, a3, descripcion)
        {
        }
    }
}
