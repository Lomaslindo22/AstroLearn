using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroLearn.Modelos
{
    public class CuerpoCeleste:ObjetoAstronomico
    {
        public CuerpoCeleste(string nombre, double a1, double a2, string a3, string descripcion)
        : base(nombre, "Cuerpo Celeste", a1, a2, a3, descripcion)
        {
        }
    }
}
