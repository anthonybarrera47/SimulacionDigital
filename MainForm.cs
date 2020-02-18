using Extensores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimulacionDigital
{
    public partial class MainForm : Form
    {
        public int Row { get; set; }
        public int Repeticiones { get; set; }
        public MainForm()
        {
            InitializeComponent();
            DGV.AutoGenerateColumns = false;
        }
        public void ColocacionValores(int Length, ref int[] arrayvalores, ref decimal[] Probabilidad)
        {
            for (int i = 0; i < Length; i++)
            {
                arrayvalores[i] = i + 1;
                Probabilidad[i] = (1M / Length).ToDecimal().ToRound();
            }
        }
        public List<decimal> CalcularPeso(decimal[] Probabilidad)
        {
            return Probabilidad.Aggregate((IEnumerable<decimal>)new List<decimal>(),
                       (x, i) => x.Concat(new[] { x.LastOrDefault() + i })).ToList();
        }
        public void CalcularProbabilidad(int[] ArrayValores, int Length, decimal[] Probabilidad, bool[] Marcados)
        {
            DGV.Rows.Clear();
            Repeticiones = CantidadRepeticiones.Text.ToInt();


            ColocacionValores(Length, ref ArrayValores, ref Probabilidad);

            DistribuirProbabilidadSobrante(ref Probabilidad, Marcados);

            List<decimal> pesosAcumulados = CalcularPeso(Probabilidad);

            int[] resultadoaleatorio = new int[Length];

            EjectutarRandom(ref resultadoaleatorio, pesosAcumulados, Repeticiones, Probabilidad);

            Calcular(Length, resultadoaleatorio, Probabilidad, Marcados);

        }
        private void DistribuirProbabilidadSobrante(ref decimal[] dcm, bool[] Marcados)
        {
            decimal ProbabilidadTotal = dcm.Sum();
            decimal excedente = ProbabilidadTotal - 1M;
            int Length = dcm.Length;
            if (excedente != 0)
            {
                int i = Length - 1;
                while (excedente > 0)
                {
                    if (i < 0)
                        i = Length - 1;
                    if (excedente > 0)
                    {
                        if (!Marcados[i])
                        {
                            dcm[i] -= 0.01M;
                            excedente -= 0.01M;
                        }

                    }
                    else
                        break;

                    i--;
                }
            }
        }
        public void EjectutarRandom(ref int[] ResultadoAleatorio, List<decimal> PesoAcumulado, int Repeticiones, decimal[] Probabilidad)
        {
            Random random = new Random();   
            decimal Intervalo = 0;
            int posicionArray = 0;
            for (int i = 0; i < Repeticiones; i++)
            {
                Intervalo = random.NextDouble().ToDecimal() * Probabilidad.Sum();
                posicionArray = PesoAcumulado.IndexOf(PesoAcumulado.Where(x => x > Intervalo).FirstOrDefault());
                ResultadoAleatorio[posicionArray]++;
            }
        }
        public void Calcular(int Length, int[] resultadoaleatorio, decimal[] Probabilidad, bool[] Marcados)
        {
            DGV.Rows.Clear();
            decimal Porcentaje = 0;
            decimal lb1 = 0, lb2 = 0, lb3 = 0;
            for (int i = 0; i < Length; i++)
            {
                Porcentaje = (resultadoaleatorio[i] * 100M / Repeticiones) / 100.0M;

                ValorProbabilidad valorProbabilidad = new ValorProbabilidad
                {
                    Valor = i + 1,
                    Probabilidad = Probabilidad[i].ToRound(),
                    VecesRepetidas = resultadoaleatorio[i],
                    pct = Porcentaje,
                    Marcado = Marcados[i]
                };
                lb1 += valorProbabilidad.Probabilidad;
                lb2 += valorProbabilidad.VecesRepetidas;
                lb3 += valorProbabilidad.pct;
                AddDetalle(valorProbabilidad);
            }
            ProbabilidadLB.Text = lb1.ToString();
            VecesRepetidaLb.Text = lb2.ToString();
            PorcentajeLB.Text = lb3.ToString();
        }
        public void AddDetalle(ValorProbabilidad valorProbabilidad)
        {
            DGV.Rows.Add(valorProbabilidad.Valor, valorProbabilidad.Probabilidad, valorProbabilidad.VecesRepetidas, valorProbabilidad.pct, valorProbabilidad.Marcado);
        }
        public void RecalcularProbabilidad()
        {
            decimal Probabilidad = 1M;
            int TotalElementos = DGV.Rows.Count - 1;
            int i = 0;
            Probabilidad -= DGV.Rows[Row].Cells["Probabilidad"].Value.ToDecimal();
            foreach (DataGridViewRow item in DGV.Rows)
            {
                if (item.Index == Row)
                {
                    i++;
                    continue;
                }
                DataGridViewCheckBoxCell a = DGV.Rows[i].Cells["Marcado"] as DataGridViewCheckBoxCell;
                if (!a.Value.ToBoolean())
                {
                    DGV.Rows[i].Cells["Probabilidad"].Value = Probabilidad / TotalElementos.ToDecimal();
                }
                i++;
            }
            decimal[] prob = new decimal[DGV.Rows.Count];
            bool[] Marcados = new bool[DGV.Rows.Count];
            i = 0;

            foreach (DataGridViewRow item in DGV.Rows)
            {
                prob[i] = DGV.Rows[i].Cells["Probabilidad"].Value.ToDecimal();
                Marcados[i] = DGV.Rows[i].Cells["Marcado"].Value.ToBoolean();
                i++;
            }

            List<decimal> pesosAcumulados = CalcularPeso(prob);
            int[] resultadoaleatorio = new int[CantidadElemento.Text.ToInt()];

            DistribuirProbabilidadSobrante(ref prob, Marcados);
            EjectutarRandom(ref resultadoaleatorio, pesosAcumulados, Repeticiones, prob);
            Calcular(CantidadElemento.Text.ToInt(), resultadoaleatorio, prob, Marcados);
        }
        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int[] ArrayValores = new int[CantidadElemento.Text.ToInt()];
            int Length = ArrayValores.Length;
            decimal[] Probabilidad = new decimal[Length];
            bool[] Marcados = new bool[Length];

            CalcularProbabilidad(ArrayValores, Length, Probabilidad, Marcados);
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Row = e.RowIndex;
        }
        private void AumentarProbabilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DGV.Rows[Row].Cells["Probabilidad"].Value = AumentarProbabilidad.Text.ToDecimal();
                RecalcularProbabilidad();
            }
        }
    }
    public class ValorProbabilidad
    {
        public int Valor { get; set; }
        public decimal Probabilidad { get; set; }
        public decimal VecesRepetidas { get; set; }
        public decimal pct { get; set; }
        public bool Marcado { get; set; }

    }
}
