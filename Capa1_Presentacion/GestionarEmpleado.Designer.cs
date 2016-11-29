namespace Capa1_Presentacion
{
    partial class GestionarEmpleado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.IDEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmpleado,
            this.NumeroDocumento,
            this.Nombre,
            this.Apellidos,
            this.TipoEmpleado,
            this.TipoDocumento});
            this.dataGridView1.Location = new System.Drawing.Point(47, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(181, 251);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(364, 251);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEmpleado.TabIndex = 2;
            this.btnModificarEmpleado.Text = "Modificar";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(549, 251);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEmpleado.TabIndex = 3;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(766, 52);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(21, 13);
            this.lblIdEmpleado.TabIndex = 4;
            this.lblIdEmpleado.Text = "ID:";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(766, 85);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(120, 13);
            this.lblNumeroDocumento.TabIndex = 5;
            this.lblNumeroDocumento.Text = "Número de Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(766, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(766, 158);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 7;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(769, 193);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(1051, 52);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(81, 13);
            this.lblTipoEmpleado.TabIndex = 11;
            this.lblTipoEmpleado.Text = "Tipo Empleado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(1051, 85);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(1054, 122);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(898, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 14;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(898, 85);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroDocumento.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(898, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(898, 158);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(121, 20);
            this.txtApellidos.TabIndex = 17;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(898, 190);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(1149, 82);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(1149, 119);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 22;
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "RECEPCIONISTA"});
            this.cbTipoEmpleado.Location = new System.Drawing.Point(1149, 49);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEmpleado.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(923, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1057, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // IDEmpleado
            // 
            this.IDEmpleado.HeaderText = "ID Empleado";
            this.IDEmpleado.Name = "IDEmpleado";
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // TipoEmpleado
            // 
            this.TipoEmpleado.HeaderText = "Tipo Empleado";
            this.TipoEmpleado.Name = "TipoEmpleado";
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(1054, 158);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 26;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "CARNET DE EXTRANGERIA",
            "PASAPORTE"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(1149, 155);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDocumento.TabIndex = 27;
            // 
            // GestionarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 312);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbTipoEmpleado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionarEmpleado";
            this.Text = "GestionarEmpleado";
            this.Load += new System.EventHandler(this.GestionarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
    }
}