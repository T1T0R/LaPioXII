namespace LaPioXII.Presentacion
{
    partial class FormInputID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputID));
            this.btnEliminarProductoForm = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarProductoForm
            // 
            this.btnEliminarProductoForm.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminarProductoForm.BackgroundImage = global::LaPioXII.Properties.Resources.hexagonos_con_luces_en_degradado_3840x2160_xtrafondos_com;
            this.btnEliminarProductoForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProductoForm.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProductoForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProductoForm.Location = new System.Drawing.Point(44, 166);
            this.btnEliminarProductoForm.Name = "btnEliminarProductoForm";
            this.btnEliminarProductoForm.Size = new System.Drawing.Size(377, 61);
            this.btnEliminarProductoForm.TabIndex = 22;
            this.btnEliminarProductoForm.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarProductoForm.UseVisualStyleBackColor = false;
            this.btnEliminarProductoForm.Click += new System.EventHandler(this.btnEliminarProductoForm_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtCodigoProducto.Location = new System.Drawing.Point(44, 115);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(377, 28);
            this.txtCodigoProducto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "INGRESE CODIGO DEL PRODUCTO ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 27F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(-3, -1);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(485, 60);
            this.label4.TabIndex = 23;
            this.label4.Text = "ELIMINAR PRODUCTOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormInputID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaPioXII.Properties.Resources.lineas_con_fondo_degradado_amarillo_naranja_y_rosa_2560x1440_xtrafondos_com__1_;
            this.ClientSize = new System.Drawing.Size(471, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarProductoForm);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInputID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarProductoForm;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}