using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiReal.Models
{
    public class BookTable
    {
        private int primarykey;
        private int userId;
        private int categoryTableId;
        public int NumberOfTables { get; set; }
        public DateTime Bookdate { get; set; }

        public BookTable() { }
        public BookTable(int primarykey,int userId,int categoryTableId,
            int NumberOfTables,DateTime Bookdate) {
            this.primarykey = primarykey;
            this.userId = userId;
            this.categoryTableId = categoryTableId;
            this.NumberOfTables = NumberOfTables;
            this.Bookdate = Bookdate;
        }
        
        public int PrimaryKey
        {
            get { return primarykey; }
            set { primarykey = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public int CategoryTableId
        {
            get { return categoryTableId; }
            set { categoryTableId = value; }
        }
    }
}
