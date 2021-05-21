using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model.Entities
{
    public class DailyRate
    {
        public virtual int Id { protected set; get; }
        public virtual DateTime Date { set; get; }
        public virtual int CaloriesPortion { set; get; }
    }
}
