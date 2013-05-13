using FirstFloor.ModernUI.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Prover.Data.ProviderModel;
using Prover.Instruments.Data;

namespace Prover.UI.ViewModel
{
    public class InstrumentsListPageViewModel
        : NotifyPropertyChanged
    {
        private InstrumentDataProvider instruments;
        public InstrumentsListPageViewModel()
        {
            instruments = new InstrumentDataProvider();
        }

        public List<BaseInstrument> ListOfInstruments()
        {
            return instruments.GetInstrumentsBySerialNumber("01084240");
        }
    }
}
