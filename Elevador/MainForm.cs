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
using static Elevador.Enums;

namespace Elevador
{
    public partial class MainForm : Form
    {
        List<Button> ListaBotones = new List<Button>();
        List<ImagenPersona> Lista = new List<ImagenPersona>();
        List<ImagenPersona> ListaSalida = new List<ImagenPersona>();
        ImagenPersona PersonaGlobal = new ImagenPersona();
        Button ButtonGlobal = new Button();
        Pisos AquePiso;
        Pisos PisoActual;
        int i = 0;
        int Id = 0;
        int DecrementoEnY = -10;
        decimal PesoTotalAcumulado = 0;
        decimal PesoTotal = 1000;
        Point PointPersona = new Point();
        Point PointAscensor = new Point();
        bool MoverAscensor = false;
        bool MoverPersonas = false;
        bool CapturarGente = false;
        public MainForm()
        {
            InitializeComponent();
            OnTimer.Stop();
            PointPersona = PrimeraPersonaPictureBox.Location;
            PointAscensor = AscensorPictureBox.Location;

            AgregarImagenes(PrimeraPersonaPictureBox, "Piso1", 9);
            AgregarImagenes(SegundaPersonaPictureBox, "Piso2", 4);
            AgregarImagenes(TerceraPersonaPictureBox, "Piso3", 4);
            AgregarImagenes(CuartaPersonaPictureBox, "Piso4", 4);

            ImagenPersona imagenPersona = new ImagenPersona
            {
                PictureBox = PrimeraPersonaPictureBox,
                PisoOrigen = Pisos.PrimerPiso,
                Id = Lista.Count() + 1,
                Peso = ObtenerPesoRandom()
            };
            Lista.Add(imagenPersona);

            imagenPersona = new ImagenPersona
            {
                PictureBox = SegundaPersonaPictureBox,
                PisoOrigen = Pisos.SegundoPiso,
                Id = Lista.Count() + 1,
                Peso = ObtenerPesoRandom()
            };
            Lista.Add(imagenPersona);

            imagenPersona = new ImagenPersona
            {
                PictureBox = TerceraPersonaPictureBox,
                PisoOrigen = Pisos.TercerPiso,
                Id = Lista.Count() + 1,
                Peso = ObtenerPesoRandom()
            };
            Lista.Add(imagenPersona);

            imagenPersona = new ImagenPersona
            {
                PictureBox = CuartaPersonaPictureBox,
                PisoOrigen = Pisos.CuartoPiso,
                Id = Lista.Count() + 1,
                Peso = ObtenerPesoRandom()
            };
            Lista.Add(imagenPersona);
            ListaBotones.Add(PrimerPisoButton);
            ListaBotones.Add(SegundoPisoButton);
            ListaBotones.Add(TercerPisoButton);
            ListaBotones.Add(CuartoPisoButton);

        }
        public void AnimarImagen(PictureBox Imagen)
        {
            i++;
            if (i == 0)
                Imagen.Image = Elevador.Properties.Resources.Image0;
            if (i == 1)
                Imagen.Image = Elevador.Properties.Resources.Image1;
            if (i == 2)
                Imagen.Image = Elevador.Properties.Resources.Image2;
            if (i == 3)
                Imagen.Image = Elevador.Properties.Resources.Image3;
            if (i == 4)
                i = 0;
        }

        private void OnTimer_Tick(object sender, EventArgs e)
        {
            if (Lista.Sum(x => x.Peso) <= 0)
                OnTimer.Stop();

            if (CapturarGente)
            {
                PesoTotalAcumulado = ListaSalida.Sum(x => x.Peso);
                PersonaGlobal = ObtenerImagenPorPisoControles(PisoActual) ?? new ImagenPersona();
                if (PesoTotalAcumulado + PersonaGlobal.Peso >= PesoTotal)
                {
                    StateTextBox.AppendText($"La persona que intento ingresar tenia {PersonaGlobal.Peso} sobrepasando el limite con {(PesoTotalAcumulado + PersonaGlobal.Peso) - PesoTotal} {Environment.NewLine}");
                    CambiarLabel("Ascensor Lleno.", Color.White, Color.Red);
                    CapturarGente = false;
                    MoverAscensor = true;
                    ListaBotones.ForEach(x => x.Enabled = true);
                    ObtenerButton(PisoActual).Enabled = false;
                }
                else
                {
                    PersonaGlobal.PisoDireccion = AquePiso;
                    if (PersonaGlobal.Id != 0)
                    {
                        if (!ListaSalida.Exists(x => x.Id == PersonaGlobal.Id))
                            ListaSalida.Add(PersonaGlobal);
                    }
                    else
                        ListaSalida.Add(new ImagenPersona() { PisoDireccion = AquePiso, Peso = 0 });

                    StateTextBox.AppendText($"Peso Agregado {PersonaGlobal.Peso} {Environment.NewLine}");
                    CantidadPersonasLabel.Text = ListaSalida.Count(x => x.Peso > 0).ToString();
                    PesoElevadorLabel.Text = ListaSalida.Sum(x => x.Peso).ToString();
                    CapturarGente = false;
                    MoverPersonas = true;
                    MoverAscensor = false;
                    CambiarLabel("Esperando que seleccione un piso", Color.White, Color.Green);
                }
            }
            if (MoverPersonas)
            {
                AnimarImagen(PersonaGlobal.PictureBox);
                if (MoverPersonaHorizontal(PersonaGlobal.PictureBox, 25))
                {
                    AsignarPosicionPersona(PersonaGlobal.PictureBox);
                    if (PesoTotalAcumulado <= PesoTotal)
                    {
                        CapturarGente = false;
                        MoverPersonas = false;

                        if (ListaSalida.Count(x => x.PisoOrigen == PisoActual) == Lista.Count(x => x.PisoOrigen == PisoActual))
                        {
                            MoverPersonas = false;
                            MoverAscensor = true;
                        }
                        else
                        {
                            ListaBotones.ForEach(x => x.Enabled = true);
                            ObtenerButton(PisoActual).Enabled = false;
                        }
                        CambiarLabel("Esperando que seleccione un piso", Color.White, Color.Green);
                    }
                    else
                    {
                        MoverPersonas = false;
                        MoverAscensor = true;
                    }
                }
                else
                    CambiarLabel("Persona en movimiento", Color.Black, Color.Yellow);
            }
            if (MoverAscensor)
            {
                if ((int)PisoActual <= (int)AquePiso)
                {
                    Pisos ppp;
                    if (ListaSalida.Count == 0)
                        ppp = AquePiso;
                    else
                        ppp = ListaSalida.FirstOrDefault().PisoDireccion;
                    if (!MoverAscensorArriba(ppp))
                    {
                        MoverPersonaVertical(ListaSalida, DecrementoEnY);
                        MoverAscensorVertical(DecrementoEnY);
                        CambiarLabel("Ascensor en movimiento, no presione nada", Color.White, Color.Red);
                    }
                    else
                    {
                        ListaBotones.ForEach(x => x.Enabled = true);
                        ObtenerButton(PisoActual).Enabled = false;
                        CambiarLabel("Esperando que seleccione un piso", Color.White, Color.Green);
                    }
                }                else
                {
                    Pisos ppp;
                    if (ListaSalida.Count == 0)
                        ppp = AquePiso;
                    else
                        ppp = ListaSalida.FirstOrDefault().PisoDireccion;

                    if (!MoverAscensorAbajo(ppp))
                    {
                        MoverPersonaVertical(ListaSalida, DecrementoEnY);
                        MoverAscensorVertical(DecrementoEnY);
                        CambiarLabel("Ascensor en movimiento, no presione nada", Color.White, Color.Red);
                    }
                    else
                    {
                        ListaBotones.ForEach(x => x.Enabled = true);
                        ObtenerButton(PisoActual).Enabled = false;
                        CambiarLabel("Esperando que seleccione un piso", Color.White, Color.Green);
                    }
                }

            }

            Invalidate();
        }
        public bool PersonaLLegoAscensor(PictureBox Persona)
        {
            return Persona.Location.X >= AscensorPictureBox.Location.X;
        }
        public Point ObtenerPointPiso(Pisos Piso)
        {
            Point Point = new Point();

            switch (Piso)
            {
                case Pisos.PrimerPiso:
                    Point = PrimerPisoPictureBox.Location;
                    break;
                case Pisos.SegundoPiso:
                    Point = SegundoPisoPictureBox.Location;
                    break;
                case Pisos.TercerPiso:
                    Point = TercerPisoPictureBox.Location;
                    break;
                case Pisos.CuartoPiso:
                    Point = CuartorPisoPictureBox.Location;
                    break;
            }
            return Point;
        }
        public PictureBox NivelEdificio(Pisos Piso)
        {
            PictureBox RetornoPicture = new PictureBox();
            switch (Piso)
            {
                case Pisos.PrimerPiso:
                    RetornoPicture = PrimerPisoPictureBox;
                    break;
                case Pisos.SegundoPiso:
                    RetornoPicture = SegundoPisoPictureBox;
                    break;
                case Pisos.TercerPiso:
                    RetornoPicture = TercerPisoPictureBox;
                    break;
                case Pisos.CuartoPiso:
                    RetornoPicture = CuartorPisoPictureBox;
                    break;
            }
            return RetornoPicture;
        }
        public void AgregarImagenes(PictureBox picture, string Piso, int CantidadImagenes)
        {
            ImagenPersona ImagenPerson;
            Point PisoLocation = picture.Location;
            for (int i = 1; i <= CantidadImagenes; i++)
            {
                Id++;
                ImagenPerson = new ImagenPersona();
                PisoLocation.X += picture.Size.Width;
                ImagenPerson.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                ImagenPerson.PictureBox.Size = picture.Size;
                ImagenPerson.PictureBox.Image = picture.Image;
                ImagenPerson.PictureBox.Location = PisoLocation;
                ImagenPerson.PisoOrigen = ObtenerPiso(Piso.Last().ToInt());
                ImagenPerson.PictureBox.Name = $"Persona{Piso}{i}";
                ImagenPerson.Id = Id;
                ImagenPerson.Peso = ObtenerPesoRandom();
                Lista.Add(ImagenPerson);
                Controls.Add(ImagenPerson.PictureBox);
            }
            this.Refresh();
        }
        public Pisos ObtenerPiso(int Piso)
        {
            Pisos ValorRetornar = Pisos.PrimerPiso;

            switch (Piso)
            {
                case 1:
                    ValorRetornar = Pisos.PrimerPiso;
                    break;
                case 2:
                    ValorRetornar = Pisos.SegundoPiso;
                    break;
                case 3:
                    ValorRetornar = Pisos.TercerPiso;
                    break;
                case 4:
                    ValorRetornar = Pisos.CuartoPiso;
                    break;
            }
            return ValorRetornar;
        }
        public bool MoverAscensorArriba(Pisos piso)
        {
            PictureBox PisoParada = NivelEdificio(piso);
            if (AscensorPictureBox.Location.Y <= PisoParada.Location.Y)
            {
                ImagenPersona ImagenInterna = Lista.Find(x => x.PisoDireccion == piso) ?? new ImagenPersona();
                ImagenPersona ImagenSinPiso = ListaSalida.Find(x => x.PisoOrigen == Pisos.SinPiso) ?? new ImagenPersona();
                PointAscensor.Y = PisoParada.Location.Y;
                AscensorPictureBox.Location = PointAscensor;
                MoverAscensor = false;
                if (ImagenInterna.Id > 0)
                {
                    StateTextBox.AppendText($"Salieron {ListaSalida.Where(x => x.PisoDireccion == piso).ToList().Count() } personas del elevador{Environment.NewLine}");
                    EliminarControles(ListaSalida.Where(x => x.PisoDireccion == piso).ToList());
                }
                ListaSalida.RemoveAll(x => x.PisoDireccion == piso);
                PisoActual = piso;
                Lista.RemoveAll(x => x.PisoDireccion == piso);
                ListaSalida.Remove(ImagenSinPiso);
                CambiarLabel("Esperando que seleccione un piso", Color.White, Color.Green);
                CantidadPersonasLabel.Text = ListaSalida.Count(x => x.Peso > 0).ToString();
                PesoElevadorLabel.Text = ListaSalida.Sum(x => x.Peso).ToString();
                return true;
            }
            return false;
        }
        public bool MoverAscensorAbajo(Pisos piso)
        {
            PictureBox PisoParada = NivelEdificio(piso);
            if (AscensorPictureBox.Location.Y >= PisoParada.Location.Y)
            {
                ImagenPersona ImagenInterna = Lista.Find(x => x.PisoDireccion == piso) ?? new ImagenPersona();
                PointAscensor.Y = PisoParada.Location.Y;
                AscensorPictureBox.Location = PointAscensor;
                MoverAscensor = false;

                if (ImagenInterna.Id > 0)
                {
                    StateTextBox.AppendText($"Salieron {ListaSalida.Where(x => x.PisoDireccion == piso).ToList().Count() } personas del elevador{Environment.NewLine}");
                    EliminarControles(ListaSalida.Where(x => x.PisoDireccion == piso).ToList());
                }

                Lista.Remove(Lista.Find(x => x.PisoDireccion == piso));
                PisoActual = piso;
                ListaSalida.RemoveAll(x => x.PisoDireccion == piso);
                ListaSalida.RemoveAll(x=>x.PisoDireccion==Pisos.SinPiso);
                CambiarLabel("Esperando que seleccione un piso", Color.White, Color.Green);

                CantidadPersonasLabel.Text = ListaSalida.Count(x => x.Peso > 0).ToString();
                PesoElevadorLabel.Text = ListaSalida.Sum(x => x.Peso).ToString();
                return true;
            }
            return false;
        }
        public bool MoverPersonaHorizontal(PictureBox Persona, int X)
        {
            if (!PersonaLLegoAscensor(Persona))
            {
                PointPersona.X += X;
                Persona.Location = PointPersona;
                return false;
            }
            else
                return true;
        }
        public void MoverPersonaVertical(List<ImagenPersona> Movibles, int Y)
        {
            PointPersona.Y += Y;
            PointPersona.X = AscensorPictureBox.Location.X;
            Movibles.ForEach(x => x.PictureBox.Location = PointPersona);
        }
        public void MoverAscensorVertical(int Y)
        {
            PointAscensor.Y += Y;
            AscensorPictureBox.Location = PointAscensor;
        }
        public void AsignarPosicionPersona(PictureBox Persona)
        {
            PointPersona.X = AscensorPictureBox.Location.X;
            Persona.Location = PointPersona;
            Persona.Image = Elevador.Properties.Resources.Image0;
            PointPersona.X = 0;
            i = 0;
        }
        public ImagenPersona ObtenerImagenPorPisoControles(Pisos Piso)
        {
            return Lista.Find(x => x.PisoOrigen == Piso && x.PisoDireccion == Pisos.SinPiso);
        }
        public void EliminarControles(List<ImagenPersona> Lista)
        {
            foreach (var item in Lista)
            {
                ImagenPersona imagenPersona = Lista.Find(x => x.Id == item.Id);
                Controls.RemoveByKey(imagenPersona.PictureBox.Name);
            }
        }
        public decimal ObtenerPesoRandom()
        {
            int Valor = GetRandom(100, 250);
            return Valor.ToDecimal();
        }
        public static int GetRandom(int IntervaloA, int IntervaloB)
        {
            var guid = Guid.NewGuid();
            var justNumbers = new string(guid.ToString().Where(char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            Random random = new Random(seed);
            return random.Next(IntervaloA, IntervaloB);
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            if (PesoTotalTextBox.Text.ToDecimal() <= 0)
            {
                MessageBox.Show("Ingrese un peso superior a 0", "AnWil Elevadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            IniciarButton.Enabled = false;
            MoverPersonas = false;
            Lista = Lista.OrderBy(x => x.PisoOrigen).ToList();
            PrimerPisoButton.Enabled = false;
            PisoActual = Pisos.PrimerPiso;
            PesoTotal = PesoTotalTextBox.Text.ToDecimal();
            PesoTotalTextBox.Enabled = false;
            OnTimer.Start();
            CambiarLabel("Esperando que seleccione un piso", Color.White, Color.Green);
        }
        public void CapturarPersona(Pisos piso)
        {
            PersonaGlobal = ObtenerImagenPorPisoControles(piso);
        }
        void CapturarPiso(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string Piso = button.Name;
            ListaBotones.ForEach(x => x.Enabled = (x != button));

            switch (Piso)
            {
                case "PrimerPisoButton":
                    AquePiso = Pisos.PrimerPiso;
                    break;
                case "SegundoPisoButton":
                    AquePiso = Pisos.SegundoPiso;
                    break;
                case "TercerPisoButton":
                    AquePiso = Pisos.TercerPiso;
                    break;
                case "CuartoPisoButton":
                    AquePiso = Pisos.CuartoPiso;
                    break;
            }
            if ((int)PisoActual > (int)AquePiso)
                DecrementoEnY = 10;
            else
                DecrementoEnY = -10;
            CapturarGente = true;
        }
        public Button ObtenerButton(Pisos pisos)
        {
            Button button = new Button();

            switch (pisos)
            {
                case Pisos.PrimerPiso:
                    button = PrimerPisoButton;
                    break;
                case Pisos.SegundoPiso:
                    button = SegundoPisoButton;
                    break;
                case Pisos.TercerPiso:
                    button = TercerPisoButton;
                    break;
                case Pisos.CuartoPiso:
                    button = CuartoPisoButton;
                    break;
            }
            return button;
        }
        public void CambiarLabel(string Text, Color ForeColor, Color BackColor)
        {
            EstadoAscensorlabel.Text = Text;
            EstadoAscensorlabel.ForeColor = ForeColor;
            EstadoAscensorlabel.BackColor = BackColor;
        }
    }
}
