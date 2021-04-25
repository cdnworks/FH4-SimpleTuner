
namespace FH4Tuner
{
    partial class Form1
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
            this.frontWeightLabel = new System.Windows.Forms.Label();
            this.maxSpringLabel = new System.Windows.Forms.Label();
            this.minSpringLabel = new System.Windows.Forms.Label();
            this.minSpringInput = new System.Windows.Forms.TextBox();
            this.maxSpringInput = new System.Windows.Forms.TextBox();
            this.desiredDamperLabel = new System.Windows.Forms.Label();
            this.dampRatioSelection = new System.Windows.Forms.ListBox();
            this.frontARBLabel = new System.Windows.Forms.Label();
            this.rearARBLabel = new System.Windows.Forms.Label();
            this.frontSpringLabel = new System.Windows.Forms.Label();
            this.rearSpringLabel = new System.Windows.Forms.Label();
            this.frontDampingLabel = new System.Windows.Forms.Label();
            this.rearDampingLabel = new System.Windows.Forms.Label();
            this.frontBumpLabel = new System.Windows.Forms.Label();
            this.rearBumpLabel = new System.Windows.Forms.Label();
            this.frontARBBox = new System.Windows.Forms.TextBox();
            this.rearARBBox = new System.Windows.Forms.TextBox();
            this.frontSpringBox = new System.Windows.Forms.TextBox();
            this.rearSpringBox = new System.Windows.Forms.TextBox();
            this.frontDampBox = new System.Windows.Forms.TextBox();
            this.rearDampBox = new System.Windows.Forms.TextBox();
            this.frontBumpBox = new System.Windows.Forms.TextBox();
            this.rearBumpBox = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.frontWeightInput = new System.Windows.Forms.TextBox();
            this.drivetrainLabel = new System.Windows.Forms.Label();
            this.drivetrainInput = new System.Windows.Forms.ListBox();
            this.trackTypeLabel = new System.Windows.Forms.Label();
            this.raceTypeInput = new System.Windows.Forms.ListBox();
            this.frontDifLabel = new System.Windows.Forms.Label();
            this.fAccLabel = new System.Windows.Forms.Label();
            this.fDecLabel = new System.Windows.Forms.Label();
            this.rearDifLabel = new System.Windows.Forms.Label();
            this.rAccLabel = new System.Windows.Forms.Label();
            this.rDecLabel = new System.Windows.Forms.Label();
            this.fAccBox = new System.Windows.Forms.TextBox();
            this.fDecBox = new System.Windows.Forms.TextBox();
            this.rAccBox = new System.Windows.Forms.TextBox();
            this.rDecBox = new System.Windows.Forms.TextBox();
            this.difBalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frontWeightLabel
            // 
            this.frontWeightLabel.AutoSize = true;
            this.frontWeightLabel.Location = new System.Drawing.Point(9, 9);
            this.frontWeightLabel.Name = "frontWeightLabel";
            this.frontWeightLabel.Size = new System.Drawing.Size(197, 13);
            this.frontWeightLabel.TabIndex = 1;
            this.frontWeightLabel.Text = "1)  Enter Front Weight Distribution Ratio:";
            this.frontWeightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxSpringLabel
            // 
            this.maxSpringLabel.AutoSize = true;
            this.maxSpringLabel.Location = new System.Drawing.Point(9, 61);
            this.maxSpringLabel.Name = "maxSpringLabel";
            this.maxSpringLabel.Size = new System.Drawing.Size(223, 13);
            this.maxSpringLabel.TabIndex = 3;
            this.maxSpringLabel.Text = "2)  Enter Maximum Spring Compression Value:";
            // 
            // minSpringLabel
            // 
            this.minSpringLabel.AutoSize = true;
            this.minSpringLabel.Location = new System.Drawing.Point(9, 113);
            this.minSpringLabel.Name = "minSpringLabel";
            this.minSpringLabel.Size = new System.Drawing.Size(220, 13);
            this.minSpringLabel.TabIndex = 4;
            this.minSpringLabel.Text = "3)  Enter Minimum Spring Compression Value:";
            // 
            // minSpringInput
            // 
            this.minSpringInput.Location = new System.Drawing.Point(12, 129);
            this.minSpringInput.Name = "minSpringInput";
            this.minSpringInput.Size = new System.Drawing.Size(100, 20);
            this.minSpringInput.TabIndex = 5;
            this.minSpringInput.Text = "0";
            // 
            // maxSpringInput
            // 
            this.maxSpringInput.Location = new System.Drawing.Point(12, 77);
            this.maxSpringInput.Name = "maxSpringInput";
            this.maxSpringInput.Size = new System.Drawing.Size(100, 20);
            this.maxSpringInput.TabIndex = 6;
            this.maxSpringInput.Text = "0";
            // 
            // desiredDamperLabel
            // 
            this.desiredDamperLabel.AutoSize = true;
            this.desiredDamperLabel.Location = new System.Drawing.Point(9, 169);
            this.desiredDamperLabel.Name = "desiredDamperLabel";
            this.desiredDamperLabel.Size = new System.Drawing.Size(197, 13);
            this.desiredDamperLabel.TabIndex = 7;
            this.desiredDamperLabel.Text = "4)  Select Desired Bump Damping Ratio:";
            // 
            // dampRatioSelection
            // 
            this.dampRatioSelection.FormattingEnabled = true;
            this.dampRatioSelection.Items.AddRange(new object[] {
            "0.50",
            "0.55",
            "0.60",
            "0.65",
            "0.70",
            "0.75"});
            this.dampRatioSelection.Location = new System.Drawing.Point(12, 185);
            this.dampRatioSelection.Name = "dampRatioSelection";
            this.dampRatioSelection.Size = new System.Drawing.Size(34, 82);
            this.dampRatioSelection.TabIndex = 8;
            // 
            // frontARBLabel
            // 
            this.frontARBLabel.AutoSize = true;
            this.frontARBLabel.Location = new System.Drawing.Point(281, 28);
            this.frontARBLabel.Name = "frontARBLabel";
            this.frontARBLabel.Size = new System.Drawing.Size(131, 13);
            this.frontARBLabel.TabIndex = 9;
            this.frontARBLabel.Text = "Front Anti-Roll Bar Setting:";
            this.frontARBLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rearARBLabel
            // 
            this.rearARBLabel.AutoSize = true;
            this.rearARBLabel.Location = new System.Drawing.Point(281, 61);
            this.rearARBLabel.Name = "rearARBLabel";
            this.rearARBLabel.Size = new System.Drawing.Size(130, 13);
            this.rearARBLabel.TabIndex = 10;
            this.rearARBLabel.Text = "Rear Anti-Roll Bar Setting:";
            this.rearARBLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // frontSpringLabel
            // 
            this.frontSpringLabel.AutoSize = true;
            this.frontSpringLabel.Location = new System.Drawing.Point(281, 95);
            this.frontSpringLabel.Name = "frontSpringLabel";
            this.frontSpringLabel.Size = new System.Drawing.Size(130, 13);
            this.frontSpringLabel.TabIndex = 11;
            this.frontSpringLabel.Text = "Front Spring Compression:";
            // 
            // rearSpringLabel
            // 
            this.rearSpringLabel.AutoSize = true;
            this.rearSpringLabel.Location = new System.Drawing.Point(281, 129);
            this.rearSpringLabel.Name = "rearSpringLabel";
            this.rearSpringLabel.Size = new System.Drawing.Size(129, 13);
            this.rearSpringLabel.TabIndex = 12;
            this.rearSpringLabel.Text = "Rear Spring Compression:";
            // 
            // frontDampingLabel
            // 
            this.frontDampingLabel.AutoSize = true;
            this.frontDampingLabel.Location = new System.Drawing.Point(281, 182);
            this.frontDampingLabel.Name = "frontDampingLabel";
            this.frontDampingLabel.Size = new System.Drawing.Size(126, 13);
            this.frontDampingLabel.TabIndex = 13;
            this.frontDampingLabel.Text = "Front Damping Rebound:";
            this.frontDampingLabel.Click += new System.EventHandler(this.frontDampingLabel_Click);
            // 
            // rearDampingLabel
            // 
            this.rearDampingLabel.AutoSize = true;
            this.rearDampingLabel.Location = new System.Drawing.Point(281, 218);
            this.rearDampingLabel.Name = "rearDampingLabel";
            this.rearDampingLabel.Size = new System.Drawing.Size(125, 13);
            this.rearDampingLabel.TabIndex = 14;
            this.rearDampingLabel.Text = "Rear Damping Rebound:";
            // 
            // frontBumpLabel
            // 
            this.frontBumpLabel.AutoSize = true;
            this.frontBumpLabel.Location = new System.Drawing.Point(281, 254);
            this.frontBumpLabel.Name = "frontBumpLabel";
            this.frontBumpLabel.Size = new System.Drawing.Size(107, 13);
            this.frontBumpLabel.TabIndex = 15;
            this.frontBumpLabel.Text = "Front Bump Stiffness:";
            // 
            // rearBumpLabel
            // 
            this.rearBumpLabel.AutoSize = true;
            this.rearBumpLabel.Location = new System.Drawing.Point(281, 289);
            this.rearBumpLabel.Name = "rearBumpLabel";
            this.rearBumpLabel.Size = new System.Drawing.Size(106, 13);
            this.rearBumpLabel.TabIndex = 16;
            this.rearBumpLabel.Text = "Rear Bump Stiffness:";
            // 
            // frontARBBox
            // 
            this.frontARBBox.Location = new System.Drawing.Point(418, 25);
            this.frontARBBox.Name = "frontARBBox";
            this.frontARBBox.Size = new System.Drawing.Size(100, 20);
            this.frontARBBox.TabIndex = 17;
            this.frontARBBox.TextChanged += new System.EventHandler(this.frontARBBox_TextChanged);
            // 
            // rearARBBox
            // 
            this.rearARBBox.Location = new System.Drawing.Point(418, 58);
            this.rearARBBox.Name = "rearARBBox";
            this.rearARBBox.Size = new System.Drawing.Size(100, 20);
            this.rearARBBox.TabIndex = 18;
            // 
            // frontSpringBox
            // 
            this.frontSpringBox.Location = new System.Drawing.Point(418, 92);
            this.frontSpringBox.Name = "frontSpringBox";
            this.frontSpringBox.Size = new System.Drawing.Size(100, 20);
            this.frontSpringBox.TabIndex = 19;
            // 
            // rearSpringBox
            // 
            this.rearSpringBox.Location = new System.Drawing.Point(418, 129);
            this.rearSpringBox.Name = "rearSpringBox";
            this.rearSpringBox.Size = new System.Drawing.Size(100, 20);
            this.rearSpringBox.TabIndex = 20;
            // 
            // frontDampBox
            // 
            this.frontDampBox.Location = new System.Drawing.Point(418, 179);
            this.frontDampBox.Name = "frontDampBox";
            this.frontDampBox.Size = new System.Drawing.Size(100, 20);
            this.frontDampBox.TabIndex = 21;
            // 
            // rearDampBox
            // 
            this.rearDampBox.Location = new System.Drawing.Point(418, 215);
            this.rearDampBox.Name = "rearDampBox";
            this.rearDampBox.Size = new System.Drawing.Size(100, 20);
            this.rearDampBox.TabIndex = 22;
            // 
            // frontBumpBox
            // 
            this.frontBumpBox.Location = new System.Drawing.Point(418, 251);
            this.frontBumpBox.Name = "frontBumpBox";
            this.frontBumpBox.Size = new System.Drawing.Size(100, 20);
            this.frontBumpBox.TabIndex = 23;
            // 
            // rearBumpBox
            // 
            this.rearBumpBox.Location = new System.Drawing.Point(418, 286);
            this.rearBumpBox.Name = "rearBumpBox";
            this.rearBumpBox.Size = new System.Drawing.Size(100, 20);
            this.rearBumpBox.TabIndex = 24;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(12, 448);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(208, 23);
            this.btn_Calculate.TabIndex = 25;
            this.btn_Calculate.Text = "Calculate Tune!";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // frontWeightInput
            // 
            this.frontWeightInput.Location = new System.Drawing.Point(12, 25);
            this.frontWeightInput.Name = "frontWeightInput";
            this.frontWeightInput.Size = new System.Drawing.Size(100, 20);
            this.frontWeightInput.TabIndex = 26;
            this.frontWeightInput.Text = "0";
            // 
            // drivetrainLabel
            // 
            this.drivetrainLabel.AutoSize = true;
            this.drivetrainLabel.Location = new System.Drawing.Point(9, 273);
            this.drivetrainLabel.Name = "drivetrainLabel";
            this.drivetrainLabel.Size = new System.Drawing.Size(130, 13);
            this.drivetrainLabel.TabIndex = 27;
            this.drivetrainLabel.Text = "5)  Select Drivetrain Type:";
            // 
            // drivetrainInput
            // 
            this.drivetrainInput.FormattingEnabled = true;
            this.drivetrainInput.Items.AddRange(new object[] {
            "AWD",
            "RWD",
            "FWD"});
            this.drivetrainInput.Location = new System.Drawing.Point(12, 289);
            this.drivetrainInput.Name = "drivetrainInput";
            this.drivetrainInput.Size = new System.Drawing.Size(34, 43);
            this.drivetrainInput.TabIndex = 28;
            // 
            // trackTypeLabel
            // 
            this.trackTypeLabel.AutoSize = true;
            this.trackTypeLabel.Location = new System.Drawing.Point(9, 344);
            this.trackTypeLabel.Name = "trackTypeLabel";
            this.trackTypeLabel.Size = new System.Drawing.Size(152, 13);
            this.trackTypeLabel.TabIndex = 29;
            this.trackTypeLabel.Text = "6)  Select Desired Event Type:";
            // 
            // raceTypeInput
            // 
            this.raceTypeInput.FormattingEnabled = true;
            this.raceTypeInput.Items.AddRange(new object[] {
            "Circuit/Street",
            "Rally/Cross Country",
            "Drifting"});
            this.raceTypeInput.Location = new System.Drawing.Point(12, 360);
            this.raceTypeInput.Name = "raceTypeInput";
            this.raceTypeInput.Size = new System.Drawing.Size(124, 43);
            this.raceTypeInput.TabIndex = 30;
            // 
            // frontDifLabel
            // 
            this.frontDifLabel.AutoSize = true;
            this.frontDifLabel.Location = new System.Drawing.Point(281, 344);
            this.frontDifLabel.Name = "frontDifLabel";
            this.frontDifLabel.Size = new System.Drawing.Size(87, 13);
            this.frontDifLabel.TabIndex = 31;
            this.frontDifLabel.Text = "Front Differential:";
            // 
            // fAccLabel
            // 
            this.fAccLabel.AutoSize = true;
            this.fAccLabel.Location = new System.Drawing.Point(302, 360);
            this.fAccLabel.Name = "fAccLabel";
            this.fAccLabel.Size = new System.Drawing.Size(69, 13);
            this.fAccLabel.TabIndex = 32;
            this.fAccLabel.Text = "Acceleration:";
            // 
            // fDecLabel
            // 
            this.fDecLabel.AutoSize = true;
            this.fDecLabel.Location = new System.Drawing.Point(302, 390);
            this.fDecLabel.Name = "fDecLabel";
            this.fDecLabel.Size = new System.Drawing.Size(70, 13);
            this.fDecLabel.TabIndex = 33;
            this.fDecLabel.Text = "Deceleration:";
            // 
            // rearDifLabel
            // 
            this.rearDifLabel.AutoSize = true;
            this.rearDifLabel.Location = new System.Drawing.Point(281, 426);
            this.rearDifLabel.Name = "rearDifLabel";
            this.rearDifLabel.Size = new System.Drawing.Size(86, 13);
            this.rearDifLabel.TabIndex = 34;
            this.rearDifLabel.Text = "Rear Differential:";
            // 
            // rAccLabel
            // 
            this.rAccLabel.AutoSize = true;
            this.rAccLabel.Location = new System.Drawing.Point(302, 448);
            this.rAccLabel.Name = "rAccLabel";
            this.rAccLabel.Size = new System.Drawing.Size(69, 13);
            this.rAccLabel.TabIndex = 35;
            this.rAccLabel.Text = "Acceleration:";
            // 
            // rDecLabel
            // 
            this.rDecLabel.AutoSize = true;
            this.rDecLabel.Location = new System.Drawing.Point(302, 476);
            this.rDecLabel.Name = "rDecLabel";
            this.rDecLabel.Size = new System.Drawing.Size(70, 13);
            this.rDecLabel.TabIndex = 36;
            this.rDecLabel.Text = "Deceleration:";
            // 
            // fAccBox
            // 
            this.fAccBox.Location = new System.Drawing.Point(418, 360);
            this.fAccBox.Name = "fAccBox";
            this.fAccBox.Size = new System.Drawing.Size(100, 20);
            this.fAccBox.TabIndex = 37;
            // 
            // fDecBox
            // 
            this.fDecBox.Location = new System.Drawing.Point(418, 387);
            this.fDecBox.Name = "fDecBox";
            this.fDecBox.Size = new System.Drawing.Size(100, 20);
            this.fDecBox.TabIndex = 38;
            // 
            // rAccBox
            // 
            this.rAccBox.Location = new System.Drawing.Point(418, 448);
            this.rAccBox.Name = "rAccBox";
            this.rAccBox.Size = new System.Drawing.Size(100, 20);
            this.rAccBox.TabIndex = 39;
            // 
            // rDecBox
            // 
            this.rDecBox.Location = new System.Drawing.Point(418, 473);
            this.rDecBox.Name = "rDecBox";
            this.rDecBox.Size = new System.Drawing.Size(100, 20);
            this.rDecBox.TabIndex = 40;
            // 
            // difBalLabel
            // 
            this.difBalLabel.AutoSize = true;
            this.difBalLabel.Location = new System.Drawing.Point(281, 512);
            this.difBalLabel.Name = "difBalLabel";
            this.difBalLabel.Size = new System.Drawing.Size(263, 52);
            this.difBalLabel.TabIndex = 41;
            this.difBalLabel.Text = "Differential Balance: \r\nThis is mostly to taste, start at 60%\r\nSet closer to 0% t" +
    "o have FWD behavior (Understeer)\r\nSet closer to 100% to have RWD behavior (Overs" +
    "teer)\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 91);
            this.label1.TabIndex = 42;
            this.label1.Text = "Reminders:\r\n\r\nSet tire pressure according to telemetry and temperature!\r\n\r\nObserv" +
    "e camber in telemetry before changing anything!\r\n\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.difBalLabel);
            this.Controls.Add(this.rDecBox);
            this.Controls.Add(this.rAccBox);
            this.Controls.Add(this.fDecBox);
            this.Controls.Add(this.fAccBox);
            this.Controls.Add(this.rDecLabel);
            this.Controls.Add(this.rAccLabel);
            this.Controls.Add(this.rearDifLabel);
            this.Controls.Add(this.fDecLabel);
            this.Controls.Add(this.fAccLabel);
            this.Controls.Add(this.frontDifLabel);
            this.Controls.Add(this.raceTypeInput);
            this.Controls.Add(this.trackTypeLabel);
            this.Controls.Add(this.drivetrainInput);
            this.Controls.Add(this.drivetrainLabel);
            this.Controls.Add(this.frontWeightInput);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.rearBumpBox);
            this.Controls.Add(this.frontBumpBox);
            this.Controls.Add(this.rearDampBox);
            this.Controls.Add(this.frontDampBox);
            this.Controls.Add(this.rearSpringBox);
            this.Controls.Add(this.frontSpringBox);
            this.Controls.Add(this.rearARBBox);
            this.Controls.Add(this.frontARBBox);
            this.Controls.Add(this.rearBumpLabel);
            this.Controls.Add(this.frontBumpLabel);
            this.Controls.Add(this.rearDampingLabel);
            this.Controls.Add(this.frontDampingLabel);
            this.Controls.Add(this.rearSpringLabel);
            this.Controls.Add(this.frontSpringLabel);
            this.Controls.Add(this.rearARBLabel);
            this.Controls.Add(this.frontARBLabel);
            this.Controls.Add(this.dampRatioSelection);
            this.Controls.Add(this.desiredDamperLabel);
            this.Controls.Add(this.maxSpringInput);
            this.Controls.Add(this.minSpringInput);
            this.Controls.Add(this.minSpringLabel);
            this.Controls.Add(this.maxSpringLabel);
            this.Controls.Add(this.frontWeightLabel);
            this.Name = "Form1";
            this.Text = "Forza Horizon 4 Baseline Tuner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label frontWeightLabel;
        private System.Windows.Forms.Label maxSpringLabel;
        private System.Windows.Forms.Label minSpringLabel;
        private System.Windows.Forms.TextBox minSpringInput;
        private System.Windows.Forms.TextBox maxSpringInput;
        private System.Windows.Forms.Label desiredDamperLabel;
        private System.Windows.Forms.ListBox dampRatioSelection;
        private System.Windows.Forms.Label frontARBLabel;
        private System.Windows.Forms.Label rearARBLabel;
        private System.Windows.Forms.Label frontSpringLabel;
        private System.Windows.Forms.Label rearSpringLabel;
        private System.Windows.Forms.Label frontDampingLabel;
        private System.Windows.Forms.Label rearDampingLabel;
        private System.Windows.Forms.Label frontBumpLabel;
        private System.Windows.Forms.Label rearBumpLabel;
        private System.Windows.Forms.TextBox frontARBBox;
        private System.Windows.Forms.TextBox rearARBBox;
        private System.Windows.Forms.TextBox frontSpringBox;
        private System.Windows.Forms.TextBox rearSpringBox;
        private System.Windows.Forms.TextBox frontDampBox;
        private System.Windows.Forms.TextBox rearDampBox;
        private System.Windows.Forms.TextBox frontBumpBox;
        private System.Windows.Forms.TextBox rearBumpBox;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox frontWeightInput;
        private System.Windows.Forms.Label drivetrainLabel;
        private System.Windows.Forms.ListBox drivetrainInput;
        private System.Windows.Forms.Label trackTypeLabel;
        private System.Windows.Forms.ListBox raceTypeInput;
        private System.Windows.Forms.Label frontDifLabel;
        private System.Windows.Forms.Label fAccLabel;
        private System.Windows.Forms.Label fDecLabel;
        private System.Windows.Forms.Label rearDifLabel;
        private System.Windows.Forms.Label rAccLabel;
        private System.Windows.Forms.Label rDecLabel;
        private System.Windows.Forms.TextBox fAccBox;
        private System.Windows.Forms.TextBox fDecBox;
        private System.Windows.Forms.TextBox rAccBox;
        private System.Windows.Forms.TextBox rDecBox;
        private System.Windows.Forms.Label difBalLabel;
        private System.Windows.Forms.Label label1;
    }
}

