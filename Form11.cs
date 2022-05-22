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
    public partial class Form11 : Form
    {
        Form2 f2;
        public Form11()
        {
            InitializeComponent();
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "SELECT * FROM PublicationHouse";
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            OleDbDataReader bdReader = bdcommand.ExecuteReader();
            if (bdReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены");
            }
            else
            {
                while (bdReader.Read())
                {
                    dataGridView1.Rows.Add(bdReader["id"], bdReader["Place"], bdReader["Address"], bdReader["PhoneNumber"]);
                }
            }
            bdReader.Close();
            bdconnection.Close();
        }
        public static class Per
        {
            public static int k = 0;
        }
        public Form11(Form2 f2)
        {
            this.f2 = f2;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            int d = Convert.ToInt32(dataGridView1.Rows[delet].Cells[0].Value);
            dataGridView1.Rows.RemoveAt(delet);
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "DELETE FROM PublicationHouse WHERE id = " + d;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.comboBox1.Items.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                f2.comboBox1.Items.Add(row.Cells[1].Value.ToString());
            }
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12(this);
            newForm.Show();
            Per.k = 1;
        }
    }
}
