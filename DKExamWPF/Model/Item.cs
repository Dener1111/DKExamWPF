using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Model
{
    class Item:IItem
    {
        public string Image { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string Battary { get; set; }
        public bool Touchscreen { get; set; }//{Binding SelectedItem.Manufacturer}

        //public Item()
        //{
        //    Image = "https://lumiere-a.akamaihd.net/v1/images/open-uri20150422-20810-1fndzcd_41017374.jpeg";
        //}
    }
}
