﻿using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Naftan.Infrastructure.NHibernate.Conventions
{
    public class MappingConvention : IHibernateMappingConvention
    {
        public void Apply(IHibernateMappingInstance instance)
        {
            instance.Not.DefaultLazy();            
        }
    }

}
