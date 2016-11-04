namespace StockInquiry.Models
{
    public interface ISimulatorDecider
    {
        bool ShouldSimulate(SimulatorKey key);

        void ChangeSimulatorTo(SimulatorKey key, bool value);
    }
}