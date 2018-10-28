using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace task_DEV_4
{
    /// <summary>
    /// The class for output and sort a node.
    /// </summary>
    public class Outputter
    {
        private Stack<Node> nodes = new Stack<Node>();

        /// <summary>
        /// To output and sort a node.
        /// </summary>
        /// <param name="node"></param>
        public void PrintNode(Node node)
        {
            nodes.Push(node);

            if (nodes.Peek().childNodes.Count > 0)
            {
                var childNodes = from i in nodes.Peek().childNodes
                                 orderby i.Tag
                                 select i;

                foreach (var childNode in childNodes)
                {
                    PrintNode(childNode);
                    nodes.Pop();
                }
            }
            else
            {
                var stack = new Stack<Node>(nodes);
                StringBuilder stringBuilder = new StringBuilder();

                while (stack.Count > 1)
                {
                    stringBuilder.Append(OutSimpleNode(stack.Peek()));
                    stringBuilder.Append(" -> ");
                    stack.Pop();
                }
                stringBuilder.Append(OutSimpleNode(stack.Peek()));
                Console.WriteLine(stringBuilder);
            }
        }

        /// <summary>
        /// To get an output information about a simple node.
        /// </summary>
        /// <param name="node">A simple node.</param>
        /// <returns>An output information about a simple node.</returns>
        public string OutSimpleNode(Node node)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(' ');
            stringBuilder.Append(node.Tag);

            if (node.Value != null)
            {
                stringBuilder.Append(" = ");
                stringBuilder.Append(node.Value);
            }

            if (node.attributes != null)
            {
                var attributes = from i in node.attributes
                                 orderby i.Name
                                 select i;

                foreach (var item in attributes)
                {
                    stringBuilder.Append(' ');
                    stringBuilder.Append(item);
                }
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
