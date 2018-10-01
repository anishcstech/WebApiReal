using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiReal.Models
{
    public class Category_table
    {
        private int categoryTableId;
        private string table_name;
        private int person_per_table;
       

        public Category_table()
        { }

        public Category_table(int categoryTableId, string table_name, int person_per_table)
        {

            this.categoryTableId = categoryTableId;
            this.person_per_table = person_per_table;
            this.table_name = table_name;

        }

        public int CategoryTableId
        {
            get { return categoryTableId; }
            set { categoryTableId = value; }
        }

        public int PersonPerTable
        {
            get { return person_per_table; }
            set { person_per_table = value; }
        }
        public string TableName {
            get { return table_name; }
            set { table_name = value; }
        }
    }
}
