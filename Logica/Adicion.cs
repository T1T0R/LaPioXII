using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPioXII.Logica
{
    public class Adicion
    {
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }

        public Adicion(int productoID, int cantidad)
        {
            ProductoID = productoID;
            Cantidad = cantidad;
        }
    }
}
