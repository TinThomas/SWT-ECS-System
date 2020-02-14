namespace Refactored_ECS.TempSensor
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}