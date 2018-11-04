using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return a count of all data cars.
    /// </summary>
    class CountAll : ICommand
    {
        public string Execute(List<Car> carList)
        {
            var quantityList = from car in carList
                           select car.Quantity;

            return quantityList.Sum().ToString();
        }
    }
}
