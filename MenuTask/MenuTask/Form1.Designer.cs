using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MenuTask
{
    partial class Form1
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///     Clean up any resources being used.
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
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.calculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.maxValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearTheTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.aIntervalTextBox = new System.Windows.Forms.TextBox();
            this.bIntervalTextBox = new System.Windows.Forms.TextBox();
            this.firstBracketLabel = new System.Windows.Forms.Label();
            this.semicolonLabel = new System.Windows.Forms.Label();
            this.secondBracketLabel = new System.Windows.Forms.Label();
            this.tabIntervalLabel = new System.Windows.Forms.Label();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.funcToTabTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sinButton = new System.Windows.Forms.Button();
            this.cotButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.xButton = new System.Windows.Forms.Button();
            this.showLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.fileCheckBox = new System.Windows.Forms.CheckBox();
            this.onTheScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.roundBracket2Button = new System.Windows.Forms.Button();
            this.roundBracket1Button = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.funcGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tabulateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.functionGraphToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.maxValueToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.minValueToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearTheTableToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxAndMinGroupBox = new System.Windows.Forms.GroupBox();
            this.calculatorGroupBox = new System.Windows.Forms.GroupBox();
            this.intervalAndStepGroupBox = new System.Windows.Forms.GroupBox();
            this.tableAndPlotGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.maxAndMinGroupBox.SuspendLayout();
            this.calculatorGroupBox.SuspendLayout();
            this.intervalAndStepGroupBox.SuspendLayout();
            this.tableAndPlotGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.menuStrip.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculationToolStripMenuItem,
            this.endToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(18, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(732, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // calculationToolStripMenuItem
            // 
            this.calculationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabFunctionToolStripMenuItem,
            this.functionGraphToolStripMenuItem,
            this.toolStripSeparator1,
            this.maxValueToolStripMenuItem,
            this.minValueToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearTheTableToolStripMenuItem});
            this.calculationToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.calculationToolStripMenuItem.Name = "calculationToolStripMenuItem";
            this.calculationToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.calculationToolStripMenuItem.Text = "&CALCULATION";
            // 
            // tabFunctionToolStripMenuItem
            // 
            this.tabFunctionToolStripMenuItem.Name = "tabFunctionToolStripMenuItem";
            this.tabFunctionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tabFunctionToolStripMenuItem.Size = new System.Drawing.Size(420, 28);
            this.tabFunctionToolStripMenuItem.Text = "Tabulate function";
            this.tabFunctionToolStripMenuItem.Click += new System.EventHandler(this.tabFunctionToolStripMenuItem_Click);
            // 
            // functionGraphToolStripMenuItem
            // 
            this.functionGraphToolStripMenuItem.Name = "functionGraphToolStripMenuItem";
            this.functionGraphToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.functionGraphToolStripMenuItem.Size = new System.Drawing.Size(420, 28);
            this.functionGraphToolStripMenuItem.Text = "Function graph";
            this.functionGraphToolStripMenuItem.Click += new System.EventHandler(this.functionGraphToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(417, 6);
            // 
            // maxValueToolStripMenuItem
            // 
            this.maxValueToolStripMenuItem.Name = "maxValueToolStripMenuItem";
            this.maxValueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.maxValueToolStripMenuItem.Size = new System.Drawing.Size(420, 28);
            this.maxValueToolStripMenuItem.Text = "Max value of the function";
            this.maxValueToolStripMenuItem.Click += new System.EventHandler(this.maxValueToolStripMenuItem_Click);
            // 
            // minValueToolStripMenuItem
            // 
            this.minValueToolStripMenuItem.Name = "minValueToolStripMenuItem";
            this.minValueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.minValueToolStripMenuItem.Size = new System.Drawing.Size(420, 28);
            this.minValueToolStripMenuItem.Text = "Min value of the function";
            this.minValueToolStripMenuItem.Click += new System.EventHandler(this.minValueToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(417, 6);
            // 
            // clearTheTableToolStripMenuItem
            // 
            this.clearTheTableToolStripMenuItem.Name = "clearTheTableToolStripMenuItem";
            this.clearTheTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearTheTableToolStripMenuItem.Size = new System.Drawing.Size(420, 28);
            this.clearTheTableToolStripMenuItem.Text = "Clear the table";
            this.clearTheTableToolStripMenuItem.Click += new System.EventHandler(this.clearTheTableToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.endToolStripMenuItem.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.endToolStripMenuItem.Text = "&END";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(129)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.dataGridView.Location = new System.Drawing.Point(5, 16);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(361, 205);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.MouseHover += new System.EventHandler(this.dataGridView_MouseHover);
            // 
            // aIntervalTextBox
            // 
            this.aIntervalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aIntervalTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aIntervalTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.aIntervalTextBox.Location = new System.Drawing.Point(29, 45);
            this.aIntervalTextBox.Margin = new System.Windows.Forms.Padding(3, 45, 0, 10);
            this.aIntervalTextBox.Name = "aIntervalTextBox";
            this.aIntervalTextBox.Size = new System.Drawing.Size(85, 38);
            this.aIntervalTextBox.TabIndex = 2;
            this.aIntervalTextBox.MouseHover += new System.EventHandler(this.aIntervalTextBox_MouseHover);
            // 
            // bIntervalTextBox
            // 
            this.bIntervalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bIntervalTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIntervalTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.bIntervalTextBox.Location = new System.Drawing.Point(146, 45);
            this.bIntervalTextBox.Margin = new System.Windows.Forms.Padding(5, 25, 0, 10);
            this.bIntervalTextBox.Name = "bIntervalTextBox";
            this.bIntervalTextBox.Size = new System.Drawing.Size(85, 38);
            this.bIntervalTextBox.TabIndex = 3;
            this.bIntervalTextBox.MouseHover += new System.EventHandler(this.bIntervalTextBox_MouseHover);
            // 
            // firstBracketLabel
            // 
            this.firstBracketLabel.AutoSize = true;
            this.firstBracketLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstBracketLabel.Location = new System.Drawing.Point(2, 45);
            this.firstBracketLabel.Margin = new System.Windows.Forms.Padding(15, 5, 0, 10);
            this.firstBracketLabel.Name = "firstBracketLabel";
            this.firstBracketLabel.Size = new System.Drawing.Size(24, 34);
            this.firstBracketLabel.TabIndex = 4;
            this.firstBracketLabel.Text = "[";
            // 
            // semicolonLabel
            // 
            this.semicolonLabel.AutoSize = true;
            this.semicolonLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semicolonLabel.Location = new System.Drawing.Point(117, 45);
            this.semicolonLabel.Margin = new System.Windows.Forms.Padding(3, 45, 0, 10);
            this.semicolonLabel.Name = "semicolonLabel";
            this.semicolonLabel.Size = new System.Drawing.Size(24, 34);
            this.semicolonLabel.TabIndex = 5;
            this.semicolonLabel.Text = ";";
            // 
            // secondBracketLabel
            // 
            this.secondBracketLabel.AutoSize = true;
            this.secondBracketLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondBracketLabel.Location = new System.Drawing.Point(234, 45);
            this.secondBracketLabel.Margin = new System.Windows.Forms.Padding(3, 45, 0, 10);
            this.secondBracketLabel.Name = "secondBracketLabel";
            this.secondBracketLabel.Size = new System.Drawing.Size(24, 34);
            this.secondBracketLabel.TabIndex = 6;
            this.secondBracketLabel.Text = "]";
            // 
            // tabIntervalLabel
            // 
            this.tabIntervalLabel.AutoSize = true;
            this.tabIntervalLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabIntervalLabel.Location = new System.Drawing.Point(5, 15);
            this.tabIntervalLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.tabIntervalLabel.Name = "tabIntervalLabel";
            this.tabIntervalLabel.Size = new System.Drawing.Size(128, 25);
            this.tabIntervalLabel.TabIndex = 7;
            this.tabIntervalLabel.Text = "Tab interval";
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stepLabel.Location = new System.Drawing.Point(279, 15);
            this.stepLabel.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(57, 25);
            this.stepLabel.TabIndex = 8;
            this.stepLabel.Text = "Step";
            // 
            // stepTextBox
            // 
            this.stepTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stepTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.stepTextBox.Location = new System.Drawing.Point(283, 45);
            this.stepTextBox.Margin = new System.Windows.Forms.Padding(35, 25, 0, 10);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(85, 38);
            this.stepTextBox.TabIndex = 9;
            this.stepTextBox.MouseHover += new System.EventHandler(this.stepTextBox_MouseHover);
            // 
            // funcToTabTextBox
            // 
            this.funcToTabTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funcToTabTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.funcToTabTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.funcToTabTextBox.Location = new System.Drawing.Point(29, 112);
            this.funcToTabTextBox.Margin = new System.Windows.Forms.Padding(35, 5, 0, 12);
            this.funcToTabTextBox.Name = "funcToTabTextBox";
            this.funcToTabTextBox.Size = new System.Drawing.Size(284, 42);
            this.funcToTabTextBox.TabIndex = 10;
            this.funcToTabTextBox.MouseHover += new System.EventHandler(this.funcToTabTextBox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(35, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Function to tabulate";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Window;
            this.chart.BorderlineColor = System.Drawing.Color.Empty;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 5;
            this.chart.BorderSkin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chart.BorderSkin.BackImage = "ButtonFace";
            this.chart.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.ButtonFace;
            this.chart.BorderSkin.BorderWidth = 10;
            this.chart.BorderSkin.PageColor = System.Drawing.SystemColors.ButtonFace;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(341, 430);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart1";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))))};
            series1.ChartArea = "ChartArea1";
            series1.Name = "Plot";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(361, 205);
            this.chart.TabIndex = 1;
            this.chart.MouseHover += new System.EventHandler(this.chart_MouseHover);
            // 
            // sinButton
            // 
            this.sinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.sinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sinButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.sinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.sinButton.Location = new System.Drawing.Point(29, 166);
            this.sinButton.Margin = new System.Windows.Forms.Padding(0);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(65, 38);
            this.sinButton.TabIndex = 14;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = false;
            this.sinButton.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // cotButton
            // 
            this.cotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.cotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cotButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.cotButton.Location = new System.Drawing.Point(248, 166);
            this.cotButton.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.cotButton.Name = "cotButton";
            this.cotButton.Size = new System.Drawing.Size(65, 38);
            this.cotButton.TabIndex = 15;
            this.cotButton.Text = "cot";
            this.cotButton.UseVisualStyleBackColor = false;
            this.cotButton.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.cosButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cosButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cosButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.cosButton.Location = new System.Drawing.Point(102, 166);
            this.cosButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(65, 38);
            this.cosButton.TabIndex = 16;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = false;
            this.cosButton.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // tanButton
            // 
            this.tanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.tanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tanButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.tanButton.Location = new System.Drawing.Point(175, 166);
            this.tanButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(65, 38);
            this.tanButton.TabIndex = 17;
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = false;
            this.tanButton.Click += new System.EventHandler(this.funcButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.addButton.Location = new System.Drawing.Point(29, 285);
            this.addButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 65);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.oneButton.Location = new System.Drawing.Point(102, 285);
            this.oneButton.Margin = new System.Windows.Forms.Padding(0);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(65, 65);
            this.oneButton.TabIndex = 19;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.subButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.subButton.Location = new System.Drawing.Point(29, 358);
            this.subButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(65, 65);
            this.subButton.TabIndex = 20;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.mulButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mulButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mulButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.mulButton.Location = new System.Drawing.Point(29, 431);
            this.mulButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(65, 65);
            this.mulButton.TabIndex = 21;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = false;
            this.mulButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.divButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.divButton.Location = new System.Drawing.Point(5, 434);
            this.divButton.Margin = new System.Windows.Forms.Padding(0);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(65, 65);
            this.divButton.TabIndex = 22;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fourButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.fourButton.Location = new System.Drawing.Point(102, 358);
            this.fourButton.Margin = new System.Windows.Forms.Padding(10);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(65, 65);
            this.fourButton.TabIndex = 23;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.twoButton.Location = new System.Drawing.Point(175, 284);
            this.twoButton.Margin = new System.Windows.Forms.Padding(10);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(65, 65);
            this.twoButton.TabIndex = 24;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiveButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.fiveButton.Location = new System.Drawing.Point(151, 289);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(10);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(65, 65);
            this.fiveButton.TabIndex = 25;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threeButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.threeButton.Location = new System.Drawing.Point(248, 284);
            this.threeButton.Margin = new System.Windows.Forms.Padding(0);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(65, 65);
            this.threeButton.TabIndex = 26;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.sixButton.Location = new System.Drawing.Point(224, 289);
            this.sixButton.Margin = new System.Windows.Forms.Padding(0);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(65, 65);
            this.sixButton.TabIndex = 27;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.sevenButton.Location = new System.Drawing.Point(78, 362);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(10);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(65, 65);
            this.sevenButton.TabIndex = 28;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eightButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.eightButton.Location = new System.Drawing.Point(151, 362);
            this.eightButton.Margin = new System.Windows.Forms.Padding(10);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(65, 65);
            this.eightButton.TabIndex = 29;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nineButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.nineButton.Location = new System.Drawing.Point(224, 362);
            this.nineButton.Margin = new System.Windows.Forms.Padding(8);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(65, 65);
            this.nineButton.TabIndex = 30;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dotButton.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.dotButton.Location = new System.Drawing.Point(78, 434);
            this.dotButton.Margin = new System.Windows.Forms.Padding(10);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(65, 65);
            this.dotButton.TabIndex = 31;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.zeroButton.Location = new System.Drawing.Point(151, 434);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(10);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(65, 65);
            this.zeroButton.TabIndex = 32;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // xButton
            // 
            this.xButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.xButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xButton.Font = new System.Drawing.Font("GT Walsheim Pro", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.xButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.xButton.Location = new System.Drawing.Point(224, 434);
            this.xButton.Margin = new System.Windows.Forms.Padding(0);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(65, 65);
            this.xButton.TabIndex = 33;
            this.xButton.Text = "x";
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showLabel.Location = new System.Drawing.Point(1, 13);
            this.showLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(159, 25);
            this.showLabel.TabIndex = 34;
            this.showLabel.Text = "Show results";
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.showLabel);
            this.resultsGroupBox.Controls.Add(this.fileCheckBox);
            this.resultsGroupBox.Controls.Add(this.onTheScreenCheckBox);
            this.resultsGroupBox.Location = new System.Drawing.Point(24, 569);
            this.resultsGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(294, 71);
            this.resultsGroupBox.TabIndex = 35;
            this.resultsGroupBox.TabStop = false;
            // 
            // fileCheckBox
            // 
            this.fileCheckBox.AutoSize = true;
            this.fileCheckBox.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileCheckBox.Location = new System.Drawing.Point(151, 41);
            this.fileCheckBox.Margin = new System.Windows.Forms.Padding(30);
            this.fileCheckBox.Name = "fileCheckBox";
            this.fileCheckBox.Size = new System.Drawing.Size(83, 23);
            this.fileCheckBox.TabIndex = 37;
            this.fileCheckBox.Text = "in file";
            this.fileCheckBox.UseVisualStyleBackColor = true;
            this.fileCheckBox.CheckedChanged += new System.EventHandler(this.fileCheckBox_CheckedChanged);
            // 
            // onTheScreenCheckBox
            // 
            this.onTheScreenCheckBox.AutoSize = true;
            this.onTheScreenCheckBox.Font = new System.Drawing.Font("GT Walsheim Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.onTheScreenCheckBox.Location = new System.Drawing.Point(5, 41);
            this.onTheScreenCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.onTheScreenCheckBox.Name = "onTheScreenCheckBox";
            this.onTheScreenCheckBox.Size = new System.Drawing.Size(99, 23);
            this.onTheScreenCheckBox.TabIndex = 36;
            this.onTheScreenCheckBox.Text = "on the screen";
            this.onTheScreenCheckBox.UseVisualStyleBackColor = true;
            this.onTheScreenCheckBox.CheckedChanged += new System.EventHandler(this.onTheScreenCheckBox_CheckedChanged);
            // 
            // roundBracket2Button
            // 
            this.roundBracket2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.roundBracket2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundBracket2Button.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundBracket2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.roundBracket2Button.Location = new System.Drawing.Point(102, 212);
            this.roundBracket2Button.Margin = new System.Windows.Forms.Padding(8);
            this.roundBracket2Button.Name = "roundBracket2Button";
            this.roundBracket2Button.Size = new System.Drawing.Size(65, 65);
            this.roundBracket2Button.TabIndex = 36;
            this.roundBracket2Button.Text = ")";
            this.roundBracket2Button.UseVisualStyleBackColor = false;
            this.roundBracket2Button.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // roundBracket1Button
            // 
            this.roundBracket1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.roundBracket1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundBracket1Button.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundBracket1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(225)))));
            this.roundBracket1Button.Location = new System.Drawing.Point(29, 212);
            this.roundBracket1Button.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.roundBracket1Button.Name = "roundBracket1Button";
            this.roundBracket1Button.Size = new System.Drawing.Size(65, 65);
            this.roundBracket1Button.TabIndex = 37;
            this.roundBracket1Button.Text = "(";
            this.roundBracket1Button.UseVisualStyleBackColor = false;
            this.roundBracket1Button.Click += new System.EventHandler(this.numOrSignButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cleanButton.ForeColor = System.Drawing.Color.White;
            this.cleanButton.Location = new System.Drawing.Point(175, 212);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(10);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(65, 65);
            this.cleanButton.TabIndex = 38;
            this.cleanButton.Text = "C";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(248, 212);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(65, 65);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "←";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.AllowDrop = true;
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabulateToolStripMenuItem,
            this.clearTableToolStripMenuItem,
            this.toolStripSeparator7,
            this.funcGraphToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(193, 82);
            // 
            // tabulateToolStripMenuItem
            // 
            this.tabulateToolStripMenuItem.Name = "tabulateToolStripMenuItem";
            this.tabulateToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.tabulateToolStripMenuItem.Text = "Tabulate function";
            this.tabulateToolStripMenuItem.Click += new System.EventHandler(this.tabFunctionToolStripMenuItem_Click);
            // 
            // clearTableToolStripMenuItem
            // 
            this.clearTableToolStripMenuItem.Name = "clearTableToolStripMenuItem";
            this.clearTableToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.clearTableToolStripMenuItem.Text = "Clear the table";
            this.clearTableToolStripMenuItem.Click += new System.EventHandler(this.clearTheTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(189, 6);
            // 
            // funcGraphToolStripMenuItem
            // 
            this.funcGraphToolStripMenuItem.Name = "funcGraphToolStripMenuItem";
            this.funcGraphToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.funcGraphToolStripMenuItem.Text = "Function graph";
            this.funcGraphToolStripMenuItem.Click += new System.EventHandler(this.functionGraphToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(10);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabulateToolStripButton,
            this.functionGraphToolStripButton,
            this.toolStripSeparator4,
            this.maxValueToolStripButton,
            this.minValueToolStripButton,
            this.toolStripSeparator5,
            this.clearTheTableToolStripButton,
            this.toolStripSeparator6,
            this.aboutToolStripButton,
            this.exitToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 35);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.toolStrip.Size = new System.Drawing.Size(732, 29);
            this.toolStrip.TabIndex = 40;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tabulateToolStripButton
            // 
            this.tabulateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabulateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tabulateToolStripButton.Image")));
            this.tabulateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tabulateToolStripButton.Name = "tabulateToolStripButton";
            this.tabulateToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.tabulateToolStripButton.Text = "Tabulate function";
            this.tabulateToolStripButton.Click += new System.EventHandler(this.tabFunctionToolStripMenuItem_Click);
            // 
            // functionGraphToolStripButton
            // 
            this.functionGraphToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.functionGraphToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("functionGraphToolStripButton.Image")));
            this.functionGraphToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.functionGraphToolStripButton.Name = "functionGraphToolStripButton";
            this.functionGraphToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.functionGraphToolStripButton.Text = "Function graph";
            this.functionGraphToolStripButton.Click += new System.EventHandler(this.functionGraphToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // maxValueToolStripButton
            // 
            this.maxValueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maxValueToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("maxValueToolStripButton.Image")));
            this.maxValueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maxValueToolStripButton.Name = "maxValueToolStripButton";
            this.maxValueToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.maxValueToolStripButton.Text = "Max value of the function";
            this.maxValueToolStripButton.Click += new System.EventHandler(this.maxValueToolStripMenuItem_Click);
            // 
            // minValueToolStripButton
            // 
            this.minValueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minValueToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("minValueToolStripButton.Image")));
            this.minValueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minValueToolStripButton.Name = "minValueToolStripButton";
            this.minValueToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.minValueToolStripButton.Text = "Min value of the function";
            this.minValueToolStripButton.Click += new System.EventHandler(this.minValueToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // clearTheTableToolStripButton
            // 
            this.clearTheTableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearTheTableToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearTheTableToolStripButton.Image")));
            this.clearTheTableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearTheTableToolStripButton.Name = "clearTheTableToolStripButton";
            this.clearTheTableToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.clearTheTableToolStripButton.Text = "Clear the table";
            this.clearTheTableToolStripButton.Click += new System.EventHandler(this.clearTheTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.aboutToolStripButton.Text = "About...";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripButton.Image")));
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.exitToolStripButton.Text = "Exit";
            this.exitToolStripButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxLabel.Location = new System.Drawing.Point(6, 19);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(72, 25);
            this.maxLabel.TabIndex = 41;
            this.maxLabel.Text = "Max =";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minLabel.Location = new System.Drawing.Point(215, 19);
            this.minLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(65, 25);
            this.minLabel.TabIndex = 42;
            this.minLabel.Text = "Min =";
            // 
            // minTextBox
            // 
            this.minTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.minTextBox.Location = new System.Drawing.Point(283, 13);
            this.minTextBox.Margin = new System.Windows.Forms.Padding(25, 25, 0, 10);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(85, 38);
            this.minTextBox.TabIndex = 43;
            this.minTextBox.MouseHover += new System.EventHandler(this.minTextBox_MouseHover);
            // 
            // maxTextBox
            // 
            this.maxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.maxTextBox.Location = new System.Drawing.Point(81, 13);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(25, 25, 0, 10);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(85, 38);
            this.maxTextBox.TabIndex = 44;
            this.maxTextBox.MouseHover += new System.EventHandler(this.maxTextBox_MouseHover);
            // 
            // maxAndMinGroupBox
            // 
            this.maxAndMinGroupBox.Controls.Add(this.maxLabel);
            this.maxAndMinGroupBox.Controls.Add(this.minTextBox);
            this.maxAndMinGroupBox.Controls.Add(this.maxTextBox);
            this.maxAndMinGroupBox.Controls.Add(this.minLabel);
            this.maxAndMinGroupBox.Location = new System.Drawing.Point(336, 153);
            this.maxAndMinGroupBox.Name = "maxAndMinGroupBox";
            this.maxAndMinGroupBox.Size = new System.Drawing.Size(371, 55);
            this.maxAndMinGroupBox.TabIndex = 45;
            this.maxAndMinGroupBox.TabStop = false;
            // 
            // calculatorGroupBox
            // 
            this.calculatorGroupBox.Controls.Add(this.zeroButton);
            this.calculatorGroupBox.Controls.Add(this.xButton);
            this.calculatorGroupBox.Controls.Add(this.dotButton);
            this.calculatorGroupBox.Controls.Add(this.divButton);
            this.calculatorGroupBox.Controls.Add(this.sevenButton);
            this.calculatorGroupBox.Controls.Add(this.eightButton);
            this.calculatorGroupBox.Controls.Add(this.nineButton);
            this.calculatorGroupBox.Controls.Add(this.sixButton);
            this.calculatorGroupBox.Controls.Add(this.fiveButton);
            this.calculatorGroupBox.Location = new System.Drawing.Point(24, 69);
            this.calculatorGroupBox.Name = "calculatorGroupBox";
            this.calculatorGroupBox.Size = new System.Drawing.Size(294, 505);
            this.calculatorGroupBox.TabIndex = 46;
            this.calculatorGroupBox.TabStop = false;
            // 
            // intervalAndStepGroupBox
            // 
            this.intervalAndStepGroupBox.Controls.Add(this.aIntervalTextBox);
            this.intervalAndStepGroupBox.Controls.Add(this.semicolonLabel);
            this.intervalAndStepGroupBox.Controls.Add(this.bIntervalTextBox);
            this.intervalAndStepGroupBox.Controls.Add(this.secondBracketLabel);
            this.intervalAndStepGroupBox.Controls.Add(this.firstBracketLabel);
            this.intervalAndStepGroupBox.Controls.Add(this.stepTextBox);
            this.intervalAndStepGroupBox.Controls.Add(this.stepLabel);
            this.intervalAndStepGroupBox.Controls.Add(this.tabIntervalLabel);
            this.intervalAndStepGroupBox.Location = new System.Drawing.Point(336, 69);
            this.intervalAndStepGroupBox.Name = "intervalAndStepGroupBox";
            this.intervalAndStepGroupBox.Size = new System.Drawing.Size(371, 88);
            this.intervalAndStepGroupBox.TabIndex = 47;
            this.intervalAndStepGroupBox.TabStop = false;
            // 
            // tableAndPlotGroupBox
            // 
            this.tableAndPlotGroupBox.Controls.Add(this.dataGridView);
            this.tableAndPlotGroupBox.Location = new System.Drawing.Point(336, 201);
            this.tableAndPlotGroupBox.Name = "tableAndPlotGroupBox";
            this.tableAndPlotGroupBox.Size = new System.Drawing.Size(371, 439);
            this.tableAndPlotGroupBox.TabIndex = 48;
            this.tableAndPlotGroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 663);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.intervalAndStepGroupBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.roundBracket1Button);
            this.Controls.Add(this.roundBracket2Button);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tanButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.cotButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcToTabTextBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.maxAndMinGroupBox);
            this.Controls.Add(this.calculatorGroupBox);
            this.Controls.Add(this.tableAndPlotGroupBox);
            this.Controls.Add(this.resultsGroupBox);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab function application";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.maxAndMinGroupBox.ResumeLayout(false);
            this.maxAndMinGroupBox.PerformLayout();
            this.calculatorGroupBox.ResumeLayout(false);
            this.intervalAndStepGroupBox.ResumeLayout(false);
            this.intervalAndStepGroupBox.PerformLayout();
            this.tableAndPlotGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem endToolStripMenuItem;
        private ToolStripMenuItem tabFunctionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem maxValueToolStripMenuItem;
        private ToolStripMenuItem minValueToolStripMenuItem;
        private ToolStripMenuItem functionGraphToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem clearTheTableToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private DataGridView dataGridView;
        private TextBox aIntervalTextBox;
        private TextBox bIntervalTextBox;
        private Label firstBracketLabel;
        private Label semicolonLabel;
        private Label secondBracketLabel;
        private Label tabIntervalLabel;
        private Label stepLabel;
        private TextBox stepTextBox;
        private TextBox funcToTabTextBox;
        private Label label1;
        private Button sinButton;
        private Button cotButton;
        private Button cosButton;
        private Button tanButton;
        private Button addButton;
        private Button oneButton;
        private Button subButton;
        private Button mulButton;
        private Button divButton;
        private Button twoButton;
        private Button fiveButton;
        private Button threeButton;
        private Button sixButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button dotButton;
        private Button zeroButton;
        private Button xButton;
        private Button fourButton;
        private Label showLabel;
        private GroupBox resultsGroupBox;
        private CheckBox fileCheckBox;
        private CheckBox onTheScreenCheckBox;
        private Button roundBracket2Button;
        private Button roundBracket1Button;
        private Button cleanButton;
        private Button deleteButton;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem tabulateToolStripMenuItem;
        private ToolStripMenuItem clearTableToolStripMenuItem;
        private ToolStripMenuItem funcGraphToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripMenuItem calculationToolStripMenuItem;
        private ToolStripButton tabulateToolStripButton;
        private ToolStripButton functionGraphToolStripButton;
        private ToolStripButton maxValueToolStripButton;
        private ToolStripButton minValueToolStripButton;
        private ToolStripButton clearTheTableToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton aboutToolStripButton;
        private ToolStripButton exitToolStripButton;
        private Label maxLabel;
        private Label minLabel;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private GroupBox maxAndMinGroupBox;
        private GroupBox calculatorGroupBox;
        private GroupBox intervalAndStepGroupBox;
        private GroupBox tableAndPlotGroupBox;
    }
}