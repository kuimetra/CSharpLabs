
namespace Notepad
{
    partial class AboutForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.paragraphLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.headerLabel.Location = new System.Drawing.Point(25, 25);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(339, 28);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "With this application you can:";
            // 
            // paragraphLabel
            // 
            this.paragraphLabel.AutoSize = true;
            this.paragraphLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paragraphLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(95)))));
            this.paragraphLabel.Location = new System.Drawing.Point(25, 61);
            this.paragraphLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.paragraphLabel.Name = "paragraphLabel";
            this.paragraphLabel.Size = new System.Drawing.Size(374, 96);
            this.paragraphLabel.TabIndex = 1;
            this.paragraphLabel.Text = "• change font and color of the text;\n• format individual words or characters\n   u" +
    "sing Character Styles;\n• align text.";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.copyrightLabel.Location = new System.Drawing.Point(216, 165);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(183, 19);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "2021 by Alina Artemiuk";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(424, 209);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.paragraphLabel);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About this application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label paragraphLabel;
        private System.Windows.Forms.Label copyrightLabel;
    }
}