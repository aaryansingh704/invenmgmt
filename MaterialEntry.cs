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
    public partial class MaterialEntry : Form
    {
        public MaterialEntry(string matCode, string matType, string matName)
        {
            InitializeComponent();
            MatCodeTb.Text = matCode;
            MatTypeTb.Text = matType;
            MatNameTb.Text = matName;
            OfficeRadio.Checked = true ;
        }
        public MaterialEntry()
        {
            InitializeComponent();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kumar\OneDrive\Documents\edevdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ItemListTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label12.Show();
            MatCodeTb.Show();
            MatNameTb.Show();
            MatQtyTb.Show();
            MatTypeTb.Show();
            MatLocationTb.Show();
            dateTimePicker1.Show();
            MaterialEntryButton.Show();
            button1.Show();
            NewEntryButton.Show();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
           // label11.Hide();
            ProCodeTb.Hide();
            ProNameTb.Hide();
            dateTimePicker2.Hide();
            ItemListTb.Hide();
           // ItemQtyTb.Hide();
            SearchProjectButton.Hide();
            CreateProjectButton.Hide();
            EditButton.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ProjectRadio_CheckedChanged(object sender, EventArgs e)
        {
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            //label11.Show();
            ProCodeTb.Show();
            ProNameTb.Show();
            dateTimePicker2.Show();
            ItemListTb.Show();
           // ItemQtyTb.Show();
            dataGridView1.Show();
            SearchProjectButton.Show();
            CreateProjectButton.Show();
            EditButton.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label12.Hide();
            MatCodeTb.Hide();
            MatNameTb.Hide();
            MatQtyTb.Hide();
            MatTypeTb.Hide();
            MatLocationTb.Hide();
            dateTimePicker1.Hide();
            MaterialEntryButton.Hide();
            button1.Hide();
            NewEntryButton.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatCodeTb.Text = "";
            MatTypeTb.Text = "";
            MatLocationTb.Text = "";
            MatNameTb.Text = "";
            
        }

        private void MaterialEntryButton_Click(object sender, EventArgs e)
        {

            if(MatCodeTb.Text=="" || MatNameTb.Text=="" || MatTypeTb.Text ==""||MatQtyTb.Text=="" || MatLocationTb.Text==""){
                MessageBox.Show("enter details");
            }
            else
            {
            try
            {
                Con.Open();
                string myquery = "insert into OffMatDetTable values ('" + MatCodeTb.Text.ToString() + "','" + MatNameTb.Text + "','" + MatTypeTb.Text + "')";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Material added successfully :) ");
                Con.Close();
            }
            catch(SqlException ex)
            {
                

                Con.Close();
            }
            try
            {
                Con.Open();
                string myquery1 = "insert into OffMatLocTable values ('" + MatCodeTb.Text.ToString() + "','" + MatLocationTb.Text + "','" + MatQtyTb.Text + "','" + dateTimePicker1.Value + "')";
                SqlCommand cmd1 = new SqlCommand(myquery1, Con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Material added successfully :) ");
                Con.Close();
            }
            catch (SqlException ex)
            {
                DialogResult d;
                d = MessageBox.Show("an item with same material code exists in same location, do you want to add to quantity? ", "An error has occured !! ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    string Myquery = "select * from OffMatLocTable where MatCode = '" + MatCodeTb.Text.ToString() + "' and MatLoc = '"+MatLocationTb.Text.ToString()+"'";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    int oldQty = 0;
                    try
                    {

                         oldQty = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    }
                    catch
                    {
                         oldQty = 0;
                    }
                    int newQty = oldQty + Convert.ToInt32(MatQtyTb.Text.ToString());

                    string myquery = "update OffMatLocTable set MatQty = '"+newQty+ "' where MatCode = '" + MatCodeTb.Text.ToString() + "' and MatLoc = '" + MatLocationTb.Text.ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(myquery, Con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("updated");

                }
                Con.Close();
            }
            }
            
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "insert into ProMatIndexTable values ('" + ProCodeTb.Text.ToString() + "','" + ProNameTb.Text + "')";
                string myquery1 = "insert into ProjectDetailsTable values ('" + ProCodeTb.Text.ToString() + "','" + dateTimePicker2.Value + "','" + ItemListTb.Text + "')";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                SqlCommand cmd1 = new SqlCommand(myquery1, Con);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("project added successfully :) ");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Con.Close();
            }
        }

        private void SearchProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProMatIndexTable where ProCode = '" + ProCodeTb.Text.ToString() + "'";
                string Myquery1= "select * from ProjectDetailsTable where ProCode = '" + ProCodeTb.Text.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlDataAdapter da1 = new SqlDataAdapter(Myquery1, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                SqlCommandBuilder builder1 = new SqlCommandBuilder(da1);
                var ds = new DataSet();
                var ds1 = new DataSet();

                da.Fill(ds);
                da1.Fill(ds1);
                dataGridView1.DataSource = ds.Tables[0];
                
                
                ProCodeTb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ProNameTb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dataGridView1.DataSource = ds1.Tables[0];
                ItemListTb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //ItemQtyTb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Con.Close();
               // PQtyId.Text = ProductsGV.CurrentRow.Cells[2].Value.ToString();
               // PPriceTb.Text = ProductsGV.CurrentRow.Cells[3].Value.ToString();
                //PDescTb.Text = ProductsGV.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void MaterialEntry_Load(object sender, EventArgs e)
        {

        }

        private void NewEntryButton_Click(object sender, EventArgs e)
        {
            NewMaterialEntry nme = new NewMaterialEntry();
            nme.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProCodeTb.Text.Length == 0 || ProNameTb.Text.Length==0 || ItemListTb.Text.Length ==0 )
            {
                MessageBox.Show("enter the details first !!  ");
            }
            else
            {
                try
                {

                    Con.Open();
                    string myquery = "update ProMatIndexTable set ProName='" + ProNameTb.Text + "' where ProCode= '" + ProCodeTb.SelectedText.ToString() + "'";
                    string myquery1 = "update ProjectDetailsTable set ProDnT ='"+dateTimePicker2.Value+"' , ItemListQty = '"+ ItemListTb.Text.ToString()+ "' where ProCode= '" + ProCodeTb.SelectedText.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    SqlCommand cmd1 = new SqlCommand(myquery1, Con);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Project Successfully updated");
                    Con.Close(); 
                }
                catch
                {
                    Con.Close();
                }
            }
        }
    }
}
