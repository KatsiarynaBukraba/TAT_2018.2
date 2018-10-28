using System;

namespace task_DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException();
                }
                XMLParser parser = new XMLParser();
                var text = parser.ReadXMLFile(args[0]);

                var node = parser.Parse(text);
                Outputter outputter = new Outputter();
                outputter.PrintNode(node);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
