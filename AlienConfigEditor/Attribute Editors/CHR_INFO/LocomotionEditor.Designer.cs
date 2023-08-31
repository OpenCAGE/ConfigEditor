﻿namespace AlienConfigEditor
{
    partial class LocomotionEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocomotionEditor));
            this.characters = new System.Windows.Forms.ComboBox();
            this.loadChar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.corneringPenalty1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maxAngularWarping1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.stoppingDistance1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.corneringWeight1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maxLinearWarping1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.angularAcceleration1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.maxAngularVelocity1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.linearAcceleration1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.linearVelocity1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.permittedLocomotionModulation = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.capsuleRadius = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.capsuleHeight = new System.Windows.Forms.TextBox();
            this.variantType = new System.Windows.Forms.ComboBox();
            this.swapVariant = new System.Windows.Forms.Button();
            this.setSlider = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // characters
            // 
            this.characters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characters.FormattingEnabled = true;
            this.characters.Items.AddRange(new object[] {
            "DEFAULTS",
            "THE_PLAYER",
            "ALIEN",
            "ANDROID",
            "CIVILIAN",
            "SECURITY_GUARD",
            "CUTSCENE",
            "FACEHUGGER",
            "SPACESUIT_NPC",
            "RIOT_GUARD",
            "ANDROID_HEAVY",
            "MELEE_HUMAN",
            "INNOCENT",
            "CUTSCENE_ANDROID"});
            this.characters.Location = new System.Drawing.Point(12, 13);
            this.characters.Name = "characters";
            this.characters.Size = new System.Drawing.Size(849, 21);
            this.characters.TabIndex = 523;
            this.toolTip1.SetToolTip(this.characters, "Select a character to load the data for.");
            // 
            // loadChar
            // 
            this.loadChar.Location = new System.Drawing.Point(867, 12);
            this.loadChar.Name = "loadChar";
            this.loadChar.Size = new System.Drawing.Size(115, 23);
            this.loadChar.TabIndex = 522;
            this.loadChar.Text = "Load Character";
            this.loadChar.UseVisualStyleBackColor = true;
            this.loadChar.Click += new System.EventHandler(this.loadChar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(720, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 35);
            this.btnSave.TabIndex = 518;
            this.btnSave.Text = "Save Current Data";
            this.toolTip1.SetToolTip(this.btnSave, "Save all data currently loaded into the editor. Make sure to press this whenever " +
        "moving to a new data set.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.corneringPenalty1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.maxAngularWarping1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.stoppingDistance1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.corneringWeight1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.maxLinearWarping1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.angularAcceleration1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.maxAngularVelocity1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.linearAcceleration1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.linearVelocity1);
            this.groupBox1.Location = new System.Drawing.Point(12, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 229);
            this.groupBox1.TabIndex = 527;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Steering Boundary Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 525;
            this.label8.Text = "Max Linear Warping";
            // 
            // corneringPenalty1
            // 
            this.corneringPenalty1.Enabled = false;
            this.corneringPenalty1.Location = new System.Drawing.Point(16, 117);
            this.corneringPenalty1.Name = "corneringPenalty1";
            this.corneringPenalty1.Size = new System.Drawing.Size(187, 20);
            this.corneringPenalty1.TabIndex = 526;
            this.toolTip1.SetToolTip(this.corneringPenalty1, "The cornering penalty for this variant set.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 523;
            this.label11.Text = "Max Angular Warping";
            // 
            // maxAngularWarping1
            // 
            this.maxAngularWarping1.Enabled = false;
            this.maxAngularWarping1.Location = new System.Drawing.Point(213, 156);
            this.maxAngularWarping1.Name = "maxAngularWarping1";
            this.maxAngularWarping1.Size = new System.Drawing.Size(187, 20);
            this.maxAngularWarping1.TabIndex = 524;
            this.toolTip1.SetToolTip(this.maxAngularWarping1, "The maximum angular warping for this variant set.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 521;
            this.label12.Text = "Cornering Penalty";
            // 
            // stoppingDistance1
            // 
            this.stoppingDistance1.Enabled = false;
            this.stoppingDistance1.Location = new System.Drawing.Point(16, 195);
            this.stoppingDistance1.Name = "stoppingDistance1";
            this.stoppingDistance1.Size = new System.Drawing.Size(187, 20);
            this.stoppingDistance1.TabIndex = 522;
            this.toolTip1.SetToolTip(this.stoppingDistance1, "The stopping distance for this variant set.");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 519;
            this.label13.Text = "Cornering Weight";
            // 
            // corneringWeight1
            // 
            this.corneringWeight1.Enabled = false;
            this.corneringWeight1.Location = new System.Drawing.Point(213, 117);
            this.corneringWeight1.Name = "corneringWeight1";
            this.corneringWeight1.Size = new System.Drawing.Size(187, 20);
            this.corneringWeight1.TabIndex = 520;
            this.toolTip1.SetToolTip(this.corneringWeight1, "The cornering weight for this variant set.");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 517;
            this.label14.Text = "Stopping Distance";
            // 
            // maxLinearWarping1
            // 
            this.maxLinearWarping1.Enabled = false;
            this.maxLinearWarping1.Location = new System.Drawing.Point(16, 156);
            this.maxLinearWarping1.Name = "maxLinearWarping1";
            this.maxLinearWarping1.Size = new System.Drawing.Size(187, 20);
            this.maxLinearWarping1.TabIndex = 518;
            this.toolTip1.SetToolTip(this.maxLinearWarping1, "The maximum linear warping for this variant set.");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(210, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 515;
            this.label15.Text = "Angular Acceleration";
            // 
            // angularAcceleration1
            // 
            this.angularAcceleration1.Enabled = false;
            this.angularAcceleration1.Location = new System.Drawing.Point(213, 78);
            this.angularAcceleration1.Name = "angularAcceleration1";
            this.angularAcceleration1.Size = new System.Drawing.Size(187, 20);
            this.angularAcceleration1.TabIndex = 516;
            this.toolTip1.SetToolTip(this.angularAcceleration1, "The angular acceleration for this variant set.");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 513;
            this.label16.Text = "Max Angular Velocity";
            // 
            // maxAngularVelocity1
            // 
            this.maxAngularVelocity1.Enabled = false;
            this.maxAngularVelocity1.Location = new System.Drawing.Point(16, 78);
            this.maxAngularVelocity1.Name = "maxAngularVelocity1";
            this.maxAngularVelocity1.Size = new System.Drawing.Size(187, 20);
            this.maxAngularVelocity1.TabIndex = 514;
            this.toolTip1.SetToolTip(this.maxAngularVelocity1, "The maximum angular velocity for this variant set.");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(210, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 511;
            this.label17.Text = "Linear Acceleration";
            // 
            // linearAcceleration1
            // 
            this.linearAcceleration1.Enabled = false;
            this.linearAcceleration1.Location = new System.Drawing.Point(213, 39);
            this.linearAcceleration1.Name = "linearAcceleration1";
            this.linearAcceleration1.Size = new System.Drawing.Size(187, 20);
            this.linearAcceleration1.TabIndex = 512;
            this.toolTip1.SetToolTip(this.linearAcceleration1, "The linear acceleration for this variant set.");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 509;
            this.label18.Text = "Linear Velocity";
            // 
            // linearVelocity1
            // 
            this.linearVelocity1.Enabled = false;
            this.linearVelocity1.Location = new System.Drawing.Point(16, 39);
            this.linearVelocity1.Name = "linearVelocity1";
            this.linearVelocity1.Size = new System.Drawing.Size(187, 20);
            this.linearVelocity1.TabIndex = 510;
            this.toolTip1.SetToolTip(this.linearVelocity1, "The linear velocity for this variant set.");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.permittedLocomotionModulation);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.capsuleRadius);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.capsuleHeight);
            this.groupBox4.Location = new System.Drawing.Point(12, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(970, 78);
            this.groupBox4.TabIndex = 528;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc Locomotion Settings";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(408, 23);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(117, 13);
            this.label34.TabIndex = 513;
            this.label34.Text = "Locomotion Modulation";
            // 
            // permittedLocomotionModulation
            // 
            this.permittedLocomotionModulation.Enabled = false;
            this.permittedLocomotionModulation.Location = new System.Drawing.Point(411, 39);
            this.permittedLocomotionModulation.Name = "permittedLocomotionModulation";
            this.permittedLocomotionModulation.Size = new System.Drawing.Size(187, 20);
            this.permittedLocomotionModulation.TabIndex = 514;
            this.toolTip1.SetToolTip(this.permittedLocomotionModulation, "The locomotion modulation for this character.");
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(210, 23);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 13);
            this.label35.TabIndex = 511;
            this.label35.Text = "Capsule Radius";
            // 
            // capsuleRadius
            // 
            this.capsuleRadius.Enabled = false;
            this.capsuleRadius.Location = new System.Drawing.Point(213, 39);
            this.capsuleRadius.Name = "capsuleRadius";
            this.capsuleRadius.Size = new System.Drawing.Size(187, 20);
            this.capsuleRadius.TabIndex = 512;
            this.toolTip1.SetToolTip(this.capsuleRadius, "The capsule radius for this character.");
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(13, 23);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(79, 13);
            this.label36.TabIndex = 509;
            this.label36.Text = "Capsule Height";
            // 
            // capsuleHeight
            // 
            this.capsuleHeight.Enabled = false;
            this.capsuleHeight.Location = new System.Drawing.Point(16, 39);
            this.capsuleHeight.Name = "capsuleHeight";
            this.capsuleHeight.Size = new System.Drawing.Size(187, 20);
            this.capsuleHeight.TabIndex = 510;
            this.toolTip1.SetToolTip(this.capsuleHeight, "The capsule height for this character.");
            // 
            // variantType
            // 
            this.variantType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variantType.Enabled = false;
            this.variantType.FormattingEnabled = true;
            this.variantType.Items.AddRange(new object[] {
            "Normal",
            "Crouched",
            "Aimed"});
            this.variantType.Location = new System.Drawing.Point(12, 275);
            this.variantType.Name = "variantType";
            this.variantType.Size = new System.Drawing.Size(849, 21);
            this.variantType.TabIndex = 529;
            this.toolTip1.SetToolTip(this.variantType, "Select the variant to load the steering data for.");
            // 
            // swapVariant
            // 
            this.swapVariant.Enabled = false;
            this.swapVariant.Location = new System.Drawing.Point(867, 273);
            this.swapVariant.Name = "swapVariant";
            this.swapVariant.Size = new System.Drawing.Size(115, 23);
            this.swapVariant.TabIndex = 530;
            this.swapVariant.Text = "Load Variant";
            this.swapVariant.UseVisualStyleBackColor = true;
            this.swapVariant.Click += new System.EventHandler(this.swapVariant_Click);
            // 
            // setSlider
            // 
            this.setSlider.Enabled = false;
            this.setSlider.LargeChange = 1;
            this.setSlider.Location = new System.Drawing.Point(11, 298);
            this.setSlider.Maximum = 4;
            this.setSlider.Minimum = 1;
            this.setSlider.Name = "setSlider";
            this.setSlider.Size = new System.Drawing.Size(971, 45);
            this.setSlider.TabIndex = 531;
            this.toolTip1.SetToolTip(this.setSlider, "Load a set stage of this variant.");
            this.setSlider.Value = 1;
            this.setSlider.Scroll += new System.EventHandler(this.setSlider_Scroll);
            // 
            // LocomotionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 731);
            this.Controls.Add(this.swapVariant);
            this.Controls.Add(this.variantType);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.characters);
            this.Controls.Add(this.loadChar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.setSlider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocomotionEditor";
            this.Text = "Locomotion Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox characters;
        private System.Windows.Forms.Button loadChar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox corneringPenalty1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox maxAngularWarping1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox stoppingDistance1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox corneringWeight1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox maxLinearWarping1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox angularAcceleration1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox maxAngularVelocity1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox linearAcceleration1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox linearVelocity1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox permittedLocomotionModulation;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox capsuleRadius;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox capsuleHeight;
        private System.Windows.Forms.ComboBox variantType;
        private System.Windows.Forms.Button swapVariant;
        private System.Windows.Forms.TrackBar setSlider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}