using LaPioXII.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPioXII.Logica
{
    public class ProductosLogica
    {
        public static bool AgregarProducto(string nombre, string categoria, int precio)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(categoria) || precio <= 0)
            {
                return false; // Evitar agregar productos con datos inválidos
            }

            return CapaDatos.AgregarProducto(nombre, categoria, precio);
        }

        public static bool ExisteProducto(int idProducto)
        {
            return CapaDatos.ExisteProducto(idProducto);
        }

        /// <summary>
        /// Elimina el producto si existe.
        /// </summary>
        public static bool EliminarProducto(int idProducto)
        {
            return CapaDatos.EliminarProducto(idProducto);
        }


    }
}
