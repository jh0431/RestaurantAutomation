using System;
using System.Collections.Generic;
using Models;
using SqlSugar;

namespace RestaurantAutomation.DAO
{
    public class OrderDao
    {
        SqlSugarClient db = DBHelper.GetInstance();
         
        public Order GetOrderById(int id)
        {
            return db.Queryable<Order>().Where(t => t.Id == id).First();
        }

        public Order GetOrderByTableNum(string tableNum)
        {
            return db.Queryable<Order>().Where(t => t.TableNum == tableNum && t.Status != "Completed").First();
        }

        public List<Order> GetOrders()
        {
            return db.Queryable<Order>().ToList();
        }

        public void addOrder(Order order)
        {
            db.Saveable(order).ExecuteCommand();
        }

        public void updateOrder(Order order)
        {
            db.Updateable(order).ExecuteCommand();
        }

        public void removeOrder(int id)
        {
            db.Deleteable<Order>().Where(t => t.Id == id).ExecuteCommand();
        }

    }
}
