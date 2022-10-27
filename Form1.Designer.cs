namespace windows_app
{
    partial class USBGUARD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USBGUARD));
            this.AppTittle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartPB = new System.Windows.Forms.ProgressBar();
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppTittle
            // 
            this.AppTittle.AutoSize = true;
            this.AppTittle.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppTittle.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.AppTittle.Location = new System.Drawing.Point(196, 44);
            this.AppTittle.Name = "AppTittle";
            this.AppTittle.Size = new System.Drawing.Size(353, 76);
            this.AppTittle.TabIndex = 0;
            this.AppTittle.Text = "USB GUARD";
            this.AppTittle.Click += new System.EventHandler(this.AppTittle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AppVersion
            // 
            this.AppVersion.AutoSize = true;
            this.AppVersion.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppVersion.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.AppVersion.Location = new System.Drawing.Point(196, 132);
            this.AppVersion.Name = "AppVersion";
            this.AppVersion.Size = new System.Drawing.Size(108, 49);
            this.AppVersion.TabIndex = 1;
            this.AppVersion.Text = "V2.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label1.Location = new System.Drawing.Point(66, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "STARTING IN";
            // 
            // StartPB
            // 
            this.StartPB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartPB.Location = new System.Drawing.Point(66, 420);
            this.StartPB.MarqueeAnimationSpeed = 10000;
            this.StartPB.Maximum = 10;
            this.StartPB.Name = "StartPB";
            this.StartPB.Size = new System.Drawing.Size(376, 55);
            this.StartPB.Step = 1;
            this.StartPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StartPB.TabIndex = 3;
            this.StartPB.Value = 10;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartLabel.ForeColor = System.Drawing.Color.Red;
            this.StartLabel.Location = new System.Drawing.Point(219, 317);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(85, 100);
            this.StartLabel.TabIndex = 4;
            this.StartLabel.Text = "0";
            this.StartLabel.Click += new System.EventHandler(this.StartLabel_Click);
            // 
            // StartTimer
            // 
            this.StartTimer.Enabled = true;
            this.StartTimer.Interval = 1000;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // USBGUARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 487);
            this.ControlBox = false;
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.StartPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AppTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "USBGUARD";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB GUARD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.USBGUARD_FormClosed);
            this.Load += new System.EventHandler(this.USBGUARD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AppTittle;
        private PictureBox pictureBox1;
        private Label AppVersion;
        private Label label1;
        private ProgressBar StartPB;
        private Label StartLabel;
        private System.Windows.Forms.Timer StartTimer;
        private NotifyIcon notifyIcon1;
    }
}