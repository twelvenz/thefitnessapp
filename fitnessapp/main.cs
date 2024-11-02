using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnChest_Click(object sender, EventArgs e)
        {
            Chest chestForm = new Chest();
            chestForm.Show();
            this.Close();
        }

        private void btnLeg_Click(object sender, EventArgs e)
        {
            Leg legForm = new Leg();
            legForm.Show();
            this.Close();
        }

        private void btnArms_Click(object sender, EventArgs e)
        {
            Arms armsForm = new Arms();
            armsForm.Show();
            this.Close();
        }
    }
}
