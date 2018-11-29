using System.Collections.Generic;

namespace task_DEV_5
{
    /// <summary>
    /// The class to processing commands.
    /// </summary>
    public class Invoker
    {
        ICommand command;

        public void Set(ICommand command) => this.command = command;

        public string Execute() => command.Execute();
    }
}
