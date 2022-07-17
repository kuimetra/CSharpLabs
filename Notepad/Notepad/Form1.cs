using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            toolStripStatusLabel.Text = "New file is created";
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog
            {
                Filter = "Text files|*.txt|RTF files|*.rtf|All files|*.*",
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()))
            };
            if (f.ShowDialog() != DialogResult.OK) return;
            try
            {
                richTextBox.LoadFile(f.FileName, RichTextBoxStreamType.RichText);
            }
            catch (ArgumentException)
            {
                richTextBox.LoadFile(f.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            var f = new SaveFileDialog
            {
                Filter = "Text files|*.txt",
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()))
            };
            if (f.ShowDialog() != DialogResult.OK) return;
            richTextBox.SaveFile(f.FileName);
            toolStripStatusLabel.Text = "File saved successfully";
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            var f = new SaveFileDialog
            {
                Filter = "Text files|*.txt|RTF files|*.rtf|All files|*.*",
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()))
            };
            if (f.ShowDialog() != DialogResult.OK) return;
            richTextBox.SaveFile(f.FileName);
            toolStripStatusLabel.Text = "File saved successfully";
        }

        private StringReader m_myReader;
        private uint m_PrintPageNumber;

        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            m_PrintPageNumber = 1;

            var strText = richTextBox.Text;
            m_myReader = new StringReader(strText);
            var margins = new Margins(100, 50, 50, 50);
            printDocument.DefaultPageSettings.Margins = margins;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

            m_myReader.Close();
            toolStripStatusLabel.Text = string.Empty;
        }

        private void toolStripPreviewButton_Click(object sender, EventArgs e)
        {
            m_PrintPageNumber = 1;
            var strText = richTextBox.Text;
            m_myReader = new StringReader(strText);
            printDocument.DefaultPageSettings.Margins = new Margins(100, 50, 50, 50);
            printPreviewDialog.ShowDialog();

            // m_myReader.Close();
            toolStripStatusLabel.Text = string.Empty;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var lineCount = 0;
            string currentLine = null;
            var printFont = richTextBox.Font;
            var printBrush = new SolidBrush(Color.Black);
            float leftMargin = e.MarginBounds.Left;
            var topMargin = e.MarginBounds.Top + 3 * printFont.GetHeight(e.Graphics);
            var linesPerPage = (e.MarginBounds.Height - 6 * printFont.GetHeight(e.Graphics)) /
                               printFont.GetHeight(e.Graphics);
            while (lineCount < linesPerPage &&
                   ((currentLine = m_myReader.ReadLine()) != null))
            {
                var yLinePosition = topMargin + (lineCount *
                                                 printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(currentLine, printFont, printBrush,
                    leftMargin, yLinePosition, new StringFormat());
                lineCount++;
            }

            var sPageNumber = "Page " + m_PrintPageNumber;

            var stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(sPageNumber, printFont, e.MarginBounds.Right - e.MarginBounds.Left);

            e.Graphics.DrawString(sPageNumber, printFont, printBrush,
                e.MarginBounds.Right - stringSize.Width, e.MarginBounds.Top,
                new StringFormat());
            e.Graphics.DrawString(Text, printFont, printBrush,
                e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());
            var colontitulPen = new Pen(Color.Black) {Width = 2};
            e.Graphics.DrawLine(colontitulPen,
                leftMargin,
                e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
                e.MarginBounds.Right, e.MarginBounds.Top +
                                      printFont.GetHeight(e.Graphics) + 3);
            e.Graphics.DrawLine(colontitulPen,
                leftMargin, e.MarginBounds.Bottom - 3,
                e.MarginBounds.Right, e.MarginBounds.Bottom - 3);
            if (currentLine != null)
            {
                e.HasMorePages = true;
                m_PrintPageNumber++;
            }
            else
                e.HasMorePages = false;

            printBrush.Dispose();
            colontitulPen.Dispose();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
            toolStripStatusLabel.Text = string.Empty;
        }

        private void menuEditUndo_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
            toolStripStatusLabel.Text = "Undo";
        }

        private void menuEditRedo_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
            toolStripStatusLabel.Text = "Redo";
        }

        private void menuEditCut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
            toolStripStatusLabel.Text = "Cut";
        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
            toolStripStatusLabel.Text = "Text was successfully copied";
        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
            toolStripStatusLabel.Text = "Paste";
        }

        private void menuEditDelete_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
            toolStripStatusLabel.Text = "Delete";
        }

        private void menuEditSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            toolStripStatusLabel.Text = "Select All";
        }

        private void menuFormatFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }

            toolStripStatusLabel.Text = "Text font changed";
        }

        private void menuFormatColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }

            toolStripStatusLabel.Text = "Text color changed";
        }

        private void CheckMenuFontCharacterStyle()
        {
            menuFormatCharacterStyleBold.Checked = richTextBox.SelectionFont.Bold;
            menuFormatCharacterStyleItalic.Checked = richTextBox.SelectionFont.Italic;
            menuFormatCharacterStyleUnderline.Checked = richTextBox.SelectionFont.Underline;
            menuFormatCharacterStyleStrikeout.Checked = richTextBox.SelectionFont.Strikeout;
        }

        private void menuFormatCharacterStyleBold_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return;
            var currentFont = richTextBox.SelectionFont;
            CheckMenuFontCharacterStyle();
            var newFontStyle = richTextBox.SelectionFont.Bold ? FontStyle.Regular : FontStyle.Bold;
            richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            CheckMenuFontCharacterStyle();
            toolStripStatusLabel.Text = "Character style changed";
        }

        private void menuFormatCharacterStyleItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return;
            var currentFont = richTextBox.SelectionFont;
            CheckMenuFontCharacterStyle();
            var newFontStyle = richTextBox.SelectionFont.Italic ? FontStyle.Regular : FontStyle.Italic;
            richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            CheckMenuFontCharacterStyle();
            toolStripStatusLabel.Text = "Character style changed";
        }

        private void menuFormatCharacterStyleUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return;
            var currentFont = richTextBox.SelectionFont;
            CheckMenuFontCharacterStyle();
            var newFontStyle = richTextBox.SelectionFont.Underline ? FontStyle.Regular : FontStyle.Underline;
            richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            CheckMenuFontCharacterStyle();
            toolStripStatusLabel.Text = "Character style changed";
        }

        private void menuFormatCharacterStyleStrikeout_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return;
            var currentFont = richTextBox.SelectionFont;
            CheckMenuFontCharacterStyle();
            var newFontStyle = richTextBox.SelectionFont.Strikeout ? FontStyle.Regular : FontStyle.Strikeout;
            richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            CheckMenuFontCharacterStyle();
            toolStripStatusLabel.Text = "Character style changed";
        }

        private void menuFormatParagraphAlignmentLeft_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            toolStripStatusLabel.Text = "The text is aligned to the left";
        }

        private void menuFormatParagraphAlignmentCenter_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            toolStripStatusLabel.Text = "The text is centered";
        }

        private void menuFormatParagraphAlignmentRight_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            toolStripStatusLabel.Text = "The text is aligned to the right";
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            Form aboutDialog = new AboutForm();
            aboutDialog.ShowDialog();
            toolStripStatusLabel.Text = string.Empty;
        }
    }
}