using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
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

                //TODO: Call XML methode
                if (characterDataArray.Length <= 0)
                {
                    XMLDataHandle(filePathName);
                }

                return _listOfHouseNrStr;

            }
        }

        //Function that handle the data from xml files
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
                                        Console.WriteLine("Element Value: " + characterData.ToArray()[i].Element("CharacterID").Value);
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
