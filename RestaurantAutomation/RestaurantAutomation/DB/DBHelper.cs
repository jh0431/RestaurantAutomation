using SqlSugar;
using System;
using System.Configuration;

namespace RestaurantAutomation
{
    public class DBHelper
    {
        public static  SqlSugarClient GetInstance()
        { 
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString =  ConfigurationManager.ConnectionStrings["strCon"].ToString(),//连接符字串
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });
             
            //db.Aop.OnLogExecuting = (sql, pars) =>
            //{
            //    Console.WriteLine(sql);
            //};
            return db;
        }
    }
}
