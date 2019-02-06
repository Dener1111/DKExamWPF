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

        public bool Edit { get; set; } = true;
        public bool LargeIcons { get; set; }
        public bool DarkTheme { get; set; }
        public bool English { get; set; }
        public bool Russian { get; set; }

        public ICommand EngCommand { get; set; }
        public ICommand RusCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand DelCommand { get; set; }
        public ICommand DelAllCommand { get; set; }

        public MainViewModel()//IItem
        {
            Items = new ObservableCollection<Item>();

            Properties.Resources.Culture = new CultureInfo(ConfigurationManager.AppSettings["Culture"]);

            var dialogContent = new TextBlock
            {
                Text = "Dynamic Dialog!",
                Margin = new Thickness(20)
            };

            EngCommand = new RelayCommand(x => Utility.ChangeLang("en-US"));
            RusCommand = new RelayCommand(x => Utility.ChangeLang("ru-RU"));
            AddCommand = new RelayCommand(x => Items.Add(new Item()));
            DelCommand = new RelayCommand(x => Items.Remove(SelectedItem));
            DelAllCommand = new RelayCommand(x => Items.Clear());

            CheckLang();
        }
        void CheckLang()//TODO: delete and redo normalno
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
