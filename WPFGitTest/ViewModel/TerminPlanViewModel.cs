using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using WPFGitTest.Model;

namespace WPFGitTest.ViewModel
{
    class TerminPlanViewModel : INotifyPropertyChanged
    {

        private TerminModel _terminPlanModel;

        public TerminModel TerminPlanModel
        {
            get { return _terminPlanModel; }
            set
            {
                if (_terminPlanModel != value)
                {
                    _terminPlanModel = value;
                    OnPropertyChanged("TerminPlanModel");
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
