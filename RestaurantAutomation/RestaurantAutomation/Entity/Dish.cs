using SqlSugar;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// 
        /// </summary>
        public Dish()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? MenuItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CompletedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? OrderedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? FinishedTime { get; set; }
    }
}
