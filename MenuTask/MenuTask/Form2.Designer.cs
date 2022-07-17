
namespace MenuTask
{
    partial class Form2
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
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
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
            this.paragraphLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.paragraphLabel.Location = new System.Drawing.Point(25, 61);
            this.paragraphLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.paragraphLabel.Name = "paragraphLabel";
            this.paragraphLabel.Size = new System.Drawing.Size(421, 96);
            this.paragraphLabel.TabIndex = 1;
            this.paragraphLabel.Text = "• find the max and min value of the function;\n• save data to a file;\n• display a " +
    "table;\n• draw a graph.";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.copyrightLabel.Location = new System.Drawing.Point(263, 165);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(183, 19);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "2021 by Alina Artemiuk";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(471, 209);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.paragraphLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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