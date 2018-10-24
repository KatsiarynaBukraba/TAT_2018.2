using System;

namespace task_DEV_3
{
    /// <summary>
    /// The class to input data.
    /// </summary>
    public class Inputter
    {
        private int newBase;
        private int number;

        /// <summary>
        /// The method to input data.
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

            if (!int.TryParse(args[1], out newBase))
            {
                throw new ArgumentException("Wrong input of a base!");
            }

            if (newBase < 2 || newBase > 20)
            {
                throw new ArgumentException("The base isn't in a available diapason!");
            }
        }

        public int GetNumber()
        {
            return number;
        }

        public int GetNewBase()
        {
            return newBase;
        }
    }
}
