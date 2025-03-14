namespace LaPioXII.Presentacion
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.txtContraseñaRegistro = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.linkLblRegistro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 27F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(-5, 23);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(499, 74);
            this.label3.TabIndex = 13;
            this.label3.Text = "REGISTRO EMPLEADO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "USUARIO";
            // 
            // txtUsuarioRegistro
            // 
            this.txtUsuarioRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioRegistro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioRegistro.Location = new System.Drawing.Point(45, 137);
            this.txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            this.txtUsuarioRegistro.Size = new System.Drawing.Size(399, 28);
            this.txtUsuarioRegistro.TabIndex = 18;
            this.txtUsuarioRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuarioRegistro_KeyDown);
            // 
            // txtContraseñaRegistro
            // 
            this.txtContraseñaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaRegistro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtContraseñaRegistro.Location = new System.Drawing.Point(45, 224);
            this.txtContraseñaRegistro.Name = "txtContraseñaRegistro";
            this.txtContraseñaRegistro.PasswordChar = '*';
            this.txtContraseñaRegistro.Size = new System.Drawing.Size(399, 28);
            this.txtContraseñaRegistro.TabIndex = 23;
            this.txtContraseñaRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseñaRegistro_KeyDown);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCrearUsuario.BackgroundImage = global::LaPioXII.Properties.Resources.hexagonos_con_luces_en_degradado_3840x2160_xtrafondos_com;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Location = new System.Drawing.Point(45, 294);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(399, 61);
            this.btnCrearUsuario.TabIndex = 24;
            this.btnCrearUsuario.Text = "CREAR USUARIO 🧔🏻👩🏻‍🦳";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // linkLblRegistro
            // 
            this.linkLblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.linkLblRegistro.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.linkLblRegistro.Location = new System.Drawing.Point(184, 255);
            this.linkLblRegistro.Name = "linkLblRegistro";
            this.linkLblRegistro.Size = new System.Drawing.Size(260, 19);
            this.linkLblRegistro.TabIndex = 25;
            this.linkLblRegistro.TabStop = true;
            this.linkLblRegistro.Text = "VER CONTRASEÑA";
            this.linkLblRegistro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLblRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistro_LinkClicked);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(486, 394);
            this.Controls.Add(this.linkLblRegistro);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.txtContraseñaRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuarioRegistro);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioRegistro;
        private System.Windows.Forms.TextBox txtContraseñaRegistro;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.LinkLabel linkLblRegistro;
    }
}