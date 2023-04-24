﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Diagnostics;

namespace AlienConfigEditor
{
    public partial class Filemanager_ExportMod : Form
    {
        public Filemanager_ExportMod()
        {
            InitializeComponent();

            //Set fonts & parents
            HeaderText.Font = FontManager.GetFont(1, 80);
            HeaderText.Parent = HeaderImage;
            Title1.Font = FontManager.GetFont(0, 20);
            Title3.Font = FontManager.GetFont(0, 20);
            Title5.Font = FontManager.GetFont(0, 20);
            Title2.Font = FontManager.GetFont(0, 11);
            Title4.Font = FontManager.GetFont(0, 11);
            Title6.Font = FontManager.GetFont(0, 11);
        }

        //Save mod
        private void SaveMod_Click(object sender, EventArgs e)
        {
            if (ModNameInput.Text != "" &&
                ModDescInput.Text != "" &&
                ModAuthorInput.Text != "" &&
                File.Exists(ModLogo.Text) &&
                WarnOnNoCheckboxSelected())
            {
                string CheckedCheckboxes = "";
                if (checkBox1.Checked) { CheckedCheckboxes += "ENGINE_SETTINGS,"; }
                if (checkBox2.Checked) { CheckedCheckboxes += "GBL_ITEMS,"; }
                if (checkBox3.Checked) { CheckedCheckboxes += "LIGHTING,"; }
                if (checkBox6.Checked) { CheckedCheckboxes += "ALIENCONFIGS,"; }
                if (checkBox8.Checked) { CheckedCheckboxes += "CHR_INFO,"; }
                if (checkBox9.Checked) { CheckedCheckboxes += "DIFFICULTYSETTINGS,"; }
                if (checkBox10.Checked) { CheckedCheckboxes += "VIEW_CONE_SETS,"; }
                if (checkBox11.Checked) { CheckedCheckboxes += "WEAPON_INFO,"; }
                string[] CheckboxArray = CheckedCheckboxes.Substring(0,CheckedCheckboxes.Length - 1).Split(',');

                AlienModPack AlienPacker = new AlienModPack();
                if (AlienPacker.SaveModPack(ModNameInput.Text, ModDescInput.Text, ModAuthorInput.Text, ModLogo.Text, CheckboxArray))
                {
                    MessageBox.Show("Successfully saved mod!", "Operation completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(SharedData.pathToModsFolder); //Open mods folder.

                    //Try free some memory
                    try { GC.Collect(); GC.WaitForPendingFinalizers(); } catch { }
                }
                else
                {
                    MessageBox.Show("An unknown error occured." + Environment.NewLine + "Check that a mod with the same name doesn't already exist!" + Environment.NewLine + "Also ensure you do not use any special characters.", "Mod could not be saved.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields first.", "Mod could not be saved.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Select image
        private void SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectLogo = new OpenFileDialog();
            SelectLogo.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (SelectLogo.ShowDialog() == DialogResult.OK)
            {
                ModLogo.Text = SelectLogo.FileName;
            }
        }

        //Warn if no other checkboxes selected
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WarnOnNoCheckboxSelected();
        }
        private bool WarnOnNoCheckboxSelected()
        {
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox6.Checked == false &&
                checkBox8.Checked == false &&
                checkBox9.Checked == false &&
                checkBox10.Checked == false &&
                checkBox11.Checked == false)
            {
                MessageBox.Show("Please select at least one configuration set to include in the mod.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
