using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model.Entities
{
    public class FoodList
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual double Proteins { get; set; }
        public virtual double Fats { get; set; }
        public virtual double Carbohydrates { get; set; }
        public virtual int Calories { get; set; }
        public virtual Category Category { get; set; }

    }
}
