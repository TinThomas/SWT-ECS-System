namespace ECS.Legacy.TempSensor
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}