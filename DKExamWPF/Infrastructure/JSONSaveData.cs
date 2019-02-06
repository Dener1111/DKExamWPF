using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DKExamWPF.Model;

namespace DKExamWPF.Infrastructure
{
    class JSONSaveData : ISaveData
    {
        public ObservableCollection<Item> Load()
        {
            throw new NotImplementedException();
        }

        public void Save(ObservableCollection<Item> s)
        {
            throw new NotImplementedException();
        }
    }
}
