namespace Capa1_Presentacion
{
    partial class GestionarHabitacion
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
            this.lblIDHabitacion = new System.Windows.Forms.Label();
            this.txtIDHabitacion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.btnModificarHabitacion = new System.Windows.Forms.Button();
            this.btnEliminarHabitacion = new System.Windows.Forms.Button();
            this.btnGuardarHabitacion = new System.Windows.Forms.Button();
            this.btnCancelarHabitacion = new System.Windows.Forms.Button();
            this.tablaHabitacion = new System.Windows.Forms.DataGridView();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDHabitacion
            // 
            this.lblIDHabitacion.AutoSize = true;
            this.lblIDHabitacion.Location = new System.Drawing.Point(649, 56);
            this.lblIDHabitacion.Name = "lblIDHabitacion";
            this.lblIDHabitacion.Size = new System.Drawing.Size(21, 13);
            this.lblIDHabitacion.TabIndex = 0;
            this.lblIDHabitacion.Text = "ID:";
            this.lblIDHabitacion.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtIDHabitacion
            // 
            this.txtIDHabitacion.Location = new System.Drawing.Point(727, 53);
            this.txtIDHabitacion.Name = "txtIDHabitacion";
            this.txtIDHabitacion.Size = new System.Drawing.Size(121, 20);
            this.txtIDHabitacion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(727, 198);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(163, 369);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHabitacion.TabIndex = 13;
            this.btnAgregarHabitacion.Text = "Agregar";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = true;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // btnModificarHabitacion
            // 
            this.btnModificarHabitacion.Location = new System.Drawing.Point(321, 369);
            this.btnModificarHabitacion.Name = "btnModificarHabitacion";
            this.btnModificarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnModificarHabitacion.TabIndex = 14;
            this.btnModificarHabitacion.Text = "Modificar";
            this.btnModificarHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarHabitacion
            // 
            this.btnEliminarHabitacion.Location = new System.Drawing.Point(463, 369);
            this.btnEliminarHabitacion.Name = "btnEliminarHabitacion";
            this.btnEliminarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarHabitacion.TabIndex = 15;
            this.btnEliminarHabitacion.Text = "Eliminar";
            this.btnEliminarHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnGuardarHabitacion
            // 
            this.btnGuardarHabitacion.Location = new System.Drawing.Point(668, 369);
            this.btnGuardarHabitacion.Name = "btnGuardarHabitacion";
            this.btnGuardarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarHabitacion.TabIndex = 16;
            this.btnGuardarHabitacion.Text = "Guardar";
            this.btnGuardarHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnCancelarHabitacion
            // 
            this.btnCancelarHabitacion.Location = new System.Drawing.Point(792, 369);
            this.btnCancelarHabitacion.Name = "btnCancelarHabitacion";
            this.btnCancelarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarHabitacion.TabIndex = 17;
            this.btnCancelarHabitacion.Text = "Cancelar";
            this.btnCancelarHabitacion.UseVisualStyleBackColor = true;
            // 
            // tablaHabitacion
            // 
            this.tablaHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Numero,
            this.TipoHabitacion,
            this.Precio,
            this.Estado});
            this.tablaHabitacion.Location = new System.Drawing.Point(1, 12);
            this.tablaHabitacion.Name = "tablaHabitacion";
            this.tablaHabitacion.Size = new System.Drawing.Size(537, 294);
            this.tablaHabitacion.TabIndex = 18;
            this.tablaHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHabitacion_CellContentClick);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(649, 244);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 20;
            this.lblestado.Text = "Estado:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(649, 153);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(649, 103);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 22;
            this.lblNumero.Text = "Número:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(649, 201);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 23;
            this.lblprecio.Text = "Precio:";
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(727, 100);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroHabitacion.TabIndex = 26;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "DISPONIBLE",
            "OCUPADO"});
            this.cbEstado.Location = new System.Drawing.Point(727, 241);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 29;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // TipoHabitacion
            // 
            this.TipoHabitacion.HeaderText = "Tipo Habitacion";
            this.TipoHabitacion.Name = "TipoHabitacion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "INDIVIDUAL",
            "DOBLE",
            "MATRIMONIAL"});
            this.cbTipo.Location = new System.Drawing.Point(727, 150);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 30;
            // 
            // GestionarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 475);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtNumeroHabitacion);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.tablaHabitacion);
            this.Controls.Add(this.btnCancelarHabitacion);
            this.Controls.Add(this.btnGuardarHabitacion);
            this.Controls.Add(this.btnEliminarHabitacion);
            this.Controls.Add(this.btnModificarHabitacion);
            this.Controls.Add(this.btnAgregarHabitacion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIDHabitacion);
            this.Controls.Add(this.lblIDHabitacion);
            this.Name = "GestionarHabitacion";
            this.Text = "GestionarHabitacion";
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDHabitacion;
        private System.Windows.Forms.TextBox txtIDHabitacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.Button btnModificarHabitacion;
        private System.Windows.Forms.Button btnEliminarHabitacion;
        private System.Windows.Forms.Button btnGuardarHabitacion;
        private System.Windows.Forms.Button btnCancelarHabitacion;
        private System.Windows.Forms.DataGridView tablaHabitacion;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}