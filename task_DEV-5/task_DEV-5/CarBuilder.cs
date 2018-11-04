using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_5
{
    /// <summary>
    /// The auxiliary class to build an instance of Car.
    /// </summary>
    public class CarBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public void SetBrand(string brand)
        {
            if (brand.Equals(string.Empty))
                throw new ArgumentException("Empty brand argument!");
            else
                car.Brand = brand;
        }
        public void SetModel(string model)
        {
            if (model.Equals(string.Empty))
                throw new ArgumentException("Empty model argument!");
            else
                car.Model = model;
        }
        public void SetUnitCost(string unitCost)
        {
            decimal cost = Decimal.Parse(unitCost);
            SetUnitCost(cost);
        }
        public void SetUnitCost(decimal unitCost)
        {
            if (unitCost < 0)
                throw new ArgumentException("Cost is less than zero!");
            else car.UnitCost = unitCost;
        }
        public void SetQuantity(string quantity)
        {
            int qntt = Int32.Parse(quantity);
            SetQuantity(qntt);
        }
        public void SetQuantity(int quantity)
        {
            if (quantity < 0)
                throw new ArgumentException("Quantity is less than zero!");
            car.Quantity = quantity;
        }

        public Car Build()
        {
            return car;
        }
    }
}
