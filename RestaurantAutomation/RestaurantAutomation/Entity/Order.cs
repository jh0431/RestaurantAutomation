using SqlSugar;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public Order()
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
        public System.String Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TableNum { get; set; }

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
