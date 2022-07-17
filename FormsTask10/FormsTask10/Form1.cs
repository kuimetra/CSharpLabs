using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.IO;
using System;

namespace FormsTask10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private readonly List<TelephoneBook> _telephoneSubscribers = new();

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()))
            };
            if (f.ShowDialog() != DialogResult.OK) return;
            _telephoneSubscribers.Clear();
            var fileLines = File.ReadAllLines(f.FileName);

            foreach (var line in fileLines)
            {
                var field = line.Split(',');
                _telephoneSubscribers.Add(new TelephoneBook(field[0], field[1], field[2], field[3]));
            }

            BindToADataGridView(_telephoneSubscribers);
            firstRowButton.Visible = true;
            goUpButton.Visible = true;
            goDownButton.Visible = true;
            lastRowButton.Visible = true;

            saveToolStripButton.Enabled = true;
            addToolStripButton.Enabled = true;
            removeToolStripButton.Enabled = true;
            editToolStripButton.Enabled = true;
            searchToolStripDropDownButton.Enabled = true;
            sortToolStripDropDownButton.Enabled = true;
            clearTableToolStripButton.Enabled = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (_telephoneSubscribers.Count <= 0) return;
            var f = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()))
            };
            if (f.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(f.FileName, string.Empty);
            using var sw = File.AppendText(f.FileName);
            foreach (var telephoneSubscriber in _telephoneSubscribers)
                sw.WriteLine(telephoneSubscriber.Surname + "," + telephoneSubscriber.Name + "," +
                             telephoneSubscriber.PhoneNumber + "," + telephoneSubscriber.Address);
        }

        private static DataTable GetDataTable(IEnumerable<TelephoneBook> telephoneSubscribers)
        {
            var dt = new DataTable();
            dt.Columns.Add("Surname", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Phone number", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            foreach (var telephoneSubscriber in telephoneSubscribers)
                dt.Rows.Add(telephoneSubscriber.Surname, telephoneSubscriber.Name,
                    telephoneSubscriber.PhoneNumber, telephoneSubscriber.Address);

            return dt;
        }

        private void BindToADataGridView(IEnumerable<TelephoneBook> telephoneSubscribers)
        {
            dataGridView.DataSource = GetDataTable(telephoneSubscribers).DefaultView;
            foreach (DataGridViewRow row in dataGridView.Rows) row.HeaderCell.Value = $"{row.Index + 1}";
            firstRowButton.PerformClick();
        }

        private void InfoUpdate()
        {
            _telephoneSubscribers.Clear();
            if (dataGridView.Rows.Count == 0) return;
            foreach (DataGridViewRow row in dataGridView.Rows)
                _telephoneSubscribers.Add(new TelephoneBook(row.Cells["Surname"].Value.ToString(),
                    row.Cells["Name"].Value.ToString(), row.Cells["Phone number"].Value.ToString(),
                    row.Cells["Address"].Value.ToString()));

            BindToADataGridView(_telephoneSubscribers);
        }

        private void AddRow()
        {
            if (dataGridView.Rows.Count == 0) return;
            var lastRowIndex = dataGridView.Rows.Count - 1;
            _telephoneSubscribers.Add(new TelephoneBook(dataGridView.Rows[lastRowIndex].Cells[0].Value.ToString(),
                dataGridView.Rows[lastRowIndex].Cells[1].Value.ToString(),
                dataGridView.Rows[lastRowIndex].Cells[2].Value.ToString(),
                dataGridView.Rows[lastRowIndex].Cells[3].Value.ToString()));

            BindToADataGridView(_telephoneSubscribers);
        }

        private void RemoveRow(int indexToRemove)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.RemoveAt(indexToRemove);

            BindToADataGridView(_telephoneSubscribers);
        }

        private void RowSelection(int rowIndex)
        {
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = dataGridView.Rows[rowIndex].Cells[dataGridView.CurrentCell.ColumnIndex];
            dataGridView.Rows[rowIndex].Selected = true;
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
            dataGridView.Enabled = true;
            var dt = GetDataTable(_telephoneSubscribers);
            dataGridView.AllowUserToAddRows = true;
            dt.Rows.Add();
            dataGridView.DataSource = dt;
            foreach (DataGridViewRow row in dataGridView.Rows) row.HeaderCell.Value = $"{row.Index + 1}";

            RowSelection(dataGridView.Rows.Count - 2);

            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = false;

            addButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddRow();
            dataGridView.ReadOnly = true;
            addButton.Visible = false;
            cancelButton.Visible = false;
            dataGridView.Enabled = false;
        }

        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            cancelButton.PerformClick();
            rowIndexLabel.Visible = true;
            indexToRemoveTextBox.Visible = true;
            removeButton.Visible = true;
            cancelButton.Visible = true;
            indexToRemoveTextBox.Focus();
        }

        private void indexToRemoveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            removeButton.PerformClick();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var dt = GetDataTable(_telephoneSubscribers);
            dataGridView.AllowUserToDeleteRows = true;
            var success = int.TryParse(indexToRemoveTextBox.Text, out var ind);
            try
            {
                if (success)
                {
                    dt.Rows.RemoveAt(ind - 1);
                    RemoveRow(ind - 1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"There is no row at position {ind}.", "Index out of range", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            dataGridView.DataSource = dt;
            foreach (DataGridViewRow row in dataGridView.Rows) row.HeaderCell.Value = $"{row.Index + 1}";

            dataGridView.AllowUserToDeleteRows = false;
            rowIndexLabel.Visible = false;
            indexToRemoveTextBox.Text = string.Empty;
            indexToRemoveTextBox.Visible = false;
            removeButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            cancelButton.PerformClick();
            dataGridView.Enabled = true;
            dataGridView.ReadOnly = false;
            saveChangesButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            InfoUpdate();
            dataGridView.ReadOnly = true;
            saveChangesButton.Visible = false;
            cancelButton.Visible = false;
            dataGridView.Enabled = false;
        }

        private void searchToolStripDropDownButton_Click(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
            searchToolStripTextBox.Focus();
        }

        private void searchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            var _searchValue = searchToolStripTextBox.Text;
            var rowIndex = (from DataGridViewRow row in dataGridView.Rows
                where row.Cells[0].Value.ToString().ToLower().StartsWith(_searchValue.ToLower()) ||
                      row.Cells[1].Value.ToString().ToLower().StartsWith(_searchValue.ToLower()) ||
                      row.Cells[2].Value.ToString().ToLower().StartsWith(_searchValue.ToLower()) ||
                      row.Cells[3].Value.ToString().ToLower().StartsWith(_searchValue.ToLower())
                select row.Index).FirstOrDefault();

            RowSelection(rowIndex);
        }

        private void searchToolStripDropDownButton_DropDownClosed(object sender, EventArgs e)
        {
            searchToolStripTextBox.Text = string.Empty;
        }

        private void sortToolStripDropDownButton_Click(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
        }

        private void bySurnameAscOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => x.Surname.CompareTo(y.Surname));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void bySurnameDescOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => y.Surname.CompareTo(x.Surname));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void byNameAscOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => x.Name.CompareTo(y.Name));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void byNameDescOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => y.Name.CompareTo(x.Name));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void byPhoneAscOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => x.PhoneNumber.CompareTo(y.PhoneNumber));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void byPhoneDescOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => y.PhoneNumber.CompareTo(x.PhoneNumber));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void byAddressAscOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => x.Address.CompareTo(y.Address));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void byAddressDescOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            _telephoneSubscribers.Sort((x, y) => y.Address.CompareTo(x.Address));
            BindToADataGridView(_telephoneSubscribers);
        }

        private void firstRowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            RowSelection(0);
        }

        private void goUpButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            var currentIndex = dataGridView.CurrentRow.Index;
            if (currentIndex - 1 < 0)
            {
                RowSelection(dataGridView.Rows.Count - 1);
            }
            else
            {
                RowSelection(currentIndex - 1);
            }
        }

        private void goDownButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            var currentIndex = dataGridView.CurrentRow.Index;
            if (currentIndex + 1 > dataGridView.Rows.Count - 1)
            {
                RowSelection(0);
            }
            else
            {
                RowSelection(currentIndex + 1);
            }
        }

        private void lastRowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            RowSelection(dataGridView.Rows.Count - 1);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            BindToADataGridView(_telephoneSubscribers);
            dataGridView.ReadOnly = true;
            saveChangesButton.Visible = false;
            rowIndexLabel.Visible = false;
            indexToRemoveTextBox.Text = string.Empty;
            indexToRemoveTextBox.Visible = false;
            removeButton.Visible = false;
            addButton.Visible = false;
            cancelButton.Visible = false;
            dataGridView.Enabled = false;
        }

        private void clearTable_Click(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
            dataGridView.DataSource = null;
            _telephoneSubscribers.Clear();
            firstRowButton.Visible = false;
            goUpButton.Visible = false;
            goDownButton.Visible = false;
            lastRowButton.Visible = false;

            saveToolStripButton.Enabled = false;
            addToolStripButton.Enabled = false;
            removeToolStripButton.Enabled = false;
            editToolStripButton.Enabled = false;
            searchToolStripDropDownButton.Enabled = false;
            sortToolStripDropDownButton.Enabled = false;
            clearTableToolStripButton.Enabled = false;
        }

        private void dataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }

    public class TelephoneBook
    {
        public readonly string Surname;
        public readonly string Name;
        public readonly string PhoneNumber;
        public readonly string Address;

        public TelephoneBook()
        {
            Surname = "unknown";
            Name = "unknown";
            PhoneNumber = "unknown";
            Address = "unknown";
        }

        public TelephoneBook(string surname, string name, string phoneNumber, string address)
        {
            Surname = surname;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}