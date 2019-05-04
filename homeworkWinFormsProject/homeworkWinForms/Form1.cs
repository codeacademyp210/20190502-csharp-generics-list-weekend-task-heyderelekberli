using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeworkWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Surname";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Position";
            dataGridView1.Columns[4].Name = "Salary";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
        }
        private void add(string name, string surname, string email, string position, double salary)
        {
            dataGridView1.Rows.Add(name, surname, email, position, salary);
            clearText();
        }
        private void clearText()
        {
            NameText.Text = "";
            SurnameText.Text = "";
            EmailText.Text = "";
            PositionText.Text = "";
            SalaryText.Text = "";
        }
       private void UpdateRow()
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = NameText.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = SurnameText.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = EmailText.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = PositionText.Text;
            dataGridView1.SelectedRows[0].Cells[4].Value = SalaryText.Text;

            clearText();
        }
        private void Delete()
        {
            int index = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(index);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            add(NameText.Text, SurnameText.Text, EmailText.Text, PositionText.Text, Convert.ToDouble(SalaryText.Text));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NameText.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SurnameText.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            EmailText.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PositionText.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            SalaryText.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }
    }
}
