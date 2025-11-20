namespace AstroLearn
{
    partial class formInicioSeccion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicioSeccion));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.txtUsuarioIS = new System.Windows.Forms.TextBox();
            this.txtContrasenaIS = new System.Windows.Forms.TextBox();
            this.btnIniciarSeccion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(306, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(312, 279);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // txtUsuarioIS
            // 
            this.txtUsuarioIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioIS.Location = new System.Drawing.Point(311, 309);
            this.txtUsuarioIS.Multiline = true;
            this.txtUsuarioIS.Name = "txtUsuarioIS";
            this.txtUsuarioIS.Size = new System.Drawing.Size(307, 57);
            this.txtUsuarioIS.TabIndex = 1;
            this.txtUsuarioIS.Text = "Usuario";
            this.txtUsuarioIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasenaIS
            // 
            this.txtContrasenaIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaIS.Location = new System.Drawing.Point(311, 372);
            this.txtContrasenaIS.Multiline = true;
            this.txtContrasenaIS.Name = "txtContrasenaIS";
            this.txtContrasenaIS.Size = new System.Drawing.Size(307, 53);
            this.txtContrasenaIS.TabIndex = 2;
            this.txtContrasenaIS.Text = "Contraseña";
            this.txtContrasenaIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasenaIS.UseSystemPasswordChar = true;
            // 
            // btnIniciarSeccion
            // 
            this.btnIniciarSeccion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIniciarSeccion.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSeccion.Location = new System.Drawing.Point(337, 443);
            this.btnIniciarSeccion.Name = "btnIniciarSeccion";
            this.btnIniciarSeccion.Size = new System.Drawing.Size(260, 49);
            this.btnIniciarSeccion.TabIndex = 3;
            this.btnIniciarSeccion.Text = "Iniciar sección";
            this.btnIniciarSeccion.UseVisualStyleBackColor = false;
            this.btnIniciarSeccion.Click += new System.EventHandler(this.btnIniciarSeccion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarse.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(337, 498);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(260, 49);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // formInicioSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(907, 569);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSeccion);
            this.Controls.Add(this.txtContrasenaIS);
            this.Controls.Add(this.txtUsuarioIS);
            this.Controls.Add(this.pbxLogo);
            this.Name = "formInicioSeccion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox txtUsuarioIS;
        private System.Windows.Forms.TextBox txtContrasenaIS;
        private System.Windows.Forms.Button btnIniciarSeccion;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}

