using SqlSugar;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Table
    {
        /// <summary>
        /// 
        /// </summary>
        public Table()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Status { get; set; }
    }
}
