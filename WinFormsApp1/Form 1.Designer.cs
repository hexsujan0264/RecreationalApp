
namespace WinFormsApp1
{
    partial class VisitorInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGrp = new System.Windows.Forms.Label();
            this.cmbBoxGrp = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCPFrom1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cBoxAgeGrp = new System.Windows.Forms.ComboBox();
            this.cBoxVtype = new System.Windows.Forms.ComboBox();
            this.lblVtype = new System.Windows.Forms.Label();
            this.txtBoxOutTIme = new System.Windows.Forms.TextBox();
            this.txtBoxInTime = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblOutTime = new System.Windows.Forms.Label();
            this.lblInTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxPhn = new System.Windows.Forms.TextBox();
            this.lblPhnNo = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxVisID = new System.Windows.Forms.TextBox();
            this.lblvisID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrp
            // 
            this.lblGrp.AutoSize = true;
            this.lblGrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblGrp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrp.ForeColor = System.Drawing.Color.White;
            this.lblGrp.Location = new System.Drawing.Point(37, 103);
            this.lblGrp.Name = "lblGrp";
            this.lblGrp.Size = new System.Drawing.Size(66, 25);
            this.lblGrp.TabIndex = 0;
            this.lblGrp.Text = "Group:";
            this.lblGrp.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBoxGrp
            // 
            this.cmbBoxGrp.FormattingEnabled = true;
            this.cmbBoxGrp.Items.AddRange(new object[] {
            "1",
            "10",
            "20",
            "more"});
            this.cmbBoxGrp.Location = new System.Drawing.Point(126, 104);
            this.cmbBoxGrp.Name = "cmbBoxGrp";
            this.cmbBoxGrp.Size = new System.Drawing.Size(190, 28);
            this.cmbBoxGrp.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 818);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panel6.Controls.Add(this.btnImport);
            this.panel6.Controls.Add(this.btnChart);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(4, 418);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(952, 400);
            this.panel6.TabIndex = 31;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Goldenrod;
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Location = new System.Drawing.Point(194, 327);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(152, 51);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Read";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.Chocolate;
            this.btnChart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChart.Location = new System.Drawing.Point(26, 327);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(152, 51);
            this.btnChart.TabIndex = 11;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(760, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 51);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(585, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(30, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(882, 233);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Visitor ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age Group";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone No.";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Visitor Type";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "In Time";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Out Time";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Group";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vistor Information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.btnCPFrom1);
            this.panel5.Controls.Add(this.lblGrp);
            this.panel5.Controls.Add(this.cmbBoxGrp);
            this.panel5.Location = new System.Drawing.Point(589, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 289);
            this.panel5.TabIndex = 30;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnCPFrom1
            // 
            this.btnCPFrom1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCPFrom1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCPFrom1.Location = new System.Drawing.Point(126, 195);
            this.btnCPFrom1.Name = "btnCPFrom1";
            this.btnCPFrom1.Size = new System.Drawing.Size(152, 51);
            this.btnCPFrom1.TabIndex = 5;
            this.btnCPFrom1.Text = "Calculate Price";
            this.btnCPFrom1.UseVisualStyleBackColor = false;
            this.btnCPFrom1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.cBoxAgeGrp);
            this.panel3.Controls.Add(this.cBoxVtype);
            this.panel3.Controls.Add(this.lblVtype);
            this.panel3.Controls.Add(this.txtBoxOutTIme);
            this.panel3.Controls.Add(this.txtBoxInTime);
            this.panel3.Controls.Add(this.txtBoxDate);
            this.panel3.Controls.Add(this.lblOutTime);
            this.panel3.Controls.Add(this.lblInTime);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.txtBoxPhn);
            this.panel3.Controls.Add(this.lblPhnNo);
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.txtBoxName);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.txtBoxVisID);
            this.panel3.Controls.Add(this.lblvisID);
            this.panel3.Location = new System.Drawing.Point(3, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 289);
            this.panel3.TabIndex = 28;
            // 
            // cBoxAgeGrp
            // 
            this.cBoxAgeGrp.FormattingEnabled = true;
            this.cBoxAgeGrp.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Aged",
            "Student"});
            this.cBoxAgeGrp.Location = new System.Drawing.Point(144, 151);
            this.cBoxAgeGrp.Name = "cBoxAgeGrp";
            this.cBoxAgeGrp.Size = new System.Drawing.Size(125, 28);
            this.cBoxAgeGrp.TabIndex = 28;
            // 
            // cBoxVtype
            // 
            this.cBoxVtype.FormattingEnabled = true;
            this.cBoxVtype.Items.AddRange(new object[] {
            "Nepali Citizen",
            "International",
            "Student"});
            this.cBoxVtype.Location = new System.Drawing.Point(423, 51);
            this.cBoxVtype.Name = "cBoxVtype";
            this.cBoxVtype.Size = new System.Drawing.Size(125, 28);
            this.cBoxVtype.TabIndex = 5;
            this.cBoxVtype.SelectedIndexChanged += new System.EventHandler(this.cbVtype_SelectedIndexChanged);
            // 
            // lblVtype
            // 
            this.lblVtype.AutoSize = true;
            this.lblVtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblVtype.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVtype.ForeColor = System.Drawing.Color.White;
            this.lblVtype.Location = new System.Drawing.Point(309, 50);
            this.lblVtype.Name = "lblVtype";
            this.lblVtype.Size = new System.Drawing.Size(106, 25);
            this.lblVtype.TabIndex = 27;
            this.lblVtype.Text = "Visitor type:";
            // 
            // txtBoxOutTIme
            // 
            this.txtBoxOutTIme.Location = new System.Drawing.Point(423, 207);
            this.txtBoxOutTIme.Name = "txtBoxOutTIme";
            this.txtBoxOutTIme.Size = new System.Drawing.Size(125, 27);
            this.txtBoxOutTIme.TabIndex = 26;
            // 
            // txtBoxInTime
            // 
            this.txtBoxInTime.Location = new System.Drawing.Point(423, 151);
            this.txtBoxInTime.Name = "txtBoxInTime";
            this.txtBoxInTime.Size = new System.Drawing.Size(125, 27);
            this.txtBoxInTime.TabIndex = 25;
            this.txtBoxInTime.TextChanged += new System.EventHandler(this.txtBoxInTime_TextChanged);
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(423, 101);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(125, 27);
            this.txtBoxDate.TabIndex = 24;
            // 
            // lblOutTime
            // 
            this.lblOutTime.AutoSize = true;
            this.lblOutTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblOutTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutTime.ForeColor = System.Drawing.Color.White;
            this.lblOutTime.Location = new System.Drawing.Point(309, 206);
            this.lblOutTime.Name = "lblOutTime";
            this.lblOutTime.Size = new System.Drawing.Size(86, 25);
            this.lblOutTime.TabIndex = 20;
            this.lblOutTime.Text = "Out time:";
            // 
            // lblInTime
            // 
            this.lblInTime.AutoSize = true;
            this.lblInTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblInTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInTime.ForeColor = System.Drawing.Color.White;
            this.lblInTime.Location = new System.Drawing.Point(309, 156);
            this.lblInTime.Name = "lblInTime";
            this.lblInTime.Size = new System.Drawing.Size(71, 25);
            this.lblInTime.TabIndex = 18;
            this.lblInTime.Text = "In time:";
            this.lblInTime.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(309, 103);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date:";
            // 
            // txtBoxPhn
            // 
            this.txtBoxPhn.Location = new System.Drawing.Point(144, 203);
            this.txtBoxPhn.Name = "txtBoxPhn";
            this.txtBoxPhn.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPhn.TabIndex = 15;
            // 
            // lblPhnNo
            // 
            this.lblPhnNo.AutoSize = true;
            this.lblPhnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblPhnNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhnNo.ForeColor = System.Drawing.Color.White;
            this.lblPhnNo.Location = new System.Drawing.Point(27, 205);
            this.lblPhnNo.Name = "lblPhnNo";
            this.lblPhnNo.Size = new System.Drawing.Size(95, 25);
            this.lblPhnNo.TabIndex = 14;
            this.lblPhnNo.Text = "Phone No:";
            this.lblPhnNo.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(27, 153);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(103, 25);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age Group:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(144, 104);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(27, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 25);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtBoxVisID
            // 
            this.txtBoxVisID.Location = new System.Drawing.Point(144, 50);
            this.txtBoxVisID.Name = "txtBoxVisID";
            this.txtBoxVisID.Size = new System.Drawing.Size(125, 27);
            this.txtBoxVisID.TabIndex = 9;
            // 
            // lblvisID
            // 
            this.lblvisID.AutoSize = true;
            this.lblvisID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblvisID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvisID.ForeColor = System.Drawing.Color.White;
            this.lblvisID.Location = new System.Drawing.Point(27, 49);
            this.lblvisID.Name = "lblvisID";
            this.lblvisID.Size = new System.Drawing.Size(85, 25);
            this.lblvisID.TabIndex = 8;
            this.lblvisID.Text = "Vistor ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkViolet;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(952, 125);
            this.panel4.TabIndex = 29;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(752, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
            this.textBox1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.Untitled_design4;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DarkViolet;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(202, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Fun moments with the family";
            this.lblTitle.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkViolet;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(488, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "A summer to remember";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.Untitled_design5;
            this.pictureBox2.Location = new System.Drawing.Point(712, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // VisitorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 818);
            this.Controls.Add(this.panel1);
            this.Name = "VisitorInfo";
            this.Text = "Visitor Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGrp;
        private System.Windows.Forms.ComboBox cmbBoxGrp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxOutTIme;
        private System.Windows.Forms.TextBox txtBoxInTime;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblOutTime;
        private System.Windows.Forms.Label lblInTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtBoxPhn;
        private System.Windows.Forms.Label lblPhnNo;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxVisID;
        private System.Windows.Forms.Label lblvisID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cBoxVtype;
        private System.Windows.Forms.Label lblVtype;
        private System.Windows.Forms.ComboBox cBoxAgeGrp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCPFrom1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

