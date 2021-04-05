using System;
using System.Collections.Generic;
using Models;
using SqlSugar;

namespace RestaurantAutomation.DAO
{
    public class TableDao
    {
        SqlSugarClient db = DBHelper.GetInstance();

        public List<Table> GetTableList()
        {
            return db.Queryable<Table>().ToList();
        }

        public Table GetTableById(int id)
        {
            return db.Queryable<Table>().Where(t => t.Id == id).First();
        }

        public void updateTable(Table table)
        {
            db.Updateable(table).ExecuteCommand();
        } 
        
    }
}
