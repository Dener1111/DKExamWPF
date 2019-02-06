using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Infrastructure
{
    interface ISaveSettings
    {
        void Save(Settings s);
        Settings Load();
    }
}
