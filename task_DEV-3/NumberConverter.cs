using System.Text;

namespace task_DEV_3
{
    public class NumberConverter
    {
        const string allSymbols = "0123456789ABCDEFGHIJ";

        /// <summary>
        /// The method to convert a number of decimal system to the other.
        /// </summary>
        /// <param name="number">Input number.</param>
        /// <param name="radix">New radix.</param>
        /// <returns>The number in a new system.</returns>
        public string Convert(int number, int radix)
        {
            StringBuilder convertedNumberBuilder = new StringBuilder();
            
            int indexString = 0;

            if (number < 0)
            {
                number *= -1;
                indexString++;
                convertedNumberBuilder.Append("-");
            }

            do
            {
                convertedNumberBuilder.Insert(indexString, allSymbols[number % radix]);
                number /= radix;
            }
            while (number > 0);

            return convertedNumberBuilder.ToString();
        }
    }
}
