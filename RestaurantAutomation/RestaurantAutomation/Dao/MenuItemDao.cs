using System;
using System.Collections.Generic;
using Models;
using SqlSugar;

namespace RestaurantAutomation.DAO
{
    public class MenuItemDao
    {
        SqlSugarClient db = DBHelper.GetInstance(); 

        public Menuitem GetMenuItemById(int id)
        {
            return db.Queryable<Menuitem>().Where(t => t.Id == id).First();
        }

        public List<Menuitem> GetMenu()
        {
            return db.Queryable<Menuitem>().ToList();
        }

        public void addMenuItem(Menuitem menuItem)
        {
            db.Saveable(menuItem).ExecuteCommand();
        }

        public void updateMenuItem(Menuitem menuItem)
        {
            db.Updateable(menuItem).ExecuteCommand();
        }

        public void removeMenuItem(int id)
        {
            db.Deleteable<Menuitem>().Where(t=>t.Id==id).ExecuteCommand();
        }

    }
}
