using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;

namespace WPFGitTest.Model
{
    [Table (Name="Actors")]
    public class ActorModel
    {

        private int _id;
        private string _actor;
        private string _city;
        private string _country;
        private string _age;

        public int ID {
            get { return _id; }
            set { 
                if(_id != value){
                    _id = value;
                }
            }
        }

        public string Actor
        {
            get { return _actor; }
            set
            {
                if (_actor != value)
                {
                    _actor = value;
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

        public string Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                }
            }
        }

    }
}
