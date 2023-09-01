namespace AlienConfigEditor
{
    partial class ViewconeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewconeEditor));
            this.label22 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.viewconeSets = new System.Windows.Forms.ComboBox();
            this.loadSet = new System.Windows.Forms.Button();
            this.viewconeTypes = new System.Windows.Forms.ComboBox();
            this.loadType = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.Light_meter_dark_level = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.Light_meter_partially_lit_level = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.Light_meter_fully_lit_level = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DistanceEffectLower = new System.Windows.Forms.TextBox();
            this.DistanceEffectUpper = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SmokeEffectLower = new System.Windows.Forms.TextBox();
            this.SmokeEffectUpper = new System.Windows.Forms.TextBox();
            this.MovementEffectLower = new System.Windows.Forms.TextBox();
            this.MovementEffectUpper = new System.Windows.Forms.TextBox();
            this.StanceEffectLower = new System.Windows.Forms.TextBox();
            this.StanceEffectUpper = new System.Windows.Forms.TextBox();
            this.ExposureEffectLower = new System.Windows.Forms.TextBox();
            this.ExposureEffectUpper = new System.Windows.Forms.TextBox();
            this.SmokeLengthModifier = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.VerticalAngle = new System.Windows.Forms.TextBox();
            this.HorizontalAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(288, 541);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 411;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(720, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 35);
            this.btnSave.TabIndex = 410;
            this.btnSave.Text = "Save Loaded Type";
            this.toolTip1.SetToolTip(this.btnSave, "Save this viewcone type in this viewcone set.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // viewconeSets
            // 
            this.viewconeSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewconeSets.FormattingEnabled = true;
            this.viewconeSets.Items.AddRange(new object[] {
            "VIEWCONESET_STANDARD",
            "VIEWCONESET_HUMAN",
            "VIEWCONESET_SLEEPING",
            "VIEWCONESET_ANDROID",
            "VIEWCONESET_HUMAN_HEIGHTENED"});
            this.viewconeSets.Location = new System.Drawing.Point(12, 13);
            this.viewconeSets.Name = "viewconeSets";
            this.viewconeSets.Size = new System.Drawing.Size(849, 21);
            this.viewconeSets.TabIndex = 409;
            this.toolTip1.SetToolTip(this.viewconeSets, "All viewcone sets.");
            // 
            // loadSet
            // 
            this.loadSet.Location = new System.Drawing.Point(867, 12);
            this.loadSet.Name = "loadSet";
            this.loadSet.Size = new System.Drawing.Size(115, 23);
            this.loadSet.TabIndex = 408;
            this.loadSet.Text = "Load Viewcone Set";
            this.toolTip1.SetToolTip(this.loadSet, "Load the selected viewcone.");
            this.loadSet.UseVisualStyleBackColor = true;
            this.loadSet.Click += new System.EventHandler(this.loadSet_Click);
            // 
            // viewconeTypes
            // 
            this.viewconeTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewconeTypes.Enabled = false;
            this.viewconeTypes.FormattingEnabled = true;
            this.viewconeTypes.Location = new System.Drawing.Point(12, 40);
            this.viewconeTypes.Name = "viewconeTypes";
            this.viewconeTypes.Size = new System.Drawing.Size(849, 21);
            this.viewconeTypes.TabIndex = 416;
            this.toolTip1.SetToolTip(this.viewconeTypes, "All viewcone types in this viewcone set.");
            // 
            // loadType
            // 
            this.loadType.Enabled = false;
            this.loadType.Location = new System.Drawing.Point(867, 41);
            this.loadType.Name = "loadType";
            this.loadType.Size = new System.Drawing.Size(115, 23);
            this.loadType.TabIndex = 417;
            this.loadType.Text = "Load Vision Type";
            this.toolTip1.SetToolTip(this.loadType, "Load viewcone type from this set.");
            this.loadType.UseVisualStyleBackColor = true;
            this.loadType.Click += new System.EventHandler(this.loadType_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 28);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(85, 13);
            this.label29.TabIndex = 351;
            this.label29.Text = "Dark Light Level";
            // 
            // Light_meter_dark_level
            // 
            this.Light_meter_dark_level.Enabled = false;
            this.Light_meter_dark_level.Location = new System.Drawing.Point(20, 44);
            this.Light_meter_dark_level.Name = "Light_meter_dark_level";
            this.Light_meter_dark_level.Size = new System.Drawing.Size(187, 20);
            this.Light_meter_dark_level.TabIndex = 352;
            this.toolTip1.SetToolTip(this.Light_meter_dark_level, "The light level considered to be dark for this setting.");
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 67);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(112, 13);
            this.label30.TabIndex = 353;
            this.label30.Text = "Partially Lit Light Level";
            // 
            // Light_meter_partially_lit_level
            // 
            this.Light_meter_partially_lit_level.Enabled = false;
            this.Light_meter_partially_lit_level.Location = new System.Drawing.Point(20, 83);
            this.Light_meter_partially_lit_level.Name = "Light_meter_partially_lit_level";
            this.Light_meter_partially_lit_level.Size = new System.Drawing.Size(187, 20);
            this.Light_meter_partially_lit_level.TabIndex = 354;
            this.toolTip1.SetToolTip(this.Light_meter_partially_lit_level, "The light level considered to be partially lit for this setting.");
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 107);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(97, 13);
            this.label31.TabIndex = 355;
            this.label31.Text = "Fully Lit Light Level";
            // 
            // Light_meter_fully_lit_level
            // 
            this.Light_meter_fully_lit_level.Enabled = false;
            this.Light_meter_fully_lit_level.Location = new System.Drawing.Point(20, 123);
            this.Light_meter_fully_lit_level.Name = "Light_meter_fully_lit_level";
            this.Light_meter_fully_lit_level.Size = new System.Drawing.Size(187, 20);
            this.Light_meter_fully_lit_level.TabIndex = 356;
            this.toolTip1.SetToolTip(this.Light_meter_fully_lit_level, "The light level considered to be fully lit for this setting.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 434;
            this.label11.Text = "Vision Distance Modifier";
            // 
            // DistanceEffectLower
            // 
            this.DistanceEffectLower.Enabled = false;
            this.DistanceEffectLower.Location = new System.Drawing.Point(19, 41);
            this.DistanceEffectLower.Name = "DistanceEffectLower";
            this.DistanceEffectLower.Size = new System.Drawing.Size(49, 20);
            this.DistanceEffectLower.TabIndex = 435;
            this.toolTip1.SetToolTip(this.DistanceEffectLower, "Minimum vision distance modifier for this viewcone type.");
            // 
            // DistanceEffectUpper
            // 
            this.DistanceEffectUpper.Enabled = false;
            this.DistanceEffectUpper.Location = new System.Drawing.Point(157, 41);
            this.DistanceEffectUpper.Name = "DistanceEffectUpper";
            this.DistanceEffectUpper.Size = new System.Drawing.Size(49, 20);
            this.DistanceEffectUpper.TabIndex = 436;
            this.toolTip1.SetToolTip(this.DistanceEffectUpper, "Maximum vision distance modifier for this viewcone type.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 437;
            this.label12.Text = "Min -------> Max";
            // 
            // SmokeEffectLower
            // 
            this.SmokeEffectLower.Enabled = false;
            this.SmokeEffectLower.Location = new System.Drawing.Point(19, 80);
            this.SmokeEffectLower.Name = "SmokeEffectLower";
            this.SmokeEffectLower.Size = new System.Drawing.Size(49, 20);
            this.SmokeEffectLower.TabIndex = 439;
            this.toolTip1.SetToolTip(this.SmokeEffectLower, "Minimum vision smoke modifier for this viewcone type.");
            // 
            // SmokeEffectUpper
            // 
            this.SmokeEffectUpper.Enabled = false;
            this.SmokeEffectUpper.Location = new System.Drawing.Point(157, 80);
            this.SmokeEffectUpper.Name = "SmokeEffectUpper";
            this.SmokeEffectUpper.Size = new System.Drawing.Size(49, 20);
            this.SmokeEffectUpper.TabIndex = 440;
            this.toolTip1.SetToolTip(this.SmokeEffectUpper, "Maximum vision smoke modifier for this viewcone type.");
            // 
            // MovementEffectLower
            // 
            this.MovementEffectLower.Enabled = false;
            this.MovementEffectLower.Location = new System.Drawing.Point(19, 158);
            this.MovementEffectLower.Name = "MovementEffectLower";
            this.MovementEffectLower.Size = new System.Drawing.Size(49, 20);
            this.MovementEffectLower.TabIndex = 443;
            this.toolTip1.SetToolTip(this.MovementEffectLower, "Minimum vision movement modifier for this viewcone type.");
            // 
            // MovementEffectUpper
            // 
            this.MovementEffectUpper.Enabled = false;
            this.MovementEffectUpper.Location = new System.Drawing.Point(157, 158);
            this.MovementEffectUpper.Name = "MovementEffectUpper";
            this.MovementEffectUpper.Size = new System.Drawing.Size(49, 20);
            this.MovementEffectUpper.TabIndex = 444;
            this.toolTip1.SetToolTip(this.MovementEffectUpper, "Maximum vision movement modifier for this viewcone type.");
            // 
            // StanceEffectLower
            // 
            this.StanceEffectLower.Enabled = false;
            this.StanceEffectLower.Location = new System.Drawing.Point(20, 197);
            this.StanceEffectLower.Name = "StanceEffectLower";
            this.StanceEffectLower.Size = new System.Drawing.Size(49, 20);
            this.StanceEffectLower.TabIndex = 447;
            this.toolTip1.SetToolTip(this.StanceEffectLower, "Minimum vision stance modifier for this viewcone type.");
            // 
            // StanceEffectUpper
            // 
            this.StanceEffectUpper.Enabled = false;
            this.StanceEffectUpper.Location = new System.Drawing.Point(158, 197);
            this.StanceEffectUpper.Name = "StanceEffectUpper";
            this.StanceEffectUpper.Size = new System.Drawing.Size(49, 20);
            this.StanceEffectUpper.TabIndex = 448;
            this.toolTip1.SetToolTip(this.StanceEffectUpper, "Maximum vision stance modifier for this viewcone type.");
            // 
            // ExposureEffectLower
            // 
            this.ExposureEffectLower.Enabled = false;
            this.ExposureEffectLower.Location = new System.Drawing.Point(20, 236);
            this.ExposureEffectLower.Name = "ExposureEffectLower";
            this.ExposureEffectLower.Size = new System.Drawing.Size(49, 20);
            this.ExposureEffectLower.TabIndex = 451;
            this.toolTip1.SetToolTip(this.ExposureEffectLower, "Minimum vision exposure modifier for this viewcone type.");
            // 
            // ExposureEffectUpper
            // 
            this.ExposureEffectUpper.Enabled = false;
            this.ExposureEffectUpper.Location = new System.Drawing.Point(158, 236);
            this.ExposureEffectUpper.Name = "ExposureEffectUpper";
            this.ExposureEffectUpper.Size = new System.Drawing.Size(49, 20);
            this.ExposureEffectUpper.TabIndex = 452;
            this.toolTip1.SetToolTip(this.ExposureEffectUpper, "Maximum vision exposure modifier for this viewcone type.");
            // 
            // SmokeLengthModifier
            // 
            this.SmokeLengthModifier.Enabled = false;
            this.SmokeLengthModifier.Location = new System.Drawing.Point(19, 119);
            this.SmokeLengthModifier.Name = "SmokeLengthModifier";
            this.SmokeLengthModifier.Size = new System.Drawing.Size(187, 20);
            this.SmokeLengthModifier.TabIndex = 455;
            this.toolTip1.SetToolTip(this.SmokeLengthModifier, "The modifier based on smoke length for this viewcone.");
            // 
            // Length
            // 
            this.Length.Enabled = false;
            this.Length.Location = new System.Drawing.Point(18, 44);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(187, 20);
            this.Length.TabIndex = 458;
            this.toolTip1.SetToolTip(this.Length, "The length of the vision for this viewcone.");
            // 
            // VerticalAngle
            // 
            this.VerticalAngle.Enabled = false;
            this.VerticalAngle.Location = new System.Drawing.Point(18, 83);
            this.VerticalAngle.Name = "VerticalAngle";
            this.VerticalAngle.Size = new System.Drawing.Size(187, 20);
            this.VerticalAngle.TabIndex = 460;
            this.toolTip1.SetToolTip(this.VerticalAngle, "The vertical angle of this viewcone.");
            // 
            // HorizontalAngle
            // 
            this.HorizontalAngle.Enabled = false;
            this.HorizontalAngle.Location = new System.Drawing.Point(18, 123);
            this.HorizontalAngle.Name = "HorizontalAngle";
            this.HorizontalAngle.Size = new System.Drawing.Size(187, 20);
            this.HorizontalAngle.TabIndex = 462;
            this.toolTip1.SetToolTip(this.HorizontalAngle, "The horizontal angle of this viewcone.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 438;
            this.label1.Text = "Vision Smoke Modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 441;
            this.label2.Text = "Min -------> Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 442;
            this.label3.Text = "Vision Movement Modifier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 445;
            this.label4.Text = "Min -------> Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 446;
            this.label5.Text = "Vision Stance Modifier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 449;
            this.label6.Text = "Min -------> Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 450;
            this.label7.Text = "Vision Exposure Modifier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 453;
            this.label8.Text = "Min -------> Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 454;
            this.label9.Text = "Smoke Length Modifier";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 457;
            this.label14.Text = "Vision Length";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 459;
            this.label15.Text = "Vertical Vision Angle";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 461;
            this.label16.Text = "Horizontal Vision Angle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.DistanceEffectUpper);
            this.groupBox1.Controls.Add(this.DistanceEffectLower);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SmokeEffectUpper);
            this.groupBox1.Controls.Add(this.SmokeEffectLower);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SmokeLengthModifier);
            this.groupBox1.Controls.Add(this.MovementEffectUpper);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MovementEffectLower);
            this.groupBox1.Controls.Add(this.ExposureEffectLower);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ExposureEffectUpper);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.StanceEffectUpper);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.StanceEffectLower);
            this.groupBox1.Location = new System.Drawing.Point(501, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 275);
            this.groupBox1.TabIndex = 463;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vision Modifiers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Length);
            this.groupBox2.Controls.Add(this.HorizontalAngle);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.VerticalAngle);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(272, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 161);
            this.groupBox2.TabIndex = 464;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Light_meter_dark_level);
            this.groupBox3.Controls.Add(this.Light_meter_fully_lit_level);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.Light_meter_partially_lit_level);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Location = new System.Drawing.Point(272, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 161);
            this.groupBox3.TabIndex = 465;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Light Meter";
            // 
            // ViewconeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 731);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadType);
            this.Controls.Add(this.viewconeTypes);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.viewconeSets);
            this.Controls.Add(this.loadSet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewconeEditor";
            this.Text = "Vision Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox viewconeSets;
        private System.Windows.Forms.Button loadSet;
        private System.Windows.Forms.ComboBox viewconeTypes;
        private System.Windows.Forms.Button loadType;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox Light_meter_dark_level;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox Light_meter_partially_lit_level;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox Light_meter_fully_lit_level;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DistanceEffectLower;
        private System.Windows.Forms.TextBox DistanceEffectUpper;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SmokeEffectLower;
        private System.Windows.Forms.TextBox SmokeEffectUpper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MovementEffectLower;
        private System.Windows.Forms.TextBox MovementEffectUpper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StanceEffectLower;
        private System.Windows.Forms.TextBox StanceEffectUpper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExposureEffectLower;
        private System.Windows.Forms.TextBox ExposureEffectUpper;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SmokeLengthModifier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox VerticalAngle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox HorizontalAngle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}