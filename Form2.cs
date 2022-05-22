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
    public partial class Form2 : Form
    {

        Form1 f1;
        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = f1.dataGridView1.Rows.Count;
            if (i == 0)
            {
                int d = 1;
                f1.dataGridView1.Rows.Add(d, textBox1.Text, textBox2.Text, comboBox2.Text, dateTimePicker1.Text, comboBox1.Text, textBox5.Text);
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string title = textBox1.Text;
                string pages = textBox2.Text;
                string udk = comboBox2.Text;
                string dates = dateTimePicker1.Text;
                string pubhouse = comboBox1.Text;
                string doi = textBox5.Text;
                string query = "INSERT INTO Works VALUES (" + d + ", '" + title + "', '" + pages + "', '" + udk + "', '" + dates + "', '" + pubhouse + "', '" + doi + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            else
            {
                int d = Convert.ToInt32(f1.dataGridView1.Rows[i - 1].Cells[0].Value);
                f1.dataGridView1.Rows.Add(d + 1, textBox1.Text, textBox2.Text, comboBox2.Text, dateTimePicker1.Text, comboBox1.Text, textBox5.Text);
                int d1 = d + 1;
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string title = textBox1.Text;
                string pages = textBox2.Text;
                string udk = comboBox2.Text;
                string dates = dateTimePicker1.Text;
                string pubhouse = comboBox1.Text;
                string doi = textBox5.Text;
                string query = "INSERT INTO Works VALUES (" + d1 + ", '" + title + "', '" + pages + "', '" + udk + "', '" + dates + "', '" + pubhouse + "', '" + doi + "')";
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
        private void button3_Click(object sender, EventArgs e)
        {
            int i = f1.dataGridView1.SelectedCells[0].RowIndex;
            string id = f1.dataGridView1.Rows[i].Cells[0].Value.ToString();
            string title = textBox1.Text;
            string pages = textBox2.Text;
            string udk = comboBox2.Text;
            string dates = dateTimePicker1.Text;
            string pubhouse = comboBox1.Text;
            string doi = textBox5.Text;
            f1.dataGridView1.CurrentRow.Cells[0].Value=i + 1;
            f1.dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
            f1.dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
            f1.dataGridView1.CurrentRow.Cells[3].Value = comboBox2.Text;
            f1.dataGridView1.CurrentRow.Cells[4].Value = dateTimePicker1.Text;
            f1.dataGridView1.CurrentRow.Cells[5].Value = comboBox1.Text;
            f1.dataGridView1.CurrentRow.Cells[6].Value = textBox5.Text;
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "UPDATE Works SET [Title] = '" + title + "',[Pages] = '" + pages + "',[UDK] = '" + udk + "',[Dates] = '" + dates + "',[PubHouse] = '" + pubhouse + "',[DOI] = '" + doi + "' WHERE [id] = " + id;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text=null;
            textBox2.Text = null;
            comboBox2.Text = null;
            dateTimePicker1.Text = null;
            comboBox1.Text = null;
            textBox5.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.Per.k == 1)
            {
                textBox1.Text = f1.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = f1.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.Text = f1.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = f1.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox1.Text = f1.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox5.Text = f1.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Form1.Per.k = 0;
            }
        }
    }
}
