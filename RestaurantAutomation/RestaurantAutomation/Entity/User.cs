using SqlSugar;
using System;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public User()
        {
        }

        public User(String username, String password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Role { get; set; }
    }
}
