namespace ZulrahHelper.Forms
{
    partial class MainForm
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
            this.activePanel = new System.Windows.Forms.Panel();
            this.curRotationLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activePanel
            // 
            this.activePanel.Location = new System.Drawing.Point(12, 39);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(509, 410);
            this.activePanel.TabIndex = 0;
            // 
            // curRotationLabel
            // 
            this.curRotationLabel.AutoSize = true;
            this.curRotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.curRotationLabel.Location = new System.Drawing.Point(12, 13);
            this.curRotationLabel.Name = "curRotationLabel";
            this.curRotationLabel.Size = new System.Drawing.Size(110, 16);
            this.curRotationLabel.TabIndex = 1;
            this.curRotationLabel.Text = "Current rotation: 1";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(446, 10);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 461);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.curRotationLabel);
            this.Controls.Add(this.activePanel);
            this.Name = "MainForm";
            this.Text = "Zulrah Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Label curRotationLabel;
        private System.Windows.Forms.Button AboutButton;
    }
}

