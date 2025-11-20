namespace AstroLearn
{
    partial class formObjetosAstronomicos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloObjetos = new System.Windows.Forms.Label();
            this.lblNombreObjeto = new System.Windows.Forms.Label();
            this.lblTipoObjeto = new System.Windows.Forms.Label();
            this.lblAtributo1 = new System.Windows.Forms.Label();
            this.lblAtributo2 = new System.Windows.Forms.Label();
            this.lblAtributo3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreObjeto = new System.Windows.Forms.TextBox();
            this.txtAtributo1 = new System.Windows.Forms.TextBox();
            this.txtAtributo2 = new System.Windows.Forms.TextBox();
            this.txtAtributo3 = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbTipoObjeto = new System.Windows.Forms.ComboBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminarObjeto = new System.Windows.Forms.Button();
            this.btnEditarObjeto = new System.Windows.Forms.Button();
            this.btnAgregarObjeto = new System.Windows.Forms.Button();
            this.dgvObjetos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(739, 487);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(178, 49);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTituloObjetos
            // 
            this.lblTituloObjetos.AutoSize = true;
            this.lblTituloObjetos.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloObjetos.Location = new System.Drawing.Point(296, 19);
            this.lblTituloObjetos.Name = "lblTituloObjetos";
            this.lblTituloObjetos.Size = new System.Drawing.Size(343, 27);
            this.lblTituloObjetos.TabIndex = 9;
            this.lblTituloObjetos.Text = "Gestión de datos astronómicos";
            // 
            // lblNombreObjeto
            // 
            this.lblNombreObjeto.AutoSize = true;
            this.lblNombreObjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombreObjeto.Location = new System.Drawing.Point(12, 89);
            this.lblNombreObjeto.Name = "lblNombreObjeto";
            this.lblNombreObjeto.Size = new System.Drawing.Size(94, 25);
            this.lblNombreObjeto.TabIndex = 10;
            this.lblNombreObjeto.Text = "Nombre:";
            // 
            // lblTipoObjeto
            // 
            this.lblTipoObjeto.AutoSize = true;
            this.lblTipoObjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoObjeto.Location = new System.Drawing.Point(12, 148);
            this.lblTipoObjeto.Name = "lblTipoObjeto";
            this.lblTipoObjeto.Size = new System.Drawing.Size(74, 25);
            this.lblTipoObjeto.TabIndex = 11;
            this.lblTipoObjeto.Text = "Tipo : ";
            // 
            // lblAtributo1
            // 
            this.lblAtributo1.AutoSize = true;
            this.lblAtributo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAtributo1.Location = new System.Drawing.Point(12, 206);
            this.lblAtributo1.Name = "lblAtributo1";
            this.lblAtributo1.Size = new System.Drawing.Size(118, 25);
            this.lblAtributo1.TabIndex = 12;
            this.lblAtributo1.Text = "Atributo 1: ";
            // 
            // lblAtributo2
            // 
            this.lblAtributo2.AutoSize = true;
            this.lblAtributo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAtributo2.Location = new System.Drawing.Point(12, 262);
            this.lblAtributo2.Name = "lblAtributo2";
            this.lblAtributo2.Size = new System.Drawing.Size(124, 25);
            this.lblAtributo2.TabIndex = 13;
            this.lblAtributo2.Text = "Atributo 2 : ";
            // 
            // lblAtributo3
            // 
            this.lblAtributo3.AutoSize = true;
            this.lblAtributo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAtributo3.Location = new System.Drawing.Point(12, 326);
            this.lblAtributo3.Name = "lblAtributo3";
            this.lblAtributo3.Size = new System.Drawing.Size(112, 25);
            this.lblAtributo3.TabIndex = 14;
            this.lblAtributo3.Text = "Atributo 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Descripción : ";
            // 
            // txtNombreObjeto
            // 
            this.txtNombreObjeto.Location = new System.Drawing.Point(112, 82);
            this.txtNombreObjeto.Multiline = true;
            this.txtNombreObjeto.Name = "txtNombreObjeto";
            this.txtNombreObjeto.Size = new System.Drawing.Size(303, 32);
            this.txtNombreObjeto.TabIndex = 16;
            // 
            // txtAtributo1
            // 
            this.txtAtributo1.Location = new System.Drawing.Point(127, 199);
            this.txtAtributo1.Multiline = true;
            this.txtAtributo1.Name = "txtAtributo1";
            this.txtAtributo1.Size = new System.Drawing.Size(288, 32);
            this.txtAtributo1.TabIndex = 17;
            // 
            // txtAtributo2
            // 
            this.txtAtributo2.Location = new System.Drawing.Point(127, 255);
            this.txtAtributo2.Multiline = true;
            this.txtAtributo2.Name = "txtAtributo2";
            this.txtAtributo2.Size = new System.Drawing.Size(288, 32);
            this.txtAtributo2.TabIndex = 18;
            this.txtAtributo2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAtributo3
            // 
            this.txtAtributo3.Location = new System.Drawing.Point(127, 319);
            this.txtAtributo3.Multiline = true;
            this.txtAtributo3.Name = "txtAtributo3";
            this.txtAtributo3.Size = new System.Drawing.Size(288, 32);
            this.txtAtributo3.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(149, 375);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(266, 106);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cmbTipoObjeto
            // 
            this.cmbTipoObjeto.FormattingEnabled = true;
            this.cmbTipoObjeto.Items.AddRange(new object[] {
            "Planeta",
            "Constelación",
            "Cuerpo celeste"});
            this.cmbTipoObjeto.Location = new System.Drawing.Point(118, 141);
            this.cmbTipoObjeto.Name = "cmbTipoObjeto";
            this.cmbTipoObjeto.Size = new System.Drawing.Size(296, 24);
            this.cmbTipoObjeto.TabIndex = 21;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(564, 487);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(178, 49);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnEliminarObjeto
            // 
            this.btnEliminarObjeto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminarObjeto.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarObjeto.Location = new System.Drawing.Point(380, 487);
            this.btnEliminarObjeto.Name = "btnEliminarObjeto";
            this.btnEliminarObjeto.Size = new System.Drawing.Size(178, 49);
            this.btnEliminarObjeto.TabIndex = 23;
            this.btnEliminarObjeto.Text = "Eliminar";
            this.btnEliminarObjeto.UseVisualStyleBackColor = false;
            this.btnEliminarObjeto.Click += new System.EventHandler(this.btnEliminarObjeto_Click);
            // 
            // btnEditarObjeto
            // 
            this.btnEditarObjeto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditarObjeto.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarObjeto.Location = new System.Drawing.Point(196, 487);
            this.btnEditarObjeto.Name = "btnEditarObjeto";
            this.btnEditarObjeto.Size = new System.Drawing.Size(178, 49);
            this.btnEditarObjeto.TabIndex = 24;
            this.btnEditarObjeto.Text = "Editar";
            this.btnEditarObjeto.UseVisualStyleBackColor = false;
            this.btnEditarObjeto.Click += new System.EventHandler(this.btnEditarObjeto_Click);
            // 
            // btnAgregarObjeto
            // 
            this.btnAgregarObjeto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarObjeto.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarObjeto.Location = new System.Drawing.Point(12, 487);
            this.btnAgregarObjeto.Name = "btnAgregarObjeto";
            this.btnAgregarObjeto.Size = new System.Drawing.Size(178, 49);
            this.btnAgregarObjeto.TabIndex = 25;
            this.btnAgregarObjeto.Text = "Agregar";
            this.btnAgregarObjeto.UseVisualStyleBackColor = false;
            this.btnAgregarObjeto.Click += new System.EventHandler(this.btnAgregarObjeto_Click);
            // 
            // dgvObjetos
            // 
            this.dgvObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetos.Location = new System.Drawing.Point(520, 82);
            this.dgvObjetos.Name = "dgvObjetos";
            this.dgvObjetos.RowHeadersWidth = 51;
            this.dgvObjetos.RowTemplate.Height = 24;
            this.dgvObjetos.Size = new System.Drawing.Size(379, 385);
            this.dgvObjetos.TabIndex = 26;
            this.dgvObjetos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjetos_CellClick);
            // 
            // formObjetosAstronomicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(932, 554);
            this.Controls.Add(this.dgvObjetos);
            this.Controls.Add(this.btnAgregarObjeto);
            this.Controls.Add(this.btnEditarObjeto);
            this.Controls.Add(this.btnEliminarObjeto);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.cmbTipoObjeto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAtributo3);
            this.Controls.Add(this.txtAtributo2);
            this.Controls.Add(this.txtAtributo1);
            this.Controls.Add(this.txtNombreObjeto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAtributo3);
            this.Controls.Add(this.lblAtributo2);
            this.Controls.Add(this.lblAtributo1);
            this.Controls.Add(this.lblTipoObjeto);
            this.Controls.Add(this.lblNombreObjeto);
            this.Controls.Add(this.lblTituloObjetos);
            this.Controls.Add(this.btnVolver);
            this.Name = "formObjetosAstronomicos";
            this.Text = "formObjetosAstronomicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTituloObjetos;
        private System.Windows.Forms.Label lblNombreObjeto;
        private System.Windows.Forms.Label lblTipoObjeto;
        private System.Windows.Forms.Label lblAtributo1;
        private System.Windows.Forms.Label lblAtributo2;
        private System.Windows.Forms.Label lblAtributo3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreObjeto;
        private System.Windows.Forms.TextBox txtAtributo1;
        private System.Windows.Forms.TextBox txtAtributo2;
        private System.Windows.Forms.TextBox txtAtributo3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbTipoObjeto;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnEliminarObjeto;
        private System.Windows.Forms.Button btnEditarObjeto;
        private System.Windows.Forms.Button btnAgregarObjeto;
        private System.Windows.Forms.DataGridView dgvObjetos;
    }
}