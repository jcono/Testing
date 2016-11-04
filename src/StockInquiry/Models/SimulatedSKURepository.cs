using System.Collections.Generic;
using StockInquiry.Models.Domain;

namespace StockInquiry.Models
{
    public class SimulatedSKURepository : IRepository<SKU>
    {
        private readonly IRepository<SKU> _repository;
        private readonly ISimulatorDecider _simulatorDecider;

        public SimulatedSKURepository(ISimulatorDecider simulatorDecider, IRepository<SKU> repository)
        {
            _repository = repository;
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