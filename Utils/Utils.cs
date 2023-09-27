using WebApplication1_Ejemplo.Models;

namespace WebApplication1_Ejemplo.Utils
{
    public class Utils
    {
        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto(1, "Producto1", "Descripcion1", 1),
            new Producto(1, "Producto2", "Descripcion2", 2),
            new Producto(1, "Producto3", "Descripcion3", 3),
            new Producto(1, "Producto4", "Descripcion4", 4),
        };
        
        
    }
}
