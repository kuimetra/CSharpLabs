using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Windows.Forms;
using DynamicExpresso;
using System.Drawing;
using System.Linq;
using System.Data;
using System.IO;
using System;

namespace MenuTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _dataTable;
        private string _function;
        private double _min, _max;

        private (List<double>xList, List<double> yList) Tabulate()
        {
            _dataTable = string.Empty;
            var a = double.TryParse(aIntervalTextBox.Text, out var aValue);
            var b = double.TryParse(bIntervalTextBox.Text, out var bValue);
            var h = double.TryParse(stepTextBox.Text, out var stepValue);
            var xValues = new List<double>();
            var yValues = new List<double>();
            try
            {
                if (!a || !b || !h) return (null, null);

                var interpreter = new Interpreter();
                var parsedExpression = interpreter.Parse(_function, new Parameter("x", typeof(double)));
                if (stepValue > 0)
                {
                    for (var x = aValue; x <= bValue; x += stepValue)
                    {
                        xValues.Add(Math.Round(x, 4));
                        yValues.Add(Math.Round(Convert.ToDouble(parsedExpression.Invoke(x)), 4));

                        _dataTable += $"{x} - {Math.Round(Convert.ToDouble(parsedExpression.Invoke(x)), 4)}\n";
                    }

                    _max = yValues.Max();
                    _min = yValues.Min();
                }
            }
            catch (DivideByZeroException)
            {
                funcToTabTextBox.Text = "DivByZero";
            }
            catch (Exception)
            {
                funcToTabTextBox.Text = "SyntaxError";
            }

            return (xValues, yValues);
        }


        private static DataTable CreateDataTable(IReadOnlyList<double> xValues, IReadOnlyList<double> yValues)
        {
            var dt = new DataTable();
            dt.Columns.Add("x", typeof(double));
            dt.Columns.Add("y", typeof(double));
            for (var i = 0; i < xValues.Count; i++) dt.Rows.Add(xValues[i], yValues[i]);

            return dt;
        }

        private void tabFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var (l1, l2) = Tabulate();
            if (l1 == null || l2 == null) return;
            var dt = CreateDataTable(l1, l2);
            dataGridView.DataSource = dt.DefaultView;
        }

        private void functionGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var (l1, l2) = Tabulate();
            if (l1 == null || l2 == null) return;
            var dt = CreateDataTable(l1, l2);
            try
            {
                chart.DataSource = dt;
                chart.Series["Plot"].XValueMember = "x";
                chart.Series["Plot"].YValueMembers = "y";
                chart.Series["Plot"].ChartType = SeriesChartType.Line;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid point values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTheTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            _dataTable = string.Empty;
            onTheScreenCheckBox.Checked = false;
        }

        private void maxValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabulate();
            maxTextBox.Text = _max.ToString();
        }

        private void minValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabulate();
            minTextBox.Text = _min.ToString();
        }

        private void funcButton_Click(object sender, EventArgs e)
        {
            funcToTabTextBox.Text += ((Button) sender).Text switch
            {
                "cot" => "(cot(",
                _ => ((Button) sender).Text + "("
            };

            switch (((Button) sender).Text)
            {
                case "sin":
                    _function += "Math.Sin(";
                    break;
                case "cos":
                    _function += "Math.Cos(";
                    break;
                case "tan":
                    _function += "Math.Tan(";
                    break;
                case "cot":
                    _function += "(1.0 / Math.Tan(";
                    break;
            }
        }

        private void numOrSignButton_Click(object sender, EventArgs e)
        {
            funcToTabTextBox.Text += ((Button) sender).Text;
            _function += ((Button) sender).Text;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            funcToTabTextBox.Clear();
            _function = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            switch (funcToTabTextBox.Text.Length)
            {
                case > 0 when funcToTabTextBox.Text.Length >= 3:
                {
                    var textBoxLastThreeChars = funcToTabTextBox.Text[^3..];
                    funcToTabTextBox.Text = textBoxLastThreeChars == "sin" || textBoxLastThreeChars == "cos" ||
                                            textBoxLastThreeChars == "tan" || textBoxLastThreeChars == "cot"
                        ? funcToTabTextBox.Text[..^3]
                        : funcToTabTextBox.Text[..^1];
                    break;
                }
                case > 0:
                    funcToTabTextBox.Text = funcToTabTextBox.Text[..^1];
                    break;
            }

            switch (_function.Length)
            {
                case > 0 when _function.Length >= 8:
                {
                    var lastThreeChars = _function[^3..].ToLower();
                    _function = lastThreeChars == "sin" || lastThreeChars == "cos" || lastThreeChars == "tan" ||
                                lastThreeChars == "cot"
                        ? _function[..^8]
                        : _function[..^1];
                    break;
                }
                case > 0:
                    _function = _function[..^1];
                    break;
            }
        }

        private void onTheScreenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onTheScreenCheckBox.Checked)
            {
                tabFunctionToolStripMenuItem.PerformClick();
                functionGraphToolStripMenuItem.PerformClick();
            }
            else
            {
                clearTheTableToolStripMenuItem.PerformClick();
            }
        }

        private void fileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!fileCheckBox.Checked) return;
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt",
                InitialDirectory = Path.GetDirectoryName(Directory.GetCurrentDirectory())
            };
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var filename = saveFileDialog1.FileName;
            Tabulate();
            File.WriteAllText(filename, _dataTable);
            MessageBox.Show("The file has been saved successfully.", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void funcToTabTextBox_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(funcToTabTextBox, "function you want to tabulate");
        }

        private void aIntervalTextBox_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(aIntervalTextBox, "the beginning of the interval");
        }

        private void bIntervalTextBox_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(bIntervalTextBox, "the end of the interval");
        }

        private void stepTextBox_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(stepTextBox, "step value");
        }

        private void dataGridView_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(dataGridView, "place for the table");
        }

        private void chart_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(chart, "place for function graph");
        }

        private void minTextBox_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(minTextBox, "min value of the function");
        }

        private void maxTextBox_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(maxTextBox, "max value of the function");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }
    }
}