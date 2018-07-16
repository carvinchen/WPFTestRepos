using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGitTest.Model
{
    public class AdressModel
    {

        private string _id;
        private string _firstname;
        private string _lastname;
        private string _street;
        private int _houseNr;
        private string _zipCode;
        private string _city;
        private string _country;

        public string ID {
            get { return _id;  }
            set {
                if (_id != value)
                {
                    _id = value;
                }
            }
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if (_firstname != value)
                {
                    _firstname = value;
                }
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                }
            }
        }

        public string Street
        {

            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                }
            }
        }

        public string ZipCode
        {

            get { return _zipCode; }
            set
            {
                if (_zipCode != value)
                {
                    _zipCode = value;
                }
            }
        }

        public string City
        {

            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                }
            }
        }

        public string Country
        {

            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                }
            }
        }

        public int HouseNr {

            get { return _houseNr; }
            set
            {
                if (_houseNr != value)
                {
                    _houseNr = value;
                }
            } 
        } 

        //C# 6.0 new feature: A initializer to an auto-property DOESNT WORK with VS 2013...
        //public string Country { get; set; } = "Deutschland";


    }
}
