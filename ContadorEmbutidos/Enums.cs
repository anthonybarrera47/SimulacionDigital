using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorEmbutidos
{
    class Enums
    {
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
            Grande = 300,
            NoServible = 400
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
        public enum AprensadoraLongitud
        {
            Pequeno = 1,
            Mediano = 2,
            Grande = 3
        }
        public enum AprensadoraWidth
        {
            Pequeno = 100,
            Mediano = 200,
            Grande = 300
        }
        public enum Tipo
        {
            Servible,
            NoServible
        }
        public static int GetRandom(int IntervaloA,int IntervaloB)
        {
            var guid = Guid.NewGuid();
            var justNumbers = new string(guid.ToString().Where(char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            Random random = new Random(seed);
            return random.Next(IntervaloA, IntervaloB);
        }
        public static Longitud LongitudEmbutidoRandom()
        {
            return (Longitud)GetRandom(1,4);
        }
        public static AprensadoraLongitud LongitudAprensadoraRandom()
        {
            return (AprensadoraLongitud)GetRandom(1, 4);
        }
    }
}
