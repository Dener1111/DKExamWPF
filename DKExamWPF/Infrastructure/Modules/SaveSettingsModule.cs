using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Infrastructure
{
    class SaveSettingsModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISaveSettings>().To<JSONSaveSettings>();
        }
    }
}
