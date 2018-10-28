using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace task_DEV_4
{
    /// <summary>
    /// The class to parse a XMLfile.
    /// </summary>
    public class XMLParser
    {
        private Stack<string> tags = new Stack<string>();
        private string data;

        /// <summary>
        /// To read a XMLfile.
        /// </summary>
        /// <param name="file">File link.</param>
        /// <returns>A text of XMLfile.</returns>
        public string ReadXMLFile(string file)
        {
            var reader = new StreamReader(file);
            return reader.ReadToEnd().Replace("\r\n", String.Empty);
        }

        /// <summary>
        /// To parse a XMLfile.
        /// </summary>
        /// <param name="text">A text of XMLfile.</param>
        /// <returns>A main node.</returns>
        public Node Parse(string text)
        {
            data = text;
            data = data.Remove(data.IndexOf("<?"), data.IndexOf("?>") + 2 - data.IndexOf("<?")).Trim();
            DeleteComments();

            var node = GetNode();
            return node;
        }

        /// <summary>
        /// To get a main node.
        /// </summary>
        /// <returns>Node.</returns>
        public Node GetNode()
        {
            var node = doNode(GetTag().Trim());
            data = data.Substring(data.IndexOf('>') + 1).Trim();
            tags.Push(node.Tag);

            do
            {
                if (!GetTag().Trim().Contains(tags.Peek()))
                {
                    node.childNodes.Add(GetNode());
                }
                else
                {
                    tags.Pop();
                    if (data.IndexOf('<') != 0)
                        node.Value = data.Substring(0, data.IndexOf('<'));
                    data = data.Substring(data.IndexOf('>') + 1).Trim();
                    return node;
                }
            }
            while (tags != null);

            return node;
        }

        /// <summary>
        /// To get an information about node from tag.
        /// </summary>
        /// <param name="tag">Tag.</param>
        /// <returns>Node</returns>
        public Node doNode(string tag)
        {
            Node node = new Node();

            if (tag.Contains('='))
            {
                node.Tag = tag.Substring(0, tag.IndexOf(' '));
                tag = tag.Substring(tag.IndexOf(' ') + 1);

                while (tag.Length > 0)
                {
                    var attribute = new Attribute();

                    attribute.Name = tag.Substring(0, tag.IndexOf('=')).Trim();
                    tag = tag.Substring(tag.IndexOf('\"') + 1);

                    attribute.Value = tag.Substring(0, tag.IndexOf('\"')).Trim();

                    node.attributes.Add(attribute);
                    tag = tag.Substring(tag.IndexOf('\"') + 1);
                }
            }
            else node.Tag = tag;

            return node;
        }

        /// <summary>
        /// To get tag from line.
        /// </summary>
        /// <returns>Tag.</returns>
        public string GetTag()
        {
            var tag = data.Substring(data.IndexOf('<') + 1, data.IndexOf('>') - data.IndexOf('<') - 1);
            if (tag.Contains('<'))
            {
                throw new Exception("Invalid file!");
            }
            return tag;
        }

        /// <summary>
        /// To delete comments from XLMfile.
        /// </summary>
        public void DeleteComments()
        {
            while (data.Contains("<!--"))
            {
                int startComment = data.IndexOf("<!--");
                int endComment = data.IndexOf("-->") + 3;
                data = data.Remove(startComment, endComment - startComment).Trim();
            }
        }
    }
}