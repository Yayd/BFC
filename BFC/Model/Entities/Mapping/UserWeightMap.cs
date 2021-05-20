using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model.Entities.Mapping
{
    public class UserWeightMap : ClassMap<UserWeight>
    {
        public UserWeightMap()
        {
            Id(x => x.Id);
            Map(x => x.Date);
            Map(x => x.Weight);
        }
    }
}
