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


namespace Parqueos
{
    public partial class MainForm : Form
    {
        public List<Parqueo> Parqueos;
        public List<Vehiculo> Vehiculos;
        public MainForm()
        {
            InitializeComponent();
            DGV.AutoGenerateColumns = false;
            Parqueos = new List<Parqueo>();
            Vehiculos = new List<Vehiculo>();
            IniciarParqueos();
        }
        public void IniciarParqueos()
        {
            for (int i = 0; i < 4; i++)
            {
                Parqueos.Add(new Parqueo(i + 1, 0, EstadoRandom(), new Vehiculo()));
            }
            Parqueos.ForEach(x => x.Probabilidad = 1M / Parqueos.Count(y => y.Estados != Estado.Ocupado));
            for (int i = 0; i < 12; i++)
            {
                Vehiculos.Add(new Vehiculo(i + 1, EstadoVehiculo.SinParquear));
            }
            DGV.Rows.Clear();
            foreach (var item in Parqueos)
            {
                AddDetalle(item);
            }
        }
        public void AddDetalle(Parqueo item)
        {
            DGV.Rows.Add(item.Numero, item.Probabilidad, item.Estados.ToString(), item.Vehiculo.Numero);
        }
        public bool HayParqueoLibre()
        {
            return Parqueos.Any(x => x.Estados == Estado.Libre || x.Estados == Estado.OcupadoFake);
        }
        private void EmpezarSimulacion_Click(object sender, EventArgs e)
        {
            GC.Collect();
            EstadotextBox.Clear();
            int CantidadCasos = CantidadCasosTextBox.Text.ToInt();
            int iterador = 0;
            StringBuilder stb = new StringBuilder();

            for (int j = 0; j < CantidadCasos; j++)
            {
                GC.Collect();
                if (HayParqueoLibre())
                {
                    if (iterador == Vehiculos.Count() - 1)
                        iterador = 0;

                    Vehiculo vehiculo = Vehiculos.ElementAt(iterador);

                    stb.AppendLine("Caso: " + (j + 1));
                    stb.AppendLine("Vehiculo: " + (iterador + 1));
                    stb.AppendLine("\tTomo la calle: " + CalleRandom().Numero);
                    for (int x = 0; x < 4; x++)
                    {
                        GC.Collect();
                        Parqueo parqueo = Parqueos.ElementAt(x);
                        stb.AppendLine($"\t\tPaso al parqueo:{(x + 1)} y estaba {parqueo.Estados.ToString()}");

                        if (parqueo.Estados == Estado.Libre)
                        {
                            stb.AppendLine($"\t\tEntro al parqueo al {x + 1}");
                            Parqueos.ElementAt(x).Estados = Estado.Ocupado;
                            Vehiculos.ElementAt(iterador).Estado = EstadoVehiculo.Parqueado;
                            Parqueos.ElementAt(x).Vehiculo = Vehiculos.ElementAt(iterador);
                            break;
                        }
                        else
                        {
                            if (x + 1 == 4)
                                stb.AppendLine($"\t\tNo encontro parqueo y se fue");
                            else
                                stb.AppendLine($"\t\tPaso al siguiente parqueo");
                        }
                    }
                    iterador++;
                    CambiarEstado();
                }
                else
                {
                    stb.AppendLine("No hay parqueo libre, la simulacion ha terminado");
                    break;
                }
                
            }
            if (HayParqueoLibre())
            {
                stb.AppendLine("Quedaron libre los parqueos");
                for (int x = 0; x < Parqueos.Count(); x++)
                {
                    if (Parqueos[x].Estados == Estado.Libre || Parqueos[x].Estados == Estado.OcupadoFake)
                        stb.AppendLine($"{Parqueos.ElementAt(x).Numero}");
                }
            }
            EstadotextBox.Text = stb.ToString();
            DGV.Columns["Vehiculo"].Visible = true;
        }
        public void CambiarEstado()
        {
            GC.Collect();
            List<Parqueo> parqueosFake = Parqueos;

            for (int i = 0; i < parqueosFake.Count(); i++)
            {
                Parqueo parqueo = parqueosFake.ElementAt(i);
                if (parqueo.Estados != Estado.Ocupado)
                    parqueosFake.ElementAt(i).Estados = EstadoRandom();
            }
            Parqueos = parqueosFake;
            DGV.Rows.Clear();
            foreach (var item in Parqueos)
                AddDetalle(item);
        }
        public Estado EstadoRandom()
        {
            GC.Collect();
            var seed = Environment.TickCount;
            Random random = new Random(seed);
            int a = random.Next(0, 2);
            return (Estado)a;
        }
        public Calle CalleRandom()
        {
            GC.Collect();
            var seed = Environment.TickCount;
            Calle c = new Calle();
            Random random = new Random(seed);
            int a = random.Next(1, 4);
            c.Numero = a;
            return c;
        }

        private void Reiniciarbutton_Click(object sender, EventArgs e)
        {
            this.Parqueos = new List<Parqueo>();
            this.Vehiculos = new List<Vehiculo>();
            EstadotextBox.Clear();
            IniciarParqueos();
        }
    }
    public enum Estado
    {
        Libre = 0,
        OcupadoFake = 1,
        Ocupado = 2

    }
    public enum EstadoVehiculo
    {
        SinParquear = 0,
        Parqueado = 1
    }
    public class Calle
    {
        public int Numero { get; set; }

        public Calle(int numero)
        {
            Numero = numero;
        }
        public Calle()
        {
            Numero = 0;
        }
    }
    public class Vehiculo
    {
        public int Numero { get; set; }
        public EstadoVehiculo Estado { get; set; }

        public Vehiculo()
        {
            Numero = 0;
            Estado = EstadoVehiculo.SinParquear;
        }

        public Vehiculo(int numero, EstadoVehiculo estado)
        {
            Numero = numero;
            Estado = estado;
        }
    }
    public class Parqueo
    {
        public int Numero { get; set; }
        public decimal Probabilidad { get; set; }
        public Estado Estados { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public Parqueo(int numero, decimal probabilidad, Estado estados, Vehiculo vehiculo)
        {
            Numero = numero;
            Probabilidad = probabilidad;
            Estados = estados;
            Vehiculo = vehiculo ?? throw new ArgumentNullException(nameof(vehiculo));
        }
        public Parqueo()
        {
            Numero = 0;
            Probabilidad = 0;
            Estados = Estado.Libre;
            Vehiculo = new Vehiculo();
        }
    }
}
