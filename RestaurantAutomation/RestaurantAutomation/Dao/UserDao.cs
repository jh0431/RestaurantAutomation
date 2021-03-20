using System;
using System.Collections.Generic;
using Models;
using SqlSugar;

namespace RestaurantAutomation.DAO
{
    public class UserDao
    {
        SqlSugarClient db = DBHelper.GetInstance();

        public bool Login(User user)
        {
            int count = db.Queryable<User>().Count(it => it.Username == user.Username || it.Password == user.Password);
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUserById(int id)
        {
            return db.Queryable<User>().Where(t => t.Id == id).First();
        }

        public User GetUserByUserName(string username)
        {
            return db.Queryable<User>().Where(t => t.Username == username).First();
        }

        public List<User> GetUsers()
        {
            return db.Queryable<User>().ToList();
        }

        public void addUser(User user)
        {
            db.Saveable(user).ExecuteCommand();
        }

        public void updateUser(User user)
        {
            db.Updateable(user).ExecuteCommand();
        }

        public void removeUser(int id)
        {
            db.Deleteable<User>().Where(t=>t.Id==id).ExecuteCommand();
        }

    }
}
