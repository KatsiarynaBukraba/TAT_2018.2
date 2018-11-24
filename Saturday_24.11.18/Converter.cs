namespace Saturday_24._11._18
{
    public abstract class Converter
    {
        public decimal Value { get; set; }

        abstract public decimal ConvertToSI(decimal value, DataFormat format);
        abstract public decimal Convert(decimal value, DataFormat oldFormat, DataFormat newFormat);
    }
}
