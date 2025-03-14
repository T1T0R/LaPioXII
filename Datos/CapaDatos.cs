using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LaPioXII.Datos
{
    public class CapaDatos
    {
        private static string conexionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;



      
        public static DataTable VerificarUsuario(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "SELECT NombreUsuario, Rol FROM Usuarios WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt; // Si tiene datos, el usuario existe
            }
        }

        public static bool CrearUsuario(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Rol) VALUES (@NombreUsuario, @Contraseña, 'ADMIN')";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar usuario: " + ex.Message);
                    return false;
                }
            }
        }


        public static bool AgregarProducto(string nombre, string categoria, int precio)
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Productos (NombreProducto, Categoria, PrecioUnitario) VALUES (@Nombre, @Categoria, @Precio)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Categoria", categoria);
                        cmd.Parameters.AddWithValue("@Precio", precio);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar producto: " + ex.Message);
                    return false;
                }
            }
        }

        public static DataTable ObtenerProductos()
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    string query = "SELECT IDProducto AS [Codigo del Producto], NombreProducto AS [Nombre del Producto], Categoria, PrecioUnitario FROM Productos";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener productos: " + ex.Message);
                }
                return dt;
            }
        }




        public static DataTable ObtenerTodosLosProductos()
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string query = "SELECT IDProducto, NombreProducto, Categoria, PrecioUnitario FROM Productos";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        public static int ObtenerIDProductoPorNombre(string nombreProducto)
        {
            int IDProducto = -1;
            string query = "SELECT IDProducto FROM Productos WHERE NombreProducto = @nombre";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@nombre", nombreProducto);
                    conn.Open();
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        IDProducto = Convert.ToInt32(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del producto: " + ex.Message);
            }
            return IDProducto;
        }



        public static int ObtenerPrecioProducto(int IDProducto)
        {
            int precio = -1;
            string query = "SELECT PrecioUnitario FROM Productos WHERE IDProducto = @IDProducto";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IDProducto", IDProducto);
                    conn.Open();
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        precio = Convert.ToInt32(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el precio del producto: " + ex.Message);
            }
            return precio;
        }


        public static bool InsertarOActualizarVentasDiarias(int IDProducto, int cantidad, int precio)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string hoy = DateTime.Now.ToString("yyyy-MM-dd");

                // Verifica si ya existe el registro para el producto en el día actual.
                string queryExistente = @"SELECT CantidadVendida FROM VentasDiarias 
                                          WHERE Fecha = @Fecha AND IDProducto = @IDProducto";
                using (SqlCommand cmdExistente = new SqlCommand(queryExistente, conn))
                {
                    cmdExistente.Parameters.AddWithValue("@Fecha", hoy);
                    cmdExistente.Parameters.AddWithValue("@IDProducto", IDProducto);
                    object resultado = cmdExistente.ExecuteScalar();

                    if (resultado != null)
                    {
                        // Actualizar registro existente.
                        int cantidadActual = Convert.ToInt32(resultado);
                        int nuevaCantidad = cantidadActual + cantidad;
                        int nuevoSubtotal = nuevaCantidad * precio;

                        string updateQuery = @"UPDATE VentasDiarias
                                               SET CantidadVendida = @NuevaCantidad,
                                                   Subtotal = @NuevoSubtotal
                                               WHERE Fecha = @Fecha AND IDProducto = @IDProducto";
                        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                            cmdUpdate.Parameters.AddWithValue("@NuevoSubtotal", nuevoSubtotal);
                            cmdUpdate.Parameters.AddWithValue("@Fecha", hoy);
                            cmdUpdate.Parameters.AddWithValue("@IDProducto", IDProducto);
                            return cmdUpdate.ExecuteNonQuery() > 0;
                        }
                    }
                    else
                    {
                        // Insertar nuevo registro.
                        int subtotal = cantidad * precio;
                        string insertQuery = @"INSERT INTO VentasDiarias (Fecha, IDProducto, CantidadVendida, Subtotal)
                                               VALUES (@Fecha, @IDProducto, @Cantidad, @Subtotal)";
                        using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@Fecha", hoy);
                            cmdInsert.Parameters.AddWithValue("@IDProducto", IDProducto);
                            cmdInsert.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdInsert.Parameters.AddWithValue("@Subtotal", subtotal);
                            return cmdInsert.ExecuteNonQuery() > 0;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Obtiene el resumen diario: suma de subtotales y el producto más vendido (por cantidad).
        /// </summary>
        public static (int total, string productoMasVendido) ObtenerResumenDiario()
        {
            int total = 0;
            string productoMasVendido = "";

            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string hoy = DateTime.Now.ToString("yyyy-MM-dd");

                // Suma el total ganado del día.
                string queryTotal = @"SELECT SUM(Subtotal) FROM VentasDiarias WHERE Fecha = @Fecha";
                using (SqlCommand cmdTotal = new SqlCommand(queryTotal, conn))
                {
                    cmdTotal.Parameters.AddWithValue("@Fecha", hoy);
                    object resTotal = cmdTotal.ExecuteScalar();
                    if (resTotal != null && resTotal != DBNull.Value)
                    {
                        total = Convert.ToInt32(resTotal);
                    }
                }

                // Obtiene el producto más vendido (el que tenga mayor cantidad vendida).
                string queryMasVendido = @"
                    SELECT TOP 1 p.NombreProducto, SUM(vd.CantidadVendida) AS CantidadTotal
                    FROM VentasDiarias vd
                    INNER JOIN Productos p ON vd.IDProducto = p.IDProducto
                    WHERE vd.Fecha = @Fecha
                    GROUP BY p.NombreProducto
                    ORDER BY CantidadTotal DESC";
                using (SqlCommand cmdMasVendido = new SqlCommand(queryMasVendido, conn))
                {
                    cmdMasVendido.Parameters.AddWithValue("@Fecha", hoy);
                    using (SqlDataReader reader = cmdMasVendido.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            productoMasVendido = reader.GetString(0);
                        }
                    }
                }
            }

            return (total, productoMasVendido);
        }

        /// <summary>
        /// Inserta el resumen del día en la tabla HistorialVentas.
        /// </summary>
        public static bool InsertarHistorialVentas(DateTime fecha, int totalGanado, string productoMasVendido)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string query = @"INSERT INTO HistorialVentas (Fecha, TotalGanado, ProductoMasVendido)
                                 VALUES (@Fecha, @TotalGanado, @ProductoMasVendido)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Fecha", fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@TotalGanado", totalGanado);
                    cmd.Parameters.AddWithValue("@ProductoMasVendido", productoMasVendido);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static DataTable ObtenerDetalleVentasDiariasHoy()
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string hoy = DateTime.Now.ToString("yyyy-MM-dd");
                string query = @"
                        SELECT 
                            p.NombreProducto       AS [Nombre del Producto],
                            vd.CantidadVendida     AS [Cantidad],
                            vd.Subtotal            AS [Subtotal]
                        FROM VentasDiarias vd
                        INNER JOIN Productos p ON vd.IDProducto = p.IDProducto
                        WHERE vd.Fecha = @Fecha
                    ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Fecha", hoy);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }






        /// <summary>
        /// Limpia los registros de VentasDiarias correspondientes al día actual.
        /// </summary>
        public static bool LimpiarVentasDiarias()
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string hoy = DateTime.Now.ToString("yyyy-MM-dd");
                string deleteQuery = @"DELETE FROM VentasDiarias WHERE Fecha = @Fecha";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Fecha", hoy);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public static DataTable ObtenerVentasDiariasHoy()
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                // Formato de fecha AAAA-MM-DD
                string hoy = DateTime.Now.ToString("yyyy-MM-dd");

                // Consulta con alias descriptivos y sin IDs irrelevantes
                string query = @"
                    SELECT 
                    p.NombreProducto       AS [Nombre del Producto],
                    vd.CantidadVendida     AS [Cantidad Vendida],
                    vd.Subtotal            AS [Subtotal Ganado]
                    FROM VentasDiarias vd
                    INNER JOIN Productos p ON vd.IDProducto = p.IDProducto
                    WHERE vd.Fecha = @Fecha
                                            ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Fecha", hoy);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
            }
        }

        public static DataTable ObtenerHistorialVentas()
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string query = @"
         SELECT 
            HistorialID AS 'ID',
            Fecha AS 'Fecha de Venta',
            TotalGanado AS 'Total Recaudado',
            ProductoMasVendido AS 'Producto Más Vendido'
        FROM HistorialVentas
        ORDER BY Fecha DESC";  // Ordenado por fecha de más reciente a más antigua

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool ModificarProducto(int idProducto, string nombre, string categoria, int precio)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string query = @"
            UPDATE Productos
            SET NombreProducto = @Nombre,
                Categoria = @Categoria,
                PrecioUnitario = @Precio
            WHERE IDProducto = @IDProducto";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@IDProducto", idProducto);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public static bool ExisteProducto(int idProducto)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Productos WHERE IDProducto = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idProducto);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // true si existe
                }
            }
        }

        /// <summary>
        /// Elimina el producto de la tabla Productos según su ID.
        /// </summary>
        public static bool EliminarProducto(int idProducto)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                conn.Open();
                string query = "DELETE FROM Productos WHERE IDProducto = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idProducto);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


    }
}






