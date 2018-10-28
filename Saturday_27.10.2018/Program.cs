using System;

namespace Saturday_27._10._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyList<Car> cars = new MyList<Car>();

                cars.Add(new Car("X5", "BMW", "Green"));
                cars.Add(new Car("X6", "BMW", "Black"));
                cars.Add(new Car("7", "BMW", "Black"));
                cars.Add(new Car("ВАЗ-2107", "Zhiguli", "Gold"));
                cars.Add(new Car("X156", "Mercedes-Benz", "Red"));

                foreach (Car car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
