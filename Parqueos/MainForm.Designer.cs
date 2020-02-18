namespace Parqueos
{
    partial class MainForm
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
            this.CantidadCasosTextBox = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpezarSimulacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EstadotextBox = new System.Windows.Forms.TextBox();
            this.Reiniciarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CantidadCasosTextBox
            // 
            this.CantidadCasosTextBox.Location = new System.Drawing.Point(9, 35);
            this.CantidadCasosTextBox.Name = "CantidadCasosTextBox";
            this.CantidadCasosTextBox.Size = new System.Drawing.Size(100, 22);
            this.CantidadCasosTextBox.TabIndex = 0;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Probabilidad,
            this.EstadoActual,
            this.Vehiculo});
            this.DGV.Location = new System.Drawing.Point(9, 62);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(684, 376);
            this.DGV.TabIndex = 1;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero del parqueo";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 125;
            // 
            // Probabilidad
            // 
            this.Probabilidad.HeaderText = "Probabilidad";
            this.Probabilidad.MinimumWidth = 6;
            this.Probabilidad.Name = "Probabilidad";
            this.Probabilidad.ReadOnly = true;
            this.Probabilidad.Visible = false;
            this.Probabilidad.Width = 125;
            // 
            // EstadoActual
            // 
            this.EstadoActual.HeaderText = "Estado Actual";
            this.EstadoActual.MinimumWidth = 6;
            this.EstadoActual.Name = "EstadoActual";
            this.EstadoActual.ReadOnly = true;
            this.EstadoActual.Width = 125;
            // 
            // Vehiculo
            // 
            this.Vehiculo.HeaderText = "Vehiculo";
            this.Vehiculo.MinimumWidth = 6;
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.ReadOnly = true;
            this.Vehiculo.Visible = false;
            this.Vehiculo.Width = 125;
            // 
            // EmpezarSimulacion
            // 
            this.EmpezarSimulacion.BackColor = System.Drawing.Color.Lime;
            this.EmpezarSimulacion.ForeColor = System.Drawing.Color.Black;
            this.EmpezarSimulacion.Location = new System.Drawing.Point(127, 33);
            this.EmpezarSimulacion.Name = "EmpezarSimulacion";
            this.EmpezarSimulacion.Size = new System.Drawing.Size(195, 26);
            this.EmpezarSimulacion.TabIndex = 2;
            this.EmpezarSimulacion.Text = "Empezar Simulación";
            this.EmpezarSimulacion.UseVisualStyleBackColor = false;
            this.EmpezarSimulacion.Click += new System.EventHandler(this.EmpezarSimulacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de casos ";
            // 
            // EstadotextBox
            // 
            this.EstadotextBox.Location = new System.Drawing.Point(715, 62);
            this.EstadotextBox.Multiline = true;
            this.EstadotextBox.Name = "EstadotextBox";
            this.EstadotextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EstadotextBox.Size = new System.Drawing.Size(459, 376);
            this.EstadotextBox.TabIndex = 4;
            // 
            // Reiniciarbutton
            // 
            this.Reiniciarbutton.BackColor = System.Drawing.Color.Black;
            this.Reiniciarbutton.ForeColor = System.Drawing.Color.White;
            this.Reiniciarbutton.Location = new System.Drawing.Point(340, 33);
            this.Reiniciarbutton.Name = "Reiniciarbutton";
            this.Reiniciarbutton.Size = new System.Drawing.Size(195, 26);
            this.Reiniciarbutton.TabIndex = 5;
            this.Reiniciarbutton.Text = "Reiniciar Simulación";
            this.Reiniciarbutton.UseVisualStyleBackColor = false;
            this.Reiniciarbutton.Click += new System.EventHandler(this.Reiniciarbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.Reiniciarbutton);
            this.Controls.Add(this.EstadotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpezarSimulacion);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.CantidadCasosTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CantidadCasosTextBox;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button EmpezarSimulacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EstadotextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.Button Reiniciarbutton;
    }
}

