namespace DF2Tracker
{
    partial class TrackerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackerMain));
            this.statusLabel = new System.Windows.Forms.Label();
            this.GameAvailableTimer = new System.Windows.Forms.Timer(this.components);
            this.currentSecretTimer = new System.Windows.Forms.Timer(this.components);
            this.currentSecretLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 13);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(179, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status: Looking for DF2Tracker.exe ";
            // 
            // GameAvailableTimer
            // 
            this.GameAvailableTimer.Enabled = true;
            this.GameAvailableTimer.Tick += new System.EventHandler(this.GameAvailableTimer_Tick);
            // 
            // currentSecretTimer
            // 
            this.currentSecretTimer.Enabled = true;
            this.currentSecretTimer.Tick += new System.EventHandler(this.currentSecretTimer_Tick);
            // 
            // currentSecretLabel
            // 
            this.currentSecretLabel.AutoSize = true;
            this.currentSecretLabel.Location = new System.Drawing.Point(24, 59);
            this.currentSecretLabel.Name = "currentSecretLabel";
            this.currentSecretLabel.Size = new System.Drawing.Size(19, 13);
            this.currentSecretLabel.TabIndex = 7;
            this.currentSecretLabel.Text = "69";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current secrets";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "READ ME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentSecretLabel);
            this.Controls.Add(this.statusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackerMain";
            this.Text = "DF2Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer GameAvailableTimer;
        private System.Windows.Forms.Timer currentSecretTimer;
        private System.Windows.Forms.Label currentSecretLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

