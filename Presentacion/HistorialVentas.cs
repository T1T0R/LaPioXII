using LaPioXII.Datos;
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
    public partial class HistorialVentas : Form
    {
        public HistorialVentas()
        {
            InitializeComponent();
            dgvDetallesVentas.Size = new Size(1127, 418);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HistorialVentas_Load(object sender, EventArgs e)
        {
            toolStrip1.BackColor = Color.FromArgb(30, 30, 30);

            // Al cargar el formulario, mostrar VentasDiarias por defecto
            dgvDetallesVentas.DataSource = CapaDatos.ObtenerVentasDiariasHoy();
            label4.Text = "VENTAS DEL DÍA";
            btnCerrarDia.Text = "VER HISTORIAL DE VENTAS";  // En mayúsculas


            // Asegurar que los labels sean visibles por defecto
            label1.Visible = true;
            label2.Visible = true;


            label2.Text =$"FECHA DE HOY : {DateTime.Now.ToString("dd/MM/yyyy")}";
            CargarVentasDiarias();
            ConfigurarDataGridView();

        }
        private void ConfigurarDataGridView()
        {
            dgvDetallesVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDetallesVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetallesVentas.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDetallesVentas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetallesVentas.DefaultCellStyle.ForeColor = Color.Black;
            dgvDetallesVentas.BackgroundColor = Color.White;
            dgvDetallesVentas.GridColor = Color.LightGray;
            dgvDetallesVentas.AllowUserToAddRows = false;
            dgvDetallesVentas.AllowUserToDeleteRows = false;
            dgvDetallesVentas.AllowUserToResizeRows = false;
            dgvDetallesVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallesVentas.ReadOnly = true;
            dgvDetallesVentas.EnableHeadersVisualStyles = false;
            dgvDetallesVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetallesVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetallesVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvDetallesVentas.ScrollBars = ScrollBars.Vertical;
        }

        private void CargarVentasDiarias()
        {
            // Cargar tu DataTable y DataGridView como antes...
            DataTable dt = CapaDatos.ObtenerVentasDiariasHoy();
            dgvDetallesVentas.DataSource = dt;

            // Sumar Subtotal ganado
            int totalHoy = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalHoy += Convert.ToInt32(row["Subtotal ganado"]);
            }

            // Formatear con punto separador de miles
            var nfi = new System.Globalization.NumberFormatInfo()
            {
                NumberGroupSeparator = ".",
                NumberDecimalSeparator = ","
            };
            string totalFormateado = totalHoy.ToString("N0", nfi);

            // -- Label2 y Label3 para la fecha --
            label2.Text = "FECHA:";
            label2.ForeColor = Color.Black;     // negro

            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label3.ForeColor = Color.Red;       // rojo

            // -- Label1 y Label5 para la ganancia --
            label1.Text = "TOTAL DE GANANCIA DEL DÍA DE HOY:";
            label1.ForeColor = Color.Black;     // negro

            label5.Text = $"${totalFormateado}";
            label5.ForeColor = Color.Red;       // rojo
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Productos mostrarproducots= new Productos();

            mostrarproducots.Show();

            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VentasAdmin mostrarventas= new VentasAdmin();
            mostrarventas.Show();
            this.Hide();

        }

        private bool mostrandoHistorial = false; // Variable para alternar entre vistas


        private void btnCerrarDia_Click(object sender, EventArgs e)
        {
            if (!mostrandoHistorial)
            {
                // Mostrar HistorialVentas
                dgvDetallesVentas.DataSource = VentasLogica.ObtenerHistorialVentas();
                label4.Text = "HISTORIAL DE VENTAS";
                btnCerrarDia.Text = "VER VENTAS DIARIAS";  // En mayúsculas

                // Ocultar labels y agrandar el DataGridView
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible= false;
                dgvDetallesVentas.Size = new Size(1127, 532);


            }
            else
            {
                // Volver a mostrar VentasDiarias
                dgvDetallesVentas.DataSource = CapaDatos.ObtenerVentasDiariasHoy();
                label4.Text = "VENTAS DEL DÍA";
                btnCerrarDia.Text = "VER HISTORIAL DE VENTAS";  // En mayúsculas

                // Mostrar labels y ajustar tamaño del DataGridView
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                dgvDetallesVentas.Size = new Size(1127, 418);
            }

            // Alternar estado
            mostrandoHistorial = !mostrandoHistorial;
        }
    }
}
