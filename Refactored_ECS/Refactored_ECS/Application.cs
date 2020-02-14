namespace Refactored_ECS
{
    public class Application
    {
        public static void Main(string[] args)
        {
            var ecs = new ECS(28,new TempSensor.TempSensor(), new Heater.Heater());

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
            System.Console.ReadKey();
        }
    }
}
