using System;

namespace Saturday_24._11._18
{
    public class Determiner
    {
        public static Converter ChooseConverter(DataFormat format)
        {
            switch (format)
            {
                case DataFormat.Gramm:
                case DataFormat.Pound:
                case DataFormat.Pood: return MassConverter.GetConverter();
                case DataFormat.Metre:
                case DataFormat.Foot:
                case DataFormat.Mile: return LengthConverter.GetConverter();
                case DataFormat.CubicMetre:
                case DataFormat.Gallon:
                case DataFormat.Pint: return VolumeConverter.GetConverter();
                case DataFormat.Celsius:
                case DataFormat.Kelvin:
                case DataFormat.Fahrenheit: return TemperatureConverter.GetConverter();
                default: throw new Exception();
            }
        }
    }
}
