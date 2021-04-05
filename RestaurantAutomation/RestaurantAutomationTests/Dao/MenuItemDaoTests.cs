using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using RestaurantAutomation.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.DAO.Tests
{
    [TestClass()]
    public class MenuItemDaoTests
    {
        [TestMethod()]
        public void GetMenuItemByIdTest()
        {
            MenuItemDao menuItemDao = new MenuItemDao();
            Menuitem menuItem = menuItemDao.GetMenuItemById(2);
            Assert.IsTrue(menuItem.Name.Equals("Hamburg"));
        }

        [TestMethod()]
        public void GetMenuTest()
        {
            MenuItemDao menuItemDao = new MenuItemDao(); 
            Assert.IsNotNull(menuItemDao.GetMenu() );
        }

        [TestMethod()]
        public void addMenuItemTest()
        {
            MenuItemDao menuItemDao = new MenuItemDao();
            menuItemDao.AddMenuItem(new Menuitem("test",11));
            Assert.IsNotNull(menuItemDao.GetMenu().Where(t=>t.Name=="test"));
        }

        [TestMethod()]
        public void updateMenuItemTest()
        {
            MenuItemDao menuItemDao = new MenuItemDao();
            menuItemDao.AddMenuItem(new Menuitem("test1", 11));
           
            Menuitem menuitem= menuItemDao.GetMenu().First(t=>t.Name=="test1");
            menuitem.Name = "ss";
            menuItemDao.UpdateMenuItem(menuitem);
            Assert.IsNotNull(menuItemDao.GetMenu().Where(t=>t.Name=="ss") );
            Assert.IsTrue(menuItemDao.GetMenu().First(t => t.Name == "ss").Price ==11);

        }

        [TestMethod()]
        public void removeMenuItemTest()
        {
            MenuItemDao menuItemDao = new MenuItemDao();
            menuItemDao.AddMenuItem(new Menuitem("test2", 11));
            menuItemDao.RemoveMenuItem(menuItemDao.GetMenu().First(t => t.Name == "test2").Id);
            Assert.IsNull(menuItemDao.GetMenu().FirstOrDefault(t => t.Name == "test2"));
        }
    }
}