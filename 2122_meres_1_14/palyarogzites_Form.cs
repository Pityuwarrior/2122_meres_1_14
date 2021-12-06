using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2122_meres_1_14
{
    public partial class palyarogzites_Form : Form
    {
        public string ConnectionString { get; private set; }
        public palyarogzites_Form(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                string a = textBox2.Text;
                string b = textBox3.Text;

                try
                {
                    string errorMessage = "";
                    if (string.IsNullOrWhiteSpace(a))
                        errorMessage += "A kategória értéke nem maradhat üresen!\n";
                    if (string.IsNullOrWhiteSpace(b))
                        errorMessage += "B kategória értéke nem maradhat üresen!\n";
                    if (!string.IsNullOrEmpty(errorMessage))
                        throw new Exception(errorMessage);

                    //new SqlCommand(
                    //    "INSERT INTO palyazatok VALUES " +
                    //    $"('{tervezetA}', {tervezetb});", c).ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                MessageBox.Show("új termék sikeresen rögzítve!");
                Close();
            }
        }
    }
}
