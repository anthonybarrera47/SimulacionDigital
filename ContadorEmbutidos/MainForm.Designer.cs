namespace ContadorEmbutidos
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
            this.components = new System.ComponentModel.Container();
            this.OnTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SegundoLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.MinutosLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.HorasLabel = new System.Windows.Forms.Label();
            this.DiasLabel = new System.Windows.Forms.Label();
            this.AumentarButton = new System.Windows.Forms.Button();
            this.EmpezarSimulacionButton = new System.Windows.Forms.Button();
            this.DetenerSimulacionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GrandeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MedianosLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PequenoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RecomendacionesTextBox = new System.Windows.Forms.TextBox();
            this.SimulacionInstantanea = new System.Windows.Forms.Button();
            this.CantidadDiasTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CostoPequenoTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CostoMedianoTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CostoGrandeTextBox = new System.Windows.Forms.TextBox();
            this.PrecioPequenoTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PequenoMedianoTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PrecioGrandeTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnTimer
            // 
            this.OnTimer.Enabled = true;
            this.OnTimer.Tick += new System.EventHandler(this.OnTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContadorEmbutidos.Properties.Resources.escaner2;
            this.pictureBox2.Location = new System.Drawing.Point(417, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContadorEmbutidos.Properties.Resources.MesaSinFondo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1321, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SegundoLabel
            // 
            this.SegundoLabel.AutoSize = true;
            this.SegundoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegundoLabel.Location = new System.Drawing.Point(803, 13);
            this.SegundoLabel.Name = "SegundoLabel";
            this.SegundoLabel.Size = new System.Drawing.Size(74, 20);
            this.SegundoLabel.TabIndex = 49;
            this.SegundoLabel.Text = "Segundo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(791, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 20);
            this.label21.TabIndex = 48;
            this.label21.Text = ":";
            // 
            // MinutosLabel
            // 
            this.MinutosLabel.AutoSize = true;
            this.MinutosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutosLabel.Location = new System.Drawing.Point(725, 13);
            this.MinutosLabel.Name = "MinutosLabel";
            this.MinutosLabel.Size = new System.Drawing.Size(68, 20);
            this.MinutosLabel.TabIndex = 47;
            this.MinutosLabel.Text = "Minutos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(708, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = ":";
            // 
            // HorasLabel
            // 
            this.HorasLabel.AutoSize = true;
            this.HorasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasLabel.Location = new System.Drawing.Point(660, 13);
            this.HorasLabel.Name = "HorasLabel";
            this.HorasLabel.Size = new System.Drawing.Size(55, 20);
            this.HorasLabel.TabIndex = 45;
            this.HorasLabel.Text = "Horas";
            // 
            // DiasLabel
            // 
            this.DiasLabel.AutoSize = true;
            this.DiasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasLabel.Location = new System.Drawing.Point(1253, 13);
            this.DiasLabel.Name = "DiasLabel";
            this.DiasLabel.Size = new System.Drawing.Size(44, 20);
            this.DiasLabel.TabIndex = 50;
            this.DiasLabel.Text = "Dias";
            // 
            // AumentarButton
            // 
            this.AumentarButton.BackColor = System.Drawing.Color.Blue;
            this.AumentarButton.Enabled = false;
            this.AumentarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AumentarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AumentarButton.Location = new System.Drawing.Point(226, 120);
            this.AumentarButton.Name = "AumentarButton";
            this.AumentarButton.Size = new System.Drawing.Size(185, 100);
            this.AumentarButton.TabIndex = 51;
            this.AumentarButton.Text = "Aumentar";
            this.AumentarButton.UseVisualStyleBackColor = false;
            this.AumentarButton.Click += new System.EventHandler(this.AumentarButton_Click);
            // 
            // EmpezarSimulacionButton
            // 
            this.EmpezarSimulacionButton.BackColor = System.Drawing.Color.Lime;
            this.EmpezarSimulacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpezarSimulacionButton.Location = new System.Drawing.Point(24, 9);
            this.EmpezarSimulacionButton.Name = "EmpezarSimulacionButton";
            this.EmpezarSimulacionButton.Size = new System.Drawing.Size(185, 105);
            this.EmpezarSimulacionButton.TabIndex = 53;
            this.EmpezarSimulacionButton.Text = "Empezar Simulación";
            this.EmpezarSimulacionButton.UseVisualStyleBackColor = false;
            this.EmpezarSimulacionButton.Click += new System.EventHandler(this.EmpezarSimulacionButton_Click);
            // 
            // DetenerSimulacionButton
            // 
            this.DetenerSimulacionButton.BackColor = System.Drawing.Color.Red;
            this.DetenerSimulacionButton.Enabled = false;
            this.DetenerSimulacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetenerSimulacionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetenerSimulacionButton.Location = new System.Drawing.Point(226, 9);
            this.DetenerSimulacionButton.Name = "DetenerSimulacionButton";
            this.DetenerSimulacionButton.Size = new System.Drawing.Size(185, 105);
            this.DetenerSimulacionButton.TabIndex = 54;
            this.DetenerSimulacionButton.Text = "Detener Simulación";
            this.DetenerSimulacionButton.UseVisualStyleBackColor = false;
            this.DetenerSimulacionButton.Click += new System.EventHandler(this.DetenerSimulacionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1087, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Cantidad de Dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1236, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = ":";
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.Silver;
            this.LogTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogTextBox.Location = new System.Drawing.Point(1383, 13);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(399, 321);
            this.LogTextBox.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.GrandeLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MedianosLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PequenoLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1091, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 249);
            this.panel1.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = ":";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(120, 115);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(18, 20);
            this.TotalLabel.TabIndex = 56;
            this.TotalLabel.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(104, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = ":";
            // 
            // GrandeLabel
            // 
            this.GrandeLabel.AutoSize = true;
            this.GrandeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandeLabel.Location = new System.Drawing.Point(120, 70);
            this.GrandeLabel.Name = "GrandeLabel";
            this.GrandeLabel.Size = new System.Drawing.Size(18, 20);
            this.GrandeLabel.TabIndex = 51;
            this.GrandeLabel.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Grandes";
            // 
            // MedianosLabel
            // 
            this.MedianosLabel.AutoSize = true;
            this.MedianosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedianosLabel.Location = new System.Drawing.Point(120, 39);
            this.MedianosLabel.Name = "MedianosLabel";
            this.MedianosLabel.Size = new System.Drawing.Size(18, 20);
            this.MedianosLabel.TabIndex = 49;
            this.MedianosLabel.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Medianos";
            // 
            // PequenoLabel
            // 
            this.PequenoLabel.AutoSize = true;
            this.PequenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PequenoLabel.Location = new System.Drawing.Point(120, 9);
            this.PequenoLabel.Name = "PequenoLabel";
            this.PequenoLabel.Size = new System.Drawing.Size(18, 20);
            this.PequenoLabel.TabIndex = 47;
            this.PequenoLabel.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Pequeños";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "------------------------------";
            // 
            // RecomendacionesTextBox
            // 
            this.RecomendacionesTextBox.BackColor = System.Drawing.Color.Silver;
            this.RecomendacionesTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RecomendacionesTextBox.Location = new System.Drawing.Point(1383, 363);
            this.RecomendacionesTextBox.Multiline = true;
            this.RecomendacionesTextBox.Name = "RecomendacionesTextBox";
            this.RecomendacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RecomendacionesTextBox.Size = new System.Drawing.Size(399, 339);
            this.RecomendacionesTextBox.TabIndex = 59;
            // 
            // SimulacionInstantanea
            // 
            this.SimulacionInstantanea.BackColor = System.Drawing.Color.Orange;
            this.SimulacionInstantanea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulacionInstantanea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SimulacionInstantanea.Location = new System.Drawing.Point(664, 506);
            this.SimulacionInstantanea.Name = "SimulacionInstantanea";
            this.SimulacionInstantanea.Size = new System.Drawing.Size(185, 106);
            this.SimulacionInstantanea.TabIndex = 60;
            this.SimulacionInstantanea.Text = "Simulacion Instantanea";
            this.SimulacionInstantanea.UseVisualStyleBackColor = false;
            this.SimulacionInstantanea.Click += new System.EventHandler(this.SimulacionInstantanea_Click);
            // 
            // CantidadDiasTextBox
            // 
            this.CantidadDiasTextBox.Location = new System.Drawing.Point(24, 148);
            this.CantidadDiasTextBox.Name = "CantidadDiasTextBox";
            this.CantidadDiasTextBox.Size = new System.Drawing.Size(100, 22);
            this.CantidadDiasTextBox.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Cantidad de dias";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(660, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "Costo Pequeños";
            // 
            // CostoPequenoTextBox
            // 
            this.CostoPequenoTextBox.Location = new System.Drawing.Point(660, 78);
            this.CostoPequenoTextBox.Name = "CostoPequenoTextBox";
            this.CostoPequenoTextBox.Size = new System.Drawing.Size(100, 22);
            this.CostoPequenoTextBox.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(660, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Costo Mediano";
            // 
            // CostoMedianoTextBox
            // 
            this.CostoMedianoTextBox.Location = new System.Drawing.Point(660, 126);
            this.CostoMedianoTextBox.Name = "CostoMedianoTextBox";
            this.CostoMedianoTextBox.Size = new System.Drawing.Size(100, 22);
            this.CostoMedianoTextBox.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(660, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 20);
            this.label15.TabIndex = 68;
            this.label15.Text = "Costo Grande";
            // 
            // CostoGrandeTextBox
            // 
            this.CostoGrandeTextBox.Location = new System.Drawing.Point(660, 179);
            this.CostoGrandeTextBox.Name = "CostoGrandeTextBox";
            this.CostoGrandeTextBox.Size = new System.Drawing.Size(100, 22);
            this.CostoGrandeTextBox.TabIndex = 67;
            // 
            // PrecioPequenoTextBox
            // 
            this.PrecioPequenoTextBox.Location = new System.Drawing.Point(825, 78);
            this.PrecioPequenoTextBox.Name = "PrecioPequenoTextBox";
            this.PrecioPequenoTextBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioPequenoTextBox.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(825, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 20);
            this.label16.TabIndex = 64;
            this.label16.Text = "Precio Pequeño";
            // 
            // PequenoMedianoTextBox
            // 
            this.PequenoMedianoTextBox.Location = new System.Drawing.Point(825, 126);
            this.PequenoMedianoTextBox.Name = "PequenoMedianoTextBox";
            this.PequenoMedianoTextBox.Size = new System.Drawing.Size(100, 22);
            this.PequenoMedianoTextBox.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(825, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 20);
            this.label17.TabIndex = 66;
            this.label17.Text = "Precio Mediano";
            // 
            // PrecioGrandeTextBox
            // 
            this.PrecioGrandeTextBox.Location = new System.Drawing.Point(825, 179);
            this.PrecioGrandeTextBox.Name = "PrecioGrandeTextBox";
            this.PrecioGrandeTextBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioGrandeTextBox.TabIndex = 67;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(825, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 20);
            this.label18.TabIndex = 68;
            this.label18.Text = "Precio Grande";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1924, 714);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PrecioGrandeTextBox);
            this.Controls.Add(this.CostoGrandeTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PequenoMedianoTextBox);
            this.Controls.Add(this.CostoMedianoTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PrecioPequenoTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CostoPequenoTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CantidadDiasTextBox);
            this.Controls.Add(this.SimulacionInstantanea);
            this.Controls.Add(this.RecomendacionesTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetenerSimulacionButton);
            this.Controls.Add(this.EmpezarSimulacionButton);
            this.Controls.Add(this.AumentarButton);
            this.Controls.Add(this.DiasLabel);
            this.Controls.Add(this.SegundoLabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.MinutosLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.HorasLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Contador de Embutidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer OnTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SegundoLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label MinutosLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label HorasLabel;
        private System.Windows.Forms.Label DiasLabel;
        private System.Windows.Forms.Button AumentarButton;
        private System.Windows.Forms.Button EmpezarSimulacionButton;
        private System.Windows.Forms.Button DetenerSimulacionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GrandeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MedianosLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PequenoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RecomendacionesTextBox;
        private System.Windows.Forms.Button SimulacionInstantanea;
        private System.Windows.Forms.TextBox CantidadDiasTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CostoPequenoTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CostoMedianoTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CostoGrandeTextBox;
        private System.Windows.Forms.TextBox PrecioPequenoTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PequenoMedianoTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PrecioGrandeTextBox;
        private System.Windows.Forms.Label label18;
    }
}

