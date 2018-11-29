using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_5
{
    public class Receiver
    {
        private List<Car> carList;

        public Receiver(List<Car> list) => carList = list;

        public string AveragePrice()
        {
            var costList = from car in carList
                select car.UnitCost;

            return costList.Average().ToString();
        }

        public string AveragePriceType(string brand)
        {
            var brandCostList = from car in carList
                where car.Brand == brand
                select car.UnitCost;

            return brandCostList.Average().ToString();
        }

        public string CountAll()
        {
            var quantityList = from car in carList
                select car.Quantity;

            return quantityList.Sum().ToString();
        }

        public string CountBrands()
        {
            var brandList = from car in carList
                select car.Brand;

            return brandList.Distinct().Count().ToString();
        }
    }
}
