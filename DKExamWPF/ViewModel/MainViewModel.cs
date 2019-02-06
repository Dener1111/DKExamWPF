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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace DKExamWPF
{
    class MainViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Item> items;
        public ObservableCollection<Item> Items
        {
            get => items;
            set
            {
                items = value;
                Notify();
            }
        }
        Item selectedItem;
        public Item SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                Notify();
            }
        }

        ISaveData saveData;
        ISaveSettings saveSettings;

        public bool Edit { get; set; } = true;
        public bool LargeIcons { get; set; }
        public bool DarkTheme { get; set; }
        public bool English { get; set; }
        public bool Russian { get; set; }

        #region commands
        public ICommand LoadCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand DelAllCommand { get; set; }

        public ICommand EngCommand { get; set; }
        public ICommand RusCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand DelCommand { get; set; }
        #endregion

        public MainViewModel(ISaveData sd, ISaveSettings ss)
        {
            saveData = sd;
            saveSettings = ss;
            
            Properties.Resources.Culture = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);
            
            DelAllCommand = new RelayCommand(x => Items.Clear());

            EngCommand = new RelayCommand(x => Utility.ChangeLang("en-US"));
            RusCommand = new RelayCommand(x => Utility.ChangeLang("ru-RU"));
            AddCommand = new RelayCommand(x => Items.Add(new Item()));
            DelCommand = new RelayCommand(x => Items.Remove(SelectedItem));
            
            Items = new ObservableCollection<Item>();
        }
        void CheckLang_Obsolete()//TODO: delete and redo normalno
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["Culture"].Value == "en-US")
                English = true;
            else
                Russian = true;
        }

        void Notify([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
