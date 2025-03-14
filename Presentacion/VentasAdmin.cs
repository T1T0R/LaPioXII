using LaPioXII.Datos;
using LaPioXII.Logica;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LaPioXII.Presentacion
{
    public partial class VentasAdmin : Form
    {
        private Productos formProductos;
        // Carrito temporal (DataTable local) para almacenar el detalle de la venta
        private DataTable dtVentas;

        public VentasAdmin()
        {
            InitializeComponent();
            
            toolStrip1.BackColor = Color.FromArgb(30, 30, 30);
            txtNombreProducto.Focus();
            ConfigurarDataGridView();
            InicializarVentasGrid();
            CargarAutoCompletado();
            // Ya no cargamos datos de la BD en el carrito temporal, solo usamos dtVentas
            ActualizarTotal();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (formProductos == null || formProductos.IsDisposed)
            {
                formProductos = new Productos();
                formProductos.Show();
                this.Hide();
            }
            else
            {
                formProductos.BringToFront();
            }
            this.Hide();
        }

        private void ConfigurarDataGridView()
        {
            dgvVentasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasAdmin.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVentasAdmin.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVentasAdmin.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvVentasAdmin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVentasAdmin.DefaultCellStyle.ForeColor = Color.Black;
            dgvVentasAdmin.BackgroundColor = Color.White;
            dgvVentasAdmin.GridColor = Color.LightGray;
            dgvVentasAdmin.AllowUserToAddRows = false;
            dgvVentasAdmin.AllowUserToDeleteRows = false;
            dgvVentasAdmin.AllowUserToResizeRows = false;
            dgvVentasAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentasAdmin.ReadOnly = true;
            dgvVentasAdmin.EnableHeadersVisualStyles = false;
            dgvVentasAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVentasAdmin.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentasAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvVentasAdmin.ScrollBars = ScrollBars.Vertical;
        }

        private void InicializarVentasGrid()
        {
            dtVentas = new DataTable();
            dtVentas.Columns.Add("IDProducto", typeof(int));
            dtVentas.Columns.Add("NombreProducto", typeof(string));
            dtVentas.Columns.Add("Cantidad", typeof(int));
            dtVentas.Columns.Add("PrecioUnitario", typeof(decimal));
            dtVentas.Columns.Add("Subtotal", typeof(int), "Cantidad * PrecioUnitario");
            dgvVentasAdmin.DataSource = dtVentas;
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text.Trim();
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            int productoID = CapaDatos.ObtenerIDProductoPorNombre(nombreProducto);
            if (productoID == -1)
            {
                MessageBox.Show("El producto no existe.");
                return;
            }

            int precio = CapaDatos.ObtenerPrecioProducto(productoID);
            if (precio == -1)
            {
                MessageBox.Show("No se pudo obtener el precio del producto.");
                return;
            }

            // 1) Buscar si el producto ya existe en el carrito (dtVentas)
            DataRow filaExistente = null;
            foreach (DataRow row in dtVentas.Rows)
            {
                if ((int)row["IDProducto"] == productoID)
                {
                    filaExistente = row;
                    break;
                }
            }

            // 2) Si existe, sumamos la cantidad y recalculamos Subtotal
            if (filaExistente != null)
            {
                int cantidadActual = (int)filaExistente["Cantidad"];
                int nuevaCantidad = cantidadActual + cantidad;
                filaExistente["Cantidad"] = nuevaCantidad;
               
            }
            else
            {
                // 3) Si no existe, creamos una nueva fila
                DataRow newRow = dtVentas.NewRow();
                newRow["IDProducto"] = productoID;
                newRow["NombreProducto"] = nombreProducto;
                newRow["Cantidad"] = cantidad;
                newRow["PrecioUnitario"] = precio;
                dtVentas.Rows.Add(newRow);
            }

            // Refrescar y limpiar campos
            dgvVentasAdmin.DataSource = dtVentas;
            ActualizarTotal();
            txtNombreProducto.Clear();
            txtCantidad.Clear();
            txtNombreProducto.Focus();
        }

        private void btnEliminarCarrito_Click(object sender, EventArgs e)
        {
            if (dtVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para eliminar.");
                return;
            }

            // 1) Obtener la última fila (último producto agregado)
            // 1) Obtener la última fila
            DataRow ultimaFila = dtVentas.Rows[dtVentas.Rows.Count - 1];
            int cantidadActual = (int)ultimaFila["Cantidad"];

            // 2) Si la cantidad es mayor a 1, restamos 1 unidad
            if (cantidadActual > 1)
            {
                ultimaFila["Cantidad"] = cantidadActual - 1;
                // No tocamos Subtotal
            }
            else
            {
                // 3) Si la cantidad es 1, eliminamos la fila completa
                dtVentas.Rows.RemoveAt(dtVentas.Rows.Count - 1);
            }


            // Refrescar la vista y el total
            dgvVentasAdmin.DataSource = dtVentas;
            ActualizarTotal();
        }


        private void ActualizarTotal()
        {
            int total = 0;
            foreach (DataRow row in dtVentas.Rows)
            {
                total += Convert.ToInt32(row["Subtotal"]);
            }

            // Configurar formato con punto (.) como separador de miles
            var nfi = new System.Globalization.NumberFormatInfo()
            {
                NumberGroupSeparator = ".", // separador de miles
                NumberDecimalSeparator = "," // separador de decimales (si lo necesitaras)
            };

            // Formatear sin decimales ("N0") usando la configuración anterior
            string totalFormateado = total.ToString("N0", nfi);

            // Label para el texto descriptivo
            label3.Text = "TOTAL A PAGAR:";
            label3.ForeColor = Color.Black;  // Por ejemplo, negro

            // Label para el valor formateado
            label5.Text = $"${totalFormateado}";
            label5.ForeColor = Color.Red;    // Por ejemplo, rojo
        }



        // Finaliza la compra ACTUAL (no todo el día), solo guarda estos productos en VentasDiarias
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (dtVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
                return;
            }

            // Pregunta al usuario si desea finalizar la compra
            DialogResult confirmacion = MessageBox.Show(
                "¿Desea finalizar la compra?",
                "Confirmar Finalización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.No)
            {
                // Si el usuario elige NO, se cancela la acción
                return;
            }


            // Insertar cada registro del carrito temporal en la tabla VentasDiarias
            foreach (DataRow row in dtVentas.Rows)
            {
                int idProducto = Convert.ToInt32(row["IDProducto"]);
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                int precio = Convert.ToInt32(row["PrecioUnitario"]);

                bool exito = VentasLogica.AgregarProductoAlCarrito(idProducto, cantidad, precio);

                if (!exito)
                {
                    MessageBox.Show($"Error al insertar el producto con ID: {idProducto}");
                    return;
                }
            }

            // Limpia el carrito temporal local
            dtVentas.Clear();
            dgvVentasAdmin.DataSource = dtVentas;
            ActualizarTotal();

            MessageBox.Show("Venta finalizada. Productos guardados en VentasDiarias (BD).");
        }

        // NUEVO BOTÓN: Cerrar el día
        // Se hace el resumen de TODO el día, se guarda en HistorialVentas y se limpia VentasDiarias
        private void btnCerrarDia_Click(object sender, EventArgs e)
        {
            // Pregunta al usuario si desea cerrar el día
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de cerrar el día? Se guardará el resumen en HistorialVentas y se limpiará VentasDiarias.\n" +
                "También se generará un PDF con las ventas de hoy.",
                "Confirmar Cierre de Día",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.No) return;

            var resumen = VentasLogica.ObtenerResumenDelDia();
            int totalGanado = resumen.total;
            string productoMasVendido = resumen.masVendido;

            if (totalGanado == 0)
            {
                MessageBox.Show("No hay ventas registradas hoy en la BD (VentasDiarias).");
                return;
            }

            // 1) Generar el PDF antes de limpiar
            bool pdfGenerado = VentasLogica.GenerarPDFVentasDiariasHoy(out string rutaPDF);
            if (pdfGenerado)
            {
                MessageBox.Show($"PDF generado correctamente:\n{rutaPDF}");
            }
            else
            {
                MessageBox.Show("No se pudo generar el PDF (posiblemente no hay datos o ocurrió un error).");
            }

            // 2) Insertar el resumen en HistorialVentas
            bool exitoHistorial = VentasLogica.InsertarHistorialDia(totalGanado, productoMasVendido);
            if (!exitoHistorial)
            {
                MessageBox.Show("Error al insertar en HistorialVentas.");
                return;
            }

            // 3) Limpiar VentasDiarias
            VentasLogica.LimpiarCarritoDeHoy();
            MessageBox.Show("Día cerrado. Se ha guardado el resumen en HistorialVentas y limpiado VentasDiarias.");

        }

        private void CargarAutoCompletado()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            DataTable productos = CapaDatos.ObtenerTodosLosProductos();

            foreach (DataRow row in productos.Rows)
            {
                autoComplete.Add(row["NombreProducto"].ToString());
            }

            txtNombreProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombreProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombreProducto.AutoCompleteCustomSource = autoComplete;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HistorialVentas mostrarVentas = new HistorialVentas();
            mostrarVentas.Show();
            this.Hide();
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCantidad.Focus();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAgregarCarrito.PerformClick();
            }
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            // Verifica si hay productos en el carrito temporal
            if (dtVentas.Rows.Count > 0)
            {
                // Pregunta al usuario si está seguro de limpiar
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea vaciar el carrito?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    // Limpia todas las filas del DataTable
                    dtVentas.Clear();
                    // Refresca el DataGridView
                    dgvVentasAdmin.DataSource = dtVentas;
                    // Actualiza el total
                    ActualizarTotal();

                    MessageBox.Show("El carrito ha sido vaciado.");
                }
            }
            else
            {
                MessageBox.Show("El carrito ya está vacío.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvVentasAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
