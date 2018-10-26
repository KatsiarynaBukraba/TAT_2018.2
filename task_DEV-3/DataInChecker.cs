using System;

namespace task_DEV_3
{
    /// <summary>
    /// The class to input validity data.
    /// </summary>
    public class DataInChecker
    {
        private int radix;
        private int number;

        /// <summary>
        /// The method for data validity check.
        /// </summary>
        /// <param name="args">Input data.</param>
        public void InputForConverter(string[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException("Wrong number of arguments!");
            }

            if (!int.TryParse(args[0], out number))
            {
                throw new ArgumentException("Wrong input of a number!");
            }

            if (!int.TryParse(args[1], out radix))
            {
                throw new ArgumentException("Wrong input of a radix!");
            }

            if (radix < 2 || radix > 20)
            {
                throw new ArgumentException("The base isn't in aт available diapason!");
            }
        }

        public int GetNumber()
        {
            return number;
        }

        public int GetNewBase()
        {
            return radix;
        }
    }
}
