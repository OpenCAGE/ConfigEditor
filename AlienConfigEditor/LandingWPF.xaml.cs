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

namespace AlienConfigEditor
{
    /// <summary>
    /// Interaction logic for LandingWPF.xaml
    /// </summary>
    public partial class LandingWPF : UserControl
    {
        public Action<ConfigEditorForm> OnButtonPress;

        public LandingWPF()
        {
            InitializeComponent();
        }
        public void SetVersionInfo(string version)
        {
            VersionText.Content = "Version " + version;
        }

        private void EditConfigBtn(object sender, RoutedEventArgs e)
        {
            OnButtonPress?.Invoke(ConfigEditorForm.EDIT_CONFIGS);
        }
        private void ResetConfigBtn(object sender, RoutedEventArgs e)
        {
            OnButtonPress?.Invoke(ConfigEditorForm.RESET_CONFIGS);
        }
        private void LoadPreviousBtn(object sender, RoutedEventArgs e)
        {
            OnButtonPress?.Invoke(ConfigEditorForm.LOAD_CONFIGS);
        }
        private void ExportChangesBtn(object sender, RoutedEventArgs e)
        {
            OnButtonPress?.Invoke(ConfigEditorForm.EXPORT_CONFIGS);
        }
    }
}
