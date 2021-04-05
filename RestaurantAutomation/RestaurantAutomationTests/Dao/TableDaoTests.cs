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
    public class TableDaoTests
    {
        [TestMethod()]
        public void GetTableListTest()
        {
            TableDao tableDao = new TableDao();
            Assert.IsTrue(tableDao.GetTableList().Count()==11);
        } 

        [TestMethod()]
        public void GetTableByIdTest()
        {
            TableDao tableDao = new TableDao();
            Assert.IsTrue(tableDao.GetTableById(1).Id == 1);
        }

        [TestMethod()]
        public void updateTableTest()
        {
            TableDao tableDao = new TableDao();
            Table table = tableDao.GetTableById(1);
            table.Status = "Dirty";
            tableDao.updateTable(table);
            Assert.IsTrue(tableDao.GetTableById(1).Status == "Dirty");
        }
    }
}