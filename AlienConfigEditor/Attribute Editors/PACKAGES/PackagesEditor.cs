using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace AlienConfigEditor
{
    public partial class PackagesEditor : Form
    {
        XDocument packagesXML = null;
        List<string> baseGameMaps = new List<string>();
        public PackagesEditor()
        {
            InitializeComponent();
            packagesXML = XDocument.Load(SharedData.pathToAI + "/DATA/PACKAGES/MAIN.PKG");
            ReloadList();
        }
        
        /* Reload level list */
        private void ReloadList()
        {
            mapList.Items.Clear();
            IEnumerable<XElement> elements = packagesXML.XPathSelectElements("//package/game_data/levels/*");
            foreach (XElement el in elements)
                mapList.Items.Add(el.Attribute("id").Value);
        }

        /* Add level */
        private void addNewMap_Click(object sender, EventArgs e)
        {
            if (newMapName.Text.Length > 11 && newMapName.Text.Substring(11).ToUpper() == "PRODUCTION/") newMapName.Text = newMapName.Text.Substring(11);
            if (newMapName.Text.Contains(' '))
            {
                MessageBox.Show("Level ID cannot contain spaces!", "Incorrectly formatted ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(SharedData.pathToAI + "/DATA/ENV/PRODUCTION/" + newMapName.Text))
            {
                MessageBox.Show("Level ID does not match ENV directory!\nMake sure your level is placed in /DATA/ENV/PRODUCTION/.", "Cannot find level by ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            packagesXML.XPathSelectElement("//package/game_data/levels").Add(XElement.Parse(@"<level id='Production\" + newMapName.Text + @"' path='data\ENV\Production\" + newMapName.Text + "' />"));
            packagesXML.Save(SharedData.pathToAI + "/DATA/PACKAGES/MAIN.PKG");
            ReloadList();
        }

        /* Remove level */
        private void removeSelectedMap_Click(object sender, EventArgs e)
        {
            if (mapList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a level from the list to remove it!", "No level selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IEnumerable<XElement> elements = packagesXML.XPathSelectElements("//package/game_data/levels/*");
            XElement toRemove = null;
            foreach (XElement el in elements)
            {
                if (el.Attribute("id").Value == mapList.Items[mapList.SelectedIndex].ToString())
                {
                    toRemove = el;
                    break;
                }
            }
            if (toRemove == null) return;
            toRemove.Remove();
            packagesXML.Save(SharedData.pathToAI + "/DATA/PACKAGES/MAIN.PKG");
            ReloadList();
        }
    }
}
