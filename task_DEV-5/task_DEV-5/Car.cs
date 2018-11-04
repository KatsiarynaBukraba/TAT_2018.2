namespace task_DEV_5
{
    /// <summary>
    /// The class to keep information about a car: a brand, a model, a quantity and a unit cost.
    /// </summary>
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }

        public static CarBuilder CreateBuilder()
        {
            return new CarBuilder();
        }
    }
}
