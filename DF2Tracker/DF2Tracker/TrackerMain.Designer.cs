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
            this.currentSecretLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSecretLabel.ForeColor = System.Drawing.Color.Black;
            this.currentSecretLabel.Location = new System.Drawing.Point(6, 77);
            this.currentSecretLabel.Name = "currentSecretLabel";
            this.currentSecretLabel.Size = new System.Drawing.Size(78, 55);
            this.currentSecretLabel.TabIndex = 7;
            this.currentSecretLabel.Text = "69";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current secrets:";
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
            // TrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 159);
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
    }
}

