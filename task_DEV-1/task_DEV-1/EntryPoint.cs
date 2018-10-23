using System;

namespace task_DEV_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException("Wrong number of parameters!");
                }

                Console.WriteLine(args[0]);
                UniqueSequencesFinder finder = new UniqueSequencesFinder();
                Console.WriteLine(finder.GetMaxLength(args[0]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
