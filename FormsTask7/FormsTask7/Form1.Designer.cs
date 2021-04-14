
namespace FormsTask7
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.removePhotoButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.universityTextBox = new System.Windows.Forms.TextBox();
            this.facultyTextBox = new System.Windows.Forms.TextBox();
            this.specialtyTextBox = new System.Windows.Forms.TextBox();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.universityLabel = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox.Location = new System.Drawing.Point(28, 22);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 278);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // photoButton
            // 
            this.photoButton.BackColor = System.Drawing.Color.Lavender;
            this.photoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.photoButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 11F);
            this.photoButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (33)))), ((int) (((byte) (33)))));
            this.photoButton.Location = new System.Drawing.Point(28, 318);
            this.photoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(143, 28);
            this.photoButton.TabIndex = 1;
            this.photoButton.Text = "Portrait photo";
            this.photoButton.UseVisualStyleBackColor = false;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // removePhotoButton
            // 
            this.removePhotoButton.BackColor = System.Drawing.Color.Transparent;
            this.removePhotoButton.Enabled = false;
            this.removePhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removePhotoButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 11F);
            this.removePhotoButton.ForeColor = System.Drawing.Color.Thistle;
            this.removePhotoButton.Location = new System.Drawing.Point(181, 318);
            this.removePhotoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removePhotoButton.Name = "removePhotoButton";
            this.removePhotoButton.Size = new System.Drawing.Size(147, 28);
            this.removePhotoButton.TabIndex = 2;
            this.removePhotoButton.Text = "Remove photo";
            this.removePhotoButton.UseVisualStyleBackColor = false;
            this.removePhotoButton.Click += new System.EventHandler(this.removePhotoButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 12F);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(479, 22);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(175, 30);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F);
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (49)))), ((int) (((byte) (49)))));
            this.firstNameLabel.Location = new System.Drawing.Point(368, 25);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(105, 23);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F);
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (49)))), ((int) (((byte) (49)))));
            this.lastNameLabel.Location = new System.Drawing.Point(369, 67);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(104, 23);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last name";
            // 
            // universityTextBox
            // 
            this.universityTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 12F);
            this.universityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.universityTextBox.Location = new System.Drawing.Point(479, 149);
            this.universityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.Size = new System.Drawing.Size(175, 30);
            this.universityTextBox.TabIndex = 8;
            // 
            // facultyTextBox
            // 
            this.facultyTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 12F);
            this.facultyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.facultyTextBox.Location = new System.Drawing.Point(479, 191);
            this.facultyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.facultyTextBox.Name = "facultyTextBox";
            this.facultyTextBox.Size = new System.Drawing.Size(175, 30);
            this.facultyTextBox.TabIndex = 9;
            // 
            // specialtyTextBox
            // 
            this.specialtyTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 12F);
            this.specialtyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.specialtyTextBox.Location = new System.Drawing.Point(479, 234);
            this.specialtyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.specialtyTextBox.Name = "specialtyTextBox";
            this.specialtyTextBox.Size = new System.Drawing.Size(175, 30);
            this.specialtyTextBox.TabIndex = 10;
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F);
            this.facultyLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (49)))), ((int) (((byte) (49)))));
            this.facultyLabel.Location = new System.Drawing.Point(396, 194);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(77, 23);
            this.facultyLabel.TabIndex = 13;
            this.facultyLabel.Text = "Faculty";
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.AutoSize = true;
            this.specialtyLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F);
            this.specialtyLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (49)))), ((int) (((byte) (49)))));
            this.specialtyLabel.Location = new System.Drawing.Point(379, 237);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(94, 23);
            this.specialtyLabel.TabIndex = 14;
            this.specialtyLabel.Text = "Specialty";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F);
            this.groupLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (49)))), ((int) (((byte) (49)))));
            this.groupLabel.Location = new System.Drawing.Point(405, 279);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(68, 23);
            this.groupLabel.TabIndex = 15;
            this.groupLabel.Text = "Group";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Thistle;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 11F);
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (33)))), ((int) (((byte) (33)))));
            this.saveButton.Location = new System.Drawing.Point(569, 318);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 28);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F);
            this.universityLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (49)))), ((int) (((byte) (49)))));
            this.universityLabel.Location = new System.Drawing.Point(374, 152);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(99, 23);
            this.universityLabel.TabIndex = 18;
            this.universityLabel.Text = "University";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 12F);
            this.groupTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.groupTextBox.Location = new System.Drawing.Point(479, 276);
            this.groupTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(175, 30);
            this.groupTextBox.TabIndex = 17;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 12F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(479, 64);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 17);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(175, 30);
            this.lastNameTextBox.TabIndex = 20;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F);
            this.dateOfBirthLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (49)))), ((int) (((byte) (49)))));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(349, 111);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(124, 23);
            this.dateOfBirthLabel.TabIndex = 22;
            this.dateOfBirthLabel.Text = "Date of birth";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.CalendarFont = new System.Drawing.Font("GT Walsheim Pro", 7F);
            this.dateOfBirthPicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.dateOfBirthPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.dateOfBirthPicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.dateOfBirthPicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (65)))), ((int) (((byte) (65)))));
            this.dateOfBirthPicker.Checked = false;
            this.dateOfBirthPicker.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(479, 105);
            this.dateOfBirthPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(175, 30);
            this.dateOfBirthPicker.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(682, 382);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.specialtyTextBox);
            this.Controls.Add(this.facultyTextBox);
            this.Controls.Add(this.universityTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.removePhotoButton);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.pictureBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.Text = "Student survey";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label dateOfBirthLabel;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Button removePhotoButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox universityTextBox;
        private System.Windows.Forms.TextBox facultyTextBox;
        private System.Windows.Forms.TextBox specialtyTextBox;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
    }
}

