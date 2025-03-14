using LaPioXII.Datos;
using LaPioXII.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LaPioXII.Presentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            CargarProductos();
            ConfigurarDataGridView();
            toolStrip1.BackColor= Color.FromArgb(30, 30, 30);
        }

        private bool modoEdicion = false; // Indica si se permite editar o no
                                          // Diccionario para guardar el valor anterior de cada celda antes de editar
        private Dictionary<DataGridViewCell, object> valorAnterior = new Dictionary<DataGridViewCell, object>();


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Abre el formulario de agregar producto y le pasa la referencia de este formulario
            AgregarProducto formAgregar = new AgregarProducto(this);
            formAgregar.Show();
        }

        public void CargarProductos()
        {
            // Cargar los productos desde la base de datos al DataGridView
            dgvProductos.DataSource = Datos.CapaDatos.ObtenerProductos();
        }

        public void ActualizarDgvProductos()
        {
            CargarProductos(); // Recargar los productos después de agregar uno nuevo
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VentasAdmin ventas  = new VentasAdmin();
            ventas.Show();
            this.Hide();

        }

        private void ConfigurarDataGridView()
        {
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.GridColor = Color.LightGray;

            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ReadOnly = true;

            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvProductos.ScrollBars = ScrollBars.Vertical;
        }


        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            FormInputID mostrareliminarid = new FormInputID(this);
            mostrareliminarid.ShowDialog();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            // Alternar modo de edición
            modoEdicion = !modoEdicion;

            if (modoEdicion)
            {
                // Permitir edición de celdas
                dgvProductos.ReadOnly = false;
                btnModificarProducto.Text = "Desactivar Edición";
                MessageBox.Show("Modo edición activado. Ahora puede modificar celdas.");
            }
            else
            {
                // Volver a modo solo lectura
                dgvProductos.ReadOnly = true;
                btnModificarProducto.Text = "Modificar Producto";
                MessageBox.Show("Modo edición desactivado.");
            }

        }

        private void dgvProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!modoEdicion) return; // Si no estamos en modo edición, no hacer nada

            DataGridViewCell celda = dgvProductos[e.ColumnIndex, e.RowIndex];
            if (!valorAnterior.ContainsKey(celda))
            {
                valorAnterior.Add(celda, celda.Value);
            }
            else
            {
                // Actualiza el valor anterior en caso de que la celda se edite de nuevo
                valorAnterior[celda] = celda.Value;
            }
        }

        private bool ActualizarProductoEnBD(int rowIndex)
        {
            try
            {
                // Supongamos que las columnas se llaman "Codigo del Producto", "Nombre del Producto", "Categoria", "PrecioUnitario"
                DataGridViewRow fila = dgvProductos.Rows[rowIndex];

                int idProducto = Convert.ToInt32(fila.Cells["Codigo del Producto"].Value);
                string nombre = fila.Cells["Nombre del Producto"].Value.ToString();
                string categoria = fila.Cells["Categoria"].Value.ToString();
                int precio = Convert.ToInt32(fila.Cells["PrecioUnitario"].Value);

                // Llamamos a la capa de datos
                return CapaDatos.ModificarProducto(idProducto, nombre, categoria, precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error interno: " + ex.Message);
                return false;
            }
        }


        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!modoEdicion) return; // Solo confirmar si estamos en modo edición

            DataGridViewCell celda = dgvProductos[e.ColumnIndex, e.RowIndex];
            if (!valorAnterior.ContainsKey(celda)) return;

            object valorViejo = valorAnterior[celda];
            object valorNuevo = celda.Value;

            // Si el valor no cambió, no hay nada que confirmar
            if (Equals(valorViejo, valorNuevo))
            {
                valorAnterior.Remove(celda);
                return;
            }

            // Preguntar al usuario si confirma la modificación
            DialogResult respuesta = MessageBox.Show(
                $"¿Desea confirmar la modificación?\n\n" +
                $"Valor anterior: {valorViejo}\n" +
                $"Valor nuevo: {valorNuevo}",
                "Confirmar Modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                // Actualizar en la base de datos
                bool exito =ActualizarProductoEnBD(e.RowIndex);
                if (!exito)
                {
                    MessageBox.Show("Error al actualizar en la base de datos. Se revertirá el cambio.");
                    // Revertir el valor en la celda
                    celda.Value = valorViejo;
                }
            }
            else
            {
                // Revertir el valor si el usuario no confirma
                celda.Value = valorViejo;
            }

            // Quitar la celda del diccionario
            valorAnterior.Remove(celda);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HistorialVentas mostrarhistorial = new HistorialVentas();
            mostrarhistorial.ShowDialog();
            this.Hide();
        }
    }
}
