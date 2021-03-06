﻿namespace HandWarmer
{
    partial class ControlForm
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
            this.tbLevel = new System.Windows.Forms.TrackBar();
            this.lMin = new System.Windows.Forms.Label();
            this.lMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLevel
            // 
            this.tbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLevel.LargeChange = 2;
            this.tbLevel.Location = new System.Drawing.Point(9, 10);
            this.tbLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLevel.Maximum = 8;
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(223, 45);
            this.tbLevel.TabIndex = 2;
            this.tbLevel.Scroll += new System.EventHandler(this.tbLevel_Scroll);
            // 
            // lMin
            // 
            this.lMin.AutoSize = true;
            this.lMin.Location = new System.Drawing.Point(9, 35);
            this.lMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMin.Name = "lMin";
            this.lMin.Size = new System.Drawing.Size(13, 13);
            this.lMin.TabIndex = 3;
            this.lMin.Text = "0";
            // 
            // lMax
            // 
            this.lMax.AutoSize = true;
            this.lMax.Location = new System.Drawing.Point(210, 35);
            this.lMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(13, 13);
            this.lMax.TabIndex = 4;
            this.lMax.Text = "8";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 56);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.lMin);
            this.Controls.Add(this.tbLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.Text = "Simple Hand Warmer";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbLevel;
        private System.Windows.Forms.Label lMin;
        private System.Windows.Forms.Label lMax;
    }
}

