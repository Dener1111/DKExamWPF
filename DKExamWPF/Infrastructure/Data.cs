using DKExamWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Infrastructure
{
    class Data
    {
        public ObservableCollection<Item> Items { get; set; }
        public Data(ObservableCollection<Item> items)
        {
            Items = items;
        }
    }
}
