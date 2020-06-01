using Extensores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static ContadorEmbutidos.Enums;

namespace ContadorEmbutidos
{
    public partial class MainForm : Form
    {
        int IntervaloTiempo = 10;
        int CorreaVelocidadValue = 1;
        int AprensadoraVelocidadValue = 1;
        private bool activar = false;
        private int dias, hora, minuto, segundo, centesima;
        int X = 0;
        int Y = 0;
        int incremento = 1;
        int incrementoAprensadora = 1;
        string Aumento = "Aumento X ";
        Thread t;
        Point pt1;
        Point pt2;
        private List<Embutidos> Lista = new List<Embutidos>();
        Embutidos embutido;
        public MainForm()
        {
            InitializeComponent();
            OnTimer.Enabled = false;
            InTimer.Enabled = false;
            t = new Thread(Empezar);
            VelocidadProduccionTrackBar_Scroll(null, null);
            VelocidadAprensadoratrackBar_Scroll(null, null);
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
                { Enums.Width.Pequeno, PorcentajePequeno },
                { Enums.Width.Mediano, PorcentajeMediano },
                { Enums.Width.Grande, PorcentajeGrande }
            };

            var max = Diccionario.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}{System.Environment.NewLine}El Embutido mas vendido fue el {max.ToString()}");
            MessageBox.Show($"Embutido recomendado a comprar: {max.ToString()}", "Recomendacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Finalizar()
        {
            if (t.IsAlive)
            {
                t.Abort();
                OnTimer.Enabled = false;
                InTimer.Enabled = false;
                t = new Thread(Empezar);
                Lista = new List<Embutidos>();
                PequenoLabel.Text = "";
                MedianosLabel.Text = "";
                GrandeLabel.Text = "";
                TotalLabel.Text = "";
                ApresadoraNivelLabel.Text = "";
                VelocidadCorreaLabel.Text = "";
                X = 0;
                Y = 0;
                VelocidadProduccionTrackBar_Scroll(null, null);
                VelocidadAprensadoratrackBar_Scroll(null, null);
            }
        }
        public void CambiarEstadoControles(bool Estado)
        {
            EmpezarSimulacionButton.Enabled = Estado;

            SimulacionInstantanea.Enabled = Estado;
            CantidadDiasTextBox.ReadOnly = !Estado;
            VelocidadProduccionTrackBar.Enabled = !Estado;
            VelocidadAprensadoratrackBar.Enabled = !Estado;
            DetenerSimulacionButton.Enabled = !Estado;
            AjustarNivelesButton.Enabled = !Estado;
        }
        public void AsignarEmbutido(bool EvualuarExpresion = false, bool MarcarNoServible = false)
        {
            embutido = new Embutidos
            {
                Longitud = LongitudEmbutidoRandom(),
                LongitudAprensadora = LongitudAprensadoraRandom(),
                Tipo = Tipo.Servible
            };
            embutido.AsignarWidthEmbutido();
            embutido.AsignarWidthAprensadora();

            if (EvualuarExpresion)
            {
                if ((float)embutido.LongitudAprensadora != (float)embutido.Longitud)
                    embutido.Tipo = Tipo.NoServible;
            }
            if (MarcarNoServible)
                embutido.Tipo = Tipo.NoServible;

            Lista.Add(embutido);
            string Servible = embutido.Tipo == Tipo.NoServible ? "Que no es servible" : "";
            LogTextBox.AppendText($"{System.Environment.NewLine}Se agrego un embutido {embutido.Longitud.ToString()} {Servible}");
            LogTextBox.AppendText($"{System.Environment.NewLine}La Aprensadora es {embutido.LongitudAprensadora.ToString()}");
        }
        void Ejecutar()
        {
            OnTimer.Enabled = true;
            InTimer.Enabled = true;
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

                AsignarEmbutido(true);
                Segundos -= (int)embutido.LongitudTiempo;
            }

            decimal TotalEmbutidos = Lista.Count().ToDecimal();
            decimal Pequenios = Lista.Count(x => x.LongitudTiempo == Enums.LongitudTiempo.Pequeno && x.Tipo == Tipo.Servible).ToDecimal();
            decimal medianos = Lista.Count(x => x.LongitudTiempo == Enums.LongitudTiempo.Mediano && x.Tipo == Tipo.Servible).ToDecimal();
            decimal Grandes = Lista.Count(x => x.LongitudTiempo == Enums.LongitudTiempo.Grande && x.Tipo == Tipo.Servible).ToDecimal();
            decimal NoServible = Lista.Count(x => x.Tipo == Tipo.NoServible).ToDecimal();

            decimal PorcentajePequeno = 0;
            decimal PorcentajeMediano = 0;
            decimal PorcentajeGrande = 0;
            decimal PorcentajeNoServible = 0;

            if (TotalEmbutidos > 0)
            {
                PorcentajePequeno = ((Pequenios / TotalEmbutidos) * 100).ToRound();
                PorcentajeMediano = ((medianos / TotalEmbutidos) * 100).ToRound();
                PorcentajeGrande = ((Grandes / TotalEmbutidos) * 100).ToRound();
                PorcentajeNoServible = ((NoServible / TotalEmbutidos) * 100).ToRound();
            }

            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Pequeño es {PorcentajePequeno}%");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Mediano es {PorcentajeMediano}%");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido Grande es {PorcentajeGrande}%");
            RecomendacionesTextBox.AppendText($"{System.Environment.NewLine}El porcentaje de venta del embutido NoServible es {PorcentajeNoServible}%");

            PequenoLabel.Text = Lista.Count(x => x.LongitudTiempo == Enums.LongitudTiempo.Pequeno).ToString();
            MedianosLabel.Text = Lista.Count(x => x.LongitudTiempo == Enums.LongitudTiempo.Mediano).ToString();
            GrandeLabel.Text = Lista.Count(x => x.LongitudTiempo == Enums.LongitudTiempo.Grande).ToString();
            EmbutidosDanadosLabel.Text = Lista.Count(x => x.LongitudTiempo == Enums.LongitudTiempo.Grande).ToString();

            TotalLabel.Text = Lista.Count().ToString();
            DiasLabel.Text = CantidadDiasTextBox.Text;
            Dictionary<LongitudTiempo, decimal> Diccionario = new Dictionary<LongitudTiempo, decimal>
            {
                { Enums.LongitudTiempo.Pequeno, PorcentajePequeno },
                { Enums.LongitudTiempo.Mediano, PorcentajeMediano },
                { Enums.LongitudTiempo.Grande, PorcentajeGrande }
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
            //Pen myPen = new Pen(Color.Red, 5);
            //e.Graphics.DrawLine(myPen, pt1, pt2);
            Size size = new Size(pt2);
            Rectangle rectangle = new Rectangle(pt1, size);
            e.Graphics.FillRectangle(Brushes.OrangeRed, X, 190, (float)embutido.Width, 100);
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
        private void VelocidadProduccionTrackBar_Scroll(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if (VelocidadProduccionTrackBar.Value == 1)
            {
                Mensaje = "La velocidad es";
                IntervaloTiempo = 10;
                incremento = VelocidadProduccionTrackBar.Value;
                OnTimer.Interval = 100;
            }
            else if (VelocidadProduccionTrackBar.Value == 10)
            {
                Mensaje = "La velocidad es";
                IntervaloTiempo = 0;
                OnTimer.Interval = 1;
                incremento = 10;
            }
            else if (VelocidadProduccionTrackBar.Value > CorreaVelocidadValue)
            {
                Mensaje = "Se Aumento la velocidad a ";
                IntervaloTiempo -= 1;
                OnTimer.Interval -= 10;
                incremento = VelocidadProduccionTrackBar.Value;
            }
            else if (CorreaVelocidadValue > VelocidadProduccionTrackBar.Value)
            {
                Mensaje = "Se Disminuyo la velocidad a";
                IntervaloTiempo += 1;
                OnTimer.Interval += 10;
                incremento = VelocidadProduccionTrackBar.Value;
            }
            LogTextBox.AppendText($"{System.Environment.NewLine}{Mensaje} {incremento.ToString()}");
            VelocidadCorreaLabel.Text = incremento.ToString();
        }
        private void VelocidadProduccionTrackBar_ValueChanged(object sender, EventArgs e)
        {
            CorreaVelocidadValue = VelocidadProduccionTrackBar.Value;
        }

        private void VelocidadAprensadoratrackBar_Scroll(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if (VelocidadAprensadoratrackBar.Value == 1)
            {
                Mensaje = "La velocidad de la aprensadora es";
                incrementoAprensadora = VelocidadAprensadoratrackBar.Value;
                InTimer.Interval = 100;
            }
            else if (VelocidadAprensadoratrackBar.Value == 10)
            {
                Mensaje = "La velocidad de la aprensadora es";
                InTimer.Interval = 1;
                incrementoAprensadora = 10;
            }
            else if (VelocidadAprensadoratrackBar.Value > AprensadoraVelocidadValue)
            {
                Mensaje = "Se Aumento la velocidad de la aprensadora a ";
                InTimer.Interval -= 10;
                incrementoAprensadora = VelocidadAprensadoratrackBar.Value;
            }
            else if (AprensadoraVelocidadValue > VelocidadAprensadoratrackBar.Value)
            {
                Mensaje = "Se Disminuyo la velocidad de la aprensadora a";
                InTimer.Interval += 10;
                incrementoAprensadora = VelocidadAprensadoratrackBar.Value;
            }
            if (X != Y && t.IsAlive)
            {
                Lista.FindLast(x => true).Tipo = Tipo.NoServible;
            }

            LogTextBox.AppendText($"{System.Environment.NewLine}{Mensaje} {incrementoAprensadora.ToString()}");
            ApresadoraNivelLabel.Text = incrementoAprensadora.ToString();
        }

        private void VelocidadAprensadoratrackBar_ValueChanged(object sender, EventArgs e)
        {
            AprensadoraVelocidadValue = VelocidadAprensadoratrackBar.Value;
        }

        private void InTimer_Tick(object sender, EventArgs e)
        {
            Y += 10;
            if (Y == 360)
                Y = 0;

            Invalidate();
        }

        private void AjustarNivelesButton_Click(object sender, EventArgs e)
        {
            X = 0;
            Y = 0;
            VelocidadAprensadoratrackBar.Value = 1;
            VelocidadProduccionTrackBar.Value = 1;
            VelocidadProduccionTrackBar_Scroll(null, null);
            VelocidadAprensadoratrackBar_Scroll(null, null);
        }

        private void EmpezarSimulacionButton_Click(object sender, EventArgs e)
        {
            if (CantidadDiasTextBox.Text.ToInt() > 0)
            {
                Lista = new List<Embutidos>();
                LogTextBox.Text = string.Empty;
                RecomendacionesTextBox.Text = string.Empty;
                LogTextBox.AppendText($"{System.Environment.NewLine}Se inicio la simulación");
                CambiarEstadoControles(false);
                Ejecutar();
                PequenoLabel.Text = "";
                MedianosLabel.Text = "";
                GrandeLabel.Text = "";
                TotalLabel.Text = "";
                EmbutidosDanadosLabel.Text = "";
            }
            else
                MessageBox.Show("Debe especificar un numero de dias");
        }
        private void DetenerSimulacionButton_Click(object sender, EventArgs e)
        {
            IntervaloTiempo = 10;
            OnTimer.Interval = 100;
            InTimer.Interval = 100;
            incremento = 1;
            VelocidadProduccionTrackBar.Value = 1;
            VelocidadAprensadoratrackBar.Value = 1;
            CalculosRecomendaciones();
            CambiarEstadoControles(true);
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
                        AsignarEmbutido(true);

                    e.Graphics.FillRectangle(Brushes.OrangeRed, X, 360, (float)embutido.Width, 100);
                    pt1 = new Point(360, 350);
                    pt2 = new Point(150, 150);
                    //Pen myPen = new Pen(Color.Red, 5);
                    //e.Graphics.DrawLine(myPen, pt1, pt2);
                    Size size = new Size(pt2);
                    Rectangle rectangle = new Rectangle(pt1, size);
                    e.Graphics.FillRectangle(Brushes.OrangeRed, 360, Y, (float)embutido.WidthAprensadora, 100);
                    //DibujarLineaRoja(e);

                    if (X == 360)
                    {
                        X = 0;
                        AsignarEmbutido(true);
                    }
                    PequenoLabel.Text = Lista.Count(x => x.Width == Enums.Width.Pequeno && x.Tipo == Tipo.Servible).ToString();
                    MedianosLabel.Text = Lista.Count(x => x.Width == Enums.Width.Mediano && x.Tipo == Tipo.Servible).ToString();
                    GrandeLabel.Text = Lista.Count(x => x.Width == Enums.Width.Grande && x.Tipo == Tipo.Servible).ToString();
                    EmbutidosDanadosLabel.Text = Lista.Count(x => x.Tipo == Tipo.NoServible).ToString();
                    TotalLabel.Text = (PequenoLabel.Text.ToInt() + MedianosLabel.Text.ToInt() + GrandeLabel.Text.ToInt() + EmbutidosDanadosLabel.Text.ToInt()).ToString();
                }
            }
            catch (Exception) { }
        }
    }

}
