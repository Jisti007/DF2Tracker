namespace RacerTools
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
            this.components = new System.ComponentModel.Container();
            this.statusLabel = new System.Windows.Forms.Label();
            this.GameAvailableTimer = new System.Windows.Forms.Timer(this.components);
            this.savePositionbtn = new System.Windows.Forms.Button();
            this.gotoPositionbtn = new System.Windows.Forms.Button();
            this.gotoZerobtn = new System.Windows.Forms.Button();
            this.positionTimer = new System.Windows.Forms.Timer(this.components);
            this.curPosXLbl = new System.Windows.Forms.Label();
            this.curPosZLbl = new System.Windows.Forms.Label();
            this.curPosYLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addSavedYValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 13);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(183, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status: Looking for SWEP1RCR.exe ";
            // 
            // GameAvailableTimer
            // 
            this.GameAvailableTimer.Enabled = true;
            this.GameAvailableTimer.Tick += new System.EventHandler(this.GameAvailableTimer_Tick);
            // 
            // savePositionbtn
            // 
            this.savePositionbtn.Location = new System.Drawing.Point(27, 64);
            this.savePositionbtn.Name = "savePositionbtn";
            this.savePositionbtn.Size = new System.Drawing.Size(76, 45);
            this.savePositionbtn.TabIndex = 4;
            this.savePositionbtn.Text = "Save current position";
            this.savePositionbtn.UseVisualStyleBackColor = true;
            this.savePositionbtn.Click += new System.EventHandler(this.savePositionbtn_Click);
            // 
            // gotoPositionbtn
            // 
            this.gotoPositionbtn.Location = new System.Drawing.Point(142, 64);
            this.gotoPositionbtn.Name = "gotoPositionbtn";
            this.gotoPositionbtn.Size = new System.Drawing.Size(83, 45);
            this.gotoPositionbtn.TabIndex = 5;
            this.gotoPositionbtn.Text = "Go to saved position";
            this.gotoPositionbtn.UseVisualStyleBackColor = true;
            this.gotoPositionbtn.Click += new System.EventHandler(this.gotoPositionbtn_Click);
            // 
            // gotoZerobtn
            // 
            this.gotoZerobtn.Location = new System.Drawing.Point(182, 228);
            this.gotoZerobtn.Name = "gotoZerobtn";
            this.gotoZerobtn.Size = new System.Drawing.Size(90, 22);
            this.gotoZerobtn.TabIndex = 6;
            this.gotoZerobtn.Text = "Go to 0, 0, 0";
            this.gotoZerobtn.UseVisualStyleBackColor = true;
            this.gotoZerobtn.Click += new System.EventHandler(this.gotoZerobtn_Click);
            // 
            // positionTimer
            // 
            this.positionTimer.Enabled = true;
            this.positionTimer.Tick += new System.EventHandler(this.positionTimer_Tick);
            // 
            // curPosXLbl
            // 
            this.curPosXLbl.AutoSize = true;
            this.curPosXLbl.Location = new System.Drawing.Point(24, 163);
            this.curPosXLbl.Name = "curPosXLbl";
            this.curPosXLbl.Size = new System.Drawing.Size(48, 13);
            this.curPosXLbl.TabIndex = 7;
            this.curPosXLbl.Text = "X: empty";
            // 
            // curPosZLbl
            // 
            this.curPosZLbl.AutoSize = true;
            this.curPosZLbl.Location = new System.Drawing.Point(24, 189);
            this.curPosZLbl.Name = "curPosZLbl";
            this.curPosZLbl.Size = new System.Drawing.Size(48, 13);
            this.curPosZLbl.TabIndex = 8;
            this.curPosZLbl.Text = "Z: empty";
            // 
            // curPosYLbl
            // 
            this.curPosYLbl.AutoSize = true;
            this.curPosYLbl.Location = new System.Drawing.Point(24, 216);
            this.curPosYLbl.Name = "curPosYLbl";
            this.curPosYLbl.Size = new System.Drawing.Size(48, 13);
            this.curPosYLbl.TabIndex = 9;
            this.curPosYLbl.Text = "Y: empty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Saved position";
            // 
            // addSavedYValue
            // 
            this.addSavedYValue.Location = new System.Drawing.Point(117, 211);
            this.addSavedYValue.Name = "addSavedYValue";
            this.addSavedYValue.Size = new System.Drawing.Size(26, 22);
            this.addSavedYValue.TabIndex = 11;
            this.addSavedYValue.Text = "+";
            this.addSavedYValue.UseVisualStyleBackColor = true;
            this.addSavedYValue.Click += new System.EventHandler(this.addSavedYValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.addSavedYValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.curPosYLbl);
            this.Controls.Add(this.curPosZLbl);
            this.Controls.Add(this.curPosXLbl);
            this.Controls.Add(this.gotoZerobtn);
            this.Controls.Add(this.gotoPositionbtn);
            this.Controls.Add(this.savePositionbtn);
            this.Controls.Add(this.statusLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer GameAvailableTimer;
        private System.Windows.Forms.Button gotoPositionbtn;
        private System.Windows.Forms.Button savePositionbtn;
        private System.Windows.Forms.Button gotoZerobtn;
        private System.Windows.Forms.Timer positionTimer;
        private System.Windows.Forms.Label curPosXLbl;
        private System.Windows.Forms.Label curPosZLbl;
        private System.Windows.Forms.Label curPosYLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSavedYValue;
    }
}

