using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nest;
using Elasticsearch.Net;

namespace Innovile_ElasticSearchAggregation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AggregationOfInnovileData aggsData;

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            btnGetInfo.Enabled = false;
            
            aggsData = new AggregationOfInnovileData("http://localhost:9200/", "new_80million", "doc");
            HeaderTitleOfListview();

            string[] s = new string[] { "RNCName.keyword", "Local_cell_name.keyword" };
            int[] c = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                c[i] = aggsData.DitinctValueCountOfField(s[i].ToString());

                for (int x = 1; x <= c[i]; x++)
                {
                    if (i == 0)
                    {
                        cmbBoxRNCName.Items.Add(x);
                        cmbBoxMinDocCount.Items.Add(x);
                    }
                    if (i == 1)
                        cmbBoxLocalCellName.Items.Add(x);
                }
            }
            cmbBoxRNCName.SelectedIndex = 0;
            cmbBoxLocalCellName.SelectedIndex = 0;
            cmbBoxMinDocCount.SelectedIndex = 0;
            cmbBoxTimeInterval.SelectedIndex = 10;
            btnGetData.Enabled = true;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                string startDate = dtPickerStartDate.Value.ToString("dd.MM.yyyy HH:mm");
                string endDate = dtPickerEndDate.Value.ToString("dd.MM.yyyy HH:mm");

                var rncNameList = aggsData.RNCName(Convert.ToInt16(cmbBoxRNCName.SelectedItem), startDate, endDate);

                foreach (var x in rncNameList)
                {
                    var LocelCellNameList = aggsData.LocalCellName(Convert.ToInt16(cmbBoxLocalCellName.SelectedItem), x.Key.ToString(), startDate, endDate);
                    foreach (var y in LocelCellNameList)
                    {
                        var sDateList = aggsData.SDate(x.Key.ToString(), y.Key.ToString(), cmbBoxTimeInterval.SelectedItem.ToString(), Convert.ToInt16(cmbBoxMinDocCount.SelectedItem.ToString()), startDate, endDate);
                        foreach (var z in sDateList)
                        {
                            string dt = new DateTime(1970, 1, 1).AddMilliseconds(z.Key + EndTime()).ToString("dd.MM.yyyy HH:mm");

                            var avgList = aggsData.ResultAvg(x.Key.ToString(), y.Key.ToString(), z.KeyAsString, dt);

                            string[] data = new string[30];
                            data[0] = aggsData.QueryCount(x.Key.ToString(), y.Key.ToString(), z.KeyAsString, dt);
                            data[1] = x.Key.ToString();
                            data[2] = y.Key.ToString();
                            data[3] = z.KeyAsString;
                            int a = 4;
                            foreach (var i in avgList)
                                data[a++] = i.ToString();
                            //listView1.Items.Add(new ListViewItem(new[] { item as string}));
                            ListViewItem lst = new ListViewItem(data);
                            listView1.Items.Add(lst);
                        }
                    }
                }
                label7.Text = "Total Count : " + aggsData.totalCount.ToString();
                aggsData.totalCount = 0;
                label8.Text = "Search Time : " + aggsData.totalSearchTime.ToString() + " ms";
                aggsData.totalSearchTime = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source.ToString());
            }
        }
        public void HeaderTitleOfListview()
        {
            string[] caption = new string[] {"Count","RNCName","Local_cell_name","SDATE","H3G_1526727293","H3G_1526727294",
                "H3G_1526727295","H3G_1526728173","H3G_1526728355","H3G_1526728356","H3G_1526728878","H3G_1526728888",
                "H3G_1526728908","H3G_1526728952","H3G_1526728953","H3G_1526729053","H3G_1526729276","H3G_1526729277",
                "H3G_1526729900" ,"H3G_1526729901","H3G_1526729902","H3G_1526730598","H3G_1526730599","H3G_1526733169",
                "H3G_1526733170","column32" ,"column33","column34"};
            listView1.View = View.Details;
            foreach (var i in caption)
                listView1.Columns.Add(i, 100);
        }
        public long EndTime()
        {
            if (cmbBoxTimeInterval.SelectedIndex / 4 < 1)
            {
                return ((Convert.ToInt32(cmbBoxTimeInterval.SelectedIndex.ToString()) + 1) * 900000);//epoc_milisecond <=> 15dakika = 900.000miliseconds
            }
            else if (cmbBoxTimeInterval.SelectedIndex / 4 < 2)
            {
                return ((Convert.ToInt32(cmbBoxTimeInterval.SelectedIndex.ToString()) - 3) * 10800000);//3hour = 10.800.000 ms
            }
            else
            {
                return ((Convert.ToInt32(cmbBoxTimeInterval.SelectedIndex.ToString()) - 7) * 86400000);//24hour = 86.400.000 ms
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGetData.Enabled = false;
            dtPickerStartDate.Format = DateTimePickerFormat.Custom;
            dtPickerStartDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtPickerEndDate.Format = DateTimePickerFormat.Custom;
            dtPickerEndDate.CustomFormat = "dd.MM.yyyy HH:mm";
        }
    }
}
