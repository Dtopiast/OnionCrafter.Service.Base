using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OnionCrafter.Service.Option.Base;

namespace OnionCrafter.Service.Base
{
    /// <summary>
    /// BaseService is an abstract class that implements the IService interface.
    /// </summary>
    public abstract class BaseService : IService
    {
        /// <summary>
        /// Field to store a logger instance.
        /// </summary>
        protected ILogger<BaseService>? _logger;

        /// <summary>
        /// Flag indicating whether to use a logger or not.
        /// </summary>
        protected bool _useLogger;

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// The constructor without parameters
        /// </summary>
        public BaseService()
        {
            Name = GetType().Name;
        }

        /// <inheritdoc/>
        public virtual TReturn Clone<TReturn>() where TReturn : IBaseService
        {
            return (TReturn)MemberwiseClone();
        }
    }

    /// <summary>
    /// Represents a base service with support service-specific options.
    /// </summary>
    /// <typeparam name="TServiceOptions">The type of service-specific options.</typeparam>
    public abstract class BaseService<TServiceOptions> :
        BaseService,
        IService<TServiceOptions>
        where TServiceOptions : class, IServiceOptions
    {
        /// <summary>
        /// Stores the configuration for the service.
        /// </summary>
        protected readonly TServiceOptions _serviceConfig;
        /// <summary>
        /// The constructor with options.
        /// </summary>
        /// <param name="options">The options monitor dependency.</param>
        public BaseService(IOptionsMonitor<TServiceOptions> options)
        {
            _serviceConfig = options.Get(Name);
        }
    }
}