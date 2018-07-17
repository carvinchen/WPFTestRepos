using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WPFGitTest.Model;

namespace WPFGitTest.ViewModel
{
    public class AdressViewModel : INotifyPropertyChanged
    {
        public static int[] listOfHouseNumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public XElement[] characterDataArray = new XElement[] { };

        public static string filePath = Directory.GetCurrentDirectory();
        public static string defaultXMLFileName = @"..\..\files\SavingGameData_past.xml";
        //public static string defaultXMLFileName = "testData.xml";
        public string filePathName = Path.Combine(filePath, defaultXMLFileName);

        private AdressModel _adressModel;
        //private string[] _istOfHouseNrStr = new string[listOfHouseNumber.Length];
        private string[] _listOfHouseNrStr = new string[] { };

        private string _playerID;
        private string _playerName;
        private string _playerGender;
        private string _playerRace;
        private string _playerHomeplanet;
        private string _playerLifeform;

        private ObservableCollection<AdressViewModel> _listOfVMAdress = new ObservableCollection<AdressViewModel>();

        public AdressViewModel() {

            if (characterDataArray.Length <= 0)
            {
                XMLDataHandle(filePathName);
            }
        }

        public AdressViewModel(string pID, string pName, string pGender, string pRace, string pHomeplanet, string pLifeForm)
        {
            PlayerID = pID;
            PlayerName = pName;
            PlayerGender = pGender;
            PlayerRace = pRace;
            PlayerHomeplanet = pHomeplanet;
            PlayerLifeform = pLifeForm;

        } 

        public AdressModel AdressModel
        {
            get { return _adressModel; }
            set
            {
                if (_adressModel != value)
                {
                    _adressModel = value;
                    OnPropertyChanged("AdressModel");
                }
            }
        }

        public ObservableCollection<AdressViewModel> AdressVMList
        {
            get { return _listOfVMAdress; }
            set
            {
                if (_listOfVMAdress != value)
                {
                    _listOfVMAdress = value;
                    OnPropertyChanged("AdressVMList");
                }
            }
        }

        //Additional data of game character
        public string PlayerID
        {
            get { return _playerID; }
            set
            {
                if (_playerID != value)
                {
                    _playerID = value;
                    OnPropertyChanged("PlayerID");
                }
            }
        }

        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                if (_playerName != value)
                {
                    _playerName = value;
                    OnPropertyChanged("PlayerName");
                }
            }
        }

        public string PlayerGender
        {
            get { return _playerGender; }
            set
            {
                if (_playerGender != value)
                {
                    _playerGender = value;
                    OnPropertyChanged("PlayerGender");
                }
            }
        }

        public string PlayerRace
        {
            get { return _playerRace; }
            set
            {
                if (_playerRace != value)
                {
                    _playerRace = value;
                    OnPropertyChanged("PlayerRace");
                }
            }
        }

        public string PlayerHomeplanet
        {
            get { return _playerHomeplanet; }
            set
            {
                if (_playerHomeplanet != value)
                {
                    _playerHomeplanet = value;
                    OnPropertyChanged("PlayerHomeplanet");
                }
            }
        }

        public string PlayerLifeform
        {
            get { return _playerLifeform; }
            set
            {
                if (_playerLifeform != value)
                {
                    _playerLifeform = value;
                    OnPropertyChanged("PlayerLifeform");
                }
            }
        }

        //Using getter methode
        public string[] ListOfHouseNr
        {
            get
            {
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
        public string[] ListOfHouseNrLing
        {
            get
            {
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
                        for (int i = 0; i < houseNrQuery.ToArray().Length; i++)
                        {
                            _listOfHouseNrStr[i] = houseNrQuery.ToArray()[i].ToString();
                        }
                    }
                }

                return _listOfHouseNrStr;
            }
        }

        //Function that handles and initializes the data from xml files for viewmodel
        public void XMLDataHandle(string filePath)
        {

            if (!string.IsNullOrEmpty(filePath))
            {
                if (File.Exists(filePath))
                {
                    //Console.WriteLine("File exits.");
                    XElement gData = XElement.Load(filePath);

                    if (gData.Elements().Count() > 0)
                    {
                        //Console.WriteLine("File has " + gData.Elements().ToArray().Length.ToString() + " character data groups");

                        var characterData =
                            from character in gData.Elements("CharacterDataGroup").Elements("CharacterData")
                            select character;

                        int charCount =
                            (from character in gData.Elements("CharacterDataGroup").Elements("CharacterData")
                             select character).Count();

                        //Console.WriteLine("File has " + charCount.ToString() + " Character data.");

                        if (characterData.Count() > 0)
                        {
                            characterDataArray = new XElement[characterData.Count()];

                            for (int i = 0; i < characterData.Count(); i++)
                            {
                                if (characterData.ToArray()[i].HasElements)
                                {
                                    if (characterData.ToArray()[i].Element("CharacterID") != null)
                                    {

                                        characterDataArray[i] = characterData.ToArray()[i];
                                        //Console.WriteLine("Element Value: " + characterData.ToArray()[i].Element("CharacterID").Value);

                                        AdressViewModel listOfAdressVM = new AdressViewModel(
                                            characterData.ToArray()[i].Element("CharacterID").Value,
                                            characterData.ToArray()[i].Element("Name").Value,
                                            characterData.ToArray()[i].Element("Gender").Value,
                                            characterData.ToArray()[i].Element("Races").Value,
                                            characterData.ToArray()[i].Element("Homeplanet").Value,
                                            characterData.ToArray()[i].Element("LifeForm").Value
                                            );

                                        if (!AdressVMList.Contains(listOfAdressVM))
                                        {
                                            AdressVMList.Add(listOfAdressVM);
                                        }
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("NO data ha´s been found.");
                    }
                }
                else
                {
                    Console.WriteLine("File NOT FOUND.");
                }
            }
        }

        public int SelectedHouseNumber
        {

            get { return AdressModel.HouseNr; }
            set
            {
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
