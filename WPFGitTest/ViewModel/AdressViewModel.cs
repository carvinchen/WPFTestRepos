using System;
using System.IO;
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
        public static int[] listOfHouseNumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        public static string filePath = Directory.GetCurrentDirectory();
        public static string defaultXMLFileName = @"..\..\files\SavingGameData_past.xml";
        public string filePathName = Path.Combine(filePath, defaultXMLFileName);    

        private AdressModel _adressModel;
        //private string[] _istOfHouseNrStr = new string[listOfHouseNumber.Length];
        private string[] _listOfHouseNrStr = new string[] { };

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

        //Using getter methode
        public string[] ListOfHouseNr {
            get {
                //string[] listOfHouseNrStr = new string[] {};

                if (listOfHouseNumber.Length > 0)
                {
                    _listOfHouseNrStr = new string[listOfHouseNumber.Length];
                    for (int i = 0; i < listOfHouseNumber.Length; i++)
                    {
                        _listOfHouseNrStr[i] = listOfHouseNumber[i].ToString();
                    }
                }
                return _listOfHouseNrStr;
            }
        }

        //Using LING features
        public string[] ListOfHouseNrLing {

            get {

                if (listOfHouseNumber.Length > 0)
                {
                    _listOfHouseNrStr = new string[listOfHouseNumber.Length];
                    
                    //Query creation and only output even number
                    var houseNrQuery =
                        from hNum in listOfHouseNumber
                        where (hNum % 2) == 0
                        select hNum;

                    if (houseNrQuery.Count<int>() > 0)
                    {
                        for(int i = 0; i < houseNrQuery.ToArray().Length; i++){
                            _listOfHouseNrStr[i] = houseNrQuery.ToArray()[i].ToString();
                        }
                    }
                }

                //TODO: Call XML methode

                return _listOfHouseNrStr;
            }
        }


        //Function that handle the data from xml files


        public int SelectedHouseNumber {

            get { return AdressModel.HouseNr; }
            set {
                if (AdressModel.HouseNr != value)
                {
                    AdressModel.HouseNr = value;
                    OnPropertyChanged("SelectedHouseNumber");
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
