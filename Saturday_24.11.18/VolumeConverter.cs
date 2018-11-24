using System;

namespace Saturday_24._11._18
{
    public class VolumeConverter : Converter
    {
        private static VolumeConverter converter;

        private VolumeConverter() { }

        public static VolumeConverter GetConverter()
        {
            if (converter == null)
                converter = new VolumeConverter();

            return converter;
        }

        public override decimal ConvertToSI(decimal value, DataFormat format)
        {
            switch (format)
            {
                case DataFormat.CubicMetre: Value = value; break;
                case DataFormat.Gallon: Value = value * 0.003785411784m; break;
                case DataFormat.Pint: Value = value * 0.125000211875m; break;
                default: throw new FormatException("Error Format! Volume conversion is not possible.");
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
                case DataFormat.CubicMetre: return ConvertToSI(value, oldFormat);
                case DataFormat.Gallon: return ConvertToGallon(value, oldFormat);
                case DataFormat.Pint: return ConvertToPint(value, oldFormat);
                default: throw new FormatException("Error Format! Mass conversion is not possible.");
            }
        }

        public decimal ConvertToGallon(decimal value, DataFormat format)
        {
            return ConvertToSI(value, format) * 264.17205235815m;
        }

        public decimal ConvertToPint(decimal value, DataFormat format)
        {
            return ConvertToSI(value, format) * 2113.28m;
        }
    }
}
