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
    public partial class MaterialDispatch : Form
    {
        public MaterialDispatch()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kumar\OneDrive\Documents\edevdb.mdf;Integrated Security=True;Connect Timeout=30");
        int orderno = 0;
        int prono = 0;
        private void MaterialDispatch_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
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
            label6.Hide();
            label12.Show();
            MatCodeTb.Show();
            MatNameTb.Show();
            MatQtyTb.Show();
            MatTypeTb.Show();
            dateTimePicker1.Show();
            SearchOffButton.Show();
            //MaterialEntryButton.Show();
            //button1.Show();
            OffMatRemTb.Show();

            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Show();
            ProCodeTb.Hide();
            ProNameTb.Hide();
            dateTimePicker2.Hide();
            RemarksTb.Hide();
            ProCodeTb.Hide();
            ProNameTb.Hide();
            MatLocationTb.Hide();
            SearchProject.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Hide();
            ProCodeTb.Show();
            ProNameTb.Show();
            dateTimePicker2.Show();
            RemarksTb.Show();
            ProCodeTb.Show();
            ProNameTb.Show();
            MatLocationTb.Show();
            SearchProject.Show();

            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Show();
            label12.Hide();
            MatCodeTb.Hide();
            MatNameTb.Hide();
            MatQtyTb.Hide();
            MatTypeTb.Hide();
            dateTimePicker1.Hide();
            //MaterialEntryButton.Hide();
            //button1.Hide();

            SearchOffButton.Hide();
            OffMatRemTb.Hide();
        }

        private void MaterialEntryButton_Click(object sender, EventArgs e)
        {
            Con.Open(); 
            if (radioButton1.Checked)
            {
                string Myquery = "select * from OffMatLocTable where MatCode = '" + MatCodeTb.Text.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                int actualQty = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                int dispqty = Convert.ToInt32(MatQtyTb.Text.ToString());
                if ( dispqty<= actualQty ) 
                {
                    orderno++;
                    string myquery = "insert into OffMatDispTable values('" + MatCodeTb.Text + "','"  + MatQtyTb.Text + "','" + dateTimePicker1.Value + "','"+OffMatRemTb.Text+"', "+orderno+" )";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    if (dispqty == actualQty)
                    {
                        string myquery1 = "delete from OffMatDetTable where MatCode = '" + MatCodeTb.Text + "'";
                        string myquery2 = "delete from OffMatLocTable where MatCode = '" + MatCodeTb.Text + "'";
                        
                        SqlCommand cmd1 = new SqlCommand(myquery1, Con);
                        SqlCommand cmd2 = new SqlCommand(myquery2, Con);
                        
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        
                    }
                    else
                    {
                        int diff = actualQty - dispqty;
                        string myquery1 = "update OffMatLocTable set MatQty = '" + diff.ToString() + "' where MatCode = '" + MatCodeTb.Text + "'";
                        
                        SqlCommand cmd1 = new SqlCommand(myquery1, Con);
                        
                        cmd1.ExecuteNonQuery();
                    }
                    MessageBox.Show("Dispatch done successfully");
                    Con.Close();
                    
                
                }
                else
                {
                    MessageBox.Show("Low Quantity. Actual quantity of selected Item is " + actualQty);
                }
                
            }
            else if (radioButton2.Checked)
            {
                string myquery1 = "delete from ProjectDetailsTable where ProCode = '" + ProCodeTb.Text + "'";
                string myquery2 = "insert into ProMatDispTable values ('" + ProCodeTb.Text + "','" + MatLocationTb.Text + "','" + dateTimePicker2.Value + "','" + RemarksTb.Text + "')";
                SqlCommand cmd1 = new SqlCommand(myquery1, Con);
                SqlCommand cmd2 = new SqlCommand(myquery2, Con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Project Dispatched successfully");
            }
            else
            {
                MessageBox.Show("please choose office or project material");
            }
        }

        private void SearchOffButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            if(MatCodeTb.Text.ToString() == "")
            {
                MessageBox.Show("enter the material code");
                Con.Close();
            }
            else
            {
                try
                {
                    string Myquery = "select * from OffMatDetTable where MatCode = '" + MatCodeTb.Text.ToString() + "'";
                    string Myquery1 = "select * from OffMatLocTable where MatCode = '" + MatCodeTb.Text.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlDataAdapter da1 = new SqlDataAdapter(Myquery1, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    SqlCommandBuilder builder1 = new SqlCommandBuilder(da1);
                    var ds = new DataSet();
                    var ds1 = new DataSet();

                    da.Fill(ds);
                    da1.Fill(ds1);
                    dataGridView1.DataSource = ds.Tables[0];


                    MatCodeTb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    MatNameTb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    MatTypeTb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dataGridView1.DataSource = ds1.Tables[0];
                    MatQtyTb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Con.Close();
                }
                catch(Exception ex)
                {
                   MessageBox.Show("Either Item Does Not Exist Or Already Dispatched");
                   Con.Close();
                }
            }
            
            
        }

        private void SearchProject_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (ProCodeTb.Text.ToString() == "")
            {
                MessageBox.Show("enter the product code");
                Con.Close();
            }
            else
            {
                try
                {
                    string Myquery = "select * from ProjectDetailsTable where ProCode = '" + ProCodeTb.Text.ToString() + "'";
                    string Myquery1 = "select * from ProMatIndexTable where ProCode = '" + ProCodeTb.Text.ToString() + "'";
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
                    dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dataGridView1.DataSource = ds1.Tables[0];

                    ProNameTb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Either Project Does Not Exist Or Already Dispatched");
                    Con.Close();
                }
            }
        }
    }
}
