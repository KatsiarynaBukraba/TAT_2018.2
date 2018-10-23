using System;
using System.Text;

namespace task_DEV_2
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
                if (args.Length != 1)
                {
                    throw new ArgumentException("A wrong number of parameters!");
                }
                Console.OutputEncoding = Encoding.UTF8;
                Transliter transliter = new Transliter();

                Console.WriteLine(args[0]);
                Console.WriteLine(transliter.Translit(args[0]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}