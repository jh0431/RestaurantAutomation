using Microsoft.VisualStudio.TestTools.UnitTesting; 
using Models;

namespace RestaurantAutomation.DAO.Tests
{
    [TestClass()]
    public class UserDaoTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            UserDao userDao = new UserDao();
            Assert.IsTrue(userDao.Login(new User("admin", "admin")));
        }

        [TestMethod()]
        public void GetUserByIdTest()
        {
            UserDao userDao = new UserDao(); 
            Assert.IsTrue(1==userDao.GetUserById(1).Id);
        }

        [TestMethod()]
        public void GetUserByUserNameTest()
        {
            UserDao userDao = new UserDao();
            userDao.addUser(new User("test5", "test5")); 
            Assert.IsTrue("test5".Equals(userDao.GetUserByUserName("test5").Username));
        }

        [TestMethod()]
        public void GetUsersTest()
        {
            UserDao userDao = new UserDao(); 
            Assert.IsTrue(userDao.GetUserByUserName( "admin")!=null);
        }

        [TestMethod()]
        public void addUserTest()
        {
            UserDao userDao = new UserDao();
            userDao.addUser(new User("test", "test"));
            Assert.IsTrue(userDao.Login(new User("test", "test")));
        }

        [TestMethod()]
        public void updateUserTest()
        {
            UserDao userDao = new UserDao();
            userDao.addUser(new User("test2", "test2"));
            User u = userDao.GetUserByUserName("test2");
            u.Username = "test3";
            u.Password = "test4";
            userDao.updateUser(u);
            Assert.IsTrue(u.Username.Equals( userDao.GetUserByUserName("test3").Username));
            Assert.IsTrue( u.Password.Equals(userDao.GetUserByUserName("test3").Password));

        }

        [TestMethod()]
        public void removeUserTest()
        { 
            UserDao userDao = new UserDao();
            userDao.addUser(new User("test1", "test1"));
            userDao.removeUser(userDao.GetUserByUserName("test1").Id);
            Assert.IsNull(userDao.GetUserByUserName("test1")); 
        }
    }
}