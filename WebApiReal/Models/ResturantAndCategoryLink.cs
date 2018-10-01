using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiReal.Models
{
    public class ResturantAndCategoryLink
    {
        private int primarykey;
        private int resturantId;
        private int categoryTableId;
        private int numberOfTables;
        private int price;


        public ResturantAndCategoryLink(int primarykey,int resturantId,int categoryTableId,int numberOfTables,int price) {

            this.primarykey = primarykey;
            this.resturantId = resturantId;
            this.categoryTableId = categoryTableId;
            this.numberOfTables = numberOfTables;
            this.price = price;
        }
        public int ResturantId
        {
            get { return resturantId; }
        }

        public int CategoryTableId
        {
            get { return categoryTableId; }
        }

        public int NumOfTables
        {
            get { return numberOfTables; }
        }

        public int Price
        {
            get { return price; }
        }


    }
}
