namespace Testing.BDD
{
    public interface ITestContext
    {
        void Reset();

        void OnScenarioFailed(ScenarioFailure context);
    }
}
