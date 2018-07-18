using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WPFGitTest.Model;

namespace WPFGitTest.ViewModel
{
    public class ActorViewModel : INotifyPropertyChanged
    {
        private ActorModel _actorModel;

        public ActorModel ActorModel {
            get { return _actorModel; }
            set
            {
                if (_actorModel != value)
                {
                    _actorModel = value;

                    OnPropertyChanged("ActorModel");
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
