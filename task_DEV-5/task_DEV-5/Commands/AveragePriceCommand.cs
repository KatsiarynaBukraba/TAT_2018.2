using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return an average price of data cars.
    /// </summary>
    public class AveragePriceCommand : ICommand
    {
        Receiver receiver;

        public AveragePriceCommand(Receiver r) => receiver = r;

        public string Execute()
        {
            return receiver.AveragePrice();
        }
    }
}
