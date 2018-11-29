using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return an average price of the input brand of data cars.
    /// </summary>
    public class AveragePriceTypeCommand : ICommand
    {
        private string brand;
        private Receiver receiver;

        public AveragePriceTypeCommand(Receiver r, string brand)
        {
            receiver = r;
            this.brand = brand;
        }

        public string Execute()
        {
            return receiver.AveragePriceType(brand);
        }
    }
}
