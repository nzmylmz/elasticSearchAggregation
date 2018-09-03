namespace Innovile_ElasticSearchAggregation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxTimeInterval = new System.Windows.Forms.ComboBox();
            this.cmbBoxMinDocCount = new System.Windows.Forms.ComboBox();
            this.cmbBoxLocalCellName = new System.Windows.Forms.ComboBox();
            this.cmbBoxRNCName = new System.Windows.Forms.ComboBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowDrop = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(983, 303);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtPickerEndDate);
            this.panel1.Controls.Add(this.dtPickerStartDate);
            this.panel1.Controls.Add(this.cmbBoxTimeInterval);
            this.panel1.Controls.Add(this.cmbBoxMinDocCount);
            this.panel1.Controls.Add(this.cmbBoxLocalCellName);
            this.panel1.Controls.Add(this.cmbBoxRNCName);
            this.panel1.Controls.Add(this.btnGetInfo);
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 100);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(840, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Search Time :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(840, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Count :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time Interval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Minimum Doc. Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Local Cell Name Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "RNCName Size";
            // 
            // dtPickerEndDate
            // 
            this.dtPickerEndDate.CustomFormat = "DD.MM.YYYY HH:SS";
            this.dtPickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerEndDate.Location = new System.Drawing.Point(593, 45);
            this.dtPickerEndDate.Name = "dtPickerEndDate";
            this.dtPickerEndDate.Size = new System.Drawing.Size(133, 20);
            this.dtPickerEndDate.TabIndex = 9;
            this.dtPickerEndDate.Value = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
            // 
            // dtPickerStartDate
            // 
            this.dtPickerStartDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtPickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerStartDate.Location = new System.Drawing.Point(593, 13);
            this.dtPickerStartDate.Name = "dtPickerStartDate";
            this.dtPickerStartDate.Size = new System.Drawing.Size(133, 20);
            this.dtPickerStartDate.TabIndex = 8;
            this.dtPickerStartDate.Value = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
            // 
            // cmbBoxTimeInterval
            // 
            this.cmbBoxTimeInterval.FormattingEnabled = true;
            this.cmbBoxTimeInterval.Items.AddRange(new object[] {
            "15m",
            "30m",
            "45m",
            "1h",
            "3h",
            "6h",
            "9h",
            "12h",
            "1d",
            "2d",
            "3d"});
            this.cmbBoxTimeInterval.Location = new System.Drawing.Point(393, 31);
            this.cmbBoxTimeInterval.Name = "cmbBoxTimeInterval";
            this.cmbBoxTimeInterval.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTimeInterval.TabIndex = 7;
            // 
            // cmbBoxMinDocCount
            // 
            this.cmbBoxMinDocCount.FormattingEnabled = true;
            this.cmbBoxMinDocCount.Location = new System.Drawing.Point(266, 31);
            this.cmbBoxMinDocCount.Name = "cmbBoxMinDocCount";
            this.cmbBoxMinDocCount.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxMinDocCount.TabIndex = 6;
            // 
            // cmbBoxLocalCellName
            // 
            this.cmbBoxLocalCellName.FormattingEnabled = true;
            this.cmbBoxLocalCellName.Location = new System.Drawing.Point(139, 31);
            this.cmbBoxLocalCellName.Name = "cmbBoxLocalCellName";
            this.cmbBoxLocalCellName.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxLocalCellName.TabIndex = 5;
            // 
            // cmbBoxRNCName
            // 
            this.cmbBoxRNCName.FormattingEnabled = true;
            this.cmbBoxRNCName.Location = new System.Drawing.Point(12, 31);
            this.cmbBoxRNCName.Name = "cmbBoxRNCName";
            this.cmbBoxRNCName.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxRNCName.TabIndex = 4;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(746, 12);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 3;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(746, 42);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 78);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(983, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 403);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Elasticsearch Aggregation of Innovile Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerEndDate;
        private System.Windows.Forms.DateTimePicker dtPickerStartDate;
        private System.Windows.Forms.ComboBox cmbBoxTimeInterval;
        private System.Windows.Forms.ComboBox cmbBoxMinDocCount;
        private System.Windows.Forms.ComboBox cmbBoxLocalCellName;
        private System.Windows.Forms.ComboBox cmbBoxRNCName;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

