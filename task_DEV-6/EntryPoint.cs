using System;

namespace task_DEV_6
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException();
                }

                var fileName = args[0];

                DataFormat format;
                var node = DataFormats.LoadFromFile(fileName, out format);

                if (format == DataFormat.JSON)
                {
                    DataFormats.SaveToFile(args[0], node, DataFormat.XML);
                }
                else
                {
                    DataFormats.SaveToFile(args[0], node, DataFormat.JSON);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
