namespace AlienConfigEditor
{
    partial class GlobalConstantsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalConstantsEditor));
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.min_time_suspicious_reaction_loop = new System.Windows.Forms.TextBox();
            this.max_time_suspicious_reaction_loop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min_time_between_squad_shots_lower_bound = new System.Windows.Forms.TextBox();
            this.min_time_between_squad_shots_upper_bound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.interaction_distance_threshold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stealth_light_meter_timeout_when_detected = new System.Windows.Forms.TextBox();
            this.stealth_light_meter_full_dark_threshold = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stealth_light_meter_full_light_threshold = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 314;
            this.label6.Text = "Suspicious Items";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 13);
            this.label10.TabIndex = 315;
            this.label10.Text = "Time Between Suspicious Reaction Loop";
            // 
            // min_time_suspicious_reaction_loop
            // 
            this.min_time_suspicious_reaction_loop.Location = new System.Drawing.Point(284, 299);
            this.min_time_suspicious_reaction_loop.Name = "min_time_suspicious_reaction_loop";
            this.min_time_suspicious_reaction_loop.Size = new System.Drawing.Size(49, 20);
            this.min_time_suspicious_reaction_loop.TabIndex = 316;
            this.min_time_suspicious_reaction_loop.TextChanged += new System.EventHandler(this.min_time_suspicious_reaction_loop_TextChanged);
            // 
            // max_time_suspicious_reaction_loop
            // 
            this.max_time_suspicious_reaction_loop.Location = new System.Drawing.Point(422, 299);
            this.max_time_suspicious_reaction_loop.Name = "max_time_suspicious_reaction_loop";
            this.max_time_suspicious_reaction_loop.Size = new System.Drawing.Size(49, 20);
            this.max_time_suspicious_reaction_loop.TabIndex = 317;
            this.max_time_suspicious_reaction_loop.TextChanged += new System.EventHandler(this.max_time_suspicious_reaction_loop_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 318;
            this.label9.Text = "Min -------> Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 319;
            this.label1.Text = "Squads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 320;
            this.label2.Text = "Min Time Between Squad Shots";
            // 
            // min_time_between_squad_shots_lower_bound
            // 
            this.min_time_between_squad_shots_lower_bound.Location = new System.Drawing.Point(284, 370);
            this.min_time_between_squad_shots_lower_bound.Name = "min_time_between_squad_shots_lower_bound";
            this.min_time_between_squad_shots_lower_bound.Size = new System.Drawing.Size(49, 20);
            this.min_time_between_squad_shots_lower_bound.TabIndex = 321;
            this.min_time_between_squad_shots_lower_bound.TextChanged += new System.EventHandler(this.min_time_between_squad_shots_lower_bound_TextChanged);
            // 
            // min_time_between_squad_shots_upper_bound
            // 
            this.min_time_between_squad_shots_upper_bound.Location = new System.Drawing.Point(422, 370);
            this.min_time_between_squad_shots_upper_bound.Name = "min_time_between_squad_shots_upper_bound";
            this.min_time_between_squad_shots_upper_bound.Size = new System.Drawing.Size(49, 20);
            this.min_time_between_squad_shots_upper_bound.TabIndex = 322;
            this.min_time_between_squad_shots_upper_bound.TextChanged += new System.EventHandler(this.min_time_between_squad_shots_upper_bound_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 323;
            this.label3.Text = "Min -------> Max";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(273, 409);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(152, 13);
            this.label34.TabIndex = 345;
            this.label34.Text = "Interaction Distance Threshold";
            // 
            // interaction_distance_threshold
            // 
            this.interaction_distance_threshold.Location = new System.Drawing.Point(276, 425);
            this.interaction_distance_threshold.Name = "interaction_distance_threshold";
            this.interaction_distance_threshold.Size = new System.Drawing.Size(187, 20);
            this.interaction_distance_threshold.TabIndex = 346;
            this.interaction_distance_threshold.TextChanged += new System.EventHandler(this.interaction_distance_threshold_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 347;
            this.label4.Text = "Stealth Light Meter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 348;
            this.label5.Text = "Timeout When Detected";
            // 
            // stealth_light_meter_timeout_when_detected
            // 
            this.stealth_light_meter_timeout_when_detected.Location = new System.Drawing.Point(536, 299);
            this.stealth_light_meter_timeout_when_detected.Name = "stealth_light_meter_timeout_when_detected";
            this.stealth_light_meter_timeout_when_detected.Size = new System.Drawing.Size(187, 20);
            this.stealth_light_meter_timeout_when_detected.TabIndex = 353;
            this.stealth_light_meter_timeout_when_detected.TextChanged += new System.EventHandler(this.stealth_light_meter_timeout_when_detected_TextChanged);
            // 
            // stealth_light_meter_full_dark_threshold
            // 
            this.stealth_light_meter_full_dark_threshold.Location = new System.Drawing.Point(537, 338);
            this.stealth_light_meter_full_dark_threshold.Name = "stealth_light_meter_full_dark_threshold";
            this.stealth_light_meter_full_dark_threshold.Size = new System.Drawing.Size(187, 20);
            this.stealth_light_meter_full_dark_threshold.TabIndex = 355;
            this.stealth_light_meter_full_dark_threshold.TextChanged += new System.EventHandler(this.stealth_light_meter_full_dark_threshold_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 354;
            this.label7.Text = "Full Dark Threshold";
            // 
            // stealth_light_meter_full_light_threshold
            // 
            this.stealth_light_meter_full_light_threshold.Location = new System.Drawing.Point(537, 377);
            this.stealth_light_meter_full_light_threshold.Name = "stealth_light_meter_full_light_threshold";
            this.stealth_light_meter_full_light_threshold.Size = new System.Drawing.Size(187, 20);
            this.stealth_light_meter_full_light_threshold.TabIndex = 357;
            this.stealth_light_meter_full_light_threshold.TextChanged += new System.EventHandler(this.stealth_light_meter_full_light_threshold_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 356;
            this.label8.Text = "Full Light Threshold";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(720, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 35);
            this.btnSave.TabIndex = 358;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GlobalConstantsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 731);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.stealth_light_meter_full_light_threshold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stealth_light_meter_full_dark_threshold);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stealth_light_meter_timeout_when_detected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.interaction_distance_threshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.min_time_between_squad_shots_lower_bound);
            this.Controls.Add(this.min_time_between_squad_shots_upper_bound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.min_time_suspicious_reaction_loop);
            this.Controls.Add(this.max_time_suspicious_reaction_loop);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlobalConstantsEditor";
            this.Text = "Global Constants Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox min_time_suspicious_reaction_loop;
        private System.Windows.Forms.TextBox max_time_suspicious_reaction_loop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox min_time_between_squad_shots_lower_bound;
        private System.Windows.Forms.TextBox min_time_between_squad_shots_upper_bound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox interaction_distance_threshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stealth_light_meter_timeout_when_detected;
        private System.Windows.Forms.TextBox stealth_light_meter_full_dark_threshold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stealth_light_meter_full_light_threshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
    }
}