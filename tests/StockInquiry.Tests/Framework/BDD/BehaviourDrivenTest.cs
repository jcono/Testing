using System;

namespace StockInquiry.Tests.Framework.BDD
{
    public abstract class BehaviourDrivenTest<TContext> where TContext : ITestContext, new()
    {
        private readonly TContext _context = new TContext();

        protected TContext I
        {
            get { return _context; }
        }

        public void Scenario(string description, Action scenario)
        {
            Exception originalException = null;
            var attempts = 1;
            while (true)
            {
                try
                {
                    scenario();
                    break;
                }
                catch (Exception ex)
                {
                    var failure = new ScenarioFailure(description, attempts, ex);
                    if (attempts == 1)
                    {
                        originalException = ex;
                    }
                    _context.OnScenarioFailed(failure);
                    const int MAXIMUM_SCENARIO_ATTEMPTS = 3;
                    if (failure.Retry && attempts <= MAXIMUM_SCENARIO_ATTEMPTS)
                    {
                        attempts++;
                        continue;
                    }
                    throw originalException;
                }
            }
        }

        public BehaviourDrivenTest<TContext> Given(Action action)
        {
            return Execute(action);
        }

        public BehaviourDrivenTest<TContext> When(Action action)
        {
            return Execute(action);
        }

        public BehaviourDrivenTest<TContext> Then(Action action)
        {
            return Execute(action);
        }

        public BehaviourDrivenTest<TContext> And(Action action)
        {
            return Execute(action);
        }

        private BehaviourDrivenTest<TContext> Execute(Action action)
        {
            action();
            return this;
        }
    }
}
