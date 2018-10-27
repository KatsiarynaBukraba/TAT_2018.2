using System.Collections.Generic;

namespace task_DEV_4
{
    public class Node
    {
        public string Value { get; set; }
        private List<Attribute> attributes = new List<Attribute>();
        private List<Node> childrenNodes = new List<Node>();
    }
}
