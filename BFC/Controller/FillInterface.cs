using BFC.Model;
using BFC.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Controller
{
    class FillInterface
    {

        //преобразование ilist<FoodList> в SortedDictionary<int, FoodList>
        public SortedDictionary<int, FoodList> ListToDic(EntityManager _tmpEntityManager)
        {
            SortedDictionary<int, FoodList> _tmpProducts = new SortedDictionary<int, FoodList> { };

            var _tmpFoodList = _tmpEntityManager.FindAll<FoodList>();

            for (int i = 0; i < _tmpFoodList.Count; i++)
                _tmpProducts.Add(i, _tmpFoodList[i]);

            return _tmpProducts;
        }

        //просто заполняем список продуктов взятых из бд
        public IList<FoodList> GetProductsFromDBFood(EntityManager _tmpEntityManager)
        {
            return _tmpEntityManager.FindAll<FoodList>();  
        }

        public IList<Category> GetProductsFromDBCategory(EntityManager _tmpEntityManager)
        {
            return _tmpEntityManager.FindAll<Category>();
        }

        public FoodList AddToDB(string _name, double _proteins, double _fats, double _carbs, int _calories, Category _categ)
        {
            FoodList _dish = new FoodList()//решить проблему доступа get,set для id
            {
                Name = _name,
                Proteins = _proteins,
                Fats = _fats,
                Carbohydrates = _carbs,
                Calories = _calories,
                Category = _categ
            };
            return _dish;

        }
    }
}
