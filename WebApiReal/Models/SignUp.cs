using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiReal.Models
{
    public class SignUp
    {
        private int signupkey;
        private string name;
        private string email;
        private string contact;
        private string password;
        private DateTime dateandtimeOfLogin;
        public SignUp() { }
        public SignUp(int signupkey,string name,string email,string contact,string password,DateTime dateandtimeOfLogin)
        {
            this.signupkey = signupkey;
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.password = password;
            this.dateandtimeOfLogin = dateandtimeOfLogin;
        }
        public DateTime DateAndTimeOfLogin
        {
            get { return dateandtimeOfLogin; }
            set { dateandtimeOfLogin = value; }
        }
        public int SignUpKey {
            get { return signupkey; }
            set { signupkey = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
