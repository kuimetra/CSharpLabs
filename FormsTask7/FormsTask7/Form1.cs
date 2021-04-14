// Створити форму “Анкета студента” з даними про себе та двома фотографіями (портретною і художньою), які перекривають 
// одна одну. Програма має працювати за наступним сценарієм: відразу після запуску програми фотографій не видно, є дві 
// кнопки “Портретна фотографія” і “Забрати фотографію”, доступною є лише перша кнопка; після клацання на кнопці “Портретна
// фотографія” у формі з’являється портретне фото, підпис на першій кнопці змінюється на “Художня фотографія”, стає 
// доступною кнопка “Забрати фотографію”; після клацання на кнопці “ Художня фотографія” фотографія у формі змінюється на 
// художню, а підпис на цій кнопці змінюється на “Портретна фотографія”; після клацання на кнопці “Забрати фотографію” 
// фотографія зникає і ця кнопка стає недоступною.

using Image = System.Drawing.Image;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing;
using System.IO;
using System;

namespace FormsTask7
{
    public partial class Form1 : Form
    {
        private string _imageFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisableRemovePhotoButton()
        {
            removePhotoButton.BackColor = Color.Transparent;
            removePhotoButton.ForeColor = Color.Thistle;
            removePhotoButton.Enabled = false;
        }

        private void EnableRemovePhotoButton()
        {
            removePhotoButton.BackColor = Color.Lavender;
            removePhotoButton.ForeColor = ColorTranslator.FromHtml("#212121");
            removePhotoButton.Enabled = true;
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog
            {
                Filter = "JPG (*.JPG)|*.jpg",
                InitialDirectory = (photoButton.Text == "Portrait photo")
                    ? Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "portrait photos")
                    : Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "art photos")
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                _imageFileName = f.FileName;
                pictureBox.Image = Image.FromFile(_imageFileName);
                switch (photoButton.Text)
                {
                    case "Portrait photo":
                        photoButton.Text = "Fine-art photo";
                        EnableRemovePhotoButton();
                        break;
                    case "Fine-art photo":
                        photoButton.Text = "Portrait photo";
                        EnableRemovePhotoButton();
                        break;
                }
            }
        }

        private void removePhotoButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            DisableRemovePhotoButton();
            _imageFileName = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != string.Empty && lastNameTextBox.Text != string.Empty &&
                universityTextBox.Text != string.Empty && facultyTextBox.Text != string.Empty &&
                specialtyTextBox.Text != string.Empty && groupTextBox.Text != string.Empty)
            {
                iTextSharp.text.Image img = null;
                var isImageSelected = true;
                try
                {
                    img = iTextSharp.text.Image.GetInstance(_imageFileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Select photo please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isImageSelected = false;
                }

                if (!isImageSelected) return;
                var document = new Document();
                PdfWriter.GetInstance(document,
                    new FileStream(Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()),
                        "surveys", $"{firstNameTextBox.Text}{lastNameTextBox.Text}.pdf"), FileMode.Create));
                document.Open();
                var paragraph = new Paragraph($"{firstNameTextBox.Text} {lastNameTextBox.Text}\n" +
                                              $"{dateOfBirthLabel.Text}: {dateOfBirthPicker.Value:dd/MM/yyyy}\n" +
                                              $"{universityLabel.Text}: {universityTextBox.Text}\n" +
                                              $"{facultyLabel.Text}: {facultyTextBox.Text}\n" +
                                              $"{specialtyLabel.Text}: {specialtyTextBox.Text}\n" +
                                              $"{groupLabel.Text}: {groupTextBox.Text}");
                img.ScaleToFit(350f, 350f);
                img.Alignment = Element.ALIGN_MIDDLE;
                paragraph.Alignment = Element.ALIGN_CENTER;
                document.Add(img);
                document.Add(paragraph);
                document.Close();
                MessageBox.Show("The survey has been saved successfully.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}