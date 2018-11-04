using System.Collections.Generic;
using System.Linq;

namespace task_DEV_5.Commands
{
    /// <summary>
    /// The command to return an average price of the input brand of data cars.
    /// </summary>
    class AveragePriceType : ICommand
    {
        private string brand;

        public AveragePriceType(string brand)
        {
            this.brand = brand;
        }

        public string Execute(List<Car> carList)
        {
            var brandCostList = from car in carList
                                where car.Brand == brand
                                select car.UnitCost;

            return brandCostList.Average().ToString();
        }
    }
}
