using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AlienConfigEditor
{
    public partial class GraphicsEditorPopup : Form
    {
        public GraphicsEditorPopup(string titleOne, string titleTwo, string titleThree)
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
            GraphicsEditor graphicsForm = (GraphicsEditor)Application.OpenForms["GraphicsEditor"];
            graphicsForm.getDataFromPopup(textBox1.Text, textBox2.Text, textBox3.Text, TitleOne.Text);

            this.Close();
        }
    }
}
