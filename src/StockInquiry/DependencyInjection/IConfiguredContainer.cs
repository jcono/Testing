using System;

namespace StockInquiry.DependencyInjection
{
    public interface IConfiguredContainer
    {
        object Resolve(Type type);

        void Release(object instance);
    }
}