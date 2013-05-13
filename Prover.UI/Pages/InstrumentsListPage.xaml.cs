using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prover.UI.ViewModel;

namespace Prover.UI.Pages
{
    /// <summary>
    /// Interaction logic for InstrumentsListPage.xaml
    /// </summary>
    public partial class InstrumentsListPage : UserControl
    {
        public InstrumentsListPage()
        {
            InitializeComponent();

            // create and assign the appearance view model
            this.DataContext = new InstrumentsListPageViewModel();
        }
    }
}
