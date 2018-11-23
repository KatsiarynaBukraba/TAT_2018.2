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
        }

        public int Number { get; set; }
        public int Radix { get; set; }
    }
}
