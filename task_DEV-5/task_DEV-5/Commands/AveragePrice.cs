using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return an average price of data cars.
    /// </summary>
    class AveragePrice : ICommand
    {
        public string Execute(List<Car> carList)
        {
            var costList = from car in carList
                           select car.UnitCost;

            return costList.Average().ToString();
        }
    }
}
