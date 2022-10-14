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
    public partial class NewMaterialEntry : Form
    {
        public NewMaterialEntry()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kumar\OneDrive\Documents\edevdb.mdf;Integrated Security=True;Connect Timeout=30");
        string MatCode;
        private void MaterialEntryButton_Click(object sender, EventArgs e)
        {
            if(MatNameTb.Text == "")
            {
                MessageBox.Show("Enter Material Name");
            }
            else if (MatTypeTb.Text == ""){
                MessageBox.Show("Enter Material Type");
            }
            else
            {
            Con.Open();
            MatCode = MatTypeTb.Text.ToString().ToLower() + "_" + MatNameTb.Text.ToString().ToUpper();
            string myquery = "insert into OffMatDetTable values ('" + MatCode + "','" + MatNameTb.Text.ToString() + "','" + MatTypeTb.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("entry done !");
            Con.Close();
            string mattype = MatTypeTb.Text;
            string matname = MatNameTb.Text;
            MaterialEntry materialEntry = new MaterialEntry(MatCode, mattype, matname);
            
            materialEntry.Show();
            this.Hide();
            }
            

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MaterialEntry materialEntry = new MaterialEntry();
            materialEntry.Show();
            this.Hide();
        }
    }
}
