using System;
using System.Net.Configuration;

namespace Saturday_24._11._18
{
    public enum DataFormat
    {
        Gramm, Pound, Pood,
        Metre, Foot, Mile,
        CubicMetre, Gallon, Pint,
        Celsius, Kelvin, Fahrenheit
    }

    public class Checker
    {
        static public DataFormat GetFormat(string system)
        {
            switch (system)
            {
                case "g": return DataFormat.Gramm;
                case "fn": return DataFormat.Pound;
                case "pd": return DataFormat.Pood;
                case "m": return DataFormat.Metre;
                case "feet": return DataFormat.Foot;
                case "miles": return DataFormat.Mile;
                case "m_3": return DataFormat.CubicMetre;
                case "gal": return DataFormat.Gallon;
                case "pinta": return DataFormat.Pint;
                case "C": return DataFormat.Celsius;
                case "K": return DataFormat.Kelvin;
                case "Fn": return DataFormat.Fahrenheit;
                default: throw new ArgumentException("Error! Cannot found of converter!");
            }
        }

        static public bool CheckFormat(DataFormat oldFormat, DataFormat newFormat)
        {
            switch (oldFormat)
            {
                case DataFormat.Gramm:
                case DataFormat.Pound:
                case DataFormat.Pood: return CheckMassFormats(newFormat);
                case DataFormat.Metre:
                case DataFormat.Foot:
                case DataFormat.Mile: return CheckLengthFormats(newFormat);
                case DataFormat.CubicMetre:
                case DataFormat.Gallon:
                case DataFormat.Pint: return CheckVolumeFormats(newFormat);
                case DataFormat.Celsius:
                case DataFormat.Kelvin:
                case DataFormat.Fahrenheit: return CheckTemperatureFormats(newFormat);
                default: return false;
            }
        }

        public static bool CheckMassFormats(DataFormat newFormat)
        {
            switch (newFormat)
            {
                case DataFormat.Gramm:
                case DataFormat.Pound:
                case DataFormat.Pood: return true;
                default: return false;
            }
        }

        public static bool CheckLengthFormats(DataFormat newFormat)
        {
            switch (newFormat)
            {
                case DataFormat.Metre:
                case DataFormat.Foot:
                case DataFormat.Mile: return true;
                default: return false;
            }
        }

        public static bool CheckVolumeFormats(DataFormat newFormat)
        {
            switch (newFormat)
            {
                case DataFormat.CubicMetre:
                case DataFormat.Gallon:
                case DataFormat.Pint: return true;
                default: return false;
            }
        }

        public static bool CheckTemperatureFormats(DataFormat newFormat)
        {
            switch (newFormat)
            {
                case DataFormat.Celsius:
                case DataFormat.Kelvin:
                case DataFormat.Fahrenheit: return true;
                default: return false;
        }
        }
    }
}
