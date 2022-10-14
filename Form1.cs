using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edevinvenmgmt
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        private void MaterialEntryButton_Click(object sender, EventArgs e)
        {
            MaterialEntry maten = new MaterialEntry();
            maten.Show();
            this.Hide();
        }

        private void MaterialDispatchButton_Click(object sender, EventArgs e)
        {
            MaterialDispatch matdis = new MaterialDispatch();
            matdis.Show(); this.Hide();
        }

        private void LocateItemButton_Click(object sender, EventArgs e)
        {
            LocateItem matl = new LocateItem();
            matl.Show(); this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
