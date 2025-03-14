namespace LaPioXII.Presentacion
{
    partial class HistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialVentas));
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetallesVentas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarDia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVentas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-2, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1137, 74);
            this.label4.TabIndex = 8;
            this.label4.Text = "BIENVENIDO AL HISTORIAL DE VENTAS DIARIAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetallesVentas
            // 
            this.dgvDetallesVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesVentas.Location = new System.Drawing.Point(8, 173);
            this.dgvDetallesVentas.Name = "dgvDetallesVentas";
            this.dgvDetallesVentas.Size = new System.Drawing.Size(1127, 418);
            this.dgvDetallesVentas.TabIndex = 16;
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
            this.toolStrip1.Size = new System.Drawing.Size(1142, 77);
            this.toolStrip1.TabIndex = 23;
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
            this.toolStripButton2.Size = new System.Drawing.Size(256, 74);
            this.toolStripButton2.Text = "🛍️ PRODUCTOS";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 594);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(408, 59);
            this.label2.TabIndex = 45;
            this.label2.Text = "FECHA : ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 653);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(430, 55);
            this.label1.TabIndex = 46;
            this.label1.Text = "TOTAL DE GANANCIA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrarDia
            // 
            this.btnCerrarDia.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCerrarDia.BackgroundImage = global::LaPioXII.Properties.Resources.hexagonos_con_luces_en_degradado_3840x2160_xtrafondos_com;
            this.btnCerrarDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarDia.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnCerrarDia.ForeColor = System.Drawing.Color.White;
            this.btnCerrarDia.Location = new System.Drawing.Point(8, 711);
            this.btnCerrarDia.Name = "btnCerrarDia";
            this.btnCerrarDia.Size = new System.Drawing.Size(1127, 61);
            this.btnCerrarDia.TabIndex = 47;
            this.btnCerrarDia.UseVisualStyleBackColor = false;
            this.btnCerrarDia.Click += new System.EventHandler(this.btnCerrarDia_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(432, 594);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(698, 46);
            this.label3.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(432, 653);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(698, 46);
            this.label5.TabIndex = 49;
            // 
            // HistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaPioXII.Properties.Resources.lineas_con_fondo_degradado_amarillo_naranja_y_rosa_2560x1440_xtrafondos_com__1_;
            this.ClientSize = new System.Drawing.Size(1142, 784);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrarDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDetallesVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVentas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDetallesVentas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}