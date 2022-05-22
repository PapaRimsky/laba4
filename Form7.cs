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
    public partial class Form7 : Form
    {
        Form4 f4;
        public static class Per
        {
            public static int k = 0;
        }
        public Form7(Form4 f4)
        {
            this.f4 = f4;
            InitializeComponent();
        }
        public Form7()
        {
            InitializeComponent();
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "SELECT * FROM Workplace";
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
                    dataGridView1.Rows.Add(bdReader["id"], bdReader["Workplaces"], bdReader["PhoneNumber"], bdReader["Address"]);
                }
            }
            bdReader.Close();
            bdconnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8(this);
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
            string query = "DELETE FROM Workplace WHERE id = " + d;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.comboBox1.Items.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                f4.comboBox1.Items.Add(row.Cells[1].Value.ToString());
            }
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8(this);
            newForm.Show();
            Per.k = 1;
        }
    }
}
