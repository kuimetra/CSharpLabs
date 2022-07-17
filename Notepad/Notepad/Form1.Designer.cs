namespace Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFormatCharacterStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatCharacterStyleBold = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatCharacterStyleItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatCharacterStyleUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatCharacterStyleStrikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatParagraphAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatParagraphAlignmentLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatParagraphAlignmentCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatParagraphAlignmentRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripUndoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPreviewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrintButton = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuFormat,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(782, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.menuFilePrint,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.menuFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(60, 29);
            this.menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFileNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(320, 30);
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFileOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(320, 30);
            this.menuFileOpen.Text = "Open...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFileSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(320, 30);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFileSaveAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(320, 30);
            this.menuFileSaveAs.Text = "Save as...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(317, 6);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFilePrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuFilePrint.Size = new System.Drawing.Size(320, 30);
            this.menuFilePrint.Text = "Print...";
            this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(317, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFileExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuFileExit.Size = new System.Drawing.Size(320, 30);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.menuEditRedo,
            this.toolStripSeparator3,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditDelete,
            this.toolStripSeparator4,
            this.menuEditSelectAll});
            this.menuEdit.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.menuEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(64, 29);
            this.menuEdit.Text = "Edit";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEditUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.Size = new System.Drawing.Size(185, 30);
            this.menuEditUndo.Text = "Undo";
            this.menuEditUndo.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEditRedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.Size = new System.Drawing.Size(185, 30);
            this.menuEditRedo.Text = "Redo";
            this.menuEditRedo.Click += new System.EventHandler(this.menuEditRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEditCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Size = new System.Drawing.Size(185, 30);
            this.menuEditCut.Text = "Cut";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEditCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(185, 30);
            this.menuEditCopy.Text = "Copy";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEditPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.Size = new System.Drawing.Size(185, 30);
            this.menuEditPaste.Text = "Paste";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuEditDelete
            // 
            this.menuEditDelete.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEditDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuEditDelete.Name = "menuEditDelete";
            this.menuEditDelete.Size = new System.Drawing.Size(185, 30);
            this.menuEditDelete.Text = "Delete";
            this.menuEditDelete.Click += new System.EventHandler(this.menuEditDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuEditSelectAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.Size = new System.Drawing.Size(185, 30);
            this.menuEditSelectAll.Text = "Select All";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatFont,
            this.menuFormatColor,
            this.toolStripSeparator5,
            this.menuFormatCharacterStyle,
            this.menuFormatParagraphAlignment});
            this.menuFormat.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.menuFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(97, 29);
            this.menuFormat.Text = "Format";
            // 
            // menuFormatFont
            // 
            this.menuFormatFont.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFormatFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatFont.Name = "menuFormatFont";
            this.menuFormatFont.Size = new System.Drawing.Size(307, 30);
            this.menuFormatFont.Text = "Font...";
            this.menuFormatFont.Click += new System.EventHandler(this.menuFormatFont_Click);
            // 
            // menuFormatColor
            // 
            this.menuFormatColor.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFormatColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatColor.Name = "menuFormatColor";
            this.menuFormatColor.Size = new System.Drawing.Size(307, 30);
            this.menuFormatColor.Text = "Color...";
            this.menuFormatColor.Click += new System.EventHandler(this.menuFormatColor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(304, 6);
            // 
            // menuFormatCharacterStyle
            // 
            this.menuFormatCharacterStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatCharacterStyleBold,
            this.menuFormatCharacterStyleItalic,
            this.menuFormatCharacterStyleUnderline,
            this.menuFormatCharacterStyleStrikeout});
            this.menuFormatCharacterStyle.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFormatCharacterStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatCharacterStyle.Name = "menuFormatCharacterStyle";
            this.menuFormatCharacterStyle.Size = new System.Drawing.Size(307, 30);
            this.menuFormatCharacterStyle.Text = "Characters Style";
            // 
            // menuFormatCharacterStyleBold
            // 
            this.menuFormatCharacterStyleBold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatCharacterStyleBold.Name = "menuFormatCharacterStyleBold";
            this.menuFormatCharacterStyleBold.Size = new System.Drawing.Size(189, 30);
            this.menuFormatCharacterStyleBold.Text = "Bold";
            this.menuFormatCharacterStyleBold.Click += new System.EventHandler(this.menuFormatCharacterStyleBold_Click);
            // 
            // menuFormatCharacterStyleItalic
            // 
            this.menuFormatCharacterStyleItalic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatCharacterStyleItalic.Name = "menuFormatCharacterStyleItalic";
            this.menuFormatCharacterStyleItalic.Size = new System.Drawing.Size(189, 30);
            this.menuFormatCharacterStyleItalic.Text = "Italic";
            this.menuFormatCharacterStyleItalic.Click += new System.EventHandler(this.menuFormatCharacterStyleItalic_Click);
            // 
            // menuFormatCharacterStyleUnderline
            // 
            this.menuFormatCharacterStyleUnderline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatCharacterStyleUnderline.Name = "menuFormatCharacterStyleUnderline";
            this.menuFormatCharacterStyleUnderline.Size = new System.Drawing.Size(189, 30);
            this.menuFormatCharacterStyleUnderline.Text = "Underline";
            this.menuFormatCharacterStyleUnderline.Click += new System.EventHandler(this.menuFormatCharacterStyleUnderline_Click);
            // 
            // menuFormatCharacterStyleStrikeout
            // 
            this.menuFormatCharacterStyleStrikeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatCharacterStyleStrikeout.Name = "menuFormatCharacterStyleStrikeout";
            this.menuFormatCharacterStyleStrikeout.Size = new System.Drawing.Size(189, 30);
            this.menuFormatCharacterStyleStrikeout.Text = "Strikeout";
            this.menuFormatCharacterStyleStrikeout.Click += new System.EventHandler(this.menuFormatCharacterStyleStrikeout_Click);
            // 
            // menuFormatParagraphAlignment
            // 
            this.menuFormatParagraphAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatParagraphAlignmentLeft,
            this.menuFormatParagraphAlignmentCenter,
            this.menuFormatParagraphAlignmentRight});
            this.menuFormatParagraphAlignment.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFormatParagraphAlignment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatParagraphAlignment.Name = "menuFormatParagraphAlignment";
            this.menuFormatParagraphAlignment.Size = new System.Drawing.Size(307, 30);
            this.menuFormatParagraphAlignment.Text = "Paragraph Alignment";
            // 
            // menuFormatParagraphAlignmentLeft
            // 
            this.menuFormatParagraphAlignmentLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatParagraphAlignmentLeft.Name = "menuFormatParagraphAlignmentLeft";
            this.menuFormatParagraphAlignmentLeft.Size = new System.Drawing.Size(165, 30);
            this.menuFormatParagraphAlignmentLeft.Text = "Left";
            this.menuFormatParagraphAlignmentLeft.Click += new System.EventHandler(this.menuFormatParagraphAlignmentLeft_Click);
            // 
            // menuFormatParagraphAlignmentCenter
            // 
            this.menuFormatParagraphAlignmentCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatParagraphAlignmentCenter.Name = "menuFormatParagraphAlignmentCenter";
            this.menuFormatParagraphAlignmentCenter.Size = new System.Drawing.Size(165, 30);
            this.menuFormatParagraphAlignmentCenter.Text = "Center";
            this.menuFormatParagraphAlignmentCenter.Click += new System.EventHandler(this.menuFormatParagraphAlignmentCenter_Click);
            // 
            // menuFormatParagraphAlignmentRight
            // 
            this.menuFormatParagraphAlignmentRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuFormatParagraphAlignmentRight.Name = "menuFormatParagraphAlignmentRight";
            this.menuFormatParagraphAlignmentRight.Size = new System.Drawing.Size(165, 30);
            this.menuFormatParagraphAlignmentRight.Text = "Right";
            this.menuFormatParagraphAlignmentRight.Click += new System.EventHandler(this.menuFormatParagraphAlignmentRight_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Font = new System.Drawing.Font("GT Walsheim Pro Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.menuHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(71, 29);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuHelpAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuHelpAbout.Size = new System.Drawing.Size(223, 30);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUndoButton,
            this.toolStripRedoButton,
            this.toolStripSeparator6,
            this.toolStripNewButton,
            this.toolStripOpenButton,
            this.toolStripSaveButton,
            this.toolStripSeparator7,
            this.toolStripCutButton,
            this.toolStripCopyButton,
            this.toolStripPasteButton,
            this.toolStripSeparator8,
            this.toolStripPreviewButton,
            this.toolStripPrintButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(15, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(782, 31);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripUndoButton
            // 
            this.toolStripUndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndoButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripUndoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripUndoButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndoButton.Image")));
            this.toolStripUndoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndoButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.toolStripUndoButton.Name = "toolStripUndoButton";
            this.toolStripUndoButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripUndoButton.Text = "Undo";
            this.toolStripUndoButton.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // toolStripRedoButton
            // 
            this.toolStripRedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedoButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripRedoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripRedoButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedoButton.Image")));
            this.toolStripRedoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedoButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 1);
            this.toolStripRedoButton.Name = "toolStripRedoButton";
            this.toolStripRedoButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripRedoButton.Text = "Redo";
            this.toolStripRedoButton.Click += new System.EventHandler(this.menuEditRedo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 1, 2, 1);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripNewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewButton.Image")));
            this.toolStripNewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // toolStripOpenButton
            // 
            this.toolStripOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripOpenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenButton.Image")));
            this.toolStripOpenButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.toolStripOpenButton.Name = "toolStripOpenButton";
            this.toolStripOpenButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripOpenButton.Text = "Open";
            this.toolStripOpenButton.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripSaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 1);
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripSaveButton.Text = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(0, 1, 2, 1);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripCutButton
            // 
            this.toolStripCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCutButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripCutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripCutButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCutButton.Image")));
            this.toolStripCutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCutButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.toolStripCutButton.Name = "toolStripCutButton";
            this.toolStripCutButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripCutButton.Text = "Cut";
            this.toolStripCutButton.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // toolStripCopyButton
            // 
            this.toolStripCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopyButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopyButton.Image")));
            this.toolStripCopyButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopyButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.toolStripCopyButton.Name = "toolStripCopyButton";
            this.toolStripCopyButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripCopyButton.Text = "Copy";
            this.toolStripCopyButton.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // toolStripPasteButton
            // 
            this.toolStripPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPasteButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripPasteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPasteButton.Image")));
            this.toolStripPasteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPasteButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 1);
            this.toolStripPasteButton.Name = "toolStripPasteButton";
            this.toolStripPasteButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripPasteButton.Text = "Paste";
            this.toolStripPasteButton.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(0, 1, 2, 1);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripPreviewButton
            // 
            this.toolStripPreviewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPreviewButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripPreviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripPreviewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPreviewButton.Image")));
            this.toolStripPreviewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPreviewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPreviewButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.toolStripPreviewButton.Name = "toolStripPreviewButton";
            this.toolStripPreviewButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripPreviewButton.Text = "Preview";
            this.toolStripPreviewButton.Click += new System.EventHandler(this.toolStripPreviewButton_Click);
            // 
            // toolStripPrintButton
            // 
            this.toolStripPrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrintButton.Font = new System.Drawing.Font("GT Walsheim Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripPrintButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.toolStripPrintButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrintButton.Image")));
            this.toolStripPrintButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrintButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripPrintButton.Name = "toolStripPrintButton";
            this.toolStripPrintButton.Size = new System.Drawing.Size(29, 29);
            this.toolStripPrintButton.Text = "Print";
            this.toolStripPrintButton.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("GT Walsheim Pro", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.richTextBox.Location = new System.Drawing.Point(0, 64);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(782, 467);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuCut,
            this.contextMenuCopy,
            this.contextMenuPaste,
            this.contextMenuDelete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(135, 108);
            // 
            // contextMenuCut
            // 
            this.contextMenuCut.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.contextMenuCut.Name = "contextMenuCut";
            this.contextMenuCut.Size = new System.Drawing.Size(134, 26);
            this.contextMenuCut.Text = "Cut";
            this.contextMenuCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // contextMenuCopy
            // 
            this.contextMenuCopy.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.contextMenuCopy.Name = "contextMenuCopy";
            this.contextMenuCopy.Size = new System.Drawing.Size(134, 26);
            this.contextMenuCopy.Text = "Copy";
            this.contextMenuCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // contextMenuPaste
            // 
            this.contextMenuPaste.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.contextMenuPaste.Name = "contextMenuPaste";
            this.contextMenuPaste.Size = new System.Drawing.Size(134, 26);
            this.contextMenuPaste.Text = "Paste";
            this.contextMenuPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.contextMenuDelete.Name = "contextMenuDelete";
            this.contextMenuDelete.Size = new System.Drawing.Size(134, 26);
            this.contextMenuDelete.Text = "Delete";
            this.contextMenuDelete.Click += new System.EventHandler(this.menuEditDelete_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.statusStrip.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 531);
            this.statusStrip.Margin = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(782, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("GT Walsheim Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem menuEditRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuFormatFont;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem menuFormatColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuFormatCharacterStyle;
        private System.Windows.Forms.ToolStripMenuItem menuFormatParagraphAlignment;
        private System.Windows.Forms.ToolStripMenuItem menuFormatCharacterStyleBold;
        private System.Windows.Forms.ToolStripMenuItem menuFormatCharacterStyleItalic;
        private System.Windows.Forms.ToolStripMenuItem menuFormatCharacterStyleUnderline;
        private System.Windows.Forms.ToolStripMenuItem menuFormatCharacterStyleStrikeout;
        private System.Windows.Forms.ToolStripMenuItem menuFormatParagraphAlignmentLeft;
        private System.Windows.Forms.ToolStripMenuItem menuFormatParagraphAlignmentCenter;
        private System.Windows.Forms.ToolStripMenuItem menuFormatParagraphAlignmentRight;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ToolStripButton toolStripOpenButton;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripCutButton;
        private System.Windows.Forms.ToolStripButton toolStripCopyButton;
        private System.Windows.Forms.ToolStripButton toolStripPasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripPreviewButton;
        private System.Windows.Forms.ToolStripButton toolStripPrintButton;
        private System.Windows.Forms.ToolStripButton toolStripUndoButton;
        private System.Windows.Forms.ToolStripButton toolStripRedoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCut;
        private System.Windows.Forms.ToolStripMenuItem contextMenuPaste;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCopy;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}