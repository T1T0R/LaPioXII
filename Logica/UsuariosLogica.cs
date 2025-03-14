using LaPioXII.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPioXII.Logica
{
    public class UsuariosLogica
    {
        public static string IniciarSesion(string usuario, string contraseña)
        {
            DataTable dt = CapaDatos.VerificarUsuario(usuario, contraseña);

            if (dt.Rows.Count > 0) // Si encontró el usuario
            {
                return dt.Rows[0]["Rol"].ToString(); // Retorna el rol del usuario
            }
            else
            {
                return null; // Usuario no encontrado
            }
        }


        public static bool CrearUsuario(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                return false; // No permitir usuarios con campos vacíos
            }

            return Datos.CapaDatos.CrearUsuario(usuario, contraseña);
        }
    }

}


