using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGitTest.Model
{
    public class TerminModel
    {
        private int _id;
        private DateTime _datum;
        private string _titel;
        private string _ort;
        private string _partner;
        private float _abstand;

        public int ID
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                }
            }
        }

        public DateTime Datum
        {
            get { return _datum; }
            set
            {
                if (_datum != value)
                {
                    _datum = value;
                }
            }
        }

        public string Titel
        {
            get { return _titel; }
            set
            {
                if (_titel != value)
                {
                    _titel = value;
                }
            }
        }

        public string Partner
        {
            get { return _partner; }
            set
            {
                if (_partner != value)
                {
                    _partner = value;
                }
            }
        }

        public string Ort
        {
            get { return _ort; }
            set
            {
                if (_ort != value)
                {
                    _ort = value;
                }
            }
        }

        public float Abstand
        {
            get { return _abstand; }
            set
            {
                if (_abstand != value)
                {
                    _abstand = value;
                }
            }
        }

    }
}
