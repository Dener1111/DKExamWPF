using DKExamWPF.Infrastructure;
using DKExamWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Configuration;
using System.Globalization;
using System.Windows;

namespace DKExamWPF
{
    class MainViewModel
    {
        public ObservableCollection<Item> Items{get;set;}
        public Item SelectedItem { get; set; }

        public bool Edit { get; set; } = true;
        public bool LargeIcons { get; set; }
        public bool DarkTheme{ get; set; }
        public bool English { get; set; }
        public bool Russian { get; set; }

        public ICommand EngCommand { get; set; }
        public ICommand RusCommand { get; set; }

        public MainViewModel()//IItem
        {
            Items = new ObservableCollection<Item>();

            Properties.Resources.Culture = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);

            EngCommand = new RelayCommand(x => Utility.ChangeLang("en-US"));
            RusCommand = new RelayCommand(x => Utility.ChangeLang("ru-RU"));

            CheckLang();
        }
        
        void CheckLang()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["Culture"].Value == "en-US")
                English = true;
            else
                Russian = true;
        }
    }
}
