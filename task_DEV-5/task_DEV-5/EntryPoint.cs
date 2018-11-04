using System;
using System.Collections.Generic;
using System.Linq;
using task_DEV_5.Commands;

namespace task_DEV_5
{
    public enum Command { CountBrands = 1, CountAll, AveragePrice, AveragePriceType, Exit }

    /// <summary>
    /// This class is an entry point in the program. 
    /// </summary>
    class EntryPoinr
    {
        /// <summary>
        /// To handles input data and user-entered commands.
        /// To output results of the commands.
        /// </summary>
        static void Main()
        {
            try
            {
                ConsoleKeyInfo continueInput = new ConsoleKeyInfo();
                List<Car> carList = new List<Car>();

                do
                {
                    var car = new CarBuilder();

                    Console.WriteLine("\nInput a brand of the car:");
                    car.SetBrand(Console.ReadLine());

                    Console.WriteLine("\nInput a model of the car:");
                    car.SetModel(Console.ReadLine());

                    Console.WriteLine("\nInput a quantity of cars:");
                    car.SetQuantity(Console.ReadLine());

                    Console.WriteLine("\nInput a cost of one car:");
                    car.SetUnitCost(Console.ReadLine());

                    AddToList(carList, car.Build());

                continueInputCars:
                    Console.WriteLine("\nDo you want to continue to input products?");
                    Console.WriteLine("Yes [LeftArrow] | No [RightArrow]");
                    continueInput = Console.ReadKey();
                    if (continueInput.Key != ConsoleKey.RightArrow && continueInput.Key != ConsoleKey.LeftArrow)
                        goto continueInputCars;
                }
                while (continueInput.Key == ConsoleKey.LeftArrow);

                do
                {

                chooseCommand:
                    Console.WriteLine("\nChoose command:" +
                   "\n1) count brands\n" +
                   "2) count all\n" +
                   "3) average price (all types)\n" +
                   "4) average price (type)\n" +
                   "5) exit\n" +
                   "Input number: ");

                    Command command;
                    if (!Enum.TryParse(Console.ReadLine(), true, out command))
                    {
                        Console.WriteLine("\nInvalid choose! Try again.");
                        goto chooseCommand;
                    }
                    Invoker invoker = new Invoker();

                    switch (command)
                    {
                        case Command.CountBrands:
                            invoker.Set(new CountBrands());
                            break;
                        case Command.CountAll:
                            invoker.Set(new CountAll());
                            break;
                        case Command.AveragePrice:
                            invoker.Set(new AveragePrice());
                            break;
                        case Command.AveragePriceType:
                            Console.WriteLine("Input brand: ");
                            string brand = Console.ReadLine();
                            invoker.Set(new AveragePriceType(brand));
                            break;
                        case Command.Exit:
                            return;
                        default:
                            Console.WriteLine("\nInvalid choose! Try again.");
                            goto chooseCommand;
                    }

                    Console.WriteLine($"\n{command}: {invoker.Execute(carList)}");
                }
                while (true);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        /// <summary>
        /// To check data cars to repeating input car for making a right list.
        /// </summary>
        /// <param name="carList">data cars</param>
        /// <param name="car">input car</param>
        static void AddToList(List<Car> carList, Car car)
        {
            bool existCar = carList.Any(c => c.Brand == car.Brand && c.Model == car.Model);

            if (existCar)
            {
                foreach (Car c in carList)
                {
                    if(c.Brand == car.Brand && c.Model == car.Model)
                    {
                        if (c.UnitCost != car.UnitCost)
                            throw new Exception("invalid input of the car!");
                        else c.Quantity += car.Quantity;
                    }
                }
            }
            else carList.Add(car);
        }
    }
}
