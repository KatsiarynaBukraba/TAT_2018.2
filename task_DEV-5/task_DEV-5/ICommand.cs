﻿using System.Collections.Generic;

namespace task_DEV_5
{
    /// <summary>
    /// Exposes an method to execution and to get a result of commands.
    /// </summary>
    public interface ICommand
    {
        string Execute();
    }
}
