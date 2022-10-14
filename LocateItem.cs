using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace edevinvenmgmt
{
    public partial class LocateItem : Form
    {
        public LocateItem()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kumar\OneDrive\Documents\edevdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
        void SearchByMatCode()
        {
            try
            {
                Con.Open();
                string Myquery = "select MatLoc from OffMatLocTable where MatCode = '" + MatCodeTb.Text.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                LocationsGV.DataSource = ds.Tables[0];
                LocationTb.Text = LocationsGV.CurrentRow.Cells[0].Value.ToString();
                Con.Close();
            }
            catch
            {
                MessageBox.Show("An error occured");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //locate
            if (MatCodeTb.Text.ToString() == "")
                MessageBox.Show("enter material code ");
            else
            SearchByMatCode();
        }

        private void LocateItem_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Show();
            label4.Show();
            label6.Show();
            MatCodeTb.Show();
            MatNameTb.Show();
            LocationTb.Show();

        }
    }
}
