namespace _3_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GasolineCar gasCar = new GasolineCar("Venom", new Engine(5000, "Gasoline"));
            gasCar.AddPart(new Part("Turbo Charger", 3000));
            gasCar.AddPart(new Part("Racing Tires", 2000));

            ElectricCar electricCar = new ElectricCar("Lightning", new Engine(4500, "Electric"));
            electricCar.AddPart(new Part("Battery Pack", 5000));
            electricCar.AddPart(new Part("Aero Kit", 1500));

            Console.WriteLine("[슈퍼카 제작 완료!]");
            gasCar.PrintInfo();
            Console.WriteLine();
            electricCar.PrintInfo();
        }
    }
}
