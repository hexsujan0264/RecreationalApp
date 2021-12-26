using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class VisitorInfo : Form
    {

        DataTable dt = new DataTable();

        int visitorID;
        String name;
        String ageGroup;
        String date;
        String phoneNo;
        String visitorType;
        String inTime;
        String outTime;
        String group;

        public VisitorInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbVtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                visitorID = int.Parse(txtBoxVisID.Text);
                name = txtBoxName.Text;
                ageGroup = cBoxAgeGrp.SelectedItem.ToString();
                phoneNo = txtBoxPhn.Text;
                visitorType = cBoxVtype.SelectedItem.ToString();
                txtBoxDate.Text = DateTime.Now.ToString("M-d-yyyy");
                date = txtBoxDate.Text;
                txtBoxInTime.Text = DateTime.Now.ToString("hh:mm");
                inTime = txtBoxInTime.Text;
                group = cmbBoxGrp.SelectedItem.ToString();

                Visitor v;
                v = new Visitor();
                v.VisitorID = visitorID.ToString();
                v.Name = name;
                v.Group = ageGroup;
                v.PhoneNo = phoneNo;
                v.VisitorType = visitorType;
                v.Date = date;
                v.InTime = inTime;
               
                List<Visitor> lstVisitor = new List<Visitor>();
                
                string data = Utility.ReadFromFile();
                if (data != null && data != "")
                {
                    lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                }
                lstVisitor.Add(v);
                string str = JsonConvert.SerializeObject(lstVisitor);
                Utility.WriteToText(str);

                MessageBox.Show("Data Submitted.");
                dataGridView1.Rows.Add(visitorID, name, ageGroup, phoneNo, visitorType, date, inTime, group);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       /*private void btnSave_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtBoxVisID.Text);
            name = txtBoxName.Text;
            ageGroup = cBoxAgeGrp.SelectedItem.ToString();
            phoneNo = txtBoxPhn.Text;
            visitorType = cBoxVtype.SelectedItem.ToString();
            txtBoxDate.Text = DateTime.Now.ToString("M-d-yyyy");
            date = txtBoxDate.Text;
            txtBoxInTime.Text = DateTime.Now.ToString("hh:mm");
            inTime = txtBoxInTime.Text;
            //display();
        }*/
        //public void display()
        //{
           

        //    DataRow dr = dt.NewRow();
        //    dr[0] = id;
        //    dr[1] = name;
        //    dr[2] = ageGroup;
        //    dr[3] = phoneNo;
        //    dr[4] = visitorType;
        //    dr[5] = date;
        //    dr[6] = inTime;
        //    dr[7] = Group;


        //    dt.Rows.Add(dr);
        //    dataGridView1.DataSource = dt;
        //}

        private void txtBoxInTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pricing f1 = new Pricing();
                f1.ageGrp = cBoxAgeGrp.SelectedItem.ToString();
                f1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtBoxName.Text = "";
            txtBoxVisID.Text = "";
            cBoxAgeGrp.Text = "";
            txtBoxPhn.Text = "";
            cBoxVtype.Text = "";
            txtBoxDate.Text = "";
            txtBoxInTime.Text = "";
            txtBoxOutTIme.Text = "";
            cmbBoxGrp.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
          
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HexSujan\Downloads\project.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                
                dataGridView1.Rows.Add(row);
            }
           
        }
    }
}
