namespace AlienConfigEditor
{
    partial class LocalisationEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalisationEditor));
            this.stringOut = new System.Windows.Forms.TextBox();
            this.selectedLanguage = new System.Windows.Forms.ComboBox();
            this.localisationTree = new System.Windows.Forms.TreeView();
            this.updateString = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringOut
            // 
            this.stringOut.Location = new System.Drawing.Point(528, 76);
            this.stringOut.Multiline = true;
            this.stringOut.Name = "stringOut";
            this.stringOut.Size = new System.Drawing.Size(454, 602);
            this.stringOut.TabIndex = 2;
            // 
            // selectedLanguage
            // 
            this.selectedLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedLanguage.FormattingEnabled = true;
            this.selectedLanguage.Location = new System.Drawing.Point(528, 27);
            this.selectedLanguage.Name = "selectedLanguage";
            this.selectedLanguage.Size = new System.Drawing.Size(442, 21);
            this.selectedLanguage.TabIndex = 5;
            this.selectedLanguage.SelectedIndexChanged += new System.EventHandler(this.selectedLanguage_SelectedIndexChanged);
            // 
            // localisationTree
            // 
            this.localisationTree.Location = new System.Drawing.Point(12, 12);
            this.localisationTree.Name = "localisationTree";
            this.localisationTree.Size = new System.Drawing.Size(510, 707);
            this.localisationTree.TabIndex = 6;
            this.localisationTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.localisationTree_AfterSelect);
            // 
            // updateString
            // 
            this.updateString.Location = new System.Drawing.Point(720, 684);
            this.updateString.Name = "updateString";
            this.updateString.Size = new System.Drawing.Size(262, 35);
            this.updateString.TabIndex = 7;
            this.updateString.Text = "Save";
            this.updateString.UseVisualStyleBackColor = true;
            this.updateString.Click += new System.EventHandler(this.updateString_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Language";
            // 
            // LocalisationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 731);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateString);
            this.Controls.Add(this.localisationTree);
            this.Controls.Add(this.selectedLanguage);
            this.Controls.Add(this.stringOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalisationEditor";
            this.Text = "Localisation Editor";
            this.Load += new System.EventHandler(this.LocalisationEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox stringOut;
        private System.Windows.Forms.ComboBox selectedLanguage;
        private System.Windows.Forms.TreeView localisationTree;
        private System.Windows.Forms.Button updateString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}