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

#if DEBUG
            openMaterialPropEditor.Enabled = true;
#endif
        }

        //On Load
        private void Landing_Load(object sender, EventArgs e)
        {
            //Set fonts & parents
            HeaderText.Font = FontManager.GetFont(1, 80);
            HeaderText.Parent = HeaderImage;
            Title1.Font = FontManager.GetFont(0, 20);
            Title3.Font = FontManager.GetFont(0, 20);
            Title4.Font = FontManager.GetFont(0, 20);
        }

        //Open CharEd
        private void button2_Click(object sender, EventArgs e)
        {
            CharEd attributeForm = new CharEd();
            attributeForm.Show();
            attributeForm.FormClosed += OnFormClosed;
        }

        //Open AlienConfigEditor
        private void openAlienConfig_Click(object sender, EventArgs e)
        {
            AlienConfigEditor alienConfigForm = new AlienConfigEditor();
            alienConfigForm.Show();
            alienConfigForm.FormClosed += OnFormClosed;
        }

        //Open DifficultyEditor
        private void openDifficultyEditor_Click(object sender, EventArgs e)
        {
            DifficultyEditor diffEditorForm = new DifficultyEditor();
            diffEditorForm.Show();
            diffEditorForm.FormClosed += OnFormClosed;
        }

        //Open ViewconeEditor (global)
        private void openViewconeEditor_Click(object sender, EventArgs e)
        {
            ViewconeEditor viewconeSetEditor = new ViewconeEditor();
            viewconeSetEditor.Show();
            viewconeSetEditor.FormClosed += OnFormClosed;
        }

        //Open ViewconeEditor (character)
        private void openCharViewconeEditor_Click(object sender, EventArgs e)
        {
            CharViewconeEditor viewconeCharSetEditor = new CharViewconeEditor();
            viewconeCharSetEditor.Show();
            viewconeCharSetEditor.FormClosed += OnFormClosed;
        }

        //Open WeaponEditor
        private void openWeaponEditor_Click(object sender, EventArgs e)
        {
            WeaponEditor weaponEditorForm = new WeaponEditor();
            weaponEditorForm.Show();
            weaponEditorForm.FormClosed += OnFormClosed;
        }

        //Open radiosity editor
        private void openRadiosityEditor_Click(object sender, EventArgs e)
        {
            RadiosityEditor radEdFormc = new RadiosityEditor();
            radEdFormc.Show();
            radEdFormc.FormClosed += OnFormClosed;
        }

        //open loot inventory settings
        private void openLootInvSettings_Click(object sender, EventArgs e)
        {
            InventoryLoot openInvEditor = new InventoryLoot();
            openInvEditor.Show();
            openInvEditor.FormClosed += OnFormClosed;
        }

        //open loadscreen movie playlist editor
        private void button4_Click(object sender, EventArgs e)
        {
            LoadMovieEditor openLoadscreenEditor = new LoadMovieEditor();
            openLoadscreenEditor.Show();
            openLoadscreenEditor.FormClosed += OnFormClosed;
        }

        //open blueprint editor
        private void openBlueprintEditor_Click(object sender, EventArgs e)
        {
            BlueprintEditor openBPEditor = new BlueprintEditor();
            openBPEditor.Show();
            openBPEditor.FormClosed += OnFormClosed;
        }

        //open hack tool editor
        private void openHackEditor_Click(object sender, EventArgs e)
        {
            HackingEditor openHackEditor = new HackingEditor();
            openHackEditor.Show();
            openHackEditor.FormClosed += OnFormClosed;
        }

        //open locomotion editor
        private void button1_Click(object sender, EventArgs e)
        {
            LocomotionEditor openLocomotionEditor = new LocomotionEditor();
            openLocomotionEditor.Show();
            openLocomotionEditor.FormClosed += OnFormClosed;
        }

        //open material property editor
        private void openMaterialPropEditor_Click(object sender, EventArgs e)
        {
            MaterialEditor openMaterialPropertyEditor = new MaterialEditor();
            openMaterialPropertyEditor.Show();
            openMaterialPropertyEditor.FormClosed += OnFormClosed;
        }

        //Open graphics settings editor
        private void openGraphicsSettings_Click(object sender, EventArgs e)
        {
            GraphicsEditor openGraphicsEditor = new GraphicsEditor();
            openGraphicsEditor.Show();
            openGraphicsEditor.FormClosed += OnFormClosed;
        }

        //Open localisation editor
        private void openLocalisationEditor_Click(object sender, EventArgs e)
        {
            LocalisationEditor openLocalisationEditor = new LocalisationEditor();
            openLocalisationEditor.Show();
            openLocalisationEditor.FormClosed += OnFormClosed;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.BringToFront();
            this.Focus();
        }
    }
}
