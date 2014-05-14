using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Events;


namespace Prover.Certificates.Reports
{
    public class CertificateReports : IModule, IProverModule
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public string Title { get; private set; }
        public string Icon { get; private set; }
        public string ToolTipText { get; private set; }
        public ICommand StartCommand { get; private set; }
    }
}
