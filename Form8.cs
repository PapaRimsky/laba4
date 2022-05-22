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
    public partial class Form8 : Form
    {
        Form7 f7;
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(Form7 f7)
        {
            this.f7 = f7;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = f7.dataGridView1.Rows.Count;
            if (i == 0)
            {
                int d = 1;
                f7.dataGridView1.Rows.Add(d, textBox2.Text, textBox3.Text, textBox4.Text);
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string workplace = textBox2.Text;
                string ph = textBox3.Text;
                string address = textBox4.Text;
                string query = "INSERT INTO Workplace VALUES (" + d + ", '" + workplace + "', '" + ph + "', '" + address + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            else
            {
                int d = Convert.ToInt32(f7.dataGridView1.Rows[i - 1].Cells[0].Value);
                f7.dataGridView1.Rows.Add(d + 1, textBox2.Text, textBox3.Text, textBox4.Text);
                int d1 = d + 1;
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string workplace = textBox2.Text;
                string ph = textBox3.Text;
                string address = textBox4.Text;
                string query = "INSERT INTO Workplace VALUES (" + d1 + ", '" + workplace + "', '" + ph + "', '" + address + "')";
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
            int i = f7.dataGridView1.SelectedCells[0].RowIndex;
            string id = f7.dataGridView1.Rows[i].Cells[0].Value.ToString();
            string workplace = textBox2.Text;
            string ph = textBox3.Text;
            string address = textBox4.Text;
            f7.dataGridView1.CurrentRow.Cells[0].Value = i + 1;
            f7.dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            f7.dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            f7.dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "UPDATE Workplace SET [Workplaces] = '" + workplace + "',[PhoneNumber] = '" + ph + "',[Address] = '" + address + "' WHERE [id] = " + id;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form7.Per.k == 1)
            {
                textBox2.Text = f7.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = f7.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = f7.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Form7.Per.k = 0;
            }
        }
    }
}
