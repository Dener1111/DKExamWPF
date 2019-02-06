using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DKExamWPF.Infrastructure
{
    class MainViewModelLocator
    {
        IKernel kernel;
        public MainViewModelLocator()
        {
            kernel = new StandardKernel(new SaveDataModule(), new SaveSettingsModule());
        }
        public MainViewModel MainViewModel
        {
            get => kernel.Get<MainViewModel>();
        }
    }
}
