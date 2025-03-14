namespace LaPioXII.Presentacion
{
    partial class VentasAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasAdmin));
            this.dgvVentasAdmin = new System.Windows.Forms.DataGridView();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.btnEliminarCarrito = new System.Windows.Forms.Button();
            this.btnLimpiarCarrito = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarDia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentasAdmin
            // 
            this.dgvVentasAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasAdmin.Location = new System.Drawing.Point(12, 326);
            this.dgvVentasAdmin.Name = "dgvVentasAdmin";
            this.dgvVentasAdmin.Size = new System.Drawing.Size(1122, 411);
            this.dgvVentasAdmin.TabIndex = 2;
            this.dgvVentasAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentasAdmin_CellContentClick);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtNombreProducto.Location = new System.Drawing.Point(2, 54);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(302, 32);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE DEL PRODUCTO";
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarCarrito.BackgroundImage = global::LaPioXII.Properties.Resources.hexagonos_con_luces_en_degradado_3840x2160_xtrafondos_com;
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(14, 259);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(314, 61);
            this.btnAgregarCarrito.TabIndex = 7;
            this.btnAgregarCarrito.Text = "AGREGAR AL CARRITO 🛒";
            this.btnAgregarCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // btnEliminarCarrito
            // 
            this.btnEliminarCarrito.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarCarrito.BackgroundImage = global::LaPioXII.Properties.Resources.pintura_de_patrones_abstractos_y_arremolinados_3840x2160_xtrafondos_com__1_;
            this.btnEliminarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCarrito.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnEliminarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCarrito.Location = new System.Drawing.Point(334, 259);
            this.btnEliminarCarrito.Name = "btnEliminarCarrito";
            this.btnEliminarCarrito.Size = new System.Drawing.Size(260, 61);
            this.btnEliminarCarrito.TabIndex = 8;
            this.btnEliminarCarrito.Text = "ELIMINAR PRODUCTO DEL CARRITO 🛒";
            this.btnEliminarCarrito.UseVisualStyleBackColor = false;
            this.btnEliminarCarrito.Click += new System.EventHandler(this.btnEliminarCarrito_Click);
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLimpiarCarrito.BackgroundImage = global::LaPioXII.Properties.Resources.barras_de_color_verde_y_negro_3840x2160_xtrafondos_com;
            this.btnLimpiarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarCarrito.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(600, 259);
            this.btnLimpiarCarrito.Name = "btnLimpiarCarrito";
            this.btnLimpiarCarrito.Size = new System.Drawing.Size(260, 61);
            this.btnLimpiarCarrito.TabIndex = 9;
            this.btnLimpiarCarrito.Text = "LIMPIAR CARRITO 🛒";
            this.btnLimpiarCarrito.UseVisualStyleBackColor = false;
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.btnLimpiarCarrito_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.Lime;
            this.btnFinalizarCompra.BackgroundImage = global::LaPioXII.Properties.Resources.barras_de_color_morado_y_negro_4800x3200_xtrafondos_com;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(866, 259);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(270, 61);
            this.btnFinalizarCompra.TabIndex = 8;
            this.btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 657);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCantidad.Location = new System.Drawing.Point(2, 134);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(302, 32);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 173);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1147, 77);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(256, 74);
            this.toolStripButton1.Text = "🛍️ PRODUCTOS";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 77);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(423, 74);
            this.toolStripButton2.Text = " 📜 HISTORIAL DE VENTAS";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(337, 185);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(435, 68);
            this.label3.TabIndex = 33;
            this.label3.Text = "TOTAL A PAGAR: $";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 40F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(334, 88);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(813, 78);
            this.label4.TabIndex = 34;
            this.label4.Text = "BIENVENIDO A VENTAS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCerrarDia
            // 
            this.btnCerrarDia.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCerrarDia.BackgroundImage = global::LaPioXII.Properties.Resources.hexagonos_con_luces_en_degradado_3840x2160_xtrafondos_com;
            this.btnCerrarDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarDia.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnCerrarDia.ForeColor = System.Drawing.Color.White;
            this.btnCerrarDia.Location = new System.Drawing.Point(12, 743);
            this.btnCerrarDia.Name = "btnCerrarDia";
            this.btnCerrarDia.Size = new System.Drawing.Size(1122, 61);
            this.btnCerrarDia.TabIndex = 35;
            this.btnCerrarDia.Text = "CERRAR DIA";
            this.btnCerrarDia.UseVisualStyleBackColor = false;
            this.btnCerrarDia.Click += new System.EventHandler(this.btnCerrarDia_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(720, 178);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(416, 68);
            this.label5.TabIndex = 36;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VentasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LaPioXII.Properties.Resources.lineas_con_fondo_degradado_amarillo_naranja_y_rosa_2560x1440_xtrafondos_com__1_;
            this.ClientSize = new System.Drawing.Size(1147, 812);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrarDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiarCarrito);
            this.Controls.Add(this.btnEliminarCarrito);
            this.Controls.Add(this.dgvVentasAdmin);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnAgregarCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentasAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVentasAdmin;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnEliminarCarrito;
        private System.Windows.Forms.Button btnLimpiarCarrito;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnCerrarDia;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label5;
    }
}