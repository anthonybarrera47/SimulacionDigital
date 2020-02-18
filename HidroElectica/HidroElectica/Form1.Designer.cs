namespace HidroElectica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CoeficienteComboBox = new System.Windows.Forms.ComboBox();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CaudalTextBox = new System.Windows.Forms.TextBox();
            this.LaptitudNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LongitudNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiametroNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PotenciaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EficienciaTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.EficienciaNecesariaTextBox = new System.Windows.Forms.TextBox();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.EficienciaPorMinutoTextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HorasLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.MinutosLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SegundoLabel = new System.Windows.Forms.Label();
            this.EmpezarButton = new System.Windows.Forms.Button();
            this.DetenerSimulacion = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.EnergiaAcumuladaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LaptitudNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongitudNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiametroNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diametro de la tuberia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Latitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Longitud";
            // 
            // CoeficienteComboBox
            // 
            this.CoeficienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoeficienteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CoeficienteComboBox.FormattingEnabled = true;
            this.CoeficienteComboBox.Location = new System.Drawing.Point(12, 193);
            this.CoeficienteComboBox.Name = "CoeficienteComboBox";
            this.CoeficienteComboBox.Size = new System.Drawing.Size(166, 24);
            this.CoeficienteComboBox.TabIndex = 11;
            this.CoeficienteComboBox.SelectedIndexChanged += new System.EventHandler(this.CoeficienteComboBox_SelectedIndexChanged);
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(184, 193);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.ReadOnly = true;
            this.ValorTextBox.Size = new System.Drawing.Size(100, 22);
            this.ValorTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Caudal";
            // 
            // CaudalTextBox
            // 
            this.CaudalTextBox.Location = new System.Drawing.Point(12, 244);
            this.CaudalTextBox.Name = "CaudalTextBox";
            this.CaudalTextBox.Size = new System.Drawing.Size(100, 22);
            this.CaudalTextBox.TabIndex = 13;
            // 
            // LaptitudNumericUpDown
            // 
            this.LaptitudNumericUpDown.DecimalPlaces = 3;
            this.LaptitudNumericUpDown.Location = new System.Drawing.Point(12, 104);
            this.LaptitudNumericUpDown.Name = "LaptitudNumericUpDown";
            this.LaptitudNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.LaptitudNumericUpDown.TabIndex = 17;
            this.LaptitudNumericUpDown.ValueChanged += new System.EventHandler(this.LaptitudNumericUpDown_ValueChanged);
            // 
            // LongitudNumericUpDown
            // 
            this.LongitudNumericUpDown.DecimalPlaces = 3;
            this.LongitudNumericUpDown.Location = new System.Drawing.Point(12, 150);
            this.LongitudNumericUpDown.Name = "LongitudNumericUpDown";
            this.LongitudNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.LongitudNumericUpDown.TabIndex = 18;
            this.LongitudNumericUpDown.ValueChanged += new System.EventHandler(this.LongitudNumericUpDown_ValueChanged);
            // 
            // DiametroNumericUpDown
            // 
            this.DiametroNumericUpDown.DecimalPlaces = 3;
            this.DiametroNumericUpDown.Location = new System.Drawing.Point(12, 56);
            this.DiametroNumericUpDown.Name = "DiametroNumericUpDown";
            this.DiametroNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.DiametroNumericUpDown.TabIndex = 19;
            this.DiametroNumericUpDown.ValueChanged += new System.EventHandler(this.DiametroNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "m";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "m^3/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Vatios";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Potencia";
            // 
            // PotenciaTextBox
            // 
            this.PotenciaTextBox.Location = new System.Drawing.Point(184, 244);
            this.PotenciaTextBox.Name = "PotenciaTextBox";
            this.PotenciaTextBox.Size = new System.Drawing.Size(100, 22);
            this.PotenciaTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Vatios";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Eficiencia producida";
            // 
            // EficienciaTextBox
            // 
            this.EficienciaTextBox.Location = new System.Drawing.Point(337, 244);
            this.EficienciaTextBox.Name = "EficienciaTextBox";
            this.EficienciaTextBox.ReadOnly = true;
            this.EficienciaTextBox.Size = new System.Drawing.Size(100, 22);
            this.EficienciaTextBox.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(624, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Eficiencia necesaria";
            // 
            // EficienciaNecesariaTextBox
            // 
            this.EficienciaNecesariaTextBox.Location = new System.Drawing.Point(627, 452);
            this.EficienciaNecesariaTextBox.Name = "EficienciaNecesariaTextBox";
            this.EficienciaNecesariaTextBox.ReadOnly = true;
            this.EficienciaNecesariaTextBox.Size = new System.Drawing.Size(100, 22);
            this.EficienciaNecesariaTextBox.TabIndex = 32;
            this.EficienciaNecesariaTextBox.Text = "250-5000";
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoLabel.Location = new System.Drawing.Point(202, 89);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(123, 39);
            this.EstadoLabel.TabIndex = 33;
            this.EstadoLabel.Text = "Estado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Eficiencia producida Por Minuto";
            // 
            // EficienciaPorMinutoTextBox
            // 
            this.EficienciaPorMinutoTextBox.Location = new System.Drawing.Point(337, 292);
            this.EficienciaPorMinutoTextBox.Name = "EficienciaPorMinutoTextBox";
            this.EficienciaPorMinutoTextBox.ReadOnly = true;
            this.EficienciaPorMinutoTextBox.Size = new System.Drawing.Size(100, 22);
            this.EficienciaPorMinutoTextBox.TabIndex = 34;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 173);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(179, 17);
            this.Label.TabIndex = 36;
            this.Label.Text = "Coeficiente Hazen-Williams";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HidroElectica.Properties.Resources.Turbina_Pelton;
            this.pictureBox1.Location = new System.Drawing.Point(627, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 351);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Formulas Utilizadas";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Formula Hazen-Williams = ",
            "        Q = 0.2787 * C(Coeficiente HazenWilliam) * D^2.63 * S^0.54",
            "         S = Latitud/ Longitud ",
            "Potencia ",
            "         P= Altura * Caudal * Gravedad ",
            "Gravedad",
            "         G= 9.81m^2/2"});
            this.listBox1.Location = new System.Drawing.Point(37, 375);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(497, 132);
            this.listBox1.TabIndex = 39;
            // 
            // HorasLabel
            // 
            this.HorasLabel.AutoSize = true;
            this.HorasLabel.Location = new System.Drawing.Point(249, 9);
            this.HorasLabel.Name = "HorasLabel";
            this.HorasLabel.Size = new System.Drawing.Size(46, 17);
            this.HorasLabel.TabIndex = 40;
            this.HorasLabel.Text = "Horas";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(297, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = ":";
            // 
            // MinutosLabel
            // 
            this.MinutosLabel.AutoSize = true;
            this.MinutosLabel.Location = new System.Drawing.Point(314, 9);
            this.MinutosLabel.Name = "MinutosLabel";
            this.MinutosLabel.Size = new System.Drawing.Size(57, 17);
            this.MinutosLabel.TabIndex = 42;
            this.MinutosLabel.Text = "Minutos";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(365, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 17);
            this.label21.TabIndex = 43;
            this.label21.Text = ":";
            // 
            // SegundoLabel
            // 
            this.SegundoLabel.AutoSize = true;
            this.SegundoLabel.Location = new System.Drawing.Point(383, 9);
            this.SegundoLabel.Name = "SegundoLabel";
            this.SegundoLabel.Size = new System.Drawing.Size(65, 17);
            this.SegundoLabel.TabIndex = 44;
            this.SegundoLabel.Text = "Segundo";
            // 
            // EmpezarButton
            // 
            this.EmpezarButton.BackColor = System.Drawing.Color.LawnGreen;
            this.EmpezarButton.ForeColor = System.Drawing.Color.Black;
            this.EmpezarButton.Location = new System.Drawing.Point(12, 521);
            this.EmpezarButton.Name = "EmpezarButton";
            this.EmpezarButton.Size = new System.Drawing.Size(85, 48);
            this.EmpezarButton.TabIndex = 45;
            this.EmpezarButton.Text = "Empezar Simulación";
            this.EmpezarButton.UseVisualStyleBackColor = false;
            this.EmpezarButton.Click += new System.EventHandler(this.EmpezarButton_Click);
            // 
            // DetenerSimulacion
            // 
            this.DetenerSimulacion.BackColor = System.Drawing.Color.Red;
            this.DetenerSimulacion.ForeColor = System.Drawing.Color.White;
            this.DetenerSimulacion.Location = new System.Drawing.Point(103, 521);
            this.DetenerSimulacion.Name = "DetenerSimulacion";
            this.DetenerSimulacion.Size = new System.Drawing.Size(110, 48);
            this.DetenerSimulacion.TabIndex = 46;
            this.DetenerSimulacion.Text = "Detener Simulación";
            this.DetenerSimulacion.UseVisualStyleBackColor = false;
            this.DetenerSimulacion.Click += new System.EventHandler(this.DetenerSimulacion_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(337, 317);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 17);
            this.label18.TabIndex = 48;
            this.label18.Text = "Energia Acumulada";
            // 
            // EnergiaAcumuladaTextBox
            // 
            this.EnergiaAcumuladaTextBox.Location = new System.Drawing.Point(337, 337);
            this.EnergiaAcumuladaTextBox.Name = "EnergiaAcumuladaTextBox";
            this.EnergiaAcumuladaTextBox.ReadOnly = true;
            this.EnergiaAcumuladaTextBox.Size = new System.Drawing.Size(100, 22);
            this.EnergiaAcumuladaTextBox.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 594);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.EnergiaAcumuladaTextBox);
            this.Controls.Add(this.DetenerSimulacion);
            this.Controls.Add(this.EmpezarButton);
            this.Controls.Add(this.SegundoLabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.MinutosLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.HorasLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.EficienciaPorMinutoTextBox);
            this.Controls.Add(this.EstadoLabel);
            this.Controls.Add(this.EficienciaNecesariaTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.EficienciaTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PotenciaTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DiametroNumericUpDown);
            this.Controls.Add(this.LongitudNumericUpDown);
            this.Controls.Add(this.LaptitudNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CaudalTextBox);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.CoeficienteComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "HidroElectrica";
            ((System.ComponentModel.ISupportInitialize)(this.LaptitudNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongitudNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiametroNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CoeficienteComboBox;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CaudalTextBox;
        private System.Windows.Forms.NumericUpDown LaptitudNumericUpDown;
        private System.Windows.Forms.NumericUpDown LongitudNumericUpDown;
        private System.Windows.Forms.NumericUpDown DiametroNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PotenciaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EficienciaTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EficienciaNecesariaTextBox;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox EficienciaPorMinutoTextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label HorasLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label MinutosLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label SegundoLabel;
        private System.Windows.Forms.Button EmpezarButton;
        private System.Windows.Forms.Button DetenerSimulacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox EnergiaAcumuladaTextBox;
    }
}

