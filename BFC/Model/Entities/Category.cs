using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model.Entities
{
    public class Category
    {
        public virtual int Id { protected set; get; }
        public virtual string Name { set; get; }

        public virtual IList<FoodList> FoodLists { get; set; } 

        public Category()
        {
            FoodLists = new List<FoodList>();
        }

    }
}
