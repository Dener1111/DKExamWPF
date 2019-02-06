using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Infrastructure
{
    class Settings
    {
        public bool Edit { get; set; }
        public bool LargeIcons { get; set; }
        public bool DarkTheme { get; set; }
        public bool English { get; set; }
        public bool Russian { get; set; }

        public Settings(bool edit = true, bool largeI = false, bool darkT = false, bool en = true, bool ru = false)
        {
            Edit = edit;
            LargeIcons = largeI;
            DarkTheme = darkT;
            English = en;
            Russian = ru;
        }
    }
}
