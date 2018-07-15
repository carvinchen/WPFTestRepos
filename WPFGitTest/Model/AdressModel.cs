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
        private string _street;
        private string _houseNr;
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

        //C# 6.0 new feature: A initializer to an auto-property DOESNT WORK with VS 2013...
        //public string Country { get; set; } = "Deutschland";





    }
}
