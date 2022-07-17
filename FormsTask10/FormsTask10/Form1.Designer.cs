using System.Windows.Forms;
using System;

namespace FormsTask10
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clearTableContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOptionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sortToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.bySurnameAscOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySurnameDescOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.byNameAscOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameDescOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.byPhoneAscOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPhoneDescOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.byAddressAscOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAddressDescOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.clearTableToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.goUpButton = new System.Windows.Forms.Button();
            this.goDownButton = new System.Windows.Forms.Button();
            this.rowIndexLabel = new System.Windows.Forms.Label();
            this.indexToRemoveTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.firstRowButton = new System.Windows.Forms.Button();
            this.lastRowButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.clearTableContextMenuStrip.SuspendLayout();
            this.fileOptionsToolStrip.SuspendLayout();
            this.menuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.clearTableContextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(50, 75);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(722, 433);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnAdded);
            // 
            // clearTableContextMenuStrip
            // 
            this.clearTableContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clearTableContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTableToolStripMenuItem});
            this.clearTableContextMenuStrip.Name = "contextMenuStrip";
            this.clearTableContextMenuStrip.Size = new System.Drawing.Size(176, 28);
            // 
            // clearTableToolStripMenuItem
            // 
            this.clearTableToolStripMenuItem.Name = "clearTableToolStripMenuItem";
            this.clearTableToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.clearTableToolStripMenuItem.Text = "Clear the table";
            this.clearTableToolStripMenuItem.Click += new System.EventHandler(this.clearTable_Click);
            // 
            // fileOptionsToolStrip
            // 
            this.fileOptionsToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.fileOptionsToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.fileOptionsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fileOptionsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fileOptionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton});
            this.fileOptionsToolStrip.Location = new System.Drawing.Point(50, 0);
            this.fileOptionsToolStrip.Name = "fileOptionsToolStrip";
            this.fileOptionsToolStrip.Padding = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.fileOptionsToolStrip.Size = new System.Drawing.Size(722, 39);
            this.fileOptionsToolStrip.TabIndex = 1;
            this.fileOptionsToolStrip.Text = "toolStrip";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.openToolStripButton.Image = global::FormsTask10.Properties.Resources.open;
            this.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(89, 29);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.saveToolStripButton.Image = global::FormsTask10.Properties.Resources.save;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(83, 29);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.menuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.toolStripSeparator1,
            this.removeToolStripButton,
            this.toolStripSeparator2,
            this.editToolStripButton,
            this.toolStripSeparator3,
            this.searchToolStripDropDownButton,
            this.toolStripSeparator4,
            this.sortToolStripDropDownButton,
            this.toolStripSeparator8,
            this.clearTableToolStripButton});
            this.menuToolStrip.Location = new System.Drawing.Point(50, 39);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Padding = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.menuToolStrip.Size = new System.Drawing.Size(722, 25);
            this.menuToolStrip.TabIndex = 2;
            this.menuToolStrip.Text = "menuToolStrip";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.Enabled = false;
            this.addToolStripButton.Font = new System.Drawing.Font("GT Walsheim Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addToolStripButton.Image = global::FormsTask10.Properties.Resources.add;
            this.addToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.Enabled = false;
            this.removeToolStripButton.Font = new System.Drawing.Font("GT Walsheim Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeToolStripButton.Image = global::FormsTask10.Properties.Resources.remove;
            this.removeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.removeToolStripButton.Text = "Remove";
            this.removeToolStripButton.Click += new System.EventHandler(this.removeToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Enabled = false;
            this.editToolStripButton.Font = new System.Drawing.Font("GT Walsheim Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editToolStripButton.Image = global::FormsTask10.Properties.Resources.edit;
            this.editToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // searchToolStripDropDownButton
            // 
            this.searchToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripTextBox});
            this.searchToolStripDropDownButton.Enabled = false;
            this.searchToolStripDropDownButton.Font = new System.Drawing.Font("GT Walsheim Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchToolStripDropDownButton.Image = global::FormsTask10.Properties.Resources.search;
            this.searchToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripDropDownButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchToolStripDropDownButton.Name = "searchToolStripDropDownButton";
            this.searchToolStripDropDownButton.Size = new System.Drawing.Size(34, 25);
            this.searchToolStripDropDownButton.Text = "Search";
            this.searchToolStripDropDownButton.DropDownClosed += new System.EventHandler(this.searchToolStripDropDownButton_DropDownClosed);
            this.searchToolStripDropDownButton.Click += new System.EventHandler(this.searchToolStripDropDownButton_Click);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchToolStripTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(100, 21);
            this.searchToolStripTextBox.TextChanged += new EventHandler(this.searchToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // sortToolStripDropDownButton
            // 
            this.sortToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bySurnameAscOrderToolStripMenuItem,
            this.bySurnameDescOrderToolStripMenuItem,
            this.toolStripSeparator5,
            this.byNameAscOrderToolStripMenuItem,
            this.byNameDescOrderToolStripMenuItem,
            this.toolStripSeparator6,
            this.byPhoneAscOrderToolStripMenuItem,
            this.byPhoneDescOrderToolStripMenuItem,
            this.toolStripSeparator7,
            this.byAddressAscOrderToolStripMenuItem,
            this.byAddressDescOrderToolStripMenuItem});
            this.sortToolStripDropDownButton.Enabled = false;
            this.sortToolStripDropDownButton.Font = new System.Drawing.Font("GT Walsheim Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortToolStripDropDownButton.Image = global::FormsTask10.Properties.Resources.sort;
            this.sortToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sortToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortToolStripDropDownButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sortToolStripDropDownButton.Name = "sortToolStripDropDownButton";
            this.sortToolStripDropDownButton.Size = new System.Drawing.Size(34, 25);
            this.sortToolStripDropDownButton.Text = "Sort by";
            this.sortToolStripDropDownButton.Click += new System.EventHandler(this.sortToolStripDropDownButton_Click);
            // 
            // bySurnameAscOrderToolStripMenuItem
            // 
            this.bySurnameAscOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bySurnameAscOrderToolStripMenuItem.Name = "bySurnameAscOrderToolStripMenuItem";
            this.bySurnameAscOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.bySurnameAscOrderToolStripMenuItem.Text = "Surname ↑";
            this.bySurnameAscOrderToolStripMenuItem.Click += new System.EventHandler(this.bySurnameAscOrderToolStripMenuItem_Click);
            // 
            // bySurnameDescOrderToolStripMenuItem
            // 
            this.bySurnameDescOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bySurnameDescOrderToolStripMenuItem.Name = "bySurnameDescOrderToolStripMenuItem";
            this.bySurnameDescOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.bySurnameDescOrderToolStripMenuItem.Text = "Surname ↓";
            this.bySurnameDescOrderToolStripMenuItem.Click += new System.EventHandler(this.bySurnameDescOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(211, 6);
            // 
            // byNameAscOrderToolStripMenuItem
            // 
            this.byNameAscOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byNameAscOrderToolStripMenuItem.Name = "byNameAscOrderToolStripMenuItem";
            this.byNameAscOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.byNameAscOrderToolStripMenuItem.Text = "Name ↑";
            this.byNameAscOrderToolStripMenuItem.Click += new System.EventHandler(this.byNameAscOrderToolStripMenuItem_Click);
            // 
            // byNameDescOrderToolStripMenuItem
            // 
            this.byNameDescOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byNameDescOrderToolStripMenuItem.Name = "byNameDescOrderToolStripMenuItem";
            this.byNameDescOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.byNameDescOrderToolStripMenuItem.Text = "Name ↓";
            this.byNameDescOrderToolStripMenuItem.Click += new System.EventHandler(this.byNameDescOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(211, 6);
            // 
            // byPhoneAscOrderToolStripMenuItem
            // 
            this.byPhoneAscOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byPhoneAscOrderToolStripMenuItem.Name = "byPhoneAscOrderToolStripMenuItem";
            this.byPhoneAscOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.byPhoneAscOrderToolStripMenuItem.Text = "Phone number ↑";
            this.byPhoneAscOrderToolStripMenuItem.Click += new System.EventHandler(this.byPhoneAscOrderToolStripMenuItem_Click);
            // 
            // byPhoneDescOrderToolStripMenuItem
            // 
            this.byPhoneDescOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byPhoneDescOrderToolStripMenuItem.Name = "byPhoneDescOrderToolStripMenuItem";
            this.byPhoneDescOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.byPhoneDescOrderToolStripMenuItem.Text = "Phone number ↓";
            this.byPhoneDescOrderToolStripMenuItem.Click += new System.EventHandler(this.byPhoneDescOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(211, 6);
            // 
            // byAddressAscOrderToolStripMenuItem
            // 
            this.byAddressAscOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byAddressAscOrderToolStripMenuItem.Name = "byAddressAscOrderToolStripMenuItem";
            this.byAddressAscOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.byAddressAscOrderToolStripMenuItem.Text = "Address ↑";
            this.byAddressAscOrderToolStripMenuItem.Click += new System.EventHandler(this.byAddressAscOrderToolStripMenuItem_Click);
            // 
            // byAddressDescOrderToolStripMenuItem
            // 
            this.byAddressDescOrderToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byAddressDescOrderToolStripMenuItem.Name = "byAddressDescOrderToolStripMenuItem";
            this.byAddressDescOrderToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.byAddressDescOrderToolStripMenuItem.Text = "Address ↓";
            this.byAddressDescOrderToolStripMenuItem.Click += new System.EventHandler(this.byAddressDescOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // clearTableToolStripButton
            // 
            this.clearTableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearTableToolStripButton.Enabled = false;
            this.clearTableToolStripButton.Font = new System.Drawing.Font("GT Walsheim Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearTableToolStripButton.Image = global::FormsTask10.Properties.Resources.clear;
            this.clearTableToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearTableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearTableToolStripButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clearTableToolStripButton.Name = "clearTableToolStripButton";
            this.clearTableToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.clearTableToolStripButton.Text = "Clear the data table";
            this.clearTableToolStripButton.Click += new System.EventHandler(this.clearTable_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saveChangesButton.Location = new System.Drawing.Point(521, 519);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(3, 11, 6, 3);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(150, 39);
            this.saveChangesButton.TabIndex = 3;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Visible = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cancelButton.Location = new System.Drawing.Point(677, 519);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 11, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 39);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // goUpButton
            // 
            this.goUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.goUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goUpButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.goUpButton.Image = global::FormsTask10.Properties.Resources.up;
            this.goUpButton.Location = new System.Drawing.Point(775, 259);
            this.goUpButton.Name = "goUpButton";
            this.goUpButton.Size = new System.Drawing.Size(30, 30);
            this.goUpButton.TabIndex = 5;
            this.goUpButton.UseVisualStyleBackColor = false;
            this.goUpButton.Visible = false;
            this.goUpButton.Click += new System.EventHandler(this.goUpButton_Click);
            // 
            // goDownButton
            // 
            this.goDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.goDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goDownButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goDownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.goDownButton.Image = global::FormsTask10.Properties.Resources.down;
            this.goDownButton.Location = new System.Drawing.Point(775, 293);
            this.goDownButton.Name = "goDownButton";
            this.goDownButton.Size = new System.Drawing.Size(30, 30);
            this.goDownButton.TabIndex = 6;
            this.goDownButton.UseVisualStyleBackColor = false;
            this.goDownButton.Visible = false;
            this.goDownButton.Click += new System.EventHandler(this.goDownButton_Click);
            // 
            // rowIndexLabel
            // 
            this.rowIndexLabel.AutoSize = true;
            this.rowIndexLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowIndexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
            this.rowIndexLabel.Location = new System.Drawing.Point(50, 528);
            this.rowIndexLabel.Margin = new System.Windows.Forms.Padding(0);
            this.rowIndexLabel.Name = "rowIndexLabel";
            this.rowIndexLabel.Size = new System.Drawing.Size(323, 22);
            this.rowIndexLabel.TabIndex = 7;
            this.rowIndexLabel.Text = "Row index you would like to remove:";
            this.rowIndexLabel.Visible = false;
            // 
            // indexToRemoveTextBox
            // 
            this.indexToRemoveTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.indexToRemoveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indexToRemoveTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.indexToRemoveTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indexToRemoveTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.indexToRemoveTextBox.Location = new System.Drawing.Point(376, 528);
            this.indexToRemoveTextBox.Name = "indexToRemoveTextBox";
            this.indexToRemoveTextBox.Size = new System.Drawing.Size(56, 21);
            this.indexToRemoveTextBox.TabIndex = 8;
            this.indexToRemoveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.indexToRemoveTextBox.Visible = false;
            this.indexToRemoveTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.indexToRemoveTextBox_KeyDown);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.removeButton.Location = new System.Drawing.Point(571, 519);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 11, 6, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 39);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // firstRowButton
            // 
            this.firstRowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.firstRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstRowButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstRowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.firstRowButton.Image = global::FormsTask10.Properties.Resources.first_row;
            this.firstRowButton.Location = new System.Drawing.Point(775, 226);
            this.firstRowButton.Name = "firstRowButton";
            this.firstRowButton.Size = new System.Drawing.Size(30, 30);
            this.firstRowButton.TabIndex = 10;
            this.firstRowButton.UseVisualStyleBackColor = false;
            this.firstRowButton.Visible = false;
            this.firstRowButton.Click += new System.EventHandler(this.firstRowButton_Click);
            // 
            // lastRowButton
            // 
            this.lastRowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.lastRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastRowButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastRowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.lastRowButton.Image = global::FormsTask10.Properties.Resources.last_row;
            this.lastRowButton.Location = new System.Drawing.Point(775, 326);
            this.lastRowButton.Name = "lastRowButton";
            this.lastRowButton.Size = new System.Drawing.Size(30, 30);
            this.lastRowButton.TabIndex = 11;
            this.lastRowButton.UseVisualStyleBackColor = false;
            this.lastRowButton.Visible = false;
            this.lastRowButton.Click += new System.EventHandler(this.lastRowButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.addButton.Location = new System.Drawing.Point(571, 519);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 11, 6, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 39);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(822, 583);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lastRowButton);
            this.Controls.Add(this.firstRowButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.indexToRemoveTextBox);
            this.Controls.Add(this.rowIndexLabel);
            this.Controls.Add(this.goDownButton);
            this.Controls.Add(this.goUpButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.menuToolStrip);
            this.Controls.Add(this.fileOptionsToolStrip);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 75);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.clearTableContextMenuStrip.ResumeLayout(false);
            this.fileOptionsToolStrip.ResumeLayout(false);
            this.fileOptionsToolStrip.PerformLayout();
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip fileOptionsToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ContextMenuStrip clearTableContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearTableToolStripMenuItem;
        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton removeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton sortToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem bySurnameAscOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton searchToolStripDropDownButton;
        private ToolStripTextBox searchToolStripTextBox;
        private Button saveChangesButton;
        private ToolStripMenuItem bySurnameDescOrderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem byNameAscOrderToolStripMenuItem;
        private ToolStripMenuItem byNameDescOrderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem byPhoneAscOrderToolStripMenuItem;
        private ToolStripMenuItem byPhoneDescOrderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem byAddressAscOrderToolStripMenuItem;
        private ToolStripMenuItem byAddressDescOrderToolStripMenuItem;
        private Button cancelButton;
        private Button goUpButton;
        private Button goDownButton;
        private Label rowIndexLabel;
        private TextBox indexToRemoveTextBox;
        private Button removeButton;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton clearTableToolStripButton;
        private Button firstRowButton;
        private Button lastRowButton;
        private Button addButton;
    }
}