namespace Capa1_Presentacion
{
    partial class GestionarPago
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
            this.ID_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.RbBoleta = new System.Windows.Forms.RadioButton();
            this.RbFactura = new System.Windows.Forms.RadioButton();
            this.btnGenerarComprobante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Reserva,
            this.Fecha_Inicio,
            this.Fecha_Fin,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_Reserva
            // 
            this.ID_Reserva.HeaderText = "ID_Reserva";
            this.ID_Reserva.Name = "ID_Reserva";
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.HeaderText = "Fecha_Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.HeaderText = "Fecha_Fin";
            this.Fecha_Fin.Name = "Fecha_Fin";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(207, 246);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(512, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Dni Cliente:";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(579, 26);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDniCliente.TabIndex = 4;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(702, 22);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarCliente.TabIndex = 5;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // RbBoleta
            // 
            this.RbBoleta.AutoSize = true;
            this.RbBoleta.Location = new System.Drawing.Point(579, 104);
            this.RbBoleta.Name = "RbBoleta";
            this.RbBoleta.Size = new System.Drawing.Size(55, 17);
            this.RbBoleta.TabIndex = 6;
            this.RbBoleta.TabStop = true;
            this.RbBoleta.Text = "Boleta";
            this.RbBoleta.UseVisualStyleBackColor = true;
            // 
            // RbFactura
            // 
            this.RbFactura.AutoSize = true;
            this.RbFactura.Location = new System.Drawing.Point(687, 104);
            this.RbFactura.Name = "RbFactura";
            this.RbFactura.Size = new System.Drawing.Size(61, 17);
            this.RbFactura.TabIndex = 7;
            this.RbFactura.TabStop = true;
            this.RbFactura.Text = "Factura";
            this.RbFactura.UseVisualStyleBackColor = true;
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.Location = new System.Drawing.Point(603, 183);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(128, 23);
            this.btnGenerarComprobante.TabIndex = 8;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            this.btnGenerarComprobante.UseVisualStyleBackColor = true;
            // 
            // GestionarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 314);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.RbFactura);
            this.Controls.Add(this.RbBoleta);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionarPago";
            this.Text = "GestionarPago";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.RadioButton RbBoleta;
        private System.Windows.Forms.RadioButton RbFactura;
        private System.Windows.Forms.Button btnGenerarComprobante;
    }
}