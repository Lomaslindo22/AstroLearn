using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroLearn.Modelos
{
    public static class ObjetoFactory
    {
        public static ObjetoAstronomico CrearObjeto(
        string tipo, string nombre, double a1, double a2, string a3, string descripcion)
        {
            switch (tipo)
            {
                case "Planeta":
                    return new Planeta(nombre, a1, a2, a3, descripcion);

                case "Constelación":
                    return new Constelacion(nombre, a1, a2, a3, descripcion);

                case "Cuerpo Celeste":
                    return new CuerpoCeleste(nombre, a1, a2, a3, descripcion);

                default:
                    throw new Exception("Tipo de objeto no reconocido.");
            }
        }
    }
}
