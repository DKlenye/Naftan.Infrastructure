using System.Collections.Generic;

namespace Naftan.Infrastructure.Domain
{
    /// <summary>
    /// Интерфейс репозитория
    /// </summary>
    /// <typeparam name="TEntity"> Тип сущности доменной модели </typeparam>
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {
        /// <summary>
        ///     Получить все сущности
        /// </summary>
        /// <returns> Список сущностей </returns>
        IEnumerable<TEntity> All();

        /// <summary>
        /// Получить сущность по идентификатору. В ряде случаев использование Load более предпочтительно.
        /// </summary>
        /// <param name="id"> Идектификатор сущности </param>
        /// <returns> Сущность с указанным Id, если существует. Иначе - null. </returns>
        TEntity Get(int id);

        /// <summary>
        /// Сохранить сущность
        /// </summary>
        /// <param name="entity"> Сущность </param>
        void Save(TEntity entity);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="entity"> Сущность </param>
        void Remove(TEntity entity);
    }
}