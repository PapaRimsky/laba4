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
    public partial class Form10 : Form
    {
        Form9 f9;
        public Form10()
        {
            InitializeComponent();
        }
        public Form10(Form9 f9)
        {
            this.f9 = f9;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = f9.dataGridView1.Rows.Count;
            if (i == 0)
            {
                int d = 1;
                f9.dataGridView1.Rows.Add(d,textBox2.Text);
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string sd = textBox2.Text;
                string query = "INSERT INTO ScienceDegree VALUES (" + d + ", '" + sd + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            else
            {
                int d = Convert.ToInt32(f9.dataGridView1.Rows[i - 1].Cells[0].Value);
                f9.dataGridView1.Rows.Add(d+1,textBox2.Text);
                int d1 = d + 1;
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string sd = textBox2.Text;
                string query = "INSERT INTO ScienceDegree VALUES (" + d1 + ", '" + sd + "')";
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
            int i = f9.dataGridView1.SelectedCells[0].RowIndex;
            string id = f9.dataGridView1.Rows[i].Cells[0].Value.ToString();
            string sd = textBox2.Text;
            f9.dataGridView1.CurrentRow.Cells[0].Value = i + 1;
            f9.dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "UPDATE ScienceDegree SET [ScienceDegrees] = '" + sd + "' WHERE [id] = " + id;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
            Close();
        }
    }
}
