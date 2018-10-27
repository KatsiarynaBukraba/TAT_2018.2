using System.IO;

namespace task_DEV_4
{
    public class XMLParser
    {
        private readonly string endRow = "\r\n";
        private readonly char openedBreacket = '<';
        private readonly char closedBreacket = '>';
        private readonly char quote = '"';
        private readonly char space = ' ';
        private readonly char equal = '=';

        public string ReadXMLFile(string file)
        {
            StreamReader reader = new StreamReader(file);
            return reader.ReadToEnd().Replace(endRow, "");
        }

        public Node Parse(string file)
        {
            Node node = new Node();



            return node;
        }

    }
}
