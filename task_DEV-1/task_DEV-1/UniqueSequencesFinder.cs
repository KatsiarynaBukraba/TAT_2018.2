using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace task_DEV_1
{
    class UniqueSequencesFinder
    {
        private List<string> Find(string arg)
        {
            var symbolsOfString = arg.ToCharArray();
            string sequenceOfUniqueSymbols = "";
            StringBuilder sequenceBuilder = new StringBuilder();
            List<string> uniqueSequences = new List<string>();

            for (int i = 0; i < symbolsOfString.Length; i++)
            {
                //subString = arg.Substring(0, i);
                if (!sequenceOfUniqueSymbols.Contains(symbolsOfString[i]))
                {
                    sequenceBuilder.Append(symbolsOfString[i]);
                    sequenceOfUniqueSymbols = sequenceBuilder.ToString();
                }
                else
                {
                    uniqueSequences.Add(sequenceOfUniqueSymbols);
                    sequenceBuilder.Remove(0, sequenceOfUniqueSymbols.LastIndexOf(symbolsOfString[i]) + 1);
                    sequenceBuilder.Append(symbolsOfString[i]);
                    sequenceOfUniqueSymbols = sequenceBuilder.ToString();
                }
            }
            if (sequenceOfUniqueSymbols.Length != 0) uniqueSequences.Add(sequenceOfUniqueSymbols);
            return uniqueSequences;
        }
        public int GetMaxLength(string arg)
        {
            var sequences = Find(arg);
            int maxLength = 0;
            foreach (string sequence in sequences)
            {
                if (maxLength < sequence.Length) maxLength = sequence.Length;
            }

            return maxLength;
        }
    }
}

