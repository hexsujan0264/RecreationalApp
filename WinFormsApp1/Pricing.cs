using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Pricing : Form
    {
        public string ageGrp { get; set; }
        public Pricing()
        {
            InitializeComponent();
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //For Child
            if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBxCWEnd.Text = "50";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBxCWEnd.Text = "100";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBxCWEnd.Text = "150";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBxCWEnd.Text = "350";
            }
            //For 10 child
            if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBxCWEnd.Text = "500";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBxCWEnd.Text = "1000";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBxCWEnd.Text = "1500";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBxCWEnd.Text = "3500";
            }
            //For 20 Child
            if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBxCWEnd.Text = "1000";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBxCWEnd.Text = "2000";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBxCWEnd.Text = "3000";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBxCWEnd.Text = "7000";
            }
            //For More Children
            if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBxCWEnd.Text = "1500";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBxCWEnd.Text = "2500";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBxCWEnd.Text = "3000";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBxCWEnd.Text = "4000";
            }


            //For Adult
            if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBoxAdultwknd.Text = "60";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBoxAdultwknd.Text = "110";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBoxAdultwknd.Text = "160";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "1" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBoxAdultwknd.Text = "360";
            }
            //For 10 Adult
            if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBoxAdultwknd.Text = "510";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBoxAdultwknd.Text = "1110";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBoxAdultwknd.Text = "1560";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "10" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBoxAdultwknd.Text = "3560";
            }
            //For 20 Child
            if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBoxAdultwknd.Text = "1010";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBoxAdultwknd.Text = "2010";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBoxAdultwknd.Text = "3010";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "20" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBoxAdultwknd.Text = "7010";
            }
            //For more Adult
            if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "1 hrs")
            {
                txtBoxAdultwknd.Text = "1510";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "2 hrs")
            {
                txtBoxAdultwknd.Text = "2510";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "4 hrs")
            {
                txtBoxAdultwknd.Text = "3510";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "more" && cbDuration.SelectedItem.ToString() == "more")
            {
                txtBoxAdultwknd.Text = "7510";
            }
            //For Aged
            if (ageGrp == "Aged" && cmbBoxGrp.SelectedItem.ToString() == "1")
            {
                txtBoxAgedWknd.Text = "50";
            }
            else if (ageGrp == "Aged" && cmbBoxGrp.SelectedItem.ToString() == "10")
            {
                txtBoxAgedWknd.Text = "100";
            }
            else if (ageGrp == "Aged" && cmbBoxGrp.SelectedItem.ToString() == "20")
            {
                txtBoxAgedWknd.Text = "150";
            }
            else if (ageGrp == "Aged" && cmbBoxGrp.SelectedItem.ToString() == "more")
            {
                txtBoxAgedWknd.Text = "350";
            }


            if ((ageGrp == "Child") && (cmbBoxGrp.SelectedItem.ToString() == "1"))
            {
                txtBxCWEnd.Text = "50";
                Console.WriteLine("check");
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "10")
            {
                txtBoxAdultwknd.Text = "100";
            }
            else if (ageGrp == "Aged" && cmbBoxGrp.SelectedItem.ToString() == "20") {
                txtBoxAgedWknd.Text = "150";
            }
            else if (ageGrp == "Aged" && cmbBoxGrp.SelectedItem.ToString() == "more")
            {
                txtBoxAgedWknd.Text = "350";
            }
            else if (ageGrp == "Child" && cmbBoxGrp.SelectedItem.ToString() == "more")
            {
                txtBxCWEnd.Text = "350";
            }
            else if (ageGrp == "Adult" && cmbBoxGrp.SelectedItem.ToString() == "more")
            {
                txtBoxAdultwknd.Text = "350";
            }
        }
    }
}
