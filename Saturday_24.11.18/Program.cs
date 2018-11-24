using System;

namespace Saturday_24._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal value = decimal.Parse(args[0]);

                var oldFormat = Checker.GetFormat(args[1]);
                var newFormat = Checker.GetFormat(args[2]);

                if (!Checker.CheckFormat(oldFormat, newFormat))
                {
                    throw new Exception();
                }

                var convertor = Determiner.ChooseConverter(oldFormat);
                Console.WriteLine(convertor.Convert(value, oldFormat, newFormat));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
