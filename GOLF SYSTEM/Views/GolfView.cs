using GOLF_SYSTEM.Controllers;
using GOLF_SYSTEM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOLF_SYSTEM.Views
{
    public partial class GolfView : Form
    {
        GolfController golfController = new GolfController();
        public GolfView()
        {
            InitializeComponent();
        }

        private void GolfView_Load(object sender, EventArgs e)
        {
            dgvGolfes.DataSource = golfController.GetAllGolfes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GOLFOVE golf = new GOLFOVE();
            golf.Model = "Golf" + " " + txtNumber.Text;
            golf.Year = txtYear.Text;
            golfController.AddGolf(golf);
            MessageBox.Show("The golf is succesfully registered!!!");
            dgvGolfes.DataSource = golfController.GetAllGolfes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
