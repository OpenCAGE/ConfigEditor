using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AlienConfigEditor
{
    public partial class RadiosityEditor : Form
    {
        string pathToLightingFile;

        public RadiosityEditor()
        {
            InitializeComponent();
            pathToLightingFile = SharedData.pathToAI + @"\DATA\RADIOSITY_SETTINGS.TXT";

            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string radiosityToSave = 
                "settings_file_version=1" + Environment.NewLine +
                "gRadiosityEmissiveSurfaceScale=" + gRadiosityEmissiveSurfaceScale.Text + Environment.NewLine +
                "gRadiosityFirstBounceScale=" + gRadiosityFirstBounceScale.Text + Environment.NewLine +
                "gRadiosityMultiBounceScale=" + gRadiosityMultiBounceScale.Text + Environment.NewLine +
                "gRadiosityAlbedoOverbrightAmount=" + gRadiosityAlbedoOverbrightAmount.Text + Environment.NewLine +
                "gRadiosityAlbedoSaturationAmount=" + gRadiosityAlbedoSaturationAmount.Text + Environment.NewLine +
                "gRadiositySpecularGlossScale=" + gRadiositySpecularGlossScale.Text + Environment.NewLine +
                "gDeferredEmissiveSurfaceScale=" + gDeferredEmissiveSurfaceScale.Text + Environment.NewLine +
                "gDeferredEmissiveSurfaceExponent=" + gDeferredEmissiveSurfaceExponent.Text;
            File.WriteAllText(pathToLightingFile, radiosityToSave);

            MessageBox.Show("Successfully saved new lighting settings.");
        }

        private void RadiosityEditor_Load(object sender, EventArgs e)
        {
            string[] lightingData = File.ReadAllLines(SharedData.pathToAI + @"\DATA\RADIOSITY_SETTINGS.TXT");
            for (int i = 0; i < lightingData.Length; i++) if (lightingData[i] != "") lightingData[i] = lightingData[i].Split('=')[1];

            gRadiosityEmissiveSurfaceScale.Text = lightingData[1];
            gRadiosityFirstBounceScale.Text = lightingData[2];
            gRadiosityMultiBounceScale.Text = lightingData[3];
            gRadiosityAlbedoOverbrightAmount.Text = lightingData[4];
            gRadiosityAlbedoSaturationAmount.Text = lightingData[5];
            gRadiositySpecularGlossScale.Text = lightingData[6];
            gDeferredEmissiveSurfaceScale.Text = lightingData[7];
            gDeferredEmissiveSurfaceExponent.Text = lightingData[8];

            Cursor.Current = Cursors.Default;
        }
    }
}
