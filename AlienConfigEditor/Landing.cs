using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlienConfigEditor;

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
            //Set fonts & parents
            HeaderText.Font = FontManager.GetFont(1, 80);
            HeaderText.Parent = HeaderImage;
            EditConfigs.Font = FontManager.GetFont(0, 40);
            ResetConfigs.Font = FontManager.GetFont(0, 40);
            LoadPrevious.Font = FontManager.GetFont(0, 40);
            ExportChanges.Font = FontManager.GetFont(0, 40);
        }

        bool closedManually = false;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            closedManually = true;
            Landing LandingForm = new Landing();
            LandingForm.Show();
            this.Close();
        }

        //When closing, check to see if we were manually closed
        //If not, halt the whole process to avoid lingering in background
        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            if (!closedManually)
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        //EDIT CONFIGS
        private void EditConfigs_Click(object sender, EventArgs e)
        {
            closedManually = true;
            ConfigEditor editConfigs = new ConfigEditor();
            editConfigs.Show();
            this.Close();
        }

        //RESET CONFIGS
        private void ResetConfigs_Click(object sender, EventArgs e)
        {
            closedManually = true;
            Filemanager_ResetMod resetFiles = new Filemanager_ResetMod();
            resetFiles.Show();
            this.Close();
        }

        //LOAD PREVIOUS CONFIGS
        private void LoadPrevious_Click(object sender, EventArgs e)
        {
            closedManually = true;
            Filemanager_ImportMod importPrevious = new Filemanager_ImportMod();
            importPrevious.Show();
            this.Close();
        }

        //EXPORT CURRENT CONFIGS
        private void ExportChanges_Click(object sender, EventArgs e)
        {
            closedManually = true;
            Filemanager_ExportMod exportChanges = new Filemanager_ExportMod();
            exportChanges.Show();
            this.Close();
        }
    }
}
