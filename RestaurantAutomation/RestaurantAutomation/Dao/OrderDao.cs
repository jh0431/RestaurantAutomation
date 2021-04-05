using Models;
using SqlSugar;

namespace RestaurantAutomation.DAO
{
    public class OrderDao
    {
        SqlSugarClient db = DBHelper.GetInstance();

        public Order GetOrderByTableNum(string tableNum)
        {
            return db.Queryable<Order>().Where(t => t.TableNum == tableNum && t.Status != "Completed").First();
        }

        public void AddOrder(Order order)
        {
            db.Saveable(order).ExecuteCommand();
        }

        public void updateOrder(Order order)
        {
            db.Updateable(order).ExecuteCommand();
        }

        public void removeAll()
        {
            db.Deleteable<Order>().ExecuteCommand();
        }

    }
}
