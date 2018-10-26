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
                DataInChecker checker = new DataInChecker();
                checker.InputForConverter(args);

                NumberConverter numberConverter = new NumberConverter();

                Console.WriteLine(checker.Number + "  " + checker.Radix);
                Console.WriteLine(numberConverter.Convert(checker.Number, checker.Radix));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
