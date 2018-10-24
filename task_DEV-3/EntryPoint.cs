using System;

namespace task_DEV_3
{
    /// <summary>
    /// An entry point in the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Inputter inputter = new Inputter();
                inputter.InputForConverter(args);

                Converter converter = new Converter();

                Console.WriteLine(inputter.GetNumber() + "  " + inputter.GetNewBase());
                Console.WriteLine(converter.Convert(inputter.GetNumber(), inputter.GetNewBase()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
