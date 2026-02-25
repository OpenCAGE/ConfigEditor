using CATHODE;
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
using WeifenLuo.WinFormsUI.Docking;

namespace AlienConfigEditor
{
    public partial class GlobalConstantsEditor : DockContent
    {
        private BML _globalConstants;

        public GlobalConstantsEditor()
        {
            InitializeComponent();

            _globalConstants = new BML(SharedData.pathToAI + @"\DATA\GLOBALCONSTANTS.BML");

            stealth_light_meter_full_dark_threshold.Text = _globalConstants.Content["GlobalConstants"]["StealthLightMeter"]["stealth_light_meter_full_dark_threshold"].InnerText;
            stealth_light_meter_full_light_threshold.Text = _globalConstants.Content["GlobalConstants"]["StealthLightMeter"]["stealth_light_meter_full_light_threshold"].InnerText;
            stealth_light_meter_timeout_when_detected.Text = _globalConstants.Content["GlobalConstants"]["StealthLightMeter"]["stealth_light_meter_timeout_when_detected"].InnerText;

            interaction_distance_threshold.Text = _globalConstants.Content["GlobalConstants"]["Interaction"]["interaction_distance_threshold"].InnerText;

            min_time_between_squad_shots_lower_bound.Text = _globalConstants.Content["GlobalConstants"]["squad_shots"]["min_time_between_squad_shots_lower_bound"].InnerText;
            min_time_between_squad_shots_upper_bound.Text = _globalConstants.Content["GlobalConstants"]["squad_shots"]["min_time_between_squad_shots_upper_bound"].InnerText;

            min_time_suspicious_reaction_loop.Text = _globalConstants.Content["GlobalConstants"]["suspicious_item_reaction"]["min_time_suspicious_reaction_loop"].InnerText;
            max_time_suspicious_reaction_loop.Text = _globalConstants.Content["GlobalConstants"]["suspicious_item_reaction"]["max_time_suspicious_reaction_loop"].InnerText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var doc = _globalConstants.Content;

            doc["GlobalConstants"]["StealthLightMeter"]["stealth_light_meter_full_dark_threshold"].InnerText = stealth_light_meter_full_dark_threshold.Text;
            doc["GlobalConstants"]["StealthLightMeter"]["stealth_light_meter_full_light_threshold"].InnerText = stealth_light_meter_full_light_threshold.Text;
            doc["GlobalConstants"]["StealthLightMeter"]["stealth_light_meter_timeout_when_detected"].InnerText = stealth_light_meter_timeout_when_detected.Text;

            doc["GlobalConstants"]["Interaction"]["interaction_distance_threshold"].InnerText = interaction_distance_threshold.Text;

            doc["GlobalConstants"]["squad_shots"]["min_time_between_squad_shots_lower_bound"].InnerText = min_time_between_squad_shots_lower_bound.Text;
            doc["GlobalConstants"]["squad_shots"]["min_time_between_squad_shots_upper_bound"].InnerText = min_time_between_squad_shots_upper_bound.Text;

            doc["GlobalConstants"]["suspicious_item_reaction"]["min_time_suspicious_reaction_loop"].InnerText = min_time_suspicious_reaction_loop.Text;
            doc["GlobalConstants"]["suspicious_item_reaction"]["max_time_suspicious_reaction_loop"].InnerText = max_time_suspicious_reaction_loop.Text;

            _globalConstants.Content = doc;
            _globalConstants.Save();
        }

        private void min_time_suspicious_reaction_loop_TextChanged(object sender, EventArgs e)
        {
            min_time_suspicious_reaction_loop.Text = ForceStringNumeric(min_time_suspicious_reaction_loop.Text, true);
        }

        private void max_time_suspicious_reaction_loop_TextChanged(object sender, EventArgs e)
        {
            max_time_suspicious_reaction_loop.Text = ForceStringNumeric(max_time_suspicious_reaction_loop.Text, true);
        }

        private void min_time_between_squad_shots_lower_bound_TextChanged(object sender, EventArgs e)
        {
            min_time_between_squad_shots_lower_bound.Text = ForceStringNumeric(min_time_between_squad_shots_lower_bound.Text, true);
        }

        private void min_time_between_squad_shots_upper_bound_TextChanged(object sender, EventArgs e)
        {
            min_time_between_squad_shots_upper_bound.Text = ForceStringNumeric(min_time_between_squad_shots_upper_bound.Text, true);
        }

        private void interaction_distance_threshold_TextChanged(object sender, EventArgs e)
        {
            interaction_distance_threshold.Text = ForceStringNumeric(interaction_distance_threshold.Text, true);
        }

        private void stealth_light_meter_timeout_when_detected_TextChanged(object sender, EventArgs e)
        {
            stealth_light_meter_timeout_when_detected.Text = ForceStringNumeric(stealth_light_meter_timeout_when_detected.Text, true);
        }

        private void stealth_light_meter_full_dark_threshold_TextChanged(object sender, EventArgs e)
        {
            stealth_light_meter_full_dark_threshold.Text = ForceStringNumeric(stealth_light_meter_full_dark_threshold.Text, true);
        }

        private void stealth_light_meter_full_light_threshold_TextChanged(object sender, EventArgs e)
        {
            stealth_light_meter_full_light_threshold.Text = ForceStringNumeric(stealth_light_meter_full_light_threshold.Text, true);
        }

        /* Utility: force a string to be numeric */
        public static string ForceStringNumeric(string str, bool allowDots = false)
        {
            string editedText = "";
            bool hasIncludedDot = false;
            bool hasIncludedMinus = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsNumber(str[i]) || (str[i] == '.' && allowDots) || (str[i] == '-'))
                {
                    if (str[i] == '-' && hasIncludedMinus) continue;
                    if (str[i] == '-' && i != 0) continue;
                    if (str[i] == '-') hasIncludedMinus = true;
                    if (str[i] == '.' && hasIncludedDot) continue;
                    if (str[i] == '.') hasIncludedDot = true;
                    editedText += str[i];
                }
            }
            if (editedText == "") editedText = "0";
            if (editedText == "-") editedText = "-0";
            if (editedText == ".") editedText = "0";
            return editedText;
        }
    }
}
