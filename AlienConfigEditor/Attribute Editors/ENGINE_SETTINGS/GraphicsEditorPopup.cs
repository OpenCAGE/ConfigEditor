﻿using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AlienConfigEditor
{
    public partial class GraphicsEditorPopup : Form
    {
        public Action<string, string, string, string> OnSaved;

        public GraphicsEditorPopup(string titleOne, string titleTwo, string titleThree = "")
        {
            InitializeComponent();

            TitleOne.Text = titleOne;
            TitleTwo.Text = titleTwo;
            TitleThree.Text = titleThree;

            if (titleThree == "")
            {
                textBox3.Visible = false;
                textBox3.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill out " + TitleOne.Text + "!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please fill out " + TitleTwo.Text + "!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox3.Visible && textBox3.Text == "")
            {
                MessageBox.Show("Please fill out " + TitleThree.Text + "!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OnSaved?.Invoke(textBox1.Text, textBox2.Text, textBox3.Text, TitleOne.Text);
            this.Close();
        }
    }
}
