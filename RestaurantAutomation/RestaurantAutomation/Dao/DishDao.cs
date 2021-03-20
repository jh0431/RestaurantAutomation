using System;
using System.Collections.Generic;
using Models;
using SqlSugar;

namespace RestaurantAutomation.DAO
{
    public class DishDao
    {
        SqlSugarClient db = DBHelper.GetInstance();

        //public List<object> GetDishesOfOrder(int orderId)
        //{
        //    return ;

        //}

        public Dish GetDishById(int id)
        {
            return db.Queryable<Dish>().Where(t => t.Id == id).First();
        }

        public void addDish(Dish dish)
        {
            db.Saveable(dish).ExecuteCommand();
        }

        public void updateDish(Dish dish)
        {
            db.Updateable(dish).ExecuteCommand();
        }

        public void removeDish(int id)
        {
            db.Deleteable<Dish>().Where(t => t.Id == id).ExecuteCommand();
        }

    }
}
