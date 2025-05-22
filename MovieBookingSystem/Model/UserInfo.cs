using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem.Model
{
    public class UserInfo
    {
        public static UserInfo CurrentUser { get; set; }
        private string fullName;
        private string email;
        private int phone;
        private string city;
        private string address;
        private int zip;
        private string country;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    
        public UserInfo(string fullName, string email, int phone, string city, string address, int zip, string country)
        {
          this.fullName = fullName;
            this.email = email;
            this.phone = phone;
            this.city = city;
            this.address = address;
            this.zip = zip;
            this.country = country;
        }
        public UserInfo()
        {
           
        }
    }
}
