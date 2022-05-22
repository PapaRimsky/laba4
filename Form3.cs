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
    public partial class Form3 : Form
    {
        public static class Per
        {
            public static int k = 0;
        }
        public Form3()
        {
            InitializeComponent();
            string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= laba4(3).mdb";
            OleDbConnection bdconnection = new OleDbConnection(connection);
            bdconnection.Open();
            string query = "SELECT * FROM Authors";
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
                    dataGridView1.Rows.Add(bdReader["id"], bdReader["Names"], bdReader["Birthday"], bdReader["Workplace"], bdReader["ScienceDegree"]);
                }
            }
            bdReader.Close();
            bdconnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
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
            string query = "DELETE FROM Authors WHERE id = " + d;
            OleDbCommand bdcommand = new OleDbCommand(query, bdconnection);
            bdcommand.ExecuteNonQuery();
            bdconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.Show();
            Per.k = 1;
        }
    }
}
