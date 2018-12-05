using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewClient.Properties;

namespace ViewClient
{
    public partial class MaterielExcelManager : Form
    {
        List<MaterielData> materielDataMap;
        int selectIndex;
        bool add;
        Action action;
        public MaterielExcelManager(Action action, List<MaterielData> materielDataMap)
        {
            InitializeComponent();
            this.Text = AppSetting.APP_NAME;
            this.Icon = Resources.Logo;
            this.materielDataMap = materielDataMap;  
            this.action = action;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            LoadData();
        }
        private void LoadData()
        {
            listView1.BeginUpdate();

            listView1.Clear();
            listView1.GridLines = true;//表格是否显示网格线
            listView1.FullRowSelect = true;//是否选中整行
            listView1.View = View.Details;//设置显示方式
            listView1.Scrollable = true;//是否自动显示滚动条
            listView1.MultiSelect = false;//是否可以选择多行

            //添加表头（列）
            // 设置标头：
            listView1.Columns.Add("物料编号", "物料编号");
            listView1.Columns.Add("二维码内容", "二维码内容");
            listView1.Columns.Add("相机IP", "相机IP");
            listView1.Columns.Add("描述", "描述");
            listView1.Columns.Add("曝光时间", "曝光时间");
            listView1.Columns.Add("增益值", "增益值");
            listView1.Columns.Add("找边X值", "找边X值");
            listView1.Columns.Add("找边Y值", "找边Y值");
            listView1.Columns.Add("找边高度", "找边高度");
            listView1.Columns.Add("找边宽度", "找边宽度");
            listView1.Columns.Add("边宽度", "边宽度");
            listView1.Columns.Add("找边阈值", "找边阈值");
            listView1.Columns.Add("二维码X值", "二维码X值");
            listView1.Columns.Add("二维码Y值", "二维码Y值");
            listView1.Columns.Add("二维码高度", "二维码高度");
            listView1.Columns.Add("二维码宽度", "二维码宽度");
            listView1.Columns.Add("100ml标签上限阈值", "100ml标签上限阈值");
            listView1.Columns.Add("100ml标签下限阈值", "100ml标签下限阈值");
            if (materielDataMap != null)
            {
                foreach (MaterielData data in materielDataMap)
                {
                    ListViewItem item = new ListViewItem(StringFormat(data).Split(':'));
                    listView1.Items.Add(item);
                }
            }

            listView1.Columns["物料编号"].Width = -2;
            listView1.Columns["二维码内容"].Width = -2;
            listView1.Columns["相机IP"].Width = -2;
            listView1.Columns["描述"].Width = -2;
            listView1.Columns["曝光时间"].Width = -2;
            listView1.Columns["增益值"].Width = -2;
            listView1.Columns["找边X值"].Width = -2;
            listView1.Columns["找边Y值"].Width = -2;
            listView1.Columns["找边高度"].Width = -2;
            listView1.Columns["找边宽度"].Width = -2;
            listView1.Columns["边宽度"].Width = -2;
            listView1.Columns["找边阈值"].Width = -2;
            listView1.Columns["二维码X值"].Width = -2;
            listView1.Columns["二维码Y值"].Width = -2;
            listView1.Columns["二维码高度"].Width = -2;
            listView1.Columns["二维码宽度"].Width = -2;
            listView1.Columns["100ml标签上限阈值"].Width = -2;
            listView1.Columns["100ml标签下限阈值"].Width = -2;

            if (selectIndex < 0)
            {
                selectIndex = 0;
            }
            if (selectIndex >= listView1.Items.Count)
            {
                selectIndex = listView1.Items.Count - 1;
            }
            listView1.HideSelection = false;
            listView1.Items[selectIndex].Focused = true;
            listView1.Items[selectIndex].Selected = true;
            listView1.Items[selectIndex].EnsureVisible();//保证可见

            listView1.EndUpdate();

        }
        string StringFormat(MaterielData data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(data.MatNo);
            sb.Append(":" + data.BarCode);
            sb.Append(":" + data.CameraAddress);
            sb.Append(":" + data.Info);
            sb.Append(":" + data.Exposure);
            sb.Append(":" + data.Gain);
            sb.Append(":" + data.FindLineX);
            sb.Append(":" + data.FindLineY);
            sb.Append(":" + data.FindLindHigh);
            sb.Append(":" + data.FindLineWide);
            sb.Append(":" + data.FindLineEdge);
            sb.Append(":" + data.FindLineThreshold);
            sb.Append(":" + data.BarCodeX);
            sb.Append(":" + data.BarCodeY);
            sb.Append(":" + data.BarCodeHigh);
            sb.Append(":" + data.BarCodeWide);
            sb.Append(":" + data.Limit);
            sb.Append(":" + data.LowerLimit);

            return sb.ToString();
        }

        private void MaterielExcelManager_Load(object sender, EventArgs e)
        {
            label1.Text = "提示：\r\n在选中条上双击修改";
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems == null || listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请先选中要修改的用户");
                return;
            }
            selectIndex = listView1.SelectedItems[0].Index;
            string matNo = (string)listView1.SelectedItems[0].SubItems[0].Text.Trim();
            string cameraIp = (string)listView1.SelectedItems[0].SubItems[2].Text.Trim();
            foreach (MaterielData data in materielDataMap)
            {
                if (data.CameraAddress.Equals(cameraIp) && data.MatNo.Equals(matNo))
                {
                    MaterielEdit materielEdit = new MaterielEdit(EditMaterielData, materielDataMap, data);
                    materielEdit.ShowDialog();
                    break;
                }
            }
        }
        private void EditMaterielData(MaterielData data, int editIndex)
        {
            LoadData();
            return;
            if (add)
            {
                //if (materielDataMap.ContainsKey(data.MatNo))
                //{
                //    materielDataMap[data.MatNo].Add(data);
                //}
                //else
                //{
                //    List<MaterielData> list = new List<MaterielData>();
                //   list.Add(data);
                //   materielDataMap.Add(data.MatNo, list);               
                //}
                LoadData();//增加物料编号全部刷新
                return;
            }
            listView1.Items[selectIndex].SubItems[1].Text = data.BarCode;
            listView1.Items[selectIndex].SubItems[2].Text = data.CameraAddress;
            listView1.Items[selectIndex].SubItems[3].Text = data.Info;
            listView1.Items[selectIndex].SubItems[4].Text = data.Exposure;
            listView1.Items[selectIndex].SubItems[5].Text = data.Gain;
            listView1.Items[selectIndex].SubItems[6].Text = data.FindLineX;
            listView1.Items[selectIndex].SubItems[7].Text = data.FindLineY;
            listView1.Items[selectIndex].SubItems[8].Text = data.FindLindHigh;
            listView1.Items[selectIndex].SubItems[9].Text = data.FindLineWide;
            listView1.Items[selectIndex].SubItems[10].Text = data.FindLineEdge;
            listView1.Items[selectIndex].SubItems[11].Text = data.FindLineThreshold;
            listView1.Items[selectIndex].SubItems[12].Text = data.BarCodeX;
            listView1.Items[selectIndex].SubItems[13].Text = data.BarCodeY;
            listView1.Items[selectIndex].SubItems[14].Text = data.BarCodeHigh;
            listView1.Items[selectIndex].SubItems[15].Text = data.BarCodeWide;
            listView1.Items[selectIndex].SubItems[16].Text = data.Limit;
            listView1.Items[selectIndex].SubItems[17].Text = data.LowerLimit;
        }

        private void MaterielExcelManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            action();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool res = FileTools.WriteExcelByText(materielDataMap);
            if (res)
            {
                this.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null || listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请先选中要删除的用户");
                return;
            }
            selectIndex = listView1.SelectedItems[0].Index + 1;
            add = false;
            string matNo = (string)listView1.SelectedItems[0].SubItems[0].Text.Trim();
            string cameraIp = (string)listView1.SelectedItems[0].SubItems[2].Text.Trim();
            foreach (MaterielData data in materielDataMap)
            {
                if (data.CameraAddress.Equals(cameraIp))
                {
                    materielDataMap.Remove(data);
                    LoadData();
                    break;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add = true;
            selectIndex = listView1.Items.Count;
            MaterielEdit materielEdit = new MaterielEdit(EditMaterielData, materielDataMap, null);
            materielEdit.ShowDialog();
        }
    }
}
