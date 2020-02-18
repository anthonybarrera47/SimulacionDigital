using Extensores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HidroElectica
{
    public partial class Form1 : Form
    {
        public int segundosPasaron = 0;
        public const decimal G = 9.81M;
        public Thread t;
        private bool activar = false;
        private int hora, minuto, segundo, centesima;
        public Form1()
        {
            InitializeComponent();
            CoeficienteComboBox.DataSource = CoeficienteHazenWilliam.InicializarCombo();
            CoeficienteComboBox.DisplayMember = "Material";
            CoeficienteComboBox.ValueMember = "Valor";
            CoeficienteComboBox.SelectedIndex = 0;
            CoeficienteComboBox_SelectedIndexChanged(null, null);
        }
        public void CalcularCaudal()
        {
            double diametro = DiametroNumericUpDown.Value.ToDouble();
            decimal Latitud = LaptitudNumericUpDown.Value;
            decimal Longitud = LongitudNumericUpDown.Value;
            decimal Caudal = 0;
            decimal S = 0;

            if (Longitud > 0)
                S = Latitud / Longitud;

            Caudal = 0.2787M * ValorTextBox.Text.ToDecimal() * Math.Pow(diametro, 2.63).ToDecimal() * Math.Pow(S.ToDouble(), 0.54).ToDecimal();
            CaudalTextBox.Text = Caudal.ToRound().ToString();
            CalcularPotencia(Latitud, Caudal);
        }
        public void CalcularPotencia(decimal Laptitud, decimal Caudal)
        {
            decimal Potencia = Laptitud * G * Caudal;
            PotenciaTextBox.Text = Potencia.ToRound().ToString();
            CalcularEficiencia(Potencia);
        }
        public void CalcularEficiencia(decimal Potencia)
        {
            decimal Eficiencia = Potencia * 0.70M;
            EficienciaTextBox.Text = Eficiencia.ToRound().ToString();
            EficienciaPorMinutoTextBox.Text = (Eficiencia / 60).ToRound().ToString();

            if (Eficiencia < 250)
            {
                EstadoLabel.BackColor = Color.Red;
                EstadoLabel.Text = "La eficiencia producida no es suficiente";
            }
            else if (Eficiencia >= 250 && Eficiencia <= 5000)
            {
                EstadoLabel.BackColor = Color.Green;
                EstadoLabel.Text = "La eficiencia producida es suficiente";
            }
            else if (Eficiencia >= 5000)
            {
                segundosPasaron++;
                EstadoLabel.BackColor = Color.DarkRed;
                MessageBox.Show("Detuvimos la simulacion por que pasaron 10 segundos desde que se sobrecargo la turbina", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DetenerSimulacion_Click(null, null);
            }
        }
        private void CoeficienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValorTextBox.Text = CoeficienteComboBox.SelectedValue.ToString();
            CalcularCaudal();
        }

        private void DiametroNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularCaudal();
        }

        private void LaptitudNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularCaudal();
        }
        private void LongitudNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularCaudal();
        }
        private void EmpezarButton_Click(object sender, EventArgs e)
        {
            Ejecutar();
        }
        private void DetenerSimulacion_Click(object sender, EventArgs e)
        {
            activar = false;
            EnergiaAcumuladaTextBox.Text = string.Empty;
        }
        public void SumarEficiencia()
        {

            decimal eficiencia = EficienciaPorMinutoTextBox.Text.ToDecimal() / 60;
            decimal eficienciaSegundo = 0;
            if (EnergiaAcumuladaTextBox.InvokeRequired)
            {
                eficienciaSegundo += EnergiaAcumuladaTextBox.Text.ToDecimal();
                eficienciaSegundo += eficiencia;
                EnergiaAcumuladaTextBox.Invoke(new Action(delegate { EnergiaAcumuladaTextBox.Text = eficienciaSegundo.ToString(); }));
            }
        }
        void Ejecutar()
        {
            t = new Thread(Empezar);
            t.Start();
        }
        public void Empezar()
        {
            activar = true;
            segundo = 0;
            minuto = 0;
            hora = 0;

            while (activar)
            {
                try
                {
                    Thread.Sleep(10);
                }
                catch (Exception)
                {

                }
                if (HorasLabel.InvokeRequired)
                {
                    HorasLabel.Invoke(new Action(delegate { HorasLabel.Text = hora.ToString(); }));
                }
                if (MinutosLabel.InvokeRequired)
                {
                    MinutosLabel.Invoke(new Action(delegate { MinutosLabel.Text = minuto.ToString(); }));
                }
                if (SegundoLabel.InvokeRequired)
                {
                    SegundoLabel.Invoke(new Action(delegate { SegundoLabel.Text = segundo.ToString(); }));
                }
                centesima++;
                if (centesima >= 99)
                {
                    centesima = 0;
                    SumarEficiencia();
                    segundo++;
                }
                if (segundo >= 60)
                {
                    segundo = 0;
                    minuto++;
                }
                if (minuto >= 60)
                {
                    minuto = 0;
                    hora++;
                }
            }
        }
    }
}
//Potencia = Altura * Caudal * Gravedad 
public class CoeficienteHazenWilliam
{
    public string Material { get; set; }
    public int Valor { get; set; }

    public CoeficienteHazenWilliam(string material, int valor)
    {
        Material = material ?? throw new ArgumentNullException(nameof(material));
        Valor = valor;
    }

    public CoeficienteHazenWilliam()
    {
        Material = string.Empty;
        Valor = 0;
    }
    //FORMULA DE HAZEN-WILLIAM PARA EL CAUDAL 
    // Q = 0.2787 * C(Coeficiente HazenWilliam) * D^2.63 * S^0.54
    // S = Laptitud / Longitud 
    public static List<CoeficienteHazenWilliam> InicializarCombo()
    {
        string[] Materiales = {"Asbesto-Cemento","Hierro Fundido nueva","Hierro fundido 10 años","Hierro fundido 20 años"
            ,"Hierro fundido 30 años","Hierro fundido 40 años","Concreto","Cobre","Acero","Hierro galvanizado","Polietileno"
            ,"Policroruro de vinilo(PVC)","Plastico fibroreforzado(FRP)"};
        int[] Valores = { 140, 130, 113, 100, 90, 83, 140, 140, 110, 120, 140, 150, 150 };
        List<CoeficienteHazenWilliam> Lista = new List<CoeficienteHazenWilliam>();

        for (int i = 0; i < Materiales.Length; i++)
        {
            Lista.Add(new CoeficienteHazenWilliam(Materiales[i], Valores[i]));
        }
        return Lista;
    }

}


