using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DKExamWPF.Model;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace DKExamWPF.Infrastructure
{
    class JSONSaveData : ISaveData
    {
        public Data Load()
        {
            try
            {
                string path = OpenFile();
                if (path != "")
                {
                    Data des = new Data(new ObservableCollection<Item>());
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.NullValueHandling = NullValueHandling.Ignore;

                    using (StreamReader sr = new StreamReader(path))
                    using (JsonReader reader = new JsonTextReader(sr))
                        des = serializer.Deserialize<Data>(reader);

                    return des;
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return new Data(new ObservableCollection<Item>());
            }
        }

        string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.json)|*.json";//|All files (*.*)|*.*
            if (openFileDialog.ShowDialog() == true)
                return openFileDialog.FileName;
            return "";
        }

        public void Save(Data s)
        {
            string path = SaveFile();
            if (path != "")
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (StreamWriter sw = new StreamWriter(path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                    serializer.Serialize(writer, s);
            }
        }

        string SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.json)|*.json";//|All files (*.*)|*.*

            if (saveFileDialog.ShowDialog() == true)
                return saveFileDialog.FileName;
            return "";
        }
    }
}
