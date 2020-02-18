﻿ using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Extensores
{
    public static class Extensores
    { 
        public static bool EsNulo(this object obj)
        {
            return obj == null;
        }
        public static decimal ToRound(this decimal dcm)
        {
            return Math.Round(dcm, 2);
        }
        public static int ToInt(this object obj)
        {
            if (obj.EsNulo())
                return 0;
            int.TryParse(obj.ToString(), out int value);
            return value;
        }
        public static decimal ToDecimal(this object obj)
        {
            if (obj.EsNulo())
                return 0;
            decimal.TryParse(obj.ToString(), out decimal value);
            return value;
        }
        public static double ToDouble(this object obj)
        {
            if (obj.EsNulo())
                return 0;
            double.TryParse(obj.ToString(), out double value);
            return value;
        }
        public static float ToFloat(this object obj)
        {
            if (obj.EsNulo())
                return 0;
            float.TryParse(obj.ToString(), out float value);
            return value;
        }
        public static bool ToBoolean(this object obj)
        {
            if (obj.EsNulo())
                return false;
            bool.TryParse(obj.ToString(), out bool value);
            return value;
        }
        public static DateTime ToDatetime(this object obj)
        {
            DateTime.TryParse(obj.ToString(), out DateTime value);
            return value;
        }
        static readonly string FECHA_FORMAT = "yyyy-MM-dd";
        public static string ToFormatDate(this DateTime dateTime)
        {
            return dateTime.ToString(FECHA_FORMAT);
        }
        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));

                        if (memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() is DescriptionAttribute descriptionAttribute)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }
            return null; // could also return string.Empty
        }
        public static T ViewStateToEntity<T>(this object viewState)
        {
            try
            {
                return (T)Convert.ChangeType(viewState, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default;
            }
        }
        public static string EliminarEspaciosEnBlanco(this string Cadena)
        {
            Cadena = Cadena.Trim();
            while (Cadena.Contains(" "))
            {
                Cadena = Cadena.Replace(" ", "");
            }
            return Cadena;
        }
    }

}

