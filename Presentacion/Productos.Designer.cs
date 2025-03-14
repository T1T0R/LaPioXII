namespace LaPioXII.Presentacion
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 97);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(1122, 538);
            this.dgvProductos.TabIndex = 9;
            this.dgvProductos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvProductos_CellBeginEdit);
            this.dgvProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEndEdit);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 656);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(368, 61);
            this.btnAgregarProducto.TabIndex = 10;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(386, 656);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(368, 61);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.DarkRed;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProducto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btnModificarProducto.Location = new System.Drawing.Point(766, 656);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(368, 61);
            this.btnModificarProducto.TabIndex = 12;
            this.btnModificarProducto.Text = "MODIFICAR PRODUCTO";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1147, 77);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 77);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(199, 74);
            this.toolStripButton1.Text = " 🛒 VENTAS";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LaPioXII.Properties.Resources.lineas_con_fondo_degradado_amarillo_naranja_y_rosa_2560x1440_xtrafondos_com__1_;
            this.ClientSize = new System.Drawing.Size(1147, 729);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}