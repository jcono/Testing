namespace StockInquiry.Tests.Framework.BDD
{
    public interface ITestContext
    {
        void Reset();

        void OnScenarioFailed(ScenarioFailure context);
    }
}
