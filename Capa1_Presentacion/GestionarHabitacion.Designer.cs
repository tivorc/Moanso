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
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtpiso = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtPreciohora = new System.Windows.Forms.TextBox();
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.btnModificarHabitacion = new System.Windows.Forms.Button();
            this.btnEliminarHabitacion = new System.Windows.Forms.Button();
            this.btnGuardarHabitacion = new System.Windows.Forms.Button();
            this.btnCancelarHabitacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblpiso = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldescipcion = new System.Windows.Forms.Label();
            this.lblpreciohora = new System.Windows.Forms.Label();
            this.lblpreciodia = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescipcion = new System.Windows.Forms.TextBox();
            this.txtpreciodia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(814, 29);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(47, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Numero:";
            this.lblnumero.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(960, 22);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(121, 20);
            this.txtnumero.TabIndex = 6;
            // 
            // txtpiso
            // 
            this.txtpiso.Location = new System.Drawing.Point(960, 68);
            this.txtpiso.Name = "txtpiso";
            this.txtpiso.Size = new System.Drawing.Size(121, 20);
            this.txtpiso.TabIndex = 7;
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(960, 114);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(121, 20);
            this.txtestado.TabIndex = 8;
            // 
            // txtPreciohora
            // 
            this.txtPreciohora.Location = new System.Drawing.Point(960, 247);
            this.txtPreciohora.Name = "txtPreciohora";
            this.txtPreciohora.Size = new System.Drawing.Size(121, 20);
            this.txtPreciohora.TabIndex = 9;
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(163, 369);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHabitacion.TabIndex = 13;
            this.btnAgregarHabitacion.Text = "Agregar";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = true;
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
            this.btnGuardarHabitacion.Location = new System.Drawing.Point(817, 369);
            this.btnGuardarHabitacion.Name = "btnGuardarHabitacion";
            this.btnGuardarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarHabitacion.TabIndex = 16;
            this.btnGuardarHabitacion.Text = "Guardar";
            this.btnGuardarHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnCancelarHabitacion
            // 
            this.btnCancelarHabitacion.Location = new System.Drawing.Point(972, 369);
            this.btnCancelarHabitacion.Name = "btnCancelarHabitacion";
            this.btnCancelarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarHabitacion.TabIndex = 17;
            this.btnCancelarHabitacion.Text = "Cancelar";
            this.btnCancelarHabitacion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Piso,
            this.Estado,
            this.Nombre,
            this.Descripcion,
            this.PrecioHora,
            this.PrecioDia});
            this.dataGridView1.Location = new System.Drawing.Point(1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 294);
            this.dataGridView1.TabIndex = 18;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Piso
            // 
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descipcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // PrecioHora
            // 
            this.PrecioHora.HeaderText = "PrecioHora";
            this.PrecioHora.Name = "PrecioHora";
            // 
            // PrecioDia
            // 
            this.PrecioDia.HeaderText = "PrecioDia";
            this.PrecioDia.Name = "PrecioDia";
            // 
            // lblpiso
            // 
            this.lblpiso.AutoSize = true;
            this.lblpiso.Location = new System.Drawing.Point(814, 75);
            this.lblpiso.Name = "lblpiso";
            this.lblpiso.Size = new System.Drawing.Size(30, 13);
            this.lblpiso.TabIndex = 19;
            this.lblpiso.Text = "Piso:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(814, 121);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 20;
            this.lblestado.Text = "Estado:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(814, 163);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 21;
            this.lblnombre.Text = "Nombre:";
            // 
            // lbldescipcion
            // 
            this.lbldescipcion.AutoSize = true;
            this.lbldescipcion.Location = new System.Drawing.Point(814, 202);
            this.lbldescipcion.Name = "lbldescipcion";
            this.lbldescipcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescipcion.TabIndex = 22;
            this.lbldescipcion.Text = "Descripcion";
            // 
            // lblpreciohora
            // 
            this.lblpreciohora.AutoSize = true;
            this.lblpreciohora.Location = new System.Drawing.Point(814, 245);
            this.lblpreciohora.Name = "lblpreciohora";
            this.lblpreciohora.Size = new System.Drawing.Size(66, 13);
            this.lblpreciohora.TabIndex = 23;
            this.lblpreciohora.Text = "Precio Hora:";
            // 
            // lblpreciodia
            // 
            this.lblpreciodia.AutoSize = true;
            this.lblpreciodia.Location = new System.Drawing.Point(814, 284);
            this.lblpreciodia.Name = "lblpreciodia";
            this.lblpreciodia.Size = new System.Drawing.Size(59, 13);
            this.lblpreciodia.TabIndex = 24;
            this.lblpreciodia.Text = "Precio Dia:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(960, 163);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 25;
            // 
            // txtdescipcion
            // 
            this.txtdescipcion.Location = new System.Drawing.Point(960, 202);
            this.txtdescipcion.Name = "txtdescipcion";
            this.txtdescipcion.Size = new System.Drawing.Size(121, 20);
            this.txtdescipcion.TabIndex = 26;
            // 
            // txtpreciodia
            // 
            this.txtpreciodia.Location = new System.Drawing.Point(960, 284);
            this.txtpreciodia.Name = "txtpreciodia";
            this.txtpreciodia.Size = new System.Drawing.Size(121, 20);
            this.txtpreciodia.TabIndex = 27;
            // 
            // GestionarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 475);
            this.Controls.Add(this.txtpreciodia);
            this.Controls.Add(this.txtdescipcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblpreciodia);
            this.Controls.Add(this.lblpreciohora);
            this.Controls.Add(this.lbldescipcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblpiso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelarHabitacion);
            this.Controls.Add(this.btnGuardarHabitacion);
            this.Controls.Add(this.btnEliminarHabitacion);
            this.Controls.Add(this.btnModificarHabitacion);
            this.Controls.Add(this.btnAgregarHabitacion);
            this.Controls.Add(this.txtPreciohora);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtpiso);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumero);
            this.Name = "GestionarHabitacion";
            this.Text = "GestionarHabitacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtpiso;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtPreciohora;
        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.Button btnModificarHabitacion;
        private System.Windows.Forms.Button btnEliminarHabitacion;
        private System.Windows.Forms.Button btnGuardarHabitacion;
        private System.Windows.Forms.Button btnCancelarHabitacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDia;
        private System.Windows.Forms.Label lblpiso;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescipcion;
        private System.Windows.Forms.Label lblpreciohora;
        private System.Windows.Forms.Label lblpreciodia;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescipcion;
        private System.Windows.Forms.TextBox txtpreciodia;
    }
}