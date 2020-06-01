using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ContadorEmbutidos.Enums;

namespace ContadorEmbutidos
{
    class Embutidos
    {
        public Longitud Longitud { get; set; }
        public Width Width { get; set; }
        public Precio Precio { get; set; }
        public LongitudTiempo LongitudTiempo { get; set; }
        public AprensadoraLongitud LongitudAprensadora { get; set; }
        public AprensadoraWidth WidthAprensadora { get; set; }
        public Tipo Tipo { get; set; }
        public Embutidos()
        {
            Longitud = Longitud.Pequeno;
            Width = Width.Pequeno;
            Precio = Precio.Pequeno;
            LongitudTiempo = LongitudTiempo.Pequeno;
            LongitudAprensadora = AprensadoraLongitud.Pequeno;
            WidthAprensadora = AprensadoraWidth.Pequeno;
            Tipo = Tipo.Servible;
        }

        public Embutidos(Longitud longitud, Width width, Precio precio, LongitudTiempo longitudTiempo, AprensadoraLongitud longitudAprensadora, AprensadoraWidth widthAprensadora, Tipo tipo)
        {
            Longitud = longitud;
            Width = width;
            Precio = precio;
            LongitudTiempo = longitudTiempo;
            LongitudAprensadora = longitudAprensadora;
            WidthAprensadora = widthAprensadora;
            Tipo = tipo;
        }

        public void AsignarWidthEmbutido()
        {
            if (Longitud == Longitud.Pequeno)
                Width = Width.Pequeno;
            else if (Longitud == Longitud.Mediano)
                Width = Width.Mediano;
            else if (Longitud == Longitud.Grande)
                Width = Width.Grande;
        }
        public void AsignarWidthAprensadora()
        {
            if (LongitudAprensadora == AprensadoraLongitud.Pequeno)
                WidthAprensadora = AprensadoraWidth.Pequeno;
            else if (LongitudAprensadora == AprensadoraLongitud.Mediano)
                WidthAprensadora = AprensadoraWidth.Mediano;
            else if (LongitudAprensadora == AprensadoraLongitud.Grande)
                WidthAprensadora = AprensadoraWidth.Grande;
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
