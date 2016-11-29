namespace Capa1_Presentacion
{
    partial class GestionarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarReserva));
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.txtdnicliente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tblreserva = new System.Windows.Forms.DataGridView();
            this.lblidreserva = new System.Windows.Forms.Label();
            this.lblfechainicio = new System.Windows.Forms.Label();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lbltiporeserva = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtidreserva = new System.Windows.Forms.TextBox();
            this.txtfechainicio = new System.Windows.Forms.TextBox();
            this.txtfechafin = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblhabitacion = new System.Windows.Forms.Label();
            this.txthabitacion = new System.Windows.Forms.TextBox();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblreserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(142, 283);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(64, 13);
            this.lblDniCliente.TabIndex = 0;
            this.lblDniCliente.Text = "Dni Cliente: ";
            // 
            // txtdnicliente
            // 
            this.txtdnicliente.Location = new System.Drawing.Point(226, 276);
            this.txtdnicliente.Name = "txtdnicliente";
            this.txtdnicliente.Size = new System.Drawing.Size(100, 20);
            this.txtdnicliente.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(427, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnBuscarAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(351, 273);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tblreserva
            // 
            this.tblreserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblreserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCliente,
            this.numeroDocumento,
            this.Nombre,
            this.Apellidos,
            this.TipoDocumento});
            this.tblreserva.Location = new System.Drawing.Point(72, 317);
            this.tblreserva.Name = "tblreserva";
            this.tblreserva.Size = new System.Drawing.Size(537, 150);
            this.tblreserva.TabIndex = 4;
            // 
            // lblidreserva
            // 
            this.lblidreserva.AutoSize = true;
            this.lblidreserva.Location = new System.Drawing.Point(142, 46);
            this.lblidreserva.Name = "lblidreserva";
            this.lblidreserva.Size = new System.Drawing.Size(64, 13);
            this.lblidreserva.TabIndex = 5;
            this.lblidreserva.Text = "ID Reserva:";
            // 
            // lblfechainicio
            // 
            this.lblfechainicio.AutoSize = true;
            this.lblfechainicio.Location = new System.Drawing.Point(139, 101);
            this.lblfechainicio.Name = "lblfechainicio";
            this.lblfechainicio.Size = new System.Drawing.Size(68, 13);
            this.lblfechainicio.TabIndex = 6;
            this.lblfechainicio.Text = "Fecha Inicio:";
            this.lblfechainicio.Click += new System.EventHandler(this.lblfechainicio_Click);
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.Location = new System.Drawing.Point(142, 163);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(57, 13);
            this.lblfechafin.TabIndex = 7;
            this.lblfechafin.Text = "Fecha Fin:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(350, 46);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 8;
            this.lblestado.Text = "Estado:";
            // 
            // lbltiporeserva
            // 
            this.lbltiporeserva.AutoSize = true;
            this.lbltiporeserva.Location = new System.Drawing.Point(348, 101);
            this.lbltiporeserva.Name = "lbltiporeserva";
            this.lbltiporeserva.Size = new System.Drawing.Size(74, 13);
            this.lbltiporeserva.TabIndex = 9;
            this.lbltiporeserva.Text = "Tipo Reserva:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(348, 167);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Precio";
            // 
            // txtidreserva
            // 
            this.txtidreserva.Location = new System.Drawing.Point(226, 46);
            this.txtidreserva.Name = "txtidreserva";
            this.txtidreserva.Size = new System.Drawing.Size(100, 20);
            this.txtidreserva.TabIndex = 11;
            this.txtidreserva.TextChanged += new System.EventHandler(this.txtidreserva_TextChanged);
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.Location = new System.Drawing.Point(226, 101);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(100, 20);
            this.txtfechainicio.TabIndex = 12;
            // 
            // txtfechafin
            // 
            this.txtfechafin.Location = new System.Drawing.Point(226, 160);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(100, 20);
            this.txtfechafin.TabIndex = 13;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(427, 160);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(121, 20);
            this.txtprecio.TabIndex = 16;
            // 
            // lblhabitacion
            // 
            this.lblhabitacion.AutoSize = true;
            this.lblhabitacion.Location = new System.Drawing.Point(139, 225);
            this.lblhabitacion.Name = "lblhabitacion";
            this.lblhabitacion.Size = new System.Drawing.Size(61, 13);
            this.lblhabitacion.TabIndex = 17;
            this.lblhabitacion.Text = "Habitación:";
            // 
            // txthabitacion
            // 
            this.txthabitacion.Location = new System.Drawing.Point(226, 225);
            this.txthabitacion.Name = "txthabitacion";
            this.txthabitacion.Size = new System.Drawing.Size(100, 20);
            this.txthabitacion.TabIndex = 18;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(351, 223);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnseleccionar.TabIndex = 19;
            this.btnseleccionar.Text = "seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(427, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(427, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(69, 496);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(45, 23);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "ID Cliente";
            this.IDCliente.Name = "IDCliente";
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.HeaderText = "Numero Documento";
            this.numeroDocumento.Name = "numeroDocumento";
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
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            // 
            // GestionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 531);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txthabitacion);
            this.Controls.Add(this.lblhabitacion);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.txtidreserva);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbltiporeserva);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblfechafin);
            this.Controls.Add(this.lblfechainicio);
            this.Controls.Add(this.lblidreserva);
            this.Controls.Add(this.tblreserva);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtdnicliente);
            this.Controls.Add(this.lblDniCliente);
            this.Name = "GestionarReserva";
            this.Text = "GestionarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.tblreserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txtdnicliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tblreserva;
        private System.Windows.Forms.Label lblidreserva;
        private System.Windows.Forms.Label lblfechainicio;
        private System.Windows.Forms.Label lblfechafin;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lbltiporeserva;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtidreserva;
        private System.Windows.Forms.TextBox txtfechainicio;
        private System.Windows.Forms.TextBox txtfechafin;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblhabitacion;
        private System.Windows.Forms.TextBox txthabitacion;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
    }
}