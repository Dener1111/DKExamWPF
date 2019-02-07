using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Model
{
    class Item : IItem
    {
        public string Image { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int Battary { get; set; }
        public bool Touchscreen { get; set; }
        public bool PhoneJack { get; set; }

        //public Item(string image = "", string manufacturer = "", string model = "", string cpu = "", string gpu = "", int battary = 0, bool touch = false, bool jack = false)
        //{
        //    Image = image;
        //    Manufacturer = manufacturer;
        //    Model = model;
        //    CPU = cpu;
        //    GPU = gpu;
        //    Battary = battary;
        //    Touchscreen = touch;
        //    PhoneJack = jack;
        //}
    }
}
