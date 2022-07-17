namespace FormsTask8
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
            this.sellRadioButton = new System.Windows.Forms.RadioButton();
            this.buyRadioButton = new System.Windows.Forms.RadioButton();
            this.eurRadioButton = new System.Windows.Forms.RadioButton();
            this.usdRadioButton = new System.Windows.Forms.RadioButton();
            this.clearInputButton = new System.Windows.Forms.Button();
            this.clearOutputButton = new System.Windows.Forms.Button();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.bankRateCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exchangeRatesGroupBox = new System.Windows.Forms.GroupBox();
            this.sellEurTextBox = new System.Windows.Forms.TextBox();
            this.sellUsdTextBox = new System.Windows.Forms.TextBox();
            this.buyEurTextBox = new System.Windows.Forms.TextBox();
            this.buyUsdTextBox = new System.Windows.Forms.TextBox();
            this.currencyGroupBox = new System.Windows.Forms.GroupBox();
            this.fromUahRadioButton = new System.Windows.Forms.RadioButton();
            this.fromUsdOrEurRadioButton = new System.Windows.Forms.RadioButton();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exchangeRatesGroupBox.SuspendLayout();
            this.currencyGroupBox.SuspendLayout();
            this.fromGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sellRadioButton
            // 
            this.sellRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.sellRadioButton.AutoSize = true;
            this.sellRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellRadioButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellRadioButton.Location = new System.Drawing.Point(170, 39);
            this.sellRadioButton.Margin = new System.Windows.Forms.Padding(0, 8, 0, 5);
            this.sellRadioButton.Name = "sellRadioButton";
            this.sellRadioButton.Size = new System.Drawing.Size(86, 35);
            this.sellRadioButton.TabIndex = 2;
            this.sellRadioButton.Text = "  SELL ";
            this.sellRadioButton.UseVisualStyleBackColor = true;
            this.sellRadioButton.CheckedChanged += new System.EventHandler(this.sellRadioButton_CheckedChanged);
            // 
            // buyRadioButton
            // 
            this.buyRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.buyRadioButton.AutoSize = true;
            this.buyRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyRadioButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.buyRadioButton.Location = new System.Drawing.Point(80, 39);
            this.buyRadioButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.buyRadioButton.Name = "buyRadioButton";
            this.buyRadioButton.Size = new System.Drawing.Size(85, 35);
            this.buyRadioButton.TabIndex = 1;
            this.buyRadioButton.Text = "  BUY  ";
            this.buyRadioButton.UseVisualStyleBackColor = true;
            this.buyRadioButton.CheckedChanged += new System.EventHandler(this.buyRadioButton_CheckedChanged);
            // 
            // eurRadioButton
            // 
            this.eurRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.eurRadioButton.AutoSize = true;
            this.eurRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.eurRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eurRadioButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eurRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.eurRadioButton.Location = new System.Drawing.Point(1, 55);
            this.eurRadioButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.eurRadioButton.Name = "eurRadioButton";
            this.eurRadioButton.Size = new System.Drawing.Size(61, 35);
            this.eurRadioButton.TabIndex = 7;
            this.eurRadioButton.Text = "EUR";
            this.eurRadioButton.UseVisualStyleBackColor = false;
            this.eurRadioButton.CheckedChanged += new System.EventHandler(this.eurRadioButton_CheckedChanged);
            // 
            // usdRadioButton
            // 
            this.usdRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.usdRadioButton.AutoSize = true;
            this.usdRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.usdRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usdRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usdRadioButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usdRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.usdRadioButton.Location = new System.Drawing.Point(0, 15);
            this.usdRadioButton.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.usdRadioButton.Name = "usdRadioButton";
            this.usdRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usdRadioButton.Size = new System.Drawing.Size(63, 35);
            this.usdRadioButton.TabIndex = 0;
            this.usdRadioButton.Text = "USD";
            this.usdRadioButton.UseVisualStyleBackColor = false;
            this.usdRadioButton.CheckedChanged += new System.EventHandler(this.usdRadioButton_CheckedChanged);
            // 
            // clearInputButton
            // 
            this.clearInputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(144)))), ((int)(((byte)(133)))));
            this.clearInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearInputButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearInputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.clearInputButton.Location = new System.Drawing.Point(497, 66);
            this.clearInputButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearInputButton.Name = "clearInputButton";
            this.clearInputButton.Size = new System.Drawing.Size(35, 35);
            this.clearInputButton.TabIndex = 3;
            this.clearInputButton.Text = "✖";
            this.clearInputButton.UseVisualStyleBackColor = false;
            this.clearInputButton.Click += new System.EventHandler(this.clearInputButton_Click);
            // 
            // clearOutputButton
            // 
            this.clearOutputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(144)))), ((int)(((byte)(133)))));
            this.clearOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearOutputButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearOutputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.clearOutputButton.Location = new System.Drawing.Point(497, 144);
            this.clearOutputButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearOutputButton.Name = "clearOutputButton";
            this.clearOutputButton.Size = new System.Drawing.Size(35, 35);
            this.clearOutputButton.TabIndex = 4;
            this.clearOutputButton.Text = "✖";
            this.clearOutputButton.UseVisualStyleBackColor = false;
            this.clearOutputButton.Click += new System.EventHandler(this.clearOutputButton_Click);
            // 
            // fromTextBox
            // 
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.fromTextBox.Location = new System.Drawing.Point(305, 66);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(192, 35);
            this.fromTextBox.TabIndex = 5;
            this.fromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fromTextBox.MouseHover += new System.EventHandler(this.fromTextBox_MouseHover);
            // 
            // toTextBox
            // 
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.toTextBox.Location = new System.Drawing.Point(305, 144);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(192, 35);
            this.toTextBox.TabIndex = 6;
            this.toTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toTextBox.MouseHover += new System.EventHandler(this.toTextBox_MouseHover);
            // 
            // bankRateCheckBox
            // 
            this.bankRateCheckBox.AutoSize = true;
            this.bankRateCheckBox.Font = new System.Drawing.Font("GT Walsheim Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bankRateCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(183)))), ((int)(((byte)(175)))));
            this.bankRateCheckBox.Location = new System.Drawing.Point(127, 159);
            this.bankRateCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.bankRateCheckBox.Name = "bankRateCheckBox";
            this.bankRateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bankRateCheckBox.Size = new System.Drawing.Size(129, 21);
            this.bankRateCheckBox.TabIndex = 8;
            this.bankRateCheckBox.Text = "use bank rates";
            this.bankRateCheckBox.UseVisualStyleBackColor = true;
            this.bankRateCheckBox.CheckedChanged += new System.EventHandler(this.bankRateCheckBox_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(183)))), ((int)(((byte)(175)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.calculateButton.Location = new System.Drawing.Point(305, 105);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(227, 35);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "↓ CONVERT ↓";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exchangeRatesGroupBox
            // 
            this.exchangeRatesGroupBox.Controls.Add(this.sellEurTextBox);
            this.exchangeRatesGroupBox.Controls.Add(this.sellUsdTextBox);
            this.exchangeRatesGroupBox.Controls.Add(this.buyEurTextBox);
            this.exchangeRatesGroupBox.Controls.Add(this.buyUsdTextBox);
            this.exchangeRatesGroupBox.Controls.Add(this.bankRateCheckBox);
            this.exchangeRatesGroupBox.Controls.Add(this.currencyGroupBox);
            this.exchangeRatesGroupBox.Controls.Add(this.sellRadioButton);
            this.exchangeRatesGroupBox.Controls.Add(this.buyRadioButton);
            this.exchangeRatesGroupBox.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exchangeRatesGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.exchangeRatesGroupBox.Location = new System.Drawing.Point(25, 25);
            this.exchangeRatesGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.exchangeRatesGroupBox.Name = "exchangeRatesGroupBox";
            this.exchangeRatesGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.exchangeRatesGroupBox.Size = new System.Drawing.Size(268, 194);
            this.exchangeRatesGroupBox.TabIndex = 15;
            this.exchangeRatesGroupBox.TabStop = false;
            this.exchangeRatesGroupBox.Text = "EXCHANGE RATES";
            // 
            // sellEurTextBox
            // 
            this.sellEurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellEurTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellEurTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.sellEurTextBox.Location = new System.Drawing.Point(170, 119);
            this.sellEurTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.sellEurTextBox.Name = "sellEurTextBox";
            this.sellEurTextBox.Size = new System.Drawing.Size(86, 35);
            this.sellEurTextBox.TabIndex = 19;
            this.sellEurTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sellEurTextBox.MouseHover += new System.EventHandler(this.sellEurTextBox_MouseHover);
            // 
            // sellUsdTextBox
            // 
            this.sellUsdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellUsdTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellUsdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.sellUsdTextBox.Location = new System.Drawing.Point(170, 79);
            this.sellUsdTextBox.Margin = new System.Windows.Forms.Padding(5, 0, 12, 5);
            this.sellUsdTextBox.Name = "sellUsdTextBox";
            this.sellUsdTextBox.Size = new System.Drawing.Size(86, 35);
            this.sellUsdTextBox.TabIndex = 19;
            this.sellUsdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sellUsdTextBox.MouseHover += new System.EventHandler(this.sellUsdTextBox_MouseHover);
            // 
            // buyEurTextBox
            // 
            this.buyEurTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyEurTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyEurTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.buyEurTextBox.Location = new System.Drawing.Point(80, 119);
            this.buyEurTextBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buyEurTextBox.Name = "buyEurTextBox";
            this.buyEurTextBox.Size = new System.Drawing.Size(85, 35);
            this.buyEurTextBox.TabIndex = 18;
            this.buyEurTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buyEurTextBox.MouseHover += new System.EventHandler(this.buyEurTextBox_MouseHover);
            // 
            // buyUsdTextBox
            // 
            this.buyUsdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyUsdTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyUsdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.buyUsdTextBox.Location = new System.Drawing.Point(80, 79);
            this.buyUsdTextBox.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buyUsdTextBox.Name = "buyUsdTextBox";
            this.buyUsdTextBox.Size = new System.Drawing.Size(85, 35);
            this.buyUsdTextBox.TabIndex = 17;
            this.buyUsdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buyUsdTextBox.MouseHover += new System.EventHandler(this.buyUsdTextBox_MouseHover);
            // 
            // currencyGroupBox
            // 
            this.currencyGroupBox.Controls.Add(this.usdRadioButton);
            this.currencyGroupBox.Controls.Add(this.eurRadioButton);
            this.currencyGroupBox.Location = new System.Drawing.Point(12, 64);
            this.currencyGroupBox.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.currencyGroupBox.Name = "currencyGroupBox";
            this.currencyGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.currencyGroupBox.Size = new System.Drawing.Size(63, 90);
            this.currencyGroupBox.TabIndex = 16;
            this.currencyGroupBox.TabStop = false;
            // 
            // fromUahRadioButton
            // 
            this.fromUahRadioButton.AutoSize = true;
            this.fromUahRadioButton.Font = new System.Drawing.Font("GT Walsheim Pro", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromUahRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.fromUahRadioButton.Location = new System.Drawing.Point(18, 12);
            this.fromUahRadioButton.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.fromUahRadioButton.Name = "fromUahRadioButton";
            this.fromUahRadioButton.Size = new System.Drawing.Size(92, 21);
            this.fromUahRadioButton.TabIndex = 16;
            this.fromUahRadioButton.Text = "from UAH";
            this.fromUahRadioButton.UseVisualStyleBackColor = true;
            // 
            // fromUsdOrEurRadioButton
            // 
            this.fromUsdOrEurRadioButton.AutoSize = true;
            this.fromUsdOrEurRadioButton.Font = new System.Drawing.Font("GT Walsheim Pro", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromUsdOrEurRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(108)))));
            this.fromUsdOrEurRadioButton.Location = new System.Drawing.Point(134, 12);
            this.fromUsdOrEurRadioButton.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.fromUsdOrEurRadioButton.Name = "fromUsdOrEurRadioButton";
            this.fromUsdOrEurRadioButton.Size = new System.Drawing.Size(75, 21);
            this.fromUsdOrEurRadioButton.TabIndex = 17;
            this.fromUsdOrEurRadioButton.Text = "to UAH";
            this.fromUsdOrEurRadioButton.UseVisualStyleBackColor = true;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromUahRadioButton);
            this.fromGroupBox.Controls.Add(this.fromUsdOrEurRadioButton);
            this.fromGroupBox.Location = new System.Drawing.Point(305, 28);
            this.fromGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(227, 35);
            this.fromGroupBox.TabIndex = 19;
            this.fromGroupBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(144)))), ((int)(((byte)(133)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.exitButton.Location = new System.Drawing.Point(462, 184);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 35);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(305, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 179);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(557, 244);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exchangeRatesGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.clearOutputButton);
            this.Controls.Add(this.clearInputButton);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency converter";
            this.exchangeRatesGroupBox.ResumeLayout(false);
            this.exchangeRatesGroupBox.PerformLayout();
            this.currencyGroupBox.ResumeLayout(false);
            this.currencyGroupBox.PerformLayout();
            this.fromGroupBox.ResumeLayout(false);
            this.fromGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton buyRadioButton;
        private System.Windows.Forms.Button clearInputButton;
        private System.Windows.Forms.Button clearOutputButton;
        private System.Windows.Forms.RadioButton eurRadioButton;
        private System.Windows.Forms.RadioButton usdRadioButton;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.CheckBox bankRateCheckBox;
        private System.Windows.Forms.RadioButton sellRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox exchangeRatesGroupBox;
        private System.Windows.Forms.GroupBox currencyGroupBox;
        private System.Windows.Forms.TextBox sellEurTextBox;
        private System.Windows.Forms.TextBox sellUsdTextBox;
        private System.Windows.Forms.TextBox buyEurTextBox;
        private System.Windows.Forms.TextBox buyUsdTextBox;
        private System.Windows.Forms.RadioButton fromUahRadioButton;
        private System.Windows.Forms.RadioButton fromUsdOrEurRadioButton;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}