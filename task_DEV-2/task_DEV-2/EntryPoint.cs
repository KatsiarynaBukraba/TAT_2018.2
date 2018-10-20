using System;
using System.Text;

namespace task_DEV_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
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