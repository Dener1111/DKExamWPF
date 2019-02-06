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
        public string Battary { get; set; }
        public bool Touchscreen { get; set; }
        public bool PhoneJack { get; set; }
    }
}
