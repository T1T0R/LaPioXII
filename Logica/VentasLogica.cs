using System;
using System.Data;
using LaPioXII.Datos;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

namespace LaPioXII.Logica
{
    public class VentasLogica
    {

        // Inserta o actualiza en la tabla VentasDiarias para el día actual.
        public static bool AgregarProductoAlCarrito(int idProducto, int cantidad, int precio)
        {
            return CapaDatos.InsertarOActualizarVentasDiarias(idProducto, cantidad, precio);
        }

        // Obtiene el resumen del día: total ganado y el producto más vendido.
        public static (int total, string masVendido) ObtenerResumenDelDia()
        {
            return CapaDatos.ObtenerResumenDiario();
        }

        // Inserta el resumen diario en la tabla HistorialVentas.
        public static bool InsertarHistorialDia(int total, string productoMasVendido)
        {
            return CapaDatos.InsertarHistorialVentas(DateTime.Now, total, productoMasVendido);
        }

        // Limpia la tabla VentasDiarias (los registros del día actual).
        public static void LimpiarCarritoDeHoy()
        {
            CapaDatos.LimpiarVentasDiarias();
        }

        public static DataTable ObtenerHistorialVentas()
        {
            return CapaDatos.ObtenerHistorialVentas();
        }


        public static bool GenerarPDFVentasDiariasHoy(out string rutaArchivoPDF)
        {
            rutaArchivoPDF = "";
            // 1) Obtener datos de VentasDiarias
            DataTable dt = CapaDatos.ObtenerDetalleVentasDiariasHoy();
            if (dt.Rows.Count == 0)
            {
                return false; // No hay datos que exportar
            }

            try
            {
                // 2) Crear la carpeta en el escritorio si no existe
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string carpetaHistorial = Path.Combine(desktopPath, "Historial de Ventas");
                if (!Directory.Exists(carpetaHistorial))
                {
                    Directory.CreateDirectory(carpetaHistorial);
                }

                // Nombre de archivo descriptivo: "Ventas_YYYY-MM-DD_HH-mm-ss.pdf"
                string fecha = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                rutaArchivoPDF = Path.Combine(carpetaHistorial, $"Ventas_{fecha}.pdf");

                // 3) Generar el PDF
                using (FileStream fs = new FileStream(rutaArchivoPDF, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Título
                    Paragraph titulo = new Paragraph("VENTAS DEL DÍA\n\n", new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    // Tabla iTextSharp
                    PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    // Encabezados
                    foreach (DataColumn column in dt.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont("Arial", 10, Font.BOLD)));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);
                    }

                    // Filas
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), FontFactory.GetFont("Arial", 10, Font.NORMAL)));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdfTable.AddCell(cell);
                        }
                    }

                    doc.Add(pdfTable);
                    doc.Close();
                    writer.Close();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
