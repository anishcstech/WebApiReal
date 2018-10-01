using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiReal.Models
{
    public class Resturant
    {
        private int resturantId;
        private string name;
        private string img;
        private string address;
        private string contact;
        private string email;
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public int rating { get; set; }

        public Resturant(int resturantId,string name,string img,string address,string contact,
            string email,string city,string state,string country,string zipcode,int rating) {

            this.resturantId = resturantId;
            this.name = name;
            this.img = img;
            this.address = address;
            this.contact = contact;
            this.email = email;
            this.city = city;
            this.state = state;
            this.country = country;
            this.zipcode = zipcode;
            this.rating = rating;
        }
        public int ResturantId {
            get { return resturantId; }
            set { resturantId = value; }
        }

        public string Img
        {
            get { return img; }
            set { img = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
