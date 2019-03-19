using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return a count of all data cars.
    /// </summary>
    public class CountAllCommand : ICommand
    {
        private Receiver receiver;

        public CountAllCommand(Receiver r) => receiver = r;

        public string Execute()
        {
            return receiver.CountAll();
        }
    }
}
