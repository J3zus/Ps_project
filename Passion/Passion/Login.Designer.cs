namespace Passion
{
    partial class Login
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
            this.Lblusuario = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.CbxUsuario = new System.Windows.Forms.ComboBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lblusuario
            // 
            this.Lblusuario.AutoSize = true;
            this.Lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblusuario.ForeColor = System.Drawing.Color.Black;
            this.Lblusuario.Location = new System.Drawing.Point(52, 200);
            this.Lblusuario.Name = "Lblusuario";
            this.Lblusuario.Size = new System.Drawing.Size(93, 25);
            this.Lblusuario.TabIndex = 0;
            this.Lblusuario.Text = "Usuario";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSalir.Location = new System.Drawing.Point(186, 301);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAceptar.Location = new System.Drawing.Point(105, 301);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.ForeColor = System.Drawing.Color.Black;
            this.LblContraseña.Location = new System.Drawing.Point(12, 237);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(133, 25);
            this.LblContraseña.TabIndex = 2;
            this.LblContraseña.Text = "Contraseña";
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.FormattingEnabled = true;
            this.CbxUsuario.Items.AddRange(new object[] {
            "Adriana",
            "Gabriela"});
            this.CbxUsuario.Location = new System.Drawing.Point(151, 200);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.Size = new System.Drawing.Size(158, 21);
            this.CbxUsuario.TabIndex = 1;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(151, 243);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(157, 20);
            this.TxtContraseña.TabIndex = 3;
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 336);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.CbxUsuario);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Lblusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblusuario;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.ComboBox CbxUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
    }
}