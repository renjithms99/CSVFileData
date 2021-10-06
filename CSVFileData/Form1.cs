using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSVFileData
{
    public partial class Form1 : Form
    {

        static List<Data> records = new List<Data>();
        int selectedRow;
        static Regex validScreenId = NumbersOnly();
        public Form1()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {

            using (var reader = new StreamReader("C:\\Users\\Josekutty\\Desktop\\WindowsFormsAppLatest1\\WindowsFormsAppLatest\\data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Data>().ToList();
            }
            dataGridView1.DataSource = records;
            BindComboBox();
        }

        private void BindComboBox()
        {
            using (var csvReader = new StreamReader("C:\\Users\\Josekutty\\Desktop\\WindowsFormsAppLatest1\\WindowsFormsAppLatest\\combo_example.csv"))
            using (var csvContent = new CsvReader(csvReader, CultureInfo.InvariantCulture))
            {
                var comboBoxItems = csvContent.GetRecords<Item>().ToList();
                cmbName.DataSource = comboBoxItems;
                cmbName.DisplayMember = "Name";
                cmbName.ValueMember = "Id";
            }
        }
        //Method for numbers validation only
        private static Regex NumbersOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]*$";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStationName.Text))
                {
                    MessageBox.Show("Station Name cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStationName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtScreen_id.Text))
                {
                    MessageBox.Show("Screen id cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStationName.Focus();
                    return;
                }
                else if (validScreenId.IsMatch(txtScreen_id.Text) != true)
                {
                    MessageBox.Show("Screen Id accept numbers only.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtScreen_id.Focus();
                    return;
                }
                else
                {
                    records.Add(new Data() { StationName = txtStationName.Text, screen_id = txtScreen_id.Text, date = dateTimePicker1.Text, depth_to_water_level = txtDepth_to_water_level.Text, comment = txtComment.Text });
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = records;
                    dataGridView1.Refresh();

                    txtStationName.Text = string.Empty;
                    txtScreen_id.Text = string.Empty;
                    txtDepth_to_water_level.Text = string.Empty;
                    txtComment.Text = string.Empty;
                    dateTimePicker1.Value = DateTime.Today;
                }
            }
            catch
            {
                MessageBox.Show("Failed Deletion");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                txtStationName.Text = row.Cells[0].Value.ToString();
                txtScreen_id.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                txtDepth_to_water_level.Text = row.Cells[3].Value.ToString();
                txtComment.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStationName.Text))
                {
                    MessageBox.Show("Station Name cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStationName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtScreen_id.Text))
                {
                    MessageBox.Show("Screen id cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStationName.Focus();
                    return;
                }
                else if (validScreenId.IsMatch(txtScreen_id.Text) != true)
                {
                    MessageBox.Show("Screen Id accept numbers only.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtScreen_id.Focus();
                    return;
                }
                else
                {
                    DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
                    newDataRow.Cells[0].Value = txtStationName.Text;
                    newDataRow.Cells[1].Value = txtScreen_id.Text;
                    newDataRow.Cells[2].Value = dateTimePicker1.Text;
                    newDataRow.Cells[3].Value = txtDepth_to_water_level.Text;
                    newDataRow.Cells[4].Value = txtComment.Text;
                }
            }
            catch
            {
                MessageBox.Show("Failed Updation");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedRow = dataGridView1.CurrentCell.RowIndex;
                records.RemoveAt(selectedRow);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = records;
                dataGridView1.Refresh();

                txtStationName.Text = string.Empty;
                txtScreen_id.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
                txtDepth_to_water_level.Text = string.Empty;
                txtComment.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Failed Deletion");
            }
        }

        private void btn_ReplaceClick(object sender, EventArgs e)
        {
            var selectedCell = dataGridView1.CurrentCell.Value?.ToString();
            var valueAfterReplace = selectedCell.Replace('a', '@');
            dataGridView1.CurrentCell.Value = valueAfterReplace;
        }
        private void btnSelectedId_Click(object sender, EventArgs e)
        {
            string message = "Name: " + cmbName.Text;
            message += Environment.NewLine;
            message += "Id: " + cmbName.SelectedValue;
            MessageBox.Show(message);
        }
        
    }
}
