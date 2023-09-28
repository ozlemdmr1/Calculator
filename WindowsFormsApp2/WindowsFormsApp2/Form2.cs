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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source= vt.mdb");
            baglan.Open();

            DataSet ds=new DataSet();
            OleDbDataAdapter adtr=new OleDbDataAdapter("select *from Kitaplar", baglan);
            adtr.Fill(ds, "Kitaplar");

            dataGridView1.DataSource = ds.Tables["Kitaplar"];
            adtr.Dispose();
        }
    }
}
