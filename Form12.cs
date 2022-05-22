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
    public partial class Form12 : Form
    {
        Form11 f11;
        public Form12()
        {
            InitializeComponent();
        }
        public Form12(Form11 f11)
        {
            this.f11 = f11;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = f11.dataGridView1.Rows.Count;
            if (i == 0)
            {
                int d = 1;
                f11.dataGridView1.Rows.Add(d, textBox2.Text, textBox3.Text, textBox4.Text);
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string place = textBox2.Text;
                string address = textBox3.Text;
                string ph= textBox4.Text;
                string query = "INSERT INTO PublicationHouse VALUES (" + d + ", '" + place + "', '" + address + "', '" + ph + "')";
                OleDbCommand bdCommand = new OleDbCommand(query, bdconnection);
                bdCommand.ExecuteNonQuery();
                bdconnection.Close();
                Close();
            }
            else
            {
                int d = Convert.ToInt32(f11.dataGridView1.Rows[i - 1].Cells[0].Value);
                f11.dataGridView1.Rows.Add(d + 1, textBox2.Text, textBox3.Text, textBox4.Text);
                int d1 = d + 1;
                string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
                OleDbConnection bdconnection = new OleDbConnection(connection);
                bdconnection.Open();
                string place = textBox2.Text;
                string address = textBox3.Text;
                string ph = textBox4.Text;
                string query = "INSERT INTO PublicationHouse VALUES (" + d1 + ", '" + place + "', '" + address + "', '" + ph + "')";
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
            int i = f11.dataGridView1.SelectedCells[0].RowIndex;
            string id = f11.dataGridView1.Rows[i].Cells[0].Value.ToString();
            string place = textBox2.Text;
            string address = textBox3.Text;
            string ph = textBox4.Text;
            f11.dataGridView1.CurrentRow.Cells[0].Value = i + 1;
            f11.dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            f11.dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            f11.dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "UPDATE PublicationHouse SET [Place] = '" + place + "',[Address] = '" + address + "',[PhoneNumber] = '" + ph + "' WHERE [id] = " + id;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form11.Per.k == 1)
            {
                textBox2.Text = f11.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = f11.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = f11.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Form11.Per.k = 0;
            }
        }
    }
}
