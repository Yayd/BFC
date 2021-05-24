using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model.Entities.Mapping
{
    public class FoodListMap : ClassMap<FoodList>
    {
        public FoodListMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Proteins);
            Map(x => x.Fats);
            Map(x => x.Carbohydrates);
            Map(x => x.Calories);
            References(x => x.Category);

        }
       
    }
}
