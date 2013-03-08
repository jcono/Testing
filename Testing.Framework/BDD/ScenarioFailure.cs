using System;

namespace Testing.Framework.BDD
{
    public class ScenarioFailure
    {
        public ScenarioFailure(string description, int attempt, Exception exception)
        {
            Description = description;
            Exception = exception;
            Attempt = attempt;
            Retry = false;
        }

        public string Description { get; private set; }
        public Exception Exception { get; private set; }
        public int Attempt { get; set; }
        public bool Retry { get; set; }
    }
}
