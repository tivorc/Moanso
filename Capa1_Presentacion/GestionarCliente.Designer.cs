namespace Capa1_Presentacion
{
    partial class GestionarCliente
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
            this.tablaclientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnumerodocumento = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellidopaterno = new System.Windows.Forms.Label();
            this.lblapellidomaterno = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.lblrazonsocial = new System.Windows.Forms.Label();
            this.lbltipocliente = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidopaterno = new System.Windows.Forms.TextBox();
            this.txtapellidomaterno = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.rdbclientenatural = new System.Windows.Forms.RadioButton();
            this.rbdclientejuridico = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaclientes
            // 
            this.tablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.numero_documento,
            this.nombre,
            this.apellido_paterno,
            this.apellido_materno,
            this.direccion,
            this.telefono});
            this.tablaclientes.Location = new System.Drawing.Point(0, 1);
            this.tablaclientes.Name = "tablaclientes";
            this.tablaclientes.Size = new System.Drawing.Size(745, 279);
            this.tablaclientes.TabIndex = 0;
            this.tablaclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // numero_documento
            // 
            this.numero_documento.HeaderText = "numero_documento";
            this.numero_documento.Name = "numero_documento";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.HeaderText = "apellido_paterno";
            this.apellido_paterno.Name = "apellido_paterno";
            // 
            // apellido_materno
            // 
            this.apellido_materno.HeaderText = "apellid_materno";
            this.apellido_materno.Name = "apellido_materno";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // lblnumerodocumento
            // 
            this.lblnumerodocumento.AutoSize = true;
            this.lblnumerodocumento.Location = new System.Drawing.Point(779, 28);
            this.lblnumerodocumento.Name = "lblnumerodocumento";
            this.lblnumerodocumento.Size = new System.Drawing.Size(103, 13);
            this.lblnumerodocumento.TabIndex = 1;
            this.lblnumerodocumento.Text = "Número documento:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(779, 73);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblapellidopaterno
            // 
            this.lblapellidopaterno.AutoSize = true;
            this.lblapellidopaterno.Location = new System.Drawing.Point(779, 124);
            this.lblapellidopaterno.Name = "lblapellidopaterno";
            this.lblapellidopaterno.Size = new System.Drawing.Size(87, 13);
            this.lblapellidopaterno.TabIndex = 3;
            this.lblapellidopaterno.Text = "Apellido Paterno:";
            // 
            // lblapellidomaterno
            // 
            this.lblapellidomaterno.AutoSize = true;
            this.lblapellidomaterno.Location = new System.Drawing.Point(777, 175);
            this.lblapellidomaterno.Name = "lblapellidomaterno";
            this.lblapellidomaterno.Size = new System.Drawing.Size(89, 13);
            this.lblapellidomaterno.TabIndex = 4;
            this.lblapellidomaterno.Text = "Apellido Materno:";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(779, 217);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(55, 13);
            this.lbldireccion.TabIndex = 5;
            this.lbldireccion.Text = "Dirección:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(779, 263);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(52, 13);
            this.lbltelefono.TabIndex = 6;
            this.lbltelefono.Text = "Teléfono:";
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Location = new System.Drawing.Point(1065, 80);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(30, 13);
            this.lblruc.TabIndex = 7;
            this.lblruc.Text = "Ruc:";
            // 
            // lblrazonsocial
            // 
            this.lblrazonsocial.AutoSize = true;
            this.lblrazonsocial.Location = new System.Drawing.Point(1055, 131);
            this.lblrazonsocial.Name = "lblrazonsocial";
            this.lblrazonsocial.Size = new System.Drawing.Size(73, 13);
            this.lblrazonsocial.TabIndex = 8;
            this.lblrazonsocial.Text = "Razon Social:";
            // 
            // lbltipocliente
            // 
            this.lbltipocliente.AutoSize = true;
            this.lbltipocliente.Location = new System.Drawing.Point(1055, 28);
            this.lbltipocliente.Name = "lbltipocliente";
            this.lbltipocliente.Size = new System.Drawing.Size(66, 13);
            this.lbltipocliente.TabIndex = 9;
            this.lbltipocliente.Text = "Tipo Cliente:";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(886, 25);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(100, 20);
            this.txtnumerodocumento.TabIndex = 10;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(886, 73);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 11;
            // 
            // txtapellidopaterno
            // 
            this.txtapellidopaterno.Location = new System.Drawing.Point(886, 124);
            this.txtapellidopaterno.Name = "txtapellidopaterno";
            this.txtapellidopaterno.Size = new System.Drawing.Size(100, 20);
            this.txtapellidopaterno.TabIndex = 12;
            // 
            // txtapellidomaterno
            // 
            this.txtapellidomaterno.Location = new System.Drawing.Point(886, 172);
            this.txtapellidomaterno.Name = "txtapellidomaterno";
            this.txtapellidomaterno.Size = new System.Drawing.Size(100, 20);
            this.txtapellidomaterno.TabIndex = 13;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(886, 217);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 14;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(886, 260);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 15;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(1154, 70);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(100, 20);
            this.txtruc.TabIndex = 16;
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(1154, 131);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(100, 20);
            this.txtrazonsocial.TabIndex = 17;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(188, 326);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 19;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(1068, 353);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(350, 326);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 21;
            this.btnmodificar.Text = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(500, 326);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 22;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // rdbclientenatural
            // 
            this.rdbclientenatural.AutoSize = true;
            this.rdbclientenatural.Location = new System.Drawing.Point(1138, 26);
            this.rdbclientenatural.Name = "rdbclientenatural";
            this.rdbclientenatural.Size = new System.Drawing.Size(91, 17);
            this.rdbclientenatural.TabIndex = 23;
            this.rdbclientenatural.TabStop = true;
            this.rdbclientenatural.Text = "cliente natural";
            this.rdbclientenatural.UseVisualStyleBackColor = true;
            // 
            // rbdclientejuridico
            // 
            this.rbdclientejuridico.AutoSize = true;
            this.rbdclientejuridico.Location = new System.Drawing.Point(1250, 24);
            this.rbdclientejuridico.Name = "rbdclientejuridico";
            this.rbdclientejuridico.Size = new System.Drawing.Size(92, 17);
            this.rbdclientejuridico.TabIndex = 24;
            this.rbdclientejuridico.TabStop = true;
            this.rbdclientejuridico.Text = "cliente juridico";
            this.rbdclientejuridico.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(900, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // GestionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 404);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rbdclientejuridico);
            this.Controls.Add(this.rdbclientenatural);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtrazonsocial);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellidomaterno);
            this.Controls.Add(this.txtapellidopaterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtnumerodocumento);
            this.Controls.Add(this.lbltipocliente);
            this.Controls.Add(this.lblrazonsocial);
            this.Controls.Add(this.lblruc);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblapellidomaterno);
            this.Controls.Add(this.lblapellidopaterno);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblnumerodocumento);
            this.Controls.Add(this.tablaclientes);
            this.Name = "GestionarCliente";
            this.Text = "GestionarCliente";
            this.Load += new System.EventHandler(this.GestionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.Label lblnumerodocumento;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellidopaterno;
        private System.Windows.Forms.Label lblapellidomaterno;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.Label lblrazonsocial;
        private System.Windows.Forms.Label lbltipocliente;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidopaterno;
        private System.Windows.Forms.TextBox txtapellidomaterno;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.RadioButton rdbclientenatural;
        private System.Windows.Forms.RadioButton rbdclientejuridico;
        private System.Windows.Forms.Button btnGuardar;
    }
}