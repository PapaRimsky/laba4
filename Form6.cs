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
    public partial class Form6 : Form
    {
        Form5 f5;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(Form5 f5)
        {
            this.f5 = f5;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = f5.dataGridView1.Rows.Count;
            if (i == 0)
            {
                int d = 1;
                f5.dataGridView1.Rows.Add(d,textBox2.Text);
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string udk = textBox2.Text;
                string query = "INSERT INTO UDK (UDK) VALUES ('" + udk + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            else
            {
                int d = Convert.ToInt32(f5.dataGridView1.Rows[i - 1].Cells[0].Value);
                f5.dataGridView1.Rows.Add(d+1,textBox2.Text);
                int d1 = d + 1;
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string udk = textBox2.Text;
                string query = "INSERT INTO UDK VALUES (" + d1 + ", '" + udk + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = f5.dataGridView1.SelectedCells[0].RowIndex;
            string id = f5.dataGridView1.Rows[i].Cells[0].Value.ToString();
            string udk = textBox2.Text;
            f5.dataGridView1.CurrentRow.Cells[0].Value = i + 1;
            f5.dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "UPDATE UDK SET [UDK] = '" + udk + "' WHERE [id] = " + id;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
            Close();
        }
    }
}
