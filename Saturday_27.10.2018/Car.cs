namespace Saturday_27._10._2018
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        public Car(string model, string brand, string color)
        {
            Model = model;
            Brand = brand;
            Color = color;
        }

        public override string ToString()
        {
            return "model: " + Model + "| brand: " + Brand + "| color: " + Color;
        }
    }
}
