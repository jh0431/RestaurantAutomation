using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantAutomation.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace RestaurantAutomation.DAO.Tests
{
    [TestClass()]
    public class OrderDaoTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderDao orderDao = new OrderDao(); 
            orderDao.removeAll();
            Order order = new Order();
            order.TableNum="1";
            order.Status = "Occupied"; 
            orderDao.AddOrder(order); 
            Assert.IsTrue(orderDao.GetOrderByTableNum("1").Status== "Occupied");
        }
         

        [TestMethod()]
        public void updateOrderTest()
        {
            OrderDao orderDao = new OrderDao();
            Order order = orderDao.GetOrderByTableNum("1"); 
            order.Status = "Dirty";
            orderDao.updateOrder(order);
            Assert.IsTrue(orderDao.GetOrderByTableNum("1").Status == "Dirty");
        }
    }
}