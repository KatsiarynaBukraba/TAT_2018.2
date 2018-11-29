using System.Collections.Generic;

namespace task_DEV_4
{
    public class Node
    {
        public string Tag { get; set; }
        public string Value { get; set; }
        public List<Attribute> attributes = new List<Attribute>();
        public List<Node> childNodes = new List<Node>();
    }
}
