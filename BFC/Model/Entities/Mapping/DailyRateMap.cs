using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model.Entities.Mapping
{
    public class DailyRateMap : ClassMap<DailyRate>
    {
        public DailyRateMap()
        {
            Id(x => x.Id);
            Map(x => x.Date);
            Map(x => x.CaloriesPortion);

        }
    }
}
