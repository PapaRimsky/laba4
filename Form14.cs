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
    public partial class Form14 : Form
    {
        Form13 f13;
        public Form14()
        {
            InitializeComponent();
        }
        public Form14(Form13 f13)
        {
            this.f13 = f13;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = f13.dataGridView1.Rows.Count;
            if (i == 0)
            {
                int d = 1;
                f13.dataGridView1.Rows.Add(d, textBox1.Text, textBox2.Text);
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string idw = textBox1.Text;
                string ida = textBox2.Text;
                string query = "INSERT INTO Links VALUES (" + d + ", '" + idw + "', '" + ida + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            else
            {
                int d = Convert.ToInt32(f13.dataGridView1.Rows[i - 1].Cells[0].Value);
                f13.dataGridView1.Rows.Add(d + 1, textBox1.Text, textBox2.Text);
                int d1 = d + 1;
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string idw = textBox1.Text;
                string ida = textBox2.Text;
                string query = "INSERT INTO Links VALUES (" + d1 + ", '" + idw + "', '" + ida + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = f13.dataGridView1.SelectedCells[0].RowIndex;
            string id = f13.dataGridView1.Rows[i].Cells[0].Value.ToString();
            string idw = textBox1.Text;
            string ida = textBox2.Text;
            f13.dataGridView1.CurrentRow.Cells[0].Value = i + 1;
            f13.dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
            f13.dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "UPDATE Links SET [Works_id] = '" + idw + "',[Authors_id] = '" + ida + "' WHERE [id] = " + id;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
            Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Form13.Per.k == 1)
            {
                textBox1.Text = f13.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = f13.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Form13.Per.k = 0;
            }
        }
    }
}
