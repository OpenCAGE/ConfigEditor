namespace AlienConfigEditor
{
    partial class ConfigEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Loadscreen Playlists");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Radiosity");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Blueprint Recipes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Graphics Settings");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hack Tool Difficulties");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Localisation");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Core Game", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Difficulty Modifiers");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Senses");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Alien-Specific");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Vision");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Attributes");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Locomotion");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Character", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Items and Weapons");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Ammo");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Inventory", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Configurations", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode14,
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditor));
            this.openMaterialPropEditor = new System.Windows.Forms.Button();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // openMaterialPropEditor
            // 
            this.openMaterialPropEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMaterialPropEditor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.openMaterialPropEditor.Location = new System.Drawing.Point(12, 633);
            this.openMaterialPropEditor.Name = "openMaterialPropEditor";
            this.openMaterialPropEditor.Size = new System.Drawing.Size(209, 25);
            this.openMaterialPropEditor.TabIndex = 50;
            this.openMaterialPropEditor.Text = "Material Property Editor";
            this.openMaterialPropEditor.UseVisualStyleBackColor = true;
            this.openMaterialPropEditor.Visible = false;
            this.openMaterialPropEditor.Click += new System.EventHandler(this.openMaterialPropEditor_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.AllowEndUserDocking = false;
            this.dockPanel1.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockPanel1.Location = new System.Drawing.Point(233, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.dockPanel1.ShowAutoHideContentOnHover = false;
            this.dockPanel1.Size = new System.Drawing.Size(1010, 770);
            this.dockPanel1.TabIndex = 52;
            this.dockPanel1.Theme = this.vS2015BlueTheme1;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(-1, -1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node7";
            treeNode1.Tag = Tabs.LOADSCREEN_PLAYLIST_EDITOR;
            treeNode1.Text = "Loadscreen Playlists";
            treeNode2.Name = "Node8";
            treeNode2.Tag = Tabs.RADIOSITY_EDITOR;
            treeNode2.Text = "Radiosity";
            treeNode3.Name = "Node9";
            treeNode3.Tag = Tabs.BLUEPRINT_EDITOR;
            treeNode3.Text = "Blueprint Recipes";
            treeNode4.Name = "Node10";
            treeNode4.Tag = Tabs.GRAPHICS_SETTINGS_EDITOR;
            treeNode4.Text = "Graphics Settings";
            treeNode5.Name = "Node11";
            treeNode5.Tag = Tabs.HACK_TOOL_EDITOR;
            treeNode5.Text = "Hack Tool Difficulties";
            treeNode6.Name = "Node12";
            treeNode6.Tag = Tabs.LOCALISATION_EDITOR;
            treeNode6.Text = "Localisation";
            treeNode7.ImageKey = "Property.ico";
            treeNode7.Name = "Node4";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "Core Game";
            treeNode8.Name = "Node13";
            treeNode8.Tag = Tabs.DIFFICULTY_EDITOR;
            treeNode8.Text = "Difficulty Modifiers";
            treeNode9.Name = "Node14";
            treeNode9.Tag = Tabs.SENSE_EDITOR;
            treeNode9.Text = "Senses";
            treeNode10.Name = "Node15";
            treeNode10.Tag = Tabs.ALIEN_CONFIG_EDITOR;
            treeNode10.Text = "Alien-Specific";
            treeNode11.Name = "Node16";
            treeNode11.Tag = Tabs.VIEWCONE_EDITOR;
            treeNode11.Text = "Vision";
            treeNode12.Name = "Node17";
            treeNode12.Tag = Tabs.CHARACTER_ATTRIBUTE_EDITOR;
            treeNode12.Text = "Attributes";
            treeNode13.Name = "Node18";
            treeNode13.Tag = Tabs.LOCOMOTION_EDITOR;
            treeNode13.Text = "Locomotion";
            treeNode14.ImageKey = "User.ico";
            treeNode14.Name = "Node5";
            treeNode14.SelectedImageIndex = 4;
            treeNode14.Text = "Character";
            treeNode15.Name = "Node19";
            treeNode15.Tag = Tabs.ITEM_AND_WEAPON_EDITOR;
            treeNode15.Text = "Items and Weapons";
            treeNode16.Name = "Node20";
            treeNode16.Tag = Tabs.WEAPON_AMMO_EDITOR;
            treeNode16.Text = "Ammo";
            treeNode17.ImageKey = "CategoryPageItemTemplate.ico";
            treeNode17.Name = "Node6";
            treeNode17.SelectedImageIndex = 0;
            treeNode17.Text = "Inventory";
            treeNode18.ImageKey = "Settings.ico";
            treeNode18.Name = "Node3";
            treeNode18.SelectedImageIndex = 3;
            treeNode18.Text = "Configurations";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(234, 772);
            this.treeView1.TabIndex = 56;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CategoryPageItemTemplate.ico");
            this.imageList1.Images.SetKeyName(1, "CustomActionsEditor_5850.ico");
            this.imageList1.Images.SetKeyName(2, "Property.ico");
            this.imageList1.Images.SetKeyName(3, "Settings.ico");
            this.imageList1.Images.SetKeyName(4, "User.ico");
            // 
            // ConfigEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 770);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.openMaterialPropEditor);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenCAGE Configuration Editor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openMaterialPropEditor;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}