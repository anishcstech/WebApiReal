using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiReal.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiReal.Controllers
{
    [Route("api/[controller]")]
    public class ResturantViewController : Controller
    {

        List<Resturant> resturantList = new List<Resturant>();
        List<Category_table> categorylist = new List<Category_table>();
        List<ResturantAndCategoryLink> restlink = new List<ResturantAndCategoryLink>();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IEnumerable<object> Get(int id)
        {
          ////////////////////////
          ///generate resturant List
            resturantList.Add(new Resturant(1,"xyz","abc.jpg",
                "dfdhfdhjf dhdfj","9518815108",
                "gargashu003@gmail.com","Sirsa","Haryana","India","125201",5));
            resturantList.Add(new Resturant(2, "abc", "abc.jpg",
               "dfdhfdhjf dhdfj", "8437973043", 
               "gargashu003@gmail.com", "Amritsar", "Punjab", "India", "125201",4));
            resturantList.Add(new Resturant(3, "tyu", "abc.jpg",
               "dfdhfdhjf dhdfj", "9518815108", 
               "garga003@gmail.com", "Sirsa", "Haryana", "India", "125201",3));


            //////////////////////
            ///generate table categorylist
            categorylist.Add(new Category_table(1,"Golden",2));
            categorylist.Add(new Category_table(2, "Silver", 4));
            categorylist.Add(new Category_table(3, "Platinum", 6));
            categorylist.Add(new Category_table(4, "Titanium", 8));

            ////////////////////////
            ///generate list of link between the both previous list
            restlink.Add(new ResturantAndCategoryLink(1,1,1,4,500));
            restlink.Add(new ResturantAndCategoryLink(2, 1, 2, 5, 1000));
            restlink.Add(new ResturantAndCategoryLink(3, 2, 1, 4, 1000));
            restlink.Add(new ResturantAndCategoryLink(4, 2, 3, 4, 2000));
            restlink.Add(new ResturantAndCategoryLink(5, 3, 4, 4, 5000));

            var list = (from resturant in resturantList
                        join link in restlink on resturant.ResturantId equals link.ResturantId
                        where link.CategoryTableId == id && resturant.rating>2
                        //here u need to give the condtitions and get result
                        //&& link.Price > 500 && resturant.city == "Sirsa" if want to search according this
                        //then take the object from the request first
                        select new
                        {
                            ResturantName = resturant.Name,
                            ResturantImg = resturant.Img,
                            TableNumber = link.NumOfTables,
                            TablePrice = link.Price
                        });

            ///first get the id from the category table
            ///then get the list from the ResturantAndcategory get the resturants  
            return list;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
