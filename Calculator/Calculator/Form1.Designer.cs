namespace Calculator
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.calculateTextBox = new System.Windows.Forms.TextBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateTextBox
            // 
            this.calculateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculateTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 40.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.calculateTextBox.Location = new System.Drawing.Point(35, 35);
            this.calculateTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.calculateTextBox.Name = "calculateTextBox";
            this.calculateTextBox.Size = new System.Drawing.Size(324, 85);
            this.calculateTextBox.TabIndex = 59;
            this.calculateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cleanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.cleanButton.Location = new System.Drawing.Point(35, 130);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 45);
            this.cleanButton.TabIndex = 60;
            this.cleanButton.Text = "C";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.deleteButton.CausesValidation = false;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.deleteButton.Location = new System.Drawing.Point(284, 130);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 45);
            this.deleteButton.TabIndex = 61;
            this.deleteButton.Text = "←";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.equalButton.CausesValidation = false;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.equalButton.Location = new System.Drawing.Point(118, 130);
            this.equalButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(158, 45);
            this.equalButton.TabIndex = 62;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.addButton.Location = new System.Drawing.Point(35, 183);
            this.addButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 75);
            this.addButton.TabIndex = 63;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.subButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.subButton.Location = new System.Drawing.Point(35, 266);
            this.subButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 75);
            this.subButton.TabIndex = 64;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.mulButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mulButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mulButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.mulButton.Location = new System.Drawing.Point(35, 349);
            this.mulButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(75, 75);
            this.mulButton.TabIndex = 65;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = false;
            this.mulButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.divButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.divButton.Location = new System.Drawing.Point(35, 432);
            this.divButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(75, 75);
            this.divButton.TabIndex = 66;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.AccessibleDescription = "";
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.oneButton.Location = new System.Drawing.Point(118, 183);
            this.oneButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(75, 75);
            this.oneButton.TabIndex = 67;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.AccessibleDescription = "";
            this.twoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.twoButton.Location = new System.Drawing.Point(201, 183);
            this.twoButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(75, 75);
            this.twoButton.TabIndex = 68;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.AccessibleDescription = "";
            this.threeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threeButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.threeButton.Location = new System.Drawing.Point(284, 183);
            this.threeButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(75, 75);
            this.threeButton.TabIndex = 69;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.AccessibleDescription = "";
            this.fourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fourButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.fourButton.Location = new System.Drawing.Point(118, 266);
            this.fourButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(75, 75);
            this.fourButton.TabIndex = 70;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.AccessibleDescription = "";
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiveButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.fiveButton.Location = new System.Drawing.Point(201, 266);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(75, 75);
            this.fiveButton.TabIndex = 71;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.AccessibleDescription = "";
            this.sixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.sixButton.Location = new System.Drawing.Point(284, 266);
            this.sixButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(75, 75);
            this.sixButton.TabIndex = 72;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.AccessibleDescription = "";
            this.nineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.nineButton.CausesValidation = false;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nineButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.nineButton.Location = new System.Drawing.Point(284, 349);
            this.nineButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(75, 75);
            this.nineButton.TabIndex = 75;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.AccessibleDescription = "";
            this.eightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eightButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.eightButton.Location = new System.Drawing.Point(201, 349);
            this.eightButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(75, 75);
            this.eightButton.TabIndex = 74;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.AccessibleDescription = "";
            this.sevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.sevenButton.CausesValidation = false;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.sevenButton.Location = new System.Drawing.Point(118, 349);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(75, 75);
            this.sevenButton.TabIndex = 73;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.AccessibleDescription = "";
            this.dotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dotButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.dotButton.Location = new System.Drawing.Point(284, 432);
            this.dotButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(75, 75);
            this.dotButton.TabIndex = 78;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.AccessibleDescription = "";
            this.zeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.zeroButton.Location = new System.Drawing.Point(118, 432);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(158, 75);
            this.zeroButton.TabIndex = 76;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(394, 542);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.calculateTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ColorDialog colorDialog1;

        #endregion
        private System.Windows.Forms.TextBox calculateTextBox;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button zeroButton;
    }
}