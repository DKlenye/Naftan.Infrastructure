using System.Collections.Generic;
using System.Linq;
using Naftan.Infrastructure.Domain;
using NHibernate;
using NHibernate.Linq;

namespace Naftan.Infrastructure.NHibernate
{
    public class NHibernateRepository:IRepository
    {
        private readonly ISessionProvider provider;

        public NHibernateRepository(ISessionProvider provider)
        {
            this.provider = provider;
        }

        protected ISession Session
        {
            get
            {
                return provider.CurrentSession;
            }
        }

        public IEnumerable<TEntity> All<TEntity>() where TEntity : IEntity
        {
            return Session.Query<TEntity>().ToArray();
        }

        public TEntity Get<TEntity>(int id) where TEntity : IEntity
        {
            return Session.Load<TEntity>(id);
        }

        public void Save<TEntity>(TEntity entity) where TEntity : IEntity
        {
            Session.SaveOrUpdate(entity);
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : IEntity
        {
            Session.SaveOrUpdate(entity);
        }
    }
}
