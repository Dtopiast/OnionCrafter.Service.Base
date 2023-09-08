using OnionCrafter.Service.Option.Base;
using OnionCrafter.Util.Object.Pattern.Prototype;

namespace OnionCrafter.Service.Base
{
    /// <summary>
    /// Interface for a base service that implements IPrototype.
    /// </summary>
    public interface IBaseService :
        IClonable<IBaseService>
    {

    }

    /// <summary>
    /// Interface for a base service with specific options that implements IPrototype.
    /// </summary>
#pragma warning disable S2326 // Unused type parameters should be removed

    public interface IBaseService<TBaseServiceOptions> :
#pragma warning restore S2326 // Unused type parameters should be removed
        IBaseService
        where TBaseServiceOptions : IBaseServiceOptions
    {
    }
}