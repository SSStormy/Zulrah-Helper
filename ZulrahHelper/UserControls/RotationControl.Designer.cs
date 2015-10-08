namespace ZulrahHelper.UserControls
{
    partial class RotationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NextPicture = new System.Windows.Forms.PictureBox();
            this.CurrentPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NextPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(3, 278);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(101, 43);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current:";
            // 
            // NextPicture
            // 
            this.NextPicture.Location = new System.Drawing.Point(10, 183);
            this.NextPicture.Name = "NextPicture";
            this.NextPicture.Size = new System.Drawing.Size(86, 60);
            this.NextPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextPicture.TabIndex = 6;
            this.NextPicture.TabStop = false;
            // 
            // CurrentPicture
            // 
            this.CurrentPicture.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentPicture.Location = new System.Drawing.Point(3, 20);
            this.CurrentPicture.Name = "CurrentPicture";
            this.CurrentPicture.Size = new System.Drawing.Size(101, 74);
            this.CurrentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentPicture.TabIndex = 5;
            this.CurrentPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Next:";
            // 
            // RotationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextPicture);
            this.Controls.Add(this.CurrentPicture);
            this.Name = "RotationControl";
            this.Size = new System.Drawing.Size(108, 325);
            ((System.ComponentModel.ISupportInitialize)(this.NextPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox NextPicture;
        private System.Windows.Forms.PictureBox CurrentPicture;
        private System.Windows.Forms.Label label1;
    }
}
