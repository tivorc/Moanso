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
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Empleado,
            this.Numero_Documento,
            this.Nombre,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.Tipo_Empleado});
            this.dataGridView1.Location = new System.Drawing.Point(47, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.HeaderText = "ID_Empleado";
            this.ID_Empleado.Name = "ID_Empleado";
            // 
            // Numero_Documento
            // 
            this.Numero_Documento.HeaderText = "Numero_Documento";
            this.Numero_Documento.Name = "Numero_Documento";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.HeaderText = "Apellido_Paterno";
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.HeaderText = "Apellido_Materno";
            this.Apellido_Materno.Name = "Apellido_Materno";
            // 
            // Tipo_Empleado
            // 
            this.Tipo_Empleado.HeaderText = "Tipo_Empleado";
            this.Tipo_Empleado.Name = "Tipo_Empleado";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(181, 251);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
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
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(766, 158);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPaterno.TabIndex = 7;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(766, 189);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMaterno.TabIndex = 8;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(1054, 52);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(1054, 85);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(1054, 122);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(81, 13);
            this.lblTipoEmpleado.TabIndex = 11;
            this.lblTipoEmpleado.Text = "Tipo Empleado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(1054, 158);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(1054, 189);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(898, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 14;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(898, 85);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumento.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(898, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(898, 158);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoPaterno.TabIndex = 17;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(898, 189);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoMaterno.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(1149, 49);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(1149, 78);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(1149, 155);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(1149, 186);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 22;
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista"});
            this.cbTipoEmpleado.Location = new System.Drawing.Point(1149, 119);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEmpleado.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(879, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1057, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // GestionarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 312);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbTipoEmpleado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.lblApellidoPaterno);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Empleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}