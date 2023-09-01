﻿/*
 * 
 * Created by Matt Filer
 * www.mattfiler.co.uk
 * 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using WeifenLuo.WinFormsUI.Docking;

namespace AlienConfigEditor
{
    public partial class ViewconeEditor : DockContent
    {
        //Load shared scripts
        AYZ_AttributeEditors AlienAttribute = new AYZ_AttributeEditors();

        //Common file paths
        string pathToWorkingXML;
        string gameBmlDirectory = @"\DATA\VIEW_CONE_SETS\";

        public ViewconeEditor()
        {
            InitializeComponent();
        }

        //load viewcone set
        private void loadSet_Click(object sender, EventArgs e)
        {
            //Update cursor and begin
            Cursor.Current = Cursors.WaitCursor;

            //Save selected viewcone set name
            string selectedClass = viewconeSets.Text;

            if (selectedClass == "")
            {
                //No viewcone set selected, can't load anything
                MessageBox.Show("Please select a viewcone set first.");
            }
            else
            {
                //Load in XML
                pathToWorkingXML = AlienAttribute.loadXML(selectedClass, gameBmlDirectory);

                //Load-in XML data
                var ChrAttributeXML = XDocument.Load(pathToWorkingXML);

                //Get types
                viewconeTypes.Items.Clear();
                IEnumerable<XElement> elements = ChrAttributeXML.XPathSelectElements("//ViewconeSettings/ViewconeSetting/ViewconeSettings_type");
                foreach (XElement el in elements)
                {
                    viewconeTypes.Items.Add(el.Value.ToString());
                    viewconeTypes.Enabled = true;
                    loadType.Enabled = true;
                }
            }


            AlienAttribute.disableInput(Length, null);
            AlienAttribute.disableInput(SmokeLengthModifier, null);
            AlienAttribute.disableInput(VerticalAngle, null);
            AlienAttribute.disableInput(HorizontalAngle, null);
            AlienAttribute.disableInput(ExposureEffectLower, null);
            AlienAttribute.disableInput(ExposureEffectUpper, null);
            AlienAttribute.disableInput(StanceEffectLower, null);
            AlienAttribute.disableInput(StanceEffectUpper, null);
            AlienAttribute.disableInput(MovementEffectLower, null);
            AlienAttribute.disableInput(MovementEffectUpper, null);
            AlienAttribute.disableInput(SmokeEffectLower, null);
            AlienAttribute.disableInput(SmokeEffectUpper, null);
            AlienAttribute.disableInput(DistanceEffectLower, null);
            AlienAttribute.disableInput(DistanceEffectUpper, null);
            AlienAttribute.disableInput(Light_meter_dark_level, null);
            AlienAttribute.disableInput(Light_meter_partially_lit_level, null);
            AlienAttribute.disableInput(Light_meter_fully_lit_level, null);

            //Update cursor and finish
            Cursor.Current = Cursors.Default;
        }

        //load viewcone type
        private void loadType_Click(object sender, EventArgs e)
        {
            //Update cursor and begin
            Cursor.Current = Cursors.WaitCursor;

            //Save selected viewcone set name
            string selectedType = viewconeTypes.Text;

            if (selectedType == "")
            {
                //No viewcone set selected, can't load anything
                MessageBox.Show("Please select a viewcone type first.");
            }
            else
            {
                //Load-in XML data
                var ChrAttributeXML = XDocument.Load(pathToWorkingXML);

                //Get all data from type
                IEnumerable<XElement> elements = ChrAttributeXML.XPathSelectElements("//ViewconeSettings/ViewconeSetting");
                foreach (XElement el in elements)
                {
                    if (el.Element("ViewconeSettings_type").Value == selectedType)
                    {
                        loadAttributeValue("Length", el, Length);
                        loadAttributeValue("SmokeLengthModifier", el, SmokeLengthModifier);
                        loadAttributeValue("VerticalAngle", el, VerticalAngle);
                        loadAttributeValue("HorizontalAngle", el, HorizontalAngle);
                        loadAttributeValue("ExposureEffectLower", el, ExposureEffectLower);
                        loadAttributeValue("ExposureEffectUpper", el, ExposureEffectUpper);
                        loadAttributeValue("StanceEffectLower", el, StanceEffectLower);
                        loadAttributeValue("StanceEffectUpper", el, StanceEffectUpper);
                        loadAttributeValue("MovementEffectLower", el, MovementEffectLower);
                        loadAttributeValue("MovementEffectUpper", el, MovementEffectUpper);
                        loadAttributeValue("SmokeEffectLower", el, SmokeEffectLower);
                        loadAttributeValue("SmokeEffectUpper", el, SmokeEffectUpper);
                        loadAttributeValue("DistanceEffectLower", el, DistanceEffectLower);
                        loadAttributeValue("DistanceEffectUpper", el, DistanceEffectUpper);
                        loadAttributeValue("Light_meter_dark_level", el, Light_meter_dark_level);
                        loadAttributeValue("Light_meter_partially_lit_level", el, Light_meter_partially_lit_level);
                        loadAttributeValue("Light_meter_fully_lit_level", el, Light_meter_fully_lit_level);
                    }
                }
            }

            //Update cursor and finish
            Cursor.Current = Cursors.Default;
        }
        
        //Save viewcone type
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update cursor and begin
            Cursor.Current = Cursors.WaitCursor;

            //Save selected viewcone set name
            string selectedSet = viewconeSets.Text;
            string selectedType = viewconeTypes.Text;

            if (selectedType == "")
            {
                //No viewcone set selected, can't load anything
                MessageBox.Show("Please load a viewcone type first.");
            }
            else
            {
                //Load-in XML data
                var ChrAttributeXML = XDocument.Load(pathToWorkingXML);

                //Get all data from type
                IEnumerable<XElement> elements = ChrAttributeXML.XPathSelectElements("//ViewconeSettings/ViewconeSetting");
                foreach (XElement el in elements)
                {
                    if (el.Element("ViewconeSettings_type").Value == selectedType)
                    {
                        saveAttributeValue("Length", el, Length);
                        saveAttributeValue("SmokeLengthModifier", el, SmokeLengthModifier);
                        saveAttributeValue("VerticalAngle", el, VerticalAngle);
                        saveAttributeValue("HorizontalAngle", el, HorizontalAngle);
                        saveAttributeValue("ExposureEffectLower", el, ExposureEffectLower);
                        saveAttributeValue("ExposureEffectUpper", el, ExposureEffectUpper);
                        saveAttributeValue("StanceEffectLower", el, StanceEffectLower);
                        saveAttributeValue("StanceEffectUpper", el, StanceEffectUpper);
                        saveAttributeValue("MovementEffectLower", el, MovementEffectLower);
                        saveAttributeValue("MovementEffectUpper", el, MovementEffectUpper);
                        saveAttributeValue("SmokeEffectLower", el, SmokeEffectLower);
                        saveAttributeValue("SmokeEffectUpper", el, SmokeEffectUpper);
                        saveAttributeValue("DistanceEffectLower", el, DistanceEffectLower);
                        saveAttributeValue("DistanceEffectUpper", el, DistanceEffectUpper);
                        saveAttributeValue("Light_meter_dark_level", el, Light_meter_dark_level);
                        saveAttributeValue("Light_meter_partially_lit_level", el, Light_meter_partially_lit_level);
                        saveAttributeValue("Light_meter_fully_lit_level", el, Light_meter_fully_lit_level);
                    }
                }
                
                //Save values
                if (AlienAttribute.saveXML(selectedSet, gameBmlDirectory, ChrAttributeXML))
                {
                    MessageBox.Show("Saved new viewcone type settings.");
                }
                else
                {
                    MessageBox.Show("An error occured while saving.");
                }
            }

            //Update cursor and finish
            Cursor.Current = Cursors.Default;
        }

        //Return XML value
        private void loadAttributeValue(string specificAttribute, XElement el, TextBox textboxToSet)
        {
            try
            {
                if (el.Element(specificAttribute).Value == "")
                {
                    textboxToSet.Text = "";
                    textboxToSet.Enabled = false;
                }
                else
                {
                    textboxToSet.Text = el.Element(specificAttribute).Value;
                    textboxToSet.Enabled = true;
                }
            }
            catch
            {
                textboxToSet.Text = "";
                textboxToSet.Enabled = false;
            }
        }
        
        //Set XML value
        private void saveAttributeValue(string specificAttribute, XElement el, TextBox textboxToSet)
        {
            try
            {
                el.Element(specificAttribute).Value = textboxToSet.Text;
            }
            catch
            {
                //Can't save, hopefully because doesnt exist (should be).
            }
        }
    }
}
