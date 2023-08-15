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
        CATHODE.BML _gblItem;
        XDocument _gblItemXML;

        XElement _selectedElement;

        public InventoryLoot()
        {
            InitializeComponent();

            _gblItem = new CATHODE.BML(SharedData.pathToAI + @"\DATA\GBL_ITEM.BML");
            _gblItemXML = XDocument.Parse(_gblItem.Content.OuterXml.Replace(" xmlns=\"http://www.w3schools.com\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.w3schools.com gbl_item.xsd\"", ""));

            ReloadUI();
        }

        private void ReloadUI()
        {
            listView.BeginUpdate();
            keyframe.BeginUpdate();
            held_object_name.BeginUpdate();
            thrown_object_name.BeginUpdate();
            special_slot.BeginUpdate();
            target_weapon.BeginUpdate();

            listView.Items.Clear();
            keyframe.Items.Clear();
            held_object_name.Items.Clear();
            thrown_object_name.Items.Clear();
            special_slot.Items.Clear();
            target_weapon.Items.Clear();

            //Parse all item configs
            Action<string> parseItems = delegate (string groupName)
            {
                IEnumerable<XElement> items = _gblItemXML.XPathSelectElements("//item_database/objects/" + groupName);
                foreach (XElement item in items)
                {
                    string itemName = item.Attribute("name").Value.ToString();
                    listView.Items.Add(new ListViewItem() { Name = itemName, Text = itemName, Group = listView.Groups[groupName] });

                    //Add available options to our attribute dropdowns, if they exist
                    keyframe.Items.Add(itemName);
                    if (groupName == "weapon") target_weapon.Items.Add(itemName);
                    try { held_object_name.Items.Add(item.Attribute("held_object_name").Value.ToString()); } catch { }
                    try { thrown_object_name.Items.Add(item.Attribute("thrown_object_name").Value.ToString()); } catch { }
                }
            };
            parseItems("object");
            //parseItems("object_held");
            parseItems("weapon");
            parseItems("ammo");
            parseItems("medikit");
            parseItems("ied");
            parseItems("light");

            //Add all available item slots to UI
            IEnumerable<XElement> slots = _gblItemXML.XPathSelectElements("//item_database/special_slots/slot");
            foreach (XElement slot in slots)
                special_slot.Items.Add(slot.Attribute("name").Value.ToString());

            listView.EndUpdate();
            keyframe.EndUpdate();
            held_object_name.EndUpdate();
            thrown_object_name.EndUpdate();
            special_slot.EndUpdate();
            target_weapon.EndUpdate();

            //If an element was previously selected, re-select it
            if (_selectedElement != null)
                listView.Items[_selectedElement.Attribute("name").Value.ToString()].Selected = true;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 1) return;
            _selectedElement = null;

            IEnumerable<XElement> objects = _gblItemXML.XPathSelectElements("//item_database/objects/" + listView.SelectedItems[0].Group.Tag);
            foreach (XElement el in objects)
            {
                if (el.Attribute("name").Value.ToString() == listView.SelectedItems[0].Text)
                {
                    _selectedElement = el;
                    break;
                }
            }

            if (_selectedElement == null)
            {
                MessageBox.Show("Failed to find item in database!", "Lookup fail.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            setAttributeString("name", name, null);
            setAttributeString("thrown_object_name", null, thrown_object_name);
            setAttributeString("target_weapon", null, target_weapon);
            setAttributeString("ammo_type", ammo_type, null);
            setAttributeString("held_object_name", null, held_object_name);
            setAttributeString("keyframe", null, keyframe);
            setAttributeString("default_quantity", default_quantity, null);
            setAttributeString("stack_limit", stack_limit, null);
            setAttributeString("consume_when", null, consume_when);
            setAttributeString("composite", composite, null);
            setAttributeString("droppable_when_held", null, droppable_when_held);
            setAttributeString("special_slot", null, special_slot);
            setAttributeString("display_ammo_as_percentage", null, display_ammo_as_percentage);
            setAttributeString("vanish_when_collected", null, vanish_when_collected);
            setAttributeString("display_quantity", null, display_quantity);
            setAttributeString("radial_menu_order_index", radial_menu_order_index, null);
            setAttributeString("crafting_resource", null, crafting_resource);
            setAttributeString("localisation_tag", localisation_tag, null);
            setAttributeString("activated_by", null, activated_by);
            setAttributeString("health_increase_percentage", health_increase_percentage, null);
            setAttributeString("upgraded_health_increase_percentage", upgraded_health_increase_percentage, null);
            setAttributeString("drop_when_consume", null, drop_when_consume);
            setAttributeString("cancellable_duration_in_seconds", cancellable_duration_in_seconds, null);
        }

        //return attribute as string (and handle nulls)
        private void setAttributeString(string attributeName, TextBox textbox, ComboBox combobox)
        {
            if (textbox == null)
            {
                try
                {
                    combobox.Text = _selectedElement.Attribute(attributeName).Value.ToString();
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
                    textbox.Text = _selectedElement.Attribute(attributeName).Value.ToString();
                    textbox.Enabled = true;
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
            if (_selectedElement == null)
            {
                MessageBox.Show("Please load an inventory item first.");
                return;
            }

            try { _selectedElement.Attribute("name").Value = name.Text; } catch { }
            try { _selectedElement.Attribute("thrown_object_name").Value = thrown_object_name.Text; } catch { }
            try { _selectedElement.Attribute("target_weapon").Value = target_weapon.Text; } catch { }
            try { _selectedElement.Attribute("ammo_type").Value = ammo_type.Text; } catch { }
            try { _selectedElement.Attribute("held_object_name").Value = held_object_name.Text; } catch { }
            try { _selectedElement.Attribute("keyframe").Value = keyframe.Text; } catch { }
            try { _selectedElement.Attribute("default_quantity").Value = default_quantity.Text; } catch { }
            try { _selectedElement.Attribute("stack_limit").Value = stack_limit.Text; } catch { }
            try { _selectedElement.Attribute("consume_when").Value = consume_when.Text; } catch { }
            try { _selectedElement.Attribute("composite").Value = composite.Text; } catch { }
            try { _selectedElement.Attribute("droppable_when_held").Value = droppable_when_held.Text; } catch { }
            try { _selectedElement.Attribute("special_slot").Value = special_slot.Text; } catch { }
            try { _selectedElement.Attribute("display_ammo_as_percentage").Value = display_ammo_as_percentage.Text; } catch { }
            try { _selectedElement.Attribute("vanish_when_collected").Value = vanish_when_collected.Text; } catch { }
            try { _selectedElement.Attribute("display_quantity").Value = display_quantity.Text; } catch { }
            try { _selectedElement.Attribute("radial_menu_order_index").Value = radial_menu_order_index.Text; } catch { }
            try { _selectedElement.Attribute("crafting_resource").Value = crafting_resource.Text; } catch { }
            try { _selectedElement.Attribute("localisation_tag").Value = localisation_tag.Text; } catch { }
            try { _selectedElement.Attribute("activated_by").Value = activated_by.Text; } catch { }
            try { _selectedElement.Attribute("health_increase_percentage").Value = health_increase_percentage.Text; } catch { }
            try { _selectedElement.Attribute("upgraded_health_increase_percentage").Value = upgraded_health_increase_percentage.Text; } catch { }
            try { _selectedElement.Attribute("drop_when_consume").Value = drop_when_consume.Text; } catch { }
            try { _selectedElement.Attribute("cancellable_duration_in_seconds").Value = cancellable_duration_in_seconds.Text; } catch { }

            _gblItem.Content.LoadXml(_gblItemXML.ToString());
            _gblItem.Save();

            ReloadUI();

            MessageBox.Show("Saved new item configuration!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
