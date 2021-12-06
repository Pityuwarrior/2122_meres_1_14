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
    public partial class Form1 : Form
    {
        public string ConnectionString { get; private set; }

        public Form1()
        {
            ConnectionString =
               "Server = (localdb)\\MSSQLLocalDB; " +
               "Database = palyazatok; ";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
            => FillDGV();

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT palyazat.id, (tervezetA + tervezetB), COUNT(szamlaszam), sum(ertek) " +
                    "FROM koltsegtipus, palyazat, szamla " +
                    "INNER JOIN szamla ON id = palyazat " +
                    "INNER JOIN szamla ON id = koltsegtipus " +
                    "ORDER BY palyazat.id; ", c)
                    .ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            palyarogzites_Form form = new palyarogzites_Form();
            form.ShowDialog();
        }
    }
}
