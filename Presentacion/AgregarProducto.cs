using System;
using System.Windows.Forms;

namespace LaPioXII.Presentacion
{
    public partial class AgregarProducto : Form
    {
        private Productos formproductos; // Referencia al formulario de productos

        // Constructor que recibe la referencia del formulario Productos
        public AgregarProducto(Productos formproductos)
        {
            InitializeComponent();
            this.formproductos = formproductos;
        }

        private void btnAgregarProductoForm_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text.Trim();
            string categoria = cmbCategoria.SelectedItem?.ToString();
            int precio;

            if (!int.TryParse(txtPrecio.Text.Trim(), out precio))
            {
                MessageBox.Show("Ingrese un precio válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Logica.ProductosLogica.AgregarProducto(nombre, categoria, precio))
            {
                MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                cmbCategoria.SelectedIndex = -1;

                // Llamamos al método en Productos para actualizar la grilla
                formproductos.ActualizarDgvProductos();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
