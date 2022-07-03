namespace AlienConfigEditor
{
    partial class PackagesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackagesEditor));
            this.mapList = new System.Windows.Forms.ListBox();
            this.removeSelectedMap = new System.Windows.Forms.Button();
            this.newMapName = new System.Windows.Forms.TextBox();
            this.addNewMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapList
            // 
            this.mapList.FormattingEnabled = true;
            this.mapList.Location = new System.Drawing.Point(12, 12);
            this.mapList.Name = "mapList";
            this.mapList.Size = new System.Drawing.Size(426, 524);
            this.mapList.TabIndex = 0;
            // 
            // removeSelectedMap
            // 
            this.removeSelectedMap.Location = new System.Drawing.Point(444, 478);
            this.removeSelectedMap.Name = "removeSelectedMap";
            this.removeSelectedMap.Size = new System.Drawing.Size(264, 58);
            this.removeSelectedMap.TabIndex = 1;
            this.removeSelectedMap.Text = "Remove Selected Level";
            this.removeSelectedMap.UseVisualStyleBackColor = true;
            this.removeSelectedMap.Click += new System.EventHandler(this.removeSelectedMap_Click);
            // 
            // newMapName
            // 
            this.newMapName.Location = new System.Drawing.Point(13, 39);
            this.newMapName.Name = "newMapName";
            this.newMapName.Size = new System.Drawing.Size(237, 20);
            this.newMapName.TabIndex = 2;
            // 
            // addNewMap
            // 
            this.addNewMap.Location = new System.Drawing.Point(121, 65);
            this.addNewMap.Name = "addNewMap";
            this.addNewMap.Size = new System.Drawing.Size(129, 23);
            this.addNewMap.TabIndex = 3;
            this.addNewMap.Text = "Add New Level";
            this.addNewMap.UseVisualStyleBackColor = true;
            this.addNewMap.Click += new System.EventHandler(this.addNewMap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newMapName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addNewMap);
            this.groupBox1.Location = new System.Drawing.Point(444, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Level";
            // 
            // PackagesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.removeSelectedMap);
            this.Controls.Add(this.mapList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackagesEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level List Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mapList;
        private System.Windows.Forms.Button removeSelectedMap;
        private System.Windows.Forms.TextBox newMapName;
        private System.Windows.Forms.Button addNewMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}