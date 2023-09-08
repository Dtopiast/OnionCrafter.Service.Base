using OnionCrafter.Service.Option.Base;
using OnionCrafter.Util.Object.Pattern.Prototype;

namespace OnionCrafter.Service.Base
{
    /// <summary>
    /// Represents an interface for a generic service without options.
    /// </summary>
    public interface IService :
        IBaseService
    {
        /// <summary>
        /// The name of the service
        /// </summary>
        string Name { get; }
    }

    /// <summary>
    /// Represents an interface for a generic service with options of type TServiceOptions.
    /// </summary>
    public interface IService<TServiceOptions> :
        IBaseService<TServiceOptions>,
        IService
        where TServiceOptions : class, IBaseServiceOptions
    {
    }
}