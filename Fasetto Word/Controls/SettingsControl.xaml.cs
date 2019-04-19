using Fasetto.Word.Core.IoC;
using System.Windows.Controls;

namespace Fasetto_Word
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            // Set datacontext to settings view model
            DataContext = IoC.Settings;
        }
    }
}
