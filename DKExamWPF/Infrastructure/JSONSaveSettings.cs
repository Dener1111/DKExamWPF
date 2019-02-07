using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DKExamWPF.Model;
using Newtonsoft.Json;

namespace DKExamWPF.Infrastructure
{
    class JSONSaveSettings : ISaveSettings
    {
        public Settings Load()
        {
            try
            {
                Settings des = new Settings();
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (StreamReader sr = new StreamReader(@"config.json"))
                using (JsonReader reader = new JsonTextReader(sr))
                    des = serializer.Deserialize<Settings>(reader);

                return des;
            }
            catch (Exception)
            {
                return new Settings();
            }
        }

        public void Save(Settings s)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"config.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, s);
            }
        }
    }
}
