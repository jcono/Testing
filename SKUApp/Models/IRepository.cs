using System.Collections.Generic;

namespace SKUApp.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> Find(string key);
    }
}
