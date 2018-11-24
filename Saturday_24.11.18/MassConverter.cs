using System;

namespace Saturday_24._11._18
{
    public class MassConverter : Converter
    {
        private static MassConverter converter;
        
        private MassConverter() { }

        public static MassConverter GetConverter()
        {
            if (converter == null)
                converter = new MassConverter();

            return converter;
        }

        public override decimal ConvertToSI(decimal value, DataFormat format)
        {
            switch (format)
            {
                case DataFormat.Gramm: Value = value; break;
                case DataFormat.Pound: Value = value * 453.592m; break;
                case DataFormat.Pood: Value = value * 16380.7m; break;
                default: throw new FormatException("Error Format! Mass conversion is not possible.");
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
                case DataFormat.Gramm: return ConvertToSI(value, oldFormat);
                case DataFormat.Pound: return ConvertToPound(value, oldFormat);
                case DataFormat.Pood: return ConvertToPood(value, oldFormat);
                default: throw new FormatException("Error Format! Mass conversion is not possible.");
            }
        }

        public decimal ConvertToPound(decimal value, DataFormat format)
        {
            return ConvertToSI(value, format) * 0.00220462m;
        }

        public decimal ConvertToPood(decimal value, DataFormat format)
        {
            return ConvertToSI(value, format) * 6.1047e-5m;
        }
    }
}
