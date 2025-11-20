using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroLearn.Modelos
{
    public static class ListaObjetos
    {
        public static List<ObjetoAstronomico> Objetos = new List<ObjetoAstronomico>()
    {
        new Planeta("Marte", 227.9, 687, "Rico en óxido de hierro",
        "Marte es conocido como el planeta rojo."),

        new Planeta("Júpiter", 778.5, 11.86, "Gigante gaseoso",
        "Es el planeta más grande del Sistema Solar."),

        new Constelacion("Orión", 1344, 8.6, "Forma de cazador",
        "Una de las constelaciones más brillantes y reconocibles."),

        new CuerpoCeleste("Luna", 384400, 27.3, "Satélite natural",
        "El único satélite natural de la Tierra.")
    };
    }
}
