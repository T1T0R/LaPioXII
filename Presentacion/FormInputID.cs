using LaPioXII.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPioXII.Presentacion
{
    public partial class FormInputID : Form
    {
        private Productos formprincipal;
        public FormInputID(Productos formprincipal)
        {
            InitializeComponent();
            this.formprincipal = formprincipal;
        }

        private void btnEliminarProductoForm_Click(object sender, EventArgs e)
        {
            // 1. Verificar si el usuario ingresó un ID válido
            if (!int.TryParse(txtCodigoProducto.Text, out int idProducto))
            {
                MessageBox.Show("Ingrese un ID de producto válido (número entero).");
                return;
            }

            // 2. Verificar si el producto existe en la BD
            bool existe = ProductosLogica.ExisteProducto(idProducto);
            if (!existe)
            {
                MessageBox.Show($"No existe un producto con el ID {idProducto}.");
                return;
            }

            // 3. Preguntar si realmente desea eliminar
            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro de eliminar el producto con ID {idProducto}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                // 4. Llamar a la capa lógica para eliminar
                bool exito = ProductosLogica.EliminarProducto(idProducto);
                if (exito)
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                    // Aquí podrías cerrar el formulario o limpiar el TextBox
                    formprincipal.CargarProductos();
                    txtCodigoProducto.Clear();


                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto. Tal vez no existe o ocurrió un error.");
                }
            }
            else
            {
                // Si el usuario dijo que no, no hacemos nada
                MessageBox.Show("El producto no se eliminó.");
            }
        }
    }
    
}
