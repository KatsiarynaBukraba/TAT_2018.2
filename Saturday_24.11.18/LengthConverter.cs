using System;

namespace Saturday_24._11._18
{
    public class LengthConverter : Converter
    {
        private static LengthConverter converter;
        
        private LengthConverter() { }

        public static LengthConverter GetConverter()
        {
            if (converter == null)
                converter = new LengthConverter();

            return converter;
        }

        public override decimal ConvertToSI(decimal value, DataFormat format)
        {
            switch (format)
            {
                case DataFormat.Metre: Value = value; break;
                case DataFormat.Foot: Value = value * 0.3048m; break;
                case DataFormat.Mile: Value = value * 1609.34m; break;
                default: throw new FormatException("Error Format! Length conversion is not possible.");
            }

            if (Value < 0)
            {
                throw new Exception("Incorrect data!");
            }

            return Value;
        }

        public override decimal Convert(decimal value, DataFormat oldFormat, DataFormat newFormat)
        {
            switch (newFormat)
            {
                case DataFormat.Metre: return ConvertToSI(value, oldFormat);
                case DataFormat.Foot: return ConvertToFoot(value, oldFormat);
                case DataFormat.Mile: return ConvertToMile(value, oldFormat);
                default: throw new FormatException("Error Format! Length conversion is not possible.");
            }
        }

        public decimal ConvertToFoot(decimal value, DataFormat format)
        {
            return ConvertToSI(value, format) * 3.28084m;
        }

        public decimal ConvertToMile(decimal value, DataFormat format)
        {
            return ConvertToSI(value, format) * 0.000621371m;
        }
    }
}
