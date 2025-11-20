using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroLearn
{
    public static class ListaUsuarios
    {
        public static List<Usuario> Usuarios = new List<Usuario>()
    {
        new Usuario("DeividM", "clave123", "david@gmail.com"),
        new Usuario("SaniagoT", "12345678", "santiago@gmail.com"),
        new Usuario("AlexandraB", "password1", "alexandra@gmail.com"),
        new Usuario("PepitoP", "abc12345", "pepito@gmail.com"),
        new Usuario("SofiaS", "qwerty12", "sofia@gmail.com"),
        new Usuario("PedroM", "pedro888", "pedro@gmail.com"),
        new Usuario("IsaacN", "contra444", "isaac@gmail.com"),
        new Usuario("Galileog", "passpass", "galileo@gmail.com"),
        new Usuario("DianaM", "diana987", "diana@gmail.com"),
        new Usuario("Pruebass", "pruebasreales", "pruebas@gmail.com")
    };
    }
}
//Esta lista nos permitirá hacer validaciones de datos y comprobar message box mientras conectamos bd