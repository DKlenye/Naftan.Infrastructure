using NHibernate.Cfg;

namespace Naftan.Infrastructure.NHibernate
{
    ///<summary>
    ///  Начальная загрузка для NHibernate
    ///</summary>
    public interface INHibernateInitializer
    {
        ///<summary>
        ///  Построить конфиг
        ///</summary>
        ///<returns> Конфиг </returns>
        Configuration GetConfiguration();
    }
}