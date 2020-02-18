namespace SimulacionDigital
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.CantidadElemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AumentarProbabilidad = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VecesRepetidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CantidadRepeticiones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProbabilidadLB = new System.Windows.Forms.Label();
            this.VecesRepetidaLb = new System.Windows.Forms.Label();
            this.PorcentajeLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(289, 72);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Probabilidad,
            this.VecesRepetidas,
            this.pct,
            this.Marcado});
            this.DGV.Location = new System.Drawing.Point(12, 103);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(674, 247);
            this.DGV.TabIndex = 4;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // CantidadElemento
            // 
            this.CantidadElemento.Location = new System.Drawing.Point(161, 72);
            this.CantidadElemento.Name = "CantidadElemento";
            this.CantidadElemento.Size = new System.Drawing.Size(100, 22);
            this.CantidadElemento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de numeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Probabilidad a aumentar";
            // 
            // AumentarProbabilidad
            // 
            this.AumentarProbabilidad.Location = new System.Drawing.Point(861, 103);
            this.AumentarProbabilidad.Name = "AumentarProbabilidad";
            this.AumentarProbabilidad.Size = new System.Drawing.Size(66, 22);
            this.AumentarProbabilidad.TabIndex = 7;
            this.AumentarProbabilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AumentarProbabilidad_KeyPress);
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Valor.Width = 47;
            // 
            // Probabilidad
            // 
            this.Probabilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Probabilidad.HeaderText = "Probabilidad";
            this.Probabilidad.MinimumWidth = 6;
            this.Probabilidad.Name = "Probabilidad";
            this.Probabilidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Probabilidad.Width = 93;
            // 
            // VecesRepetidas
            // 
            this.VecesRepetidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VecesRepetidas.HeaderText = "VecesRepetidas";
            this.VecesRepetidas.MinimumWidth = 6;
            this.VecesRepetidas.Name = "VecesRepetidas";
            this.VecesRepetidas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VecesRepetidas.Width = 117;
            // 
            // pct
            // 
            this.pct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pct.HeaderText = "Porcentaje";
            this.pct.MinimumWidth = 6;
            this.pct.Name = "pct";
            this.pct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pct.Width = 82;
            // 
            // Marcado
            // 
            this.Marcado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Marcado.HeaderText = "No Afectar Porcentaje";
            this.Marcado.MinimumWidth = 6;
            this.Marcado.Name = "Marcado";
            this.Marcado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Marcado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Marcado.Width = 161;
            // 
            // CantidadRepeticiones
            // 
            this.CantidadRepeticiones.Location = new System.Drawing.Point(183, 37);
            this.CantidadRepeticiones.Name = "CantidadRepeticiones";
            this.CantidadRepeticiones.Size = new System.Drawing.Size(100, 22);
            this.CantidadRepeticiones.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de repeticiones";
            // 
            // ProbabilidadLB
            // 
            this.ProbabilidadLB.AutoSize = true;
            this.ProbabilidadLB.Location = new System.Drawing.Point(118, 362);
            this.ProbabilidadLB.Name = "ProbabilidadLB";
            this.ProbabilidadLB.Size = new System.Drawing.Size(51, 17);
            this.ProbabilidadLB.TabIndex = 11;
            this.ProbabilidadLB.Text = "Label1";
            // 
            // VecesRepetidaLb
            // 
            this.VecesRepetidaLb.AutoSize = true;
            this.VecesRepetidaLb.Location = new System.Drawing.Point(210, 362);
            this.VecesRepetidaLb.Name = "VecesRepetidaLb";
            this.VecesRepetidaLb.Size = new System.Drawing.Size(51, 17);
            this.VecesRepetidaLb.TabIndex = 12;
            this.VecesRepetidaLb.Text = "Label1";
            // 
            // PorcentajeLB
            // 
            this.PorcentajeLB.AutoSize = true;
            this.PorcentajeLB.Location = new System.Drawing.Point(326, 362);
            this.PorcentajeLB.Name = "PorcentajeLB";
            this.PorcentajeLB.Size = new System.Drawing.Size(51, 17);
            this.PorcentajeLB.TabIndex = 13;
            this.PorcentajeLB.Text = "Label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 580);
            this.Controls.Add(this.PorcentajeLB);
            this.Controls.Add(this.VecesRepetidaLb);
            this.Controls.Add(this.ProbabilidadLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CantidadRepeticiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AumentarProbabilidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantidadElemento);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.CalcularButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox CantidadElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AumentarProbabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn VecesRepetidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Marcado;
        private System.Windows.Forms.TextBox CantidadRepeticiones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProbabilidadLB;
        private System.Windows.Forms.Label VecesRepetidaLb;
        private System.Windows.Forms.Label PorcentajeLB;
    }
}

