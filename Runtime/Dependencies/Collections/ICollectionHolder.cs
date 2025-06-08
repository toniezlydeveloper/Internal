using Internal.Runtime.Dependencies.Core;

namespace Internal.Runtime.Dependencies.Collections
{
    public interface ICollectionHolder<in TItem> : IDependency
    {
        void Add(TItem item);
        void Remove(TItem item);
    }
}