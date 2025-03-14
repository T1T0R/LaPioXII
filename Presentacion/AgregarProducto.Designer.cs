namespace LaPioXII.Presentacion
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarProductoForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "NOMBRE DEL PRODUCTO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtPrecio.Location = new System.Drawing.Point(71, 314);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(355, 28);
            this.txtPrecio.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "PRECIO UNITARIO";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtNombreProducto.Location = new System.Drawing.Point(71, 105);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(355, 28);
            this.txtNombreProducto.TabIndex = 12;
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(66, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "CATEGORIA";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Bebidas Alcoholicas",
            "Bebidas Sin Alcohol",
            "Cigarrillos",
            "Snacks"});
            this.cmbCategoria.Location = new System.Drawing.Point(71, 205);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(355, 37);
            this.cmbCategoria.TabIndex = 17;
            // 
            // btnAgregarProductoForm
            // 
            this.btnAgregarProductoForm.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarProductoForm.BackgroundImage = global::LaPioXII.Properties.Resources.hexagonos_con_luces_en_degradado_3840x2160_xtrafondos_com;
            this.btnAgregarProductoForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProductoForm.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProductoForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProductoForm.Location = new System.Drawing.Point(68, 380);
            this.btnAgregarProductoForm.Name = "btnAgregarProductoForm";
            this.btnAgregarProductoForm.Size = new System.Drawing.Size(358, 61);
            this.btnAgregarProductoForm.TabIndex = 19;
            this.btnAgregarProductoForm.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProductoForm.UseVisualStyleBackColor = false;
            this.btnAgregarProductoForm.Click += new System.EventHandler(this.btnAgregarProductoForm_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 27F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(489, 60);
            this.label4.TabIndex = 20;
            this.label4.Text = "AGREGAR PRODUCTOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::LaPioXII.Properties.Resources.lineas_con_fondo_degradado_amarillo_naranja_y_rosa_2560x1440_xtrafondos_com__1_;
            this.ClientSize = new System.Drawing.Size(486, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarProductoForm);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProducto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAgregarProductoForm;
        private System.Windows.Forms.Label label4;
    }
}