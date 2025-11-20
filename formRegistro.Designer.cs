namespace AstroLearn
{
    partial class formRegistro
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
            this.txtRegistroNombre = new System.Windows.Forms.TextBox();
            this.txtRegistroContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtRegistroCorreo = new System.Windows.Forms.TextBox();
            this.lblRegistroNombre = new System.Windows.Forms.Label();
            this.lblRegistroContraseña = new System.Windows.Forms.Label();
            this.lblConfirmacionContraseña = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegistroNombre
            // 
            this.txtRegistroNombre.AcceptsTab = true;
            this.txtRegistroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroNombre.Location = new System.Drawing.Point(352, 98);
            this.txtRegistroNombre.Multiline = true;
            this.txtRegistroNombre.Name = "txtRegistroNombre";
            this.txtRegistroNombre.Size = new System.Drawing.Size(329, 45);
            this.txtRegistroNombre.TabIndex = 0;
            // 
            // txtRegistroContrasena
            // 
            this.txtRegistroContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroContrasena.Location = new System.Drawing.Point(352, 190);
            this.txtRegistroContrasena.Multiline = true;
            this.txtRegistroContrasena.Name = "txtRegistroContrasena";
            this.txtRegistroContrasena.Size = new System.Drawing.Size(329, 45);
            this.txtRegistroContrasena.TabIndex = 1;
            this.txtRegistroContrasena.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(352, 278);
            this.txtConfirmarContrasena.Multiline = true;
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(329, 45);
            this.txtConfirmarContrasena.TabIndex = 2;
            this.txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // txtRegistroCorreo
            // 
            this.txtRegistroCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroCorreo.Location = new System.Drawing.Point(352, 371);
            this.txtRegistroCorreo.Multiline = true;
            this.txtRegistroCorreo.Name = "txtRegistroCorreo";
            this.txtRegistroCorreo.Size = new System.Drawing.Size(329, 45);
            this.txtRegistroCorreo.TabIndex = 3;
            // 
            // lblRegistroNombre
            // 
            this.lblRegistroNombre.AutoSize = true;
            this.lblRegistroNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNombre.Location = new System.Drawing.Point(12, 107);
            this.lblRegistroNombre.Name = "lblRegistroNombre";
            this.lblRegistroNombre.Size = new System.Drawing.Size(334, 27);
            this.lblRegistroNombre.TabIndex = 4;
            this.lblRegistroNombre.Text = "Ingresa tu nombre de usuario:";
            // 
            // lblRegistroContraseña
            // 
            this.lblRegistroContraseña.AutoSize = true;
            this.lblRegistroContraseña.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroContraseña.Location = new System.Drawing.Point(12, 199);
            this.lblRegistroContraseña.Name = "lblRegistroContraseña";
            this.lblRegistroContraseña.Size = new System.Drawing.Size(250, 27);
            this.lblRegistroContraseña.TabIndex = 5;
            this.lblRegistroContraseña.Text = "Ingresa tu contraseña:";
            // 
            // lblConfirmacionContraseña
            // 
            this.lblConfirmacionContraseña.AutoSize = true;
            this.lblConfirmacionContraseña.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacionContraseña.Location = new System.Drawing.Point(12, 287);
            this.lblConfirmacionContraseña.Name = "lblConfirmacionContraseña";
            this.lblConfirmacionContraseña.Size = new System.Drawing.Size(268, 27);
            this.lblConfirmacionContraseña.TabIndex = 6;
            this.lblConfirmacionContraseña.Text = "Confirma tu contraseña:";
            this.lblConfirmacionContraseña.Click += new System.EventHandler(this.lblConfirmacionContraseña_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresa tu correo electrónico:";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(364, 459);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(265, 75);
            this.btnRegistrarUsuario.TabIndex = 8;
            this.btnRegistrarUsuario.Text = "Registrarse";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(912, 598);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfirmacionContraseña);
            this.Controls.Add(this.lblRegistroContraseña);
            this.Controls.Add(this.lblRegistroNombre);
            this.Controls.Add(this.txtRegistroCorreo);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.txtRegistroContrasena);
            this.Controls.Add(this.txtRegistroNombre);
            this.Name = "formRegistro";
            this.Text = "formRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistroNombre;
        private System.Windows.Forms.TextBox txtRegistroContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.TextBox txtRegistroCorreo;
        private System.Windows.Forms.Label lblRegistroNombre;
        private System.Windows.Forms.Label lblRegistroContraseña;
        private System.Windows.Forms.Label lblConfirmacionContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarUsuario;
    }
}