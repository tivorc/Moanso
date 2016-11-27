namespace Capa1_Presentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(284, 198);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(81, 75);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.Image = ((System.Drawing.Image)(resources.GetObject("btnHabitacion.Image")));
            this.btnHabitacion.Location = new System.Drawing.Point(31, 51);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(85, 86);
            this.btnHabitacion.TabIndex = 1;
            this.btnHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.Location = new System.Drawing.Point(169, 117);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(85, 86);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.Location = new System.Drawing.Point(311, 51);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(78, 86);
            this.btnCalendario.TabIndex = 3;
            this.btnCalendario.UseVisualStyleBackColor = true;
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPago.Image = ((System.Drawing.Image)(resources.GetObject("btnPago.Image")));
            this.btnPago.Location = new System.Drawing.Point(36, 197);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(81, 76);
            this.btnPago.TabIndex = 4;
            this.btnPago.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 311);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnHabitacion);
            this.Controls.Add(this.btnReporte);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnHabitacion;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnPago;
    }
}