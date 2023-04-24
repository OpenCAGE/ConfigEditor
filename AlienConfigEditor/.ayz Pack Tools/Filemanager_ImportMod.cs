using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AlienConfigEditor
{
    public partial class Filemanager_ImportMod : Form
    {
        AlienModPack AlienPacker = new AlienModPack();

        //Count installed mods
        int ModCounter = 0;

        public Filemanager_ImportMod()
        {
            InitializeComponent();

            //Set fonts & parents
            HeaderText.Font = FontManager.GetFont(1, 80);
            HeaderText.Parent = HeaderImage;
            Title1.Font = FontManager.GetFont(0, 20);

            //Mod preview setup
            SELECTED_MOD_TITLE.Font = FontManager.GetFont(0, 16);
            SELECTED_MOD_TITLE.Text = "";
            SELECTED_MOD_DESCRIPTION.Font = FontManager.GetFont(2, 12);
            SELECTED_MOD_DESCRIPTION.Text = "";
        }

        //Load all mod names on start
        private void Filemanager_ImportMod_Load(object sender, EventArgs e)
        {
            //Read in all mod names
            foreach (string directory in Directory.GetDirectories(SharedData.pathToModsFolder))
            {
                InstalledMods.Items.Add(Path.GetFileName(directory));
                ModCounter++;
            }

            Title1.Text = "Showing " + ModCounter + " Available Mods";
        }

        //Load mod info
        private void InstalledMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get info
            string[] ModInfo = AlienPacker.GetModInfo(InstalledMods.SelectedItem.ToString());

            //Load mod info into form
            SELECTED_MOD_TITLE.Text = ModInfo[0];
            SELECTED_MOD_DESCRIPTION.Text = ModInfo[1];
            foreach (string file in Directory.GetFiles(SharedData.pathToModsFolder + InstalledMods.SelectedItem.ToString()))
            {
                if (Path.GetExtension(file) != ".ayz")
                {
                    MOD_PREVIEW.BackgroundImage = Image.FromFile(file);
                }
            }

            //Enable button
            if (ModInfo[0] != "Error" && ModInfo[1] != "Error" && ModInfo[2] != "Error")
            {
                SelectMod.Enabled = true;
            }
            else
            {
                SelectMod.Enabled = false;
            }

            //Try free some memory
            try { GC.Collect(); GC.WaitForPendingFinalizers(); } catch { }
        }

        //Install mod
        private void SelectMod_Click(object sender, EventArgs e)
        {
            if (InstalledMods.SelectedIndex != -1)
            {
                //Show mod info first
                string[] ModInfo = AlienPacker.GetModInfo(InstalledMods.SelectedItem.ToString());

                DialogResult ModConfirmation = MessageBox.Show("Are you sure you wish to install mod \"" + ModInfo[0] + "\"?" + Environment.NewLine + "This will overwrite any existing changes.", "Install mod?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ModConfirmation == DialogResult.Yes)
                {
                    if (AlienPacker.LoadModPack(InstalledMods.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Successfully loaded mod!", "Operation completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An unknown error occured." + Environment.NewLine + "Make sure Alien: Isolation is not open.", "Unable to install mod.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mod was not installed.", "Operation cancelled.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a downloaded mod from the list.", "Unable to load mod.", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shouldn't get here.
            }
        }
    }
}
