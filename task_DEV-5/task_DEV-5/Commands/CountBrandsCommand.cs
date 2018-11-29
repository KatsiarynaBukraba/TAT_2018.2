using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return a count of all brands of data cars.
    /// </summary>
    public class CountBrandsCommand : ICommand
    {
        private Receiver receiver;

        public CountBrandsCommand(Receiver r) => receiver = r;

        public string Execute()
        {
            return receiver.CountBrands();
        }
    }
}
