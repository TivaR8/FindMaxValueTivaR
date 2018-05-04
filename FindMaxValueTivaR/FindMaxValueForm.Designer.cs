namespace FindMaxValueTivaR
{
    partial class frmFindMaxValue
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstNumberSet = new System.Windows.Forms.ListBox();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(122, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstNumberSet
            // 
            this.lstNumberSet.FormattingEnabled = true;
            this.lstNumberSet.Location = new System.Drawing.Point(66, 76);
            this.lstNumberSet.Name = "lstNumberSet";
            this.lstNumberSet.Size = new System.Drawing.Size(191, 160);
            this.lstNumberSet.TabIndex = 1;
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(72, 252);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(90, 13);
            this.lblMaxValue.TabIndex = 2;
            this.lblMaxValue.Text = "The max value is:";
            // 
            // frmFindMaxValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 285);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.lstNumberSet);
            this.Controls.Add(this.btnStart);
            this.Name = "frmFindMaxValue";
            this.Text = "Find Max Value By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstNumberSet;
        private System.Windows.Forms.Label lblMaxValue;
    }
}

