﻿namespace Naftan.Infrastructure.Domain
{
    /// <summary>
    /// Интерфейс сущности
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        int Id { get; set; }
    }
}
