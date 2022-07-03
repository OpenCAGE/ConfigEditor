using System;
using System.Windows.Forms;

namespace AlienConfigEditor
{
    public partial class Filemanager_ResetMod : Form
    {
        AlienModPack AlienPacker = new AlienModPack();

        public Filemanager_ResetMod()
        {
            InitializeComponent();

            //Set fonts & parents
            HeaderText.Font = FontManager.GetFont(1, 80);
            HeaderText.Parent = HeaderImage;
            Title1.Font = FontManager.GetFont(0, 20);
            Title2.Font = FontManager.GetFont(0, 20);
        }

        //Close form
        bool closedManually = false;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            try { GC.Collect(); GC.WaitForPendingFinalizers(); } catch { }
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

        //reset all
        private void SelectMod_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("ALL", false);
        }

        //reset individual
        private void ResetGraphics_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("GRAPHICS", false);
        }
        private void ResetLighting_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("LIGHTING", false);
        }
        private void ResetAlienConfigs_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("ALIENCONFIGS", false);
        }
        private void ResetDifficulties_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("DIFFICULTIES", false);
        }
        private void ResetViewconesets_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("VIEWCONES", false);
        }
        private void ResetAmmo_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("AMMO", false);
        }
        private void ResetGblItem_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("GBL_ITEM", false);
        }
        private void ResetChrInfo_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("CHR_INFO", false);
        }
        private void ResetPackages_Click(object sender, EventArgs e)
        {
            AlienPacker.ResetFiles("PACKAGES", false);
        }
    }
}
