using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Elevador.Enums;

namespace Elevador
{
    public class ImagenPersona 
    {
        public int Id { get; set; }
        public decimal Peso { get; set; }
        public Pisos PisoOrigen { get; set; }
        public Pisos PisoDireccion { get; set; }
        public PictureBox PictureBox{ get; set; }

        public ImagenPersona(int id, decimal peso, Pisos pisoOrigen, Pisos pisoDireccion, PictureBox pictureBox)
        {
            Id = id;
            Peso = peso;
            PisoOrigen = pisoOrigen;
            PisoDireccion = pisoDireccion;
            PictureBox = pictureBox ?? throw new ArgumentNullException(nameof(pictureBox));
        }

        public ImagenPersona()
        {
            Id = 0;
            PisoOrigen = Pisos.SinPiso;
            PisoDireccion = Pisos.SinPiso;
            Peso = 0;
            PictureBox = new PictureBox();
        }
    }
}
