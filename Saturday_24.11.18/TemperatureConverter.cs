using System;

namespace Saturday_24._11._18
{
    public class TemperatureConverter : Converter
    {
        private static TemperatureConverter converter;

        private TemperatureConverter() { }

        public static TemperatureConverter GetConverter()
        {
            if (converter == null)
                converter = new TemperatureConverter();

            return converter;
        }

        public override decimal ConvertToSI(decimal value, DataFormat format)
        {
            switch (format)
            {
                case DataFormat.Celsius: Value = value; break;
                case DataFormat.Kelvin: Value = value - 273.15m; break;
                case DataFormat.Fahrenheit: Value = (value - 32) * 5 / 9; break;
                default: throw new FormatException("Error Format! Temperature conversion is not possible.");
            }

            if (Value < -273.15m && Value > 6.0e6m)
            {
                throw new Exception("Incorrect data!");
            }

            return Value;
        }

        public override decimal Convert(decimal value, DataFormat oldFormat, DataFormat newFormat)
        {
            switch (newFormat)
            {
                case DataFormat.Celsius: return ConvertToSI(value, oldFormat);
                case DataFormat.Kelvin: return ConvertToKelvin(value, oldFormat);
                case DataFormat.Fahrenheit: return ConvertToFahrenheit(value, oldFormat);
                default: throw new FormatException("Error Format! Mass conversion is not possible.");
            }
        }

        public decimal ConvertToKelvin(decimal value, DataFormat format)
        {
            return ConvertToSI(value, format) + 273.15m;
        }

        public decimal ConvertToFahrenheit(decimal value, DataFormat format)
        {
            return (ConvertToSI(value, format) * 9 / 5) + 32;
        }
    }
}
