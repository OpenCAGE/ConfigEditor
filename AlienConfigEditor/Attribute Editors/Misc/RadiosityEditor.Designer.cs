namespace AlienConfigEditor
{
    partial class RadiosityEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadiosityEditor));
            this.label22 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gRadiosityEmissiveSurfaceScale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gRadiosityFirstBounceScale = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.gRadiosityMultiBounceScale = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.gRadiosityAlbedoOverbrightAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gRadiosityAlbedoSaturationAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gRadiositySpecularGlossScale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gDeferredEmissiveSurfaceScale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gDeferredEmissiveSurfaceExponent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(283, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 411;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 35);
            this.btnSave.TabIndex = 410;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 414;
            this.label2.Text = "Emissive Surface Scale";
            // 
            // gRadiosityEmissiveSurfaceScale
            // 
            this.gRadiosityEmissiveSurfaceScale.Location = new System.Drawing.Point(18, 41);
            this.gRadiosityEmissiveSurfaceScale.Name = "gRadiosityEmissiveSurfaceScale";
            this.gRadiosityEmissiveSurfaceScale.Size = new System.Drawing.Size(187, 20);
            this.gRadiosityEmissiveSurfaceScale.TabIndex = 415;
            this.toolTip1.SetToolTip(this.gRadiosityEmissiveSurfaceScale, "The brightness scale of the emissive material on a surface.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 416;
            this.label3.Text = "First Bounce Scale";
            // 
            // gRadiosityFirstBounceScale
            // 
            this.gRadiosityFirstBounceScale.Location = new System.Drawing.Point(18, 80);
            this.gRadiosityFirstBounceScale.Name = "gRadiosityFirstBounceScale";
            this.gRadiosityFirstBounceScale.Size = new System.Drawing.Size(187, 20);
            this.gRadiosityFirstBounceScale.TabIndex = 417;
            this.toolTip1.SetToolTip(this.gRadiosityFirstBounceScale, "The brightness scale of a first radiosity bounce.");
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(208, 25);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(99, 13);
            this.label35.TabIndex = 418;
            this.label35.Text = "Multi Bounce Scale";
            // 
            // gRadiosityMultiBounceScale
            // 
            this.gRadiosityMultiBounceScale.Location = new System.Drawing.Point(211, 41);
            this.gRadiosityMultiBounceScale.Name = "gRadiosityMultiBounceScale";
            this.gRadiosityMultiBounceScale.Size = new System.Drawing.Size(187, 20);
            this.gRadiosityMultiBounceScale.TabIndex = 419;
            this.toolTip1.SetToolTip(this.gRadiosityMultiBounceScale, "The brightness scale of multiple radiosity bounces.");
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(208, 64);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(131, 13);
            this.label34.TabIndex = 420;
            this.label34.Text = "Albedo Overbright Amount";
            // 
            // gRadiosityAlbedoOverbrightAmount
            // 
            this.gRadiosityAlbedoOverbrightAmount.Location = new System.Drawing.Point(211, 80);
            this.gRadiosityAlbedoOverbrightAmount.Name = "gRadiosityAlbedoOverbrightAmount";
            this.gRadiosityAlbedoOverbrightAmount.Size = new System.Drawing.Size(187, 20);
            this.gRadiosityAlbedoOverbrightAmount.TabIndex = 421;
            this.toolTip1.SetToolTip(this.gRadiosityAlbedoOverbrightAmount, "The amount deemed overbright for albedo.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 422;
            this.label4.Text = "Albedo Saturation Amount";
            // 
            // gRadiosityAlbedoSaturationAmount
            // 
            this.gRadiosityAlbedoSaturationAmount.Location = new System.Drawing.Point(404, 41);
            this.gRadiosityAlbedoSaturationAmount.Name = "gRadiosityAlbedoSaturationAmount";
            this.gRadiosityAlbedoSaturationAmount.Size = new System.Drawing.Size(187, 20);
            this.gRadiosityAlbedoSaturationAmount.TabIndex = 423;
            this.toolTip1.SetToolTip(this.gRadiosityAlbedoSaturationAmount, "The amount of saturation in albedo.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 424;
            this.label5.Text = "Specular Gloss Scale";
            // 
            // gRadiositySpecularGlossScale
            // 
            this.gRadiositySpecularGlossScale.Location = new System.Drawing.Point(404, 80);
            this.gRadiositySpecularGlossScale.Name = "gRadiositySpecularGlossScale";
            this.gRadiositySpecularGlossScale.Size = new System.Drawing.Size(187, 20);
            this.gRadiositySpecularGlossScale.TabIndex = 425;
            this.toolTip1.SetToolTip(this.gRadiositySpecularGlossScale, "The scale applied to specular gloss lighting.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 427;
            this.label7.Text = "Emissive Surface Scale";
            // 
            // gDeferredEmissiveSurfaceScale
            // 
            this.gDeferredEmissiveSurfaceScale.Location = new System.Drawing.Point(19, 38);
            this.gDeferredEmissiveSurfaceScale.Name = "gDeferredEmissiveSurfaceScale";
            this.gDeferredEmissiveSurfaceScale.Size = new System.Drawing.Size(187, 20);
            this.gDeferredEmissiveSurfaceScale.TabIndex = 428;
            this.toolTip1.SetToolTip(this.gDeferredEmissiveSurfaceScale, "The brightness scale applied to emissive surfaces.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 429;
            this.label8.Text = "Emissive Surface Exponent";
            // 
            // gDeferredEmissiveSurfaceExponent
            // 
            this.gDeferredEmissiveSurfaceExponent.Location = new System.Drawing.Point(19, 77);
            this.gDeferredEmissiveSurfaceExponent.Name = "gDeferredEmissiveSurfaceExponent";
            this.gDeferredEmissiveSurfaceExponent.Size = new System.Drawing.Size(187, 20);
            this.gDeferredEmissiveSurfaceExponent.TabIndex = 430;
            this.toolTip1.SetToolTip(this.gDeferredEmissiveSurfaceExponent, "The exponent of the light given out by emissive surfaces.");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gRadiosityAlbedoOverbrightAmount);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.gRadiosityMultiBounceScale);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.gRadiosityFirstBounceScale);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gRadiosityEmissiveSurfaceScale);
            this.groupBox2.Controls.Add(this.gRadiosityAlbedoSaturationAmount);
            this.groupBox2.Controls.Add(this.gRadiositySpecularGlossScale);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 117);
            this.groupBox2.TabIndex = 431;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Radiosity Lighting Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gDeferredEmissiveSurfaceExponent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.gDeferredEmissiveSurfaceScale);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 111);
            this.groupBox1.TabIndex = 432;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deferred Lighting Settings";
            // 
            // RadiosityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RadiosityEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radiosity Editor";
            this.Load += new System.EventHandler(this.RadiosityEditor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gRadiosityEmissiveSurfaceScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gRadiosityFirstBounceScale;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox gRadiosityMultiBounceScale;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox gRadiosityAlbedoOverbrightAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gRadiosityAlbedoSaturationAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gRadiositySpecularGlossScale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gDeferredEmissiveSurfaceScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gDeferredEmissiveSurfaceExponent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}