using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model.Entities.Mapping
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.FoodLists)
                .Inverse()
                .Cascade.All();
        }
    }
}
