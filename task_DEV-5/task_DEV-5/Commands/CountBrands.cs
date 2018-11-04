using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return a count of all brands of data cars.
    /// </summary>
    class CountBrands : ICommand
    {
        public string Execute(List<Car> carList)
        {
            var brandList = from car in carList
                            select car.Brand;

            return brandList.Distinct().Count().ToString();           
        }
    }
}
