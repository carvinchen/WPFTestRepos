using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WPFGitTest.Model;

namespace WPFGitTest.ViewModel
{
    public class AdressViewModel : INotifyPropertyChanged
    {

        private AdressModel _adressModel;

        public AdressModel AdressModel {

            get { return _adressModel; }
            set {
                if (_adressModel != value)
                {
                    _adressModel = value;
                    OnPropertyChanged("AdressModel");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
