using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKExamWPF.Infrastructure
{
    class SaveDataModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISaveData>().To<JSONSaveData>();
        }
    }
}
