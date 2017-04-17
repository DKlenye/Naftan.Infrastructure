using System;

namespace Naftan.Infrastructure.Domain
{
    /// <summary>
    /// Единица работы
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Сохранить ВСЕ изменения в БД
        /// </summary>
        void Commit();
    }
}