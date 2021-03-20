using SqlSugar;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Menuitem
    {
        /// <summary>
        /// 
        /// </summary>
        public Menuitem()
        {
        }

        public Menuitem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Decimal? Price { get; set; }
    }
}
