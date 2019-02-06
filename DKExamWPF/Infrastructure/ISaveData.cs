using DKExamWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Infrastructure
{
    interface ISaveData
    {
        void Save(ObservableCollection<Item> s);
        ObservableCollection<Item> Load();
    }
}
