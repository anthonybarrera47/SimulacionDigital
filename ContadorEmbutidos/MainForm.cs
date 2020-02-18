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
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ContadorEmbutidos
{
    public partial class MainForm : Form
    {
        int IntervaloTiempo = 10;
        private bool activar = false;
        private int dias, hora, minuto, segundo, centesima;
        int X = 0;
        int incremento = 1;
        string aumento = "Aumento X ";
        Thread t;
        Point pt1;
        Point pt2;
        private List<Embutidos> Lista = new List<Embutidos>();
        Embutidos embutido;
        public MainForm()
        {
            InitializeComponent();
            System.Drawing.Image img = pictureBox2.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox2.Image = img;
            OnTimer.Enabled = false;
            t = new Thread(Empezar);
        }
        private void CalculosRecomendaciones()
        {
            decimal TotalEmbutidos = TotalLabel.Text.ToDecimal();
            decimal Pequenios = PequenoLabel.Text.ToDecimal();
            decimal medianos = MedianosLabel.Text.ToDecimal();
            decimal Grandes = GrandeLabel.Text.ToDecimal();

            decimal PorcentajePequeno = 0;
            decimal PorcentajeMediano = 0;
            decimal PorcentajeGrande = 0;

            if (TotalEmbutidos > 0)
            {
                PorcentajePequeno = ((Pequenios / TotalEmbutidos) * 100).ToRound();
                PorcentajeMediano = ((medianos / TotalEmbutidos) * 100).ToRound();
                PorcentajeGrande = ((Grandes / TotalEmbutidos) * 100).ToRound();
            }

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Pequeño es {PorcentajePequeno}%");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Mediano es {PorcentajeMediano}%");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Grande es {PorcentajeGrande}%");

            Dictionary<Width, decimal> Diccionario = new Dictionary<Width, decimal>
            {
                { ContadorEmbutidos.Width.Pequeno, PorcentajePequeno },
                { ContadorEmbutidos.Width.Mediano, PorcentajeMediano },
                { ContadorEmbutidos.Width.Grande, PorcentajeGrande }
            };

            var max = Diccionario.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}El Embutido mas vendido fue el {max.ToString()}");
            MessageBox.Show($"Embutido recomendado a comprar: {max.ToString()}", "Recomendacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Longitud LongitudEmbutidoRandom()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new string(guid.ToString().Where(char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            Random random = new Random(seed);
            int a = random.Next(1, 4);
            return (Longitud)a;
        }
        public void Finalizar()
        {
            if (t.IsAlive)
            {
                t.Abort();
                OnTimer.Enabled = false;
                t = new Thread(Empezar);
                Lista = new List<Embutidos>();
                PequenoLabel.Text = "";
                MedianosLabel.Text = "";
                GrandeLabel.Text = "";
                TotalLabel.Text = "";
                X = 0;
            }
        }
        public void CambiarEstadoBotones(bool Estado)
        {
            EmpezarSimulacionButton.Enabled = Estado;
            DetenerSimulacionButton.Enabled = !Estado;
            AumentarButton.Enabled = !Estado;
            SimulacionInstantanea.Enabled = Estado;
            CantidadDiasTextBox.ReadOnly = !Estado;
        }
        public void AsignarEmbutido()
        {
            embutido = new Embutidos
            {
                Longitud = LongitudEmbutidoRandom()
            };
            embutido.AsignarWidth();
            Lista.Add(embutido);
            LogTextBox.AppendText($"{System.Environment.NewLine}Se agrego un embutido {embutido.Longitud.ToString()} ");
        }
        void Ejecutar()
        {
            OnTimer.Enabled = true;
            t.Start();
        }
        public void Empezar()
        {
            activar = true;
            segundo = 0;
            minuto = 0;
            hora = 0;
            dias = 0;

            while (activar)
            {
                try
                {

                    Thread.Sleep(IntervaloTiempo);

                    if (DiasLabel.InvokeRequired)
                        DiasLabel.Invoke(new Action(delegate { DiasLabel.Text = dias.ToString(); }));

                    if (HorasLabel.InvokeRequired)
                        HorasLabel.Invoke(new Action(delegate { HorasLabel.Text = hora.ToString(); }));

                    if (MinutosLabel.InvokeRequired)
                        MinutosLabel.Invoke(new Action(delegate { MinutosLabel.Text = minuto.ToString(); }));

                    if (SegundoLabel.InvokeRequired)
                        SegundoLabel.Invoke(new Action(delegate { SegundoLabel.Text = segundo.ToString(); }));

                    centesima++;
                    if (centesima >= 99)
                    {
                        centesima = 0;
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
                    if (hora >= 24)
                    {
                        hora = 0;
                        dias++;
                    }
                    if (dias == CantidadDiasTextBox.Text.ToInt())
                        Finalizar();
                }
                catch (Exception) { }
            }
        }
        public void CalcularDeUnToque()
        {
            RecomendacionesTextBox.Text = string.Empty;
            LogTextBox.Text = string.Empty;
            int dias = CantidadDiasTextBox.Text.ToInt();
            int Segundos = dias * 86400;

            while (Segundos > 0)
            {
                embutido = new Embutidos
                {
                    Longitud = LongitudEmbutidoRandom()
                };
                embutido.AsignarTiempo();
                Segundos -= (int)embutido.LongitudTiempo;
                Lista.Add(embutido);
            }

            decimal TotalEmbutidos = Lista.Count().ToDecimal();
            decimal Pequenios = Lista.Count(x => x.LongitudTiempo == ContadorEmbutidos.LongitudTiempo.Pequeno).ToDecimal();
            decimal medianos = Lista.Count(x => x.LongitudTiempo == ContadorEmbutidos.LongitudTiempo.Mediano).ToDecimal();
            decimal Grandes = Lista.Count(x => x.LongitudTiempo == ContadorEmbutidos.LongitudTiempo.Grande).ToDecimal();

            decimal PorcentajePequeno = 0;
            decimal PorcentajeMediano = 0;
            decimal PorcentajeGrande = 0;

            if (TotalEmbutidos > 0)
            {
                PorcentajePequeno = ((Pequenios / TotalEmbutidos) * 100).ToRound();
                PorcentajeMediano = ((medianos / TotalEmbutidos) * 100).ToRound();
                PorcentajeGrande = ((Grandes / TotalEmbutidos) * 100).ToRound();
            }

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Pequeño es {PorcentajePequeno}%");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Mediano es {PorcentajeMediano}%");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Grande es {PorcentajeGrande}%");

            PequenoLabel.Text = Lista.Count(x => x.LongitudTiempo == ContadorEmbutidos.LongitudTiempo.Pequeno).ToString();
            MedianosLabel.Text = Lista.Count(x => x.LongitudTiempo == ContadorEmbutidos.LongitudTiempo.Mediano).ToString();
            GrandeLabel.Text = Lista.Count(x => x.LongitudTiempo == ContadorEmbutidos.LongitudTiempo.Grande).ToString();
            TotalLabel.Text = Lista.Count().ToString();
            DiasLabel.Text = CantidadDiasTextBox.Text;
            Dictionary<LongitudTiempo, decimal> Diccionario = new Dictionary<LongitudTiempo, decimal>
            {
                { ContadorEmbutidos.LongitudTiempo.Pequeno, PorcentajePequeno },
                { ContadorEmbutidos.LongitudTiempo.Mediano, PorcentajeMediano },
                { ContadorEmbutidos.LongitudTiempo.Grande, PorcentajeGrande }
            };

            var max = Diccionario.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            CalcularGanancia();
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}El Embutido mas vendido fue el {max.ToString()}");
            MessageBox.Show($"Embutido recomendado a comprar: {max.ToString()}", "Recomendacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void CalcularGanancia()
        {
            decimal CostoPequeno = CostoPequenoTextBox.Text.ToDecimal();
            decimal CostoMediano = CostoMedianoTextBox.Text.ToDecimal();
            decimal CostoGrande = CostoGrandeTextBox.Text.ToDecimal();
            decimal PrecioPequeno = PrecioPequenoTextBox.Text.ToDecimal();
            decimal PrecioMediano = PrecioPequenoTextBox.Text.ToDecimal();
            decimal PrecioGrande = PrecioGrandeTextBox.Text.ToDecimal();

            decimal TotalCostoPequeno = CostoPequeno * PequenoLabel.Text.ToInt();
            decimal TotalCostoMediano = CostoMediano * MedianosLabel.Text.ToInt();
            decimal TotalCostoGrande = CostoGrande * GrandeLabel.Text.ToInt();

            decimal TotalVendidoPequeno = PrecioPequeno * PequenoLabel.Text.ToInt();
            decimal TotalVendidoMediano = PrecioMediano * MedianosLabel.Text.ToInt();
            decimal TotalVendidoGrande = PrecioGrande * GrandeLabel.Text.ToInt();

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Costo Pequenio = {TotalCostoPequeno}");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Costo Mediano = {TotalCostoMediano}");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Costo Grande = {TotalCostoGrande}");

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}");

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Vendido Pequenio = {TotalVendidoPequeno}");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Vendido Mediano = {TotalVendidoMediano}");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Vendido Grande = {TotalVendidoGrande}");

            decimal TotalCosto = TotalCostoPequeno + TotalCostoMediano + TotalCostoGrande;
            decimal TotalVenta = TotalVendidoPequeno + TotalVendidoMediano + TotalVendidoGrande;


            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}");


            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Costo = {TotalCosto}");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Total Venta = {TotalVenta}");

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}");


            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}Utilidad = {TotalVenta - TotalCosto}");
        }
        private void DibujarLineaRoja(PaintEventArgs e)
        {
            pt1 = new Point(360, 100);
            pt2 = new Point(360, 310);
            Pen myPen = new Pen(Color.Red, 5);
            e.Graphics.DrawLine(myPen, pt1, pt2);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Finalizar();
        }
        private void OnTimer_Tick(object sender, EventArgs e)
        {
            X += 10;
            Invalidate();
        }
        private void AumentarButton_Click(object sender, EventArgs e)
        {
            LogTextBox.AppendText($"{System.Environment.NewLine}Se incremento la velocidad a {incremento.ToString()}");
            AumentarButton.Text = aumento + incremento.ToString();
            if (OnTimer.Interval <= 10)
            {
                IntervaloTiempo = 0;
                OnTimer.Interval = 1;
                incremento = 10;
            }
            else
            {
                IntervaloTiempo -= 1;
                OnTimer.Interval -= 10;
                incremento++;
            }
        }
        private void EmpezarSimulacionButton_Click(object sender, EventArgs e)
        {
            if (CantidadDiasTextBox.Text.ToInt() > 0)
            {
                Lista = new List<Embutidos>();
                LogTextBox.Text = string.Empty;
                RecomendacionesTextBox.Text = string.Empty;
                LogTextBox.AppendText($"{System.Environment.NewLine}Se inicio la simulación");
                CambiarEstadoBotones(false);
                Ejecutar();
                PequenoLabel.Text = "";
                MedianosLabel.Text = "";
                GrandeLabel.Text = "";
                TotalLabel.Text = "";
                AumentarButton.Text = aumento + incremento.ToString();

            }
            else
                MessageBox.Show("Debe especificar un numero de dias");

        }
        private void DetenerSimulacionButton_Click(object sender, EventArgs e)
        {
            AumentarButton.Text = aumento.ToString();
            IntervaloTiempo = 10;
            OnTimer.Interval = 100;
            incremento = 1;
            CalculosRecomendaciones();
            CambiarEstadoBotones(true);
            CalcularGanancia();
            Finalizar();
            LogTextBox.AppendText($"{System.Environment.NewLine}Se finalizo la simulación");
        }
        private void SimulacionInstantanea_Click(object sender, EventArgs e)
        {
            CalcularDeUnToque();
        }
        //Cuando es Width es 300 X es 60
        //Cuando es Width es 200 X es 160
        //Cuando es Width es 100 X es 260
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (t.IsAlive)
                {
                    if (Lista.Count == 0)
                        AsignarEmbutido();

                    e.Graphics.FillRectangle(Brushes.OrangeRed, X, 190, (float)embutido.Width, 100);
                    DibujarLineaRoja(e);

                    if (X == 360)
                    {
                        X = 0;
                        PequenoLabel.Text = Lista.Count(x => x.Width == ContadorEmbutidos.Width.Pequeno).ToString();
                        MedianosLabel.Text = Lista.Count(x => x.Width == ContadorEmbutidos.Width.Mediano).ToString();
                        GrandeLabel.Text = Lista.Count(x => x.Width == ContadorEmbutidos.Width.Grande).ToString();
                        TotalLabel.Text = (PequenoLabel.Text.ToInt() + MedianosLabel.Text.ToInt() + GrandeLabel.Text.ToInt()).ToString();
                        AsignarEmbutido();
                    }
                }
            }
            catch (Exception) { }
        }
    }
    public enum Longitud
    {
        Pequeno = 1,
        Mediano = 2,
        Grande = 3
    }
    public enum Width
    {
        Pequeno = 100,
        Mediano = 200,
        Grande = 300
    }
    public enum Precio
    {
        Pequeno = 100,
        Mediano = 200,
        Grande = 300
    }
    public enum LongitudTiempo
    {
        Pequeno = 2,
        Mediano = 4,
        Grande = 7
    }
    public class Embutidos
    {
        public Longitud Longitud { get; set; }
        public Width Width { get; set; }
        public Precio Precio { get; set; }
        public LongitudTiempo LongitudTiempo { get; set; }
        public Embutidos()
        {
            Longitud = Longitud.Pequeno;
            Width = Width.Pequeno;
            Precio = Precio.Pequeno;
            LongitudTiempo = LongitudTiempo.Pequeno;
        }
        public Embutidos(Longitud longitud, Width width, Precio precio, LongitudTiempo longitudTiempo)
        {
            Longitud = longitud;
            Width = width;
            Precio = precio;
            LongitudTiempo = longitudTiempo;
        }
        public void AsignarWidth()
        {
            if (Longitud == Longitud.Pequeno)
                Width = Width.Pequeno;
            else if (Longitud == Longitud.Mediano)
                Width = Width.Mediano;
            else if (Longitud == Longitud.Grande)
                Width = Width.Grande;
        }
        public void AsignarTiempo()
        {
            if (Longitud == Longitud.Pequeno)
                LongitudTiempo = LongitudTiempo.Pequeno;
            else if (Longitud == Longitud.Mediano)
                LongitudTiempo = LongitudTiempo.Mediano;
            else if (Longitud == Longitud.Grande)
                LongitudTiempo = LongitudTiempo.Grande;
        }
    }
}
