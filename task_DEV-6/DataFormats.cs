using System.IO;

using task_DEV_6.XML;
using task_DEV_6.JSON;
using System;

namespace task_DEV_6
{
    public enum DataFormat
    {
        Unknown,
        XML,
        JSON,
    }

    public static class DataFormats
    {
        public static DataFormat GetFormatForExtension(string extension)
        {
            switch (extension)
            {
                case ".xml": return DataFormat.XML;
                case ".json": return DataFormat.JSON;

                default:
                    {
                        return DataFormat.Unknown;
                    }
            }
        }

        public static DataFormat DetectFormat(string content)
        {
            int i = 0;
            while (i < content.Length)
            {
                var c = content[i];
                i++;

                if (char.IsWhiteSpace(c))
                {
                    continue;
                }

                switch (c)
                {
                    case '<': return DataFormat.XML;
                    case '{':
                    case '[': return DataFormat.JSON;
                    default: return DataFormat.Unknown;
                }
            }

            return DataFormat.Unknown;
        }

        public static DataNode LoadFromString(DataFormat format, string contents)
        {
            switch (format)
            {
                case DataFormat.XML: return XMLReader.ReadFromString(contents);
                case DataFormat.JSON: return JSONReader.ReadFromString(contents);
                default:
                    {
                        throw new System.Exception("Format not supported");
                    }
            }
        }

        public static string SaveToString(DataFormat format, DataNode root)
        {
            switch (format)
            {
                case DataFormat.XML: return XMLWriter.WriteToString(root);
                case DataFormat.JSON: return JSONWriter.WriteToString(root);
                default:
                    {
                        throw new System.Exception("Format not supported");
                    }
            }
        }

        public static DataNode LoadFromString(string content)
        {
            var format = DetectFormat(content);
            return LoadFromString(format, content);
        }

        /// <summary>
        /// Loads a node tree from a file, type is based on filename extension
        /// </summary>
        public static DataNode LoadFromFile(string fileName, out DataFormat format)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }

            var extension = Path.GetExtension(fileName).ToLower();


            var contents = File.ReadAllText(fileName);

            format = GetFormatForExtension(extension);

            if (format == DataFormat.Unknown)
            {
                format = DetectFormat(contents);

                if (format == DataFormat.Unknown)
                {
                    throw new Exception("Could not detect format for " + fileName);
                }
            }

            return LoadFromString(format, contents);
        }

        public static void SaveToFile(string fileName, DataNode root, DataFormat format)
        {
            var extension = Path.GetExtension(fileName).ToLower();
            
            var content = SaveToString(format, root);
            File.WriteAllText(fileName, content);
        }

    }
}
