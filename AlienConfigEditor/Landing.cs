using System;
using System.Windows.Forms;

namespace AlienConfigEditor
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Landing_ConfigTools_Load(object sender, EventArgs e)
        {
            LandingWPF wpf = (LandingWPF)elementHost1.Child;
            wpf.SetVersionInfo(ProductVersion);
            wpf.OnButtonPress += OnButtonPress;
        }

        private void OnButtonPress(ConfigEditorForm formType)
        {
            Form form = null;
            switch (formType)
            {
                case ConfigEditorForm.EDIT_CONFIGS:
                    form = new ConfigEditor();
                    break;
                case ConfigEditorForm.RESET_CONFIGS:
                    form = new Filemanager_ResetMod();
                    break;
                case ConfigEditorForm.LOAD_CONFIGS:
                    form = new Filemanager_ImportMod();
                    break;
                case ConfigEditorForm.EXPORT_CONFIGS:
                    form = new Filemanager_ExportMod();
                    break;
            }
            form.Show();
            form.FormClosing += Form_FormClosing;
            this.Hide();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            this.BringToFront();
            this.Focus();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }

    public enum ConfigEditorForm
    {
        EDIT_CONFIGS,
        RESET_CONFIGS,
        LOAD_CONFIGS,
        EXPORT_CONFIGS,
    }
}
