using System.Text;

namespace task_DEV_3
{
    public class Converter
    {
        /// <summary>
        /// The method to convert a number of decimal system to the other.
        /// </summary>
        /// <param name="number">Input number.</param>
        /// <param name="newBase">New base.</param>
        /// <returns></returns>
        public string Convert(int number, int newBase)
        {
            StringBuilder convertedNumberBuilder = new StringBuilder();
            int indexSing = 0;

            if (number < 0)
            {
                number *= -1;
                indexSing++;
                convertedNumberBuilder.Append("-");
            }

            do
            {
                convertedNumberBuilder.Insert(indexSing, GetPartOfNumber((int)(number % newBase)));
                number /= newBase;
            }
            while (number > 0);

            return convertedNumberBuilder.ToString();
        }

        public char GetPartOfNumber(int numberOfSymbol)
        {
            string allSymbols = "0123456789ABCDEFGHIJ";
            return allSymbols[numberOfSymbol];
        }
    }
}
