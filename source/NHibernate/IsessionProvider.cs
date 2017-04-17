using NHibernate;

namespace Naftan.Infrastructure.NHibernate
{
    /// <summary>
    /// Провайдер сессии
    /// </summary>
    public interface ISessionProvider
    {
        ISession CurrentSession { get; } 
    }
}
