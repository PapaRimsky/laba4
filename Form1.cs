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
    public partial class Form1 : Form
    {
        public static class Per
        {
            public static int k = 0;
        }
        public Form1()
        {
            InitializeComponent();
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "SELECT * FROM Works";
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            OleDbDataReader bdReader = bdcommand.ExecuteReader();
            if (bdReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены");
            }
            else
            {
                while(bdReader.Read())
                {
                    dataGridView1.Rows.Add(bdReader["id"], bdReader["Title"], bdReader["Pages"], bdReader["UDK"], bdReader["Dates"], bdReader["PubHouse"], bdReader["DOI"]);    
                }
            }
            bdReader.Close();
            bdconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
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
            string query = "DELETE FROM Works WHERE id = "+ d;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 newForm = new Form13();
            newForm.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
            Per.k = 1;
        }
        private void publicationHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show();
        }

        private void uDKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void workplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void scienceDegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
        }
    }
}
