/*
 * 
 * Created by Matt Filer
 * www.mattfiler.co.uk
 * 
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AlienConfigEditor
{
    public partial class ConfigEditor : Form
    {
        public ConfigEditor()
        {
            InitializeComponent();
        }

        //On Load
        private void Landing_Load(object sender, EventArgs e)
        {
            //Set fonts & parents
            HeaderText.Font = FontManager.GetFont(1, 80);
            HeaderText.Parent = HeaderImage;
            Title1.Font = FontManager.GetFont(0, 20);
            Title2.Font = FontManager.GetFont(0, 20);
            Title3.Font = FontManager.GetFont(0, 20);
            Title4.Font = FontManager.GetFont(0, 20);
        }

        //Open BehaviourPacker
        private void openBehaviourTreePackager_Click(object sender, EventArgs e)
        {
        }

        //Open CharEd
        private void button2_Click(object sender, EventArgs e)
        {
            CharEd attributeForm = new CharEd();
            attributeForm.Show();
        }

        //Open AlienConfigEditor
        private void openAlienConfig_Click(object sender, EventArgs e)
        {
            AlienConfigEditor alienConfigForm = new AlienConfigEditor();
            alienConfigForm.Show();
        }

        //Open DifficultyEditor
        private void openDifficultyEditor_Click(object sender, EventArgs e)
        {
            DifficultyEditor diffEditorForm = new DifficultyEditor();
            diffEditorForm.Show();
        }

        //Open ViewconeEditor (global)
        private void openViewconeEditor_Click(object sender, EventArgs e)
        {
            ViewconeEditor viewconeSetEditor = new ViewconeEditor();
            viewconeSetEditor.Show();
        }

        //Open ViewconeEditor (character)
        private void openCharViewconeEditor_Click(object sender, EventArgs e)
        {
            CharViewconeEditor viewconeCharSetEditor = new CharViewconeEditor();
            viewconeCharSetEditor.Show();
        }

        //Open WeaponEditor
        private void openWeaponEditor_Click(object sender, EventArgs e)
        {
            WeaponEditor weaponEditorForm = new WeaponEditor();
            weaponEditorForm.Show();
        }

        //Open radiosity editor
        private void openRadiosityEditor_Click(object sender, EventArgs e)
        {
            RadiosityEditor radEdFormc = new RadiosityEditor();
            radEdFormc.Show();
        }

        //open loot inventory settings
        private void openLootInvSettings_Click(object sender, EventArgs e)
        {
            InventoryLoot openInvEditor = new InventoryLoot();
            openInvEditor.Show();
        }

        //open loadscreen movie playlist editor
        private void button4_Click(object sender, EventArgs e)
        {
            LoadMovieEditor openLoadscreenEditor = new LoadMovieEditor();
            openLoadscreenEditor.Show();
        }

        //open blueprint editor
        private void openBlueprintEditor_Click(object sender, EventArgs e)
        {
            BlueprintEditor openBPEditor = new BlueprintEditor();
            openBPEditor.Show();
        }

        //open hack tool editor
        private void openHackEditor_Click(object sender, EventArgs e)
        {
            HackingEditor openHackEditor = new HackingEditor();
            openHackEditor.Show();
        }

        //open locomotion editor
        private void button1_Click(object sender, EventArgs e)
        {
            LocomotionEditor openLocomotionEditor = new LocomotionEditor();
            openLocomotionEditor.Show();
        }

        //open material property editor
        private void openMaterialPropEditor_Click(object sender, EventArgs e)
        {
            MaterialEditor openMaterialPropertyEditor = new MaterialEditor();
            openMaterialPropEditor.Show();
        }

        //open game
        private void startGame_Click(object sender, EventArgs e)
        {
            //Process.Start(gameDirectory + @"\AI.exe");
            Process.Start("steam://rungameid/214490");
        }

        //Open graphics settings editor
        private void openGraphicsSettings_Click(object sender, EventArgs e)
        {
            GraphicsEditor openGraphicsEditor = new GraphicsEditor();
            openGraphicsEditor.Show();
        }

        //Close
        bool closedManually = false;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(SharedData.pathToWorkingFiles, true);
                Directory.CreateDirectory(SharedData.pathToWorkingFiles);
            }
            catch { }
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
    }
}
