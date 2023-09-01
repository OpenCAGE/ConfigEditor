using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AlienConfigEditor
{
    public partial class ConfigEditor : Form
    {
        ActiveTab _activeTab = null;

        public ConfigEditor()
        {
            InitializeComponent();

            treeView1.ExpandAll();

#if DEBUG
            openMaterialPropEditor.Visible = true;
#endif
        }

        private void openMaterialPropEditor_Click(object sender, EventArgs e)
        {
            ShowTab(Tabs.MATERIAL_EDITOR);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null || node.Tag == null) return;

            ShowTab((Tabs)node.Tag);
        }

        private void ShowTab(Tabs tab)
        {
            if (_activeTab != null)
            {
                if (_activeTab.Type == tab) return;
                _activeTab.Content.Close();
            }
            _activeTab = new ActiveTab(tab);
            _activeTab.Content.Show(dockPanel1, DockState.Document);
        }
    }

    public class ActiveTab
    {
        public Tabs Type;
        public DockContent Content;

        public ActiveTab(Tabs type)
        {
            Type = type;
            switch (type)
            {
                case Tabs.CHARACTER_ATTRIBUTE_EDITOR:
                    Content = new CharEd();
                    break;
                case Tabs.ALIEN_CONFIG_EDITOR:
                    Content = new AlienConfigEditor();
                    break;
                case Tabs.DIFFICULTY_EDITOR:
                    Content = new DifficultyEditor();
                    break;
                case Tabs.VIEWCONE_EDITOR:
                    Content = new ViewconeEditor();
                    break;
                case Tabs.SENSE_EDITOR:
                    Content = new CharViewconeEditor();
                    break;
                case Tabs.WEAPON_AMMO_EDITOR:
                    Content = new WeaponEditor();
                    break;
                case Tabs.RADIOSITY_EDITOR:
                    Content = new RadiosityEditor();
                    break;
                case Tabs.ITEM_AND_WEAPON_EDITOR:
                    Content = new InventoryLoot();
                    break;
                case Tabs.LOADSCREEN_PLAYLIST_EDITOR:
                    Content = new LoadMovieEditor();
                    break;
                case Tabs.BLUEPRINT_EDITOR:
                    Content = new BlueprintEditor();
                    break;
                case Tabs.HACK_TOOL_EDITOR:
                    Content = new HackingEditor();
                    break;
                case Tabs.LOCOMOTION_EDITOR:
                    Content = new LocomotionEditor();
                    break;
                case Tabs.MATERIAL_EDITOR:
                    Content = new MaterialEditor();
                    break;
                case Tabs.GRAPHICS_SETTINGS_EDITOR:
                    Content = new GraphicsEditor();
                    break;
                case Tabs.LOCALISATION_EDITOR:
                    Content = new LocalisationEditor();
                    break;
            }
        }
    }

    public enum Tabs
    {
        CHARACTER_ATTRIBUTE_EDITOR,
        ALIEN_CONFIG_EDITOR,
        DIFFICULTY_EDITOR,
        VIEWCONE_EDITOR,
        SENSE_EDITOR,
        WEAPON_AMMO_EDITOR,
        RADIOSITY_EDITOR,
        ITEM_AND_WEAPON_EDITOR,
        LOADSCREEN_PLAYLIST_EDITOR,
        BLUEPRINT_EDITOR,
        HACK_TOOL_EDITOR,
        LOCOMOTION_EDITOR,
        MATERIAL_EDITOR,
        GRAPHICS_SETTINGS_EDITOR,
        LOCALISATION_EDITOR,
    }
}
