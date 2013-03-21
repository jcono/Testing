using System.Collections.Generic;
using StockInquiry.Models.Domain;

namespace StockInquiry.Models
{
    public class SimulatedSKURepository : IRepository<SKU>
    {
        public readonly IRepository<SKU> _repository;
        private readonly ISimulatorDecider _simulatorDecider;

        public SimulatedSKURepository(ISimulatorDecider simulatorDecider)
        {
            _repository = new FakeSKURepository();
            _simulatorDecider = simulatorDecider;
        }

        public IEnumerable<SKU> Find(string key)
        {
            if (_simulatorDecider.ShouldSimulate(SimulatorKey.SKURepository))
            {
                // return NO sql data
            }
            return _repository.Find(key);
        }
    }
}