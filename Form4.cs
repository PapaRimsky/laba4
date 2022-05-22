using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace laba4
{
    public partial class Form4 : Form
    {
        Form3 f3;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form3 f3)
        {
            this.f3 = f3;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = f3.dataGridView1.Rows.Count;
            if (i == 0)
            {
                int d = 1;
                f3.dataGridView1.Rows.Add(d, textBox1.Text, dateTimePicker1.Text, comboBox1.Text, comboBox2.Text);
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string name = textBox1.Text;
                string birth = dateTimePicker1.Text;
                string workplace = comboBox1.Text;
                string sd = comboBox2.Text;
                string query = "INSERT INTO Authors VALUES (" + d + ", '" + name + "', '" + birth + "', '" + workplace + "', '" + sd + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            else
            {
                int d = Convert.ToInt32(f3.dataGridView1.Rows[i - 1].Cells[0].Value);
                f3.dataGridView1.Rows.Add(d + 1, textBox1.Text, dateTimePicker1.Text, comboBox1.Text, comboBox2.Text);
                int d1 = d + 1;
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string name = textBox1.Text;
                string birth = dateTimePicker1.Text;
                string workplace = comboBox1.Text;
                string sd = comboBox2.Text;
                string query = "INSERT INTO Authors VALUES (" + d1 + ", '" + name + "', '" + birth + "', '" + workplace + "', '" + sd + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            int i = f3.dataGridView1.SelectedCells[0].RowIndex;
            string id = f3.dataGridView1.Rows[i].Cells[0].Value.ToString();
            string name = textBox1.Text;
            string birth = dateTimePicker1.Text;
            string wk = comboBox1.Text;
            string sd = comboBox2.Text;
            f3.dataGridView1.CurrentRow.Cells[0].Value = i + 1;
            f3.dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
            f3.dataGridView1.CurrentRow.Cells[2].Value = dateTimePicker1.Text;
            f3.dataGridView1.CurrentRow.Cells[3].Value = comboBox1.Text;
            f3.dataGridView1.CurrentRow.Cells[4].Value = comboBox2.Text;
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "UPDATE Authors SET [Names] = '" + name + "',[Birthday] = '" + birth + "',[Workplace] = '" + wk + "',[ScienceDegree] = '" + sd + "' WHERE [id] = " + id;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form3.Per.k == 1)
            {
                textBox1.Text = f3.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = f3.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = f3.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox2.Text = f3.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Form3.Per.k = 0;
            }
        }
    }
}
