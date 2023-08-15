﻿/*
 * 
 * Created by Matt Filer
 * www.mattfiler.co.uk
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace AlienConfigEditor
{
    public partial class InventoryLoot : Form
    {
        string loadedType = "";

        CATHODE.BML globalItem;
        XDocument globalItemXML;

        public InventoryLoot()
        {
            InitializeComponent();

            //Load-in XML data
            globalItem = new CATHODE.BML(SharedData.pathToAI + @"\DATA\GBL_ITEM.BML");
            globalItemXML = XDocument.Parse(globalItem.Content.OuterXml.Replace(" xmlns=\"http://www.w3schools.com\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.w3schools.com gbl_item.xsd\"", ""));

            //Update object lists
            Inv_Ammo.Items.Clear();
            keyframe.Items.Clear();
            target_weapon.Items.Clear();
            thrown_object_name.Items.Clear();
            held_object_name.Items.Clear();
            IEnumerable<XElement> ammos = globalItemXML.XPathSelectElements("//item_database/objects/ammo");
            foreach (XElement el in ammos)
            {
                Inv_Ammo.Items.Add(el.Attribute("name").Value.ToString());
                keyframe.Items.Add(el.Attribute("name").Value.ToString());
                try { held_object_name.Items.Add(el.Attribute("held_object_name").Value.ToString()); } catch { }
                try { thrown_object_name.Items.Add(el.Attribute("thrown_object_name").Value.ToString()); } catch { }
            }
            Inv_IED.Items.Clear();
            IEnumerable<XElement> ieds = globalItemXML.XPathSelectElements("//item_database/objects/ied");
            foreach (XElement el in ieds)
            {
                Inv_IED.Items.Add(el.Attribute("name").Value.ToString());
                keyframe.Items.Add(el.Attribute("name").Value.ToString());
                try { held_object_name.Items.Add(el.Attribute("held_object_name").Value.ToString()); } catch { }
                try { thrown_object_name.Items.Add(el.Attribute("thrown_object_name").Value.ToString()); } catch { }
            }
            Inv_Lights.Items.Clear();
            IEnumerable<XElement> lights = globalItemXML.XPathSelectElements("//item_database/objects/light");
            foreach (XElement el in lights)
            {
                Inv_Lights.Items.Add(el.Attribute("name").Value.ToString());
                keyframe.Items.Add(el.Attribute("name").Value.ToString());
                try { held_object_name.Items.Add(el.Attribute("held_object_name").Value.ToString()); } catch { }
                try { thrown_object_name.Items.Add(el.Attribute("thrown_object_name").Value.ToString()); } catch { }
            }
            Inv_MedKit.Items.Clear();
            IEnumerable<XElement> medkits = globalItemXML.XPathSelectElements("//item_database/objects/medikit");
            foreach (XElement el in medkits)
            {
                Inv_MedKit.Items.Add(el.Attribute("name").Value.ToString());
                keyframe.Items.Add(el.Attribute("name").Value.ToString());
                try { held_object_name.Items.Add(el.Attribute("held_object_name").Value.ToString()); } catch { }
                try { thrown_object_name.Items.Add(el.Attribute("thrown_object_name").Value.ToString()); } catch { }
            }
            Inv_Objects.Items.Clear();
            IEnumerable<XElement> objects = globalItemXML.XPathSelectElements("//item_database/objects/object");
            foreach (XElement el in objects)
            {
                Inv_Objects.Items.Add(el.Attribute("name").Value.ToString());
                keyframe.Items.Add(el.Attribute("name").Value.ToString());
                try { held_object_name.Items.Add(el.Attribute("held_object_name").Value.ToString()); } catch { }
                try { thrown_object_name.Items.Add(el.Attribute("thrown_object_name").Value.ToString()); } catch { }
            }
            Inv_Weapons.Items.Clear();
            IEnumerable<XElement> weapons = globalItemXML.XPathSelectElements("//item_database/objects/weapon");
            foreach (XElement el in weapons)
            {
                Inv_Weapons.Items.Add(el.Attribute("name").Value.ToString());
                keyframe.Items.Add(el.Attribute("name").Value.ToString());
                target_weapon.Items.Add(el.Attribute("name").Value.ToString());
                try { held_object_name.Items.Add(el.Attribute("held_object_name").Value.ToString()); } catch { }
                try { thrown_object_name.Items.Add(el.Attribute("thrown_object_name").Value.ToString()); } catch { }
            }
            special_slot.Items.Clear();
            IEnumerable<XElement> slots = globalItemXML.XPathSelectElements("//item_database/special_slots/slot");
            foreach (XElement el in slots)
            {
                special_slot.Items.Add(el.Attribute("name").Value.ToString());
            }
        }

        private void edit_objects_Click(object sender, EventArgs e)
        {
            loadItem(Inv_Objects, "object");
        }

        private void edit_weapons_Click(object sender, EventArgs e)
        {
            loadItem(Inv_Weapons, "weapon");
        }

        private void edit_ammo_Click(object sender, EventArgs e)
        {
            loadItem(Inv_Ammo, "ammo");
        }

        private void edit_medikit_Click(object sender, EventArgs e)
        {
            loadItem(Inv_MedKit, "medikit");
        }

        private void edit_ied_Click(object sender, EventArgs e)
        {
            loadItem(Inv_IED, "ied");
        }

        private void edit_light_Click(object sender, EventArgs e)
        {
            loadItem(Inv_Lights, "light");
        }

        //load selected item
        private void loadItem(ListBox listbox, string loadedObject)
        {
            //Let everyone know
            loadedType = loadedObject;

            //Get selected item
            IEnumerable<XElement> objects = globalItemXML.XPathSelectElements("//item_database/objects/"+loadedObject);
            foreach (XElement el in objects)
            {
                if (el.Attribute("name").Value.ToString() == listbox.GetItemText(listbox.SelectedItem))
                {
                    setAttributeString("name", el, name, null);
                    setAttributeString("thrown_object_name", el, null, thrown_object_name);
                    setAttributeString("target_weapon", el, null, target_weapon);
                    setAttributeString("ammo_type", el, ammo_type, null);
                    setAttributeString("held_object_name", el, null, held_object_name);
                    setAttributeString("keyframe", el, null, keyframe);
                    setAttributeString("default_quantity", el, default_quantity, null);
                    setAttributeString("stack_limit", el, stack_limit, null);
                    setAttributeString("consume_when", el, null, consume_when);
                    setAttributeString("composite", el, composite, null);
                    setAttributeString("droppable_when_held", el, null, droppable_when_held);
                    setAttributeString("special_slot", el, null, special_slot);
                    setAttributeString("display_ammo_as_percentage", el, null, display_ammo_as_percentage);
                    setAttributeString("vanish_when_collected", el, null, vanish_when_collected);
                    setAttributeString("display_quantity", el, null, display_quantity);
                    setAttributeString("radial_menu_order_index", el, radial_menu_order_index, null);
                    setAttributeString("crafting_resource", el, null, crafting_resource);
                    setAttributeString("localisation_tag", el, localisation_tag, null);
                    setAttributeString("activated_by", el, null, activated_by);
                    setAttributeString("health_increase_percentage", el, health_increase_percentage, null);
                    setAttributeString("upgraded_health_increase_percentage", el, upgraded_health_increase_percentage, null);
                    setAttributeString("drop_when_consume", el, null, drop_when_consume);
                    setAttributeString("cancellable_duration_in_seconds", el, cancellable_duration_in_seconds, null);
                }
            }
        }

        //return attribute as string (and handle nulls)
        private void setAttributeString(string attributeName, XElement el, TextBox textbox, ComboBox combobox)
        {
            if (textbox == null)
            {
                try
                {
                    combobox.Text = el.Attribute(attributeName).Value.ToString();
                    combobox.Enabled = true;
                }
                catch
                {
                    combobox.SelectedIndex = -1;
                    combobox.Enabled = false;
                }
            }
            else
            {
                try
                {
                    textbox.Text = el.Attribute(attributeName).Value.ToString();
                    textbox.Enabled = true;
                    textbox.ReadOnly = false;
                    if (attributeName == "name")
                    {
                        textbox.ReadOnly = true;
                        textbox.BackColor = Color.White;
                    }
                }
                catch
                {
                    textbox.Text = "";
                    textbox.Enabled = false;
                }
            }
        }

        //Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update cursor and begin
            Cursor.Current = Cursors.WaitCursor;

            if (name.Text == "")
            {
                //No playlist selected, can't load anything
                MessageBox.Show("Please load an inventory item first.");
            }
            else
            {
                //Get all data from type
                IEnumerable<XElement> elements = globalItemXML.XPathSelectElements("//item_database/objects/"+loadedType);
                foreach (XElement el in elements)
                {
                    if (el.Attribute("name").Value.ToString() == name.Text)
                    {
                        try { el.Attribute("thrown_object_name").Value = thrown_object_name.Text; } catch { }
                        try { el.Attribute("target_weapon").Value = target_weapon.Text; } catch { }
                        try { el.Attribute("ammo_type").Value = ammo_type.Text; } catch { }
                        try { el.Attribute("held_object_name").Value = held_object_name.Text; } catch { }
                        try { el.Attribute("keyframe").Value = keyframe.Text; } catch { }
                        try { el.Attribute("default_quantity").Value = default_quantity.Text; } catch { }
                        try { el.Attribute("stack_limit").Value = stack_limit.Text; } catch { }
                        try { el.Attribute("consume_when").Value = consume_when.Text; } catch { }
                        try { el.Attribute("composite").Value = composite.Text; } catch { }
                        try { el.Attribute("droppable_when_held").Value = droppable_when_held.Text; } catch { }
                        try { el.Attribute("special_slot").Value = special_slot.Text; } catch { }
                        try { el.Attribute("display_ammo_as_percentage").Value = display_ammo_as_percentage.Text; } catch { }
                        try { el.Attribute("vanish_when_collected").Value = vanish_when_collected.Text; } catch { }
                        try { el.Attribute("display_quantity").Value = display_quantity.Text; } catch { }
                        try { el.Attribute("radial_menu_order_index").Value = radial_menu_order_index.Text; } catch { }
                        try { el.Attribute("crafting_resource").Value = crafting_resource.Text; } catch { }
                        try { el.Attribute("localisation_tag").Value = localisation_tag.Text; } catch { }
                        try { el.Attribute("activated_by").Value = activated_by.Text; } catch { }
                        try { el.Attribute("health_increase_percentage").Value = health_increase_percentage.Text; } catch { }
                        try { el.Attribute("upgraded_health_increase_percentage").Value = upgraded_health_increase_percentage.Text; } catch { }
                        try { el.Attribute("drop_when_consume").Value = drop_when_consume.Text; } catch { }
                        try { el.Attribute("cancellable_duration_in_seconds").Value = cancellable_duration_in_seconds.Text; } catch { }
                    }
                }

                //Save all to XML
                globalItem.Content.LoadXml(globalItemXML.ToString());
                globalItem.Save();

                //Done
                MessageBox.Show("Saved new inventory item configuration.");
            }

            //Update cursor and finish
            Cursor.Current = Cursors.Default;
        }
    }
}
