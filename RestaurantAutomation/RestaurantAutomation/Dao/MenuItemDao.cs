using System;
using System.Collections.Generic;
using Models;
using SqlSugar;

namespace RestaurantAutomation.DAO
{
    public class MenuItemDao
    {
        private readonly  SqlSugarClient _db = DBHelper.GetInstance(); 

        public Menuitem GetMenuItemById(int id)
        {
            return _db.Queryable<Menuitem>().Where(t => t.Id == id).First();
        }

        public List<Menuitem> GetMenu()
        {
            return _db.Queryable<Menuitem>().ToList();
        }

        public void AddMenuItem(Menuitem menuItem)
        {
            _db.Saveable(menuItem).ExecuteCommand();
        }

        public void UpdateMenuItem(Menuitem menuItem)
        {
            _db.Updateable(menuItem).ExecuteCommand();
        }

        public void RemoveMenuItem(int id)
        {
            _db.Deleteable<Menuitem>().Where(t=>t.Id==id).ExecuteCommand();
        }

    }
}
