using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewClient
{
    public partial class MaterielEdit : Form
    {
        MaterielData data;
        List<MaterielData> list;
        Action<MaterielData, int> editAction;
        bool IsAdd;
        int editIndex;
        public MaterielEdit(Action<MaterielData, int> editAction, List<MaterielData> list, MaterielData data)
        {
            InitializeComponent();
            this.list = list;
            this.data = data;
            this.editAction = editAction;
        }


        private void MaterielEdit_Load(object sender, EventArgs e)
        {
            if (data != null)
            {
                wlhTextBox.Text = data.MatNo;
                InfoTextBox.Text = data.Info;
                CameraIpTextBox.Text = data.CameraAddress;
                ewmTextBox.Text = data.BarCode;
                bgsjTextBox.Text = data.Exposure;
                zyTextBox.Text = data.Gain;
                zbxTextBox.Text = data.FindLineX;
                zbyTextBox.Text = data.FindLineY;
                zbgdTextBox.Text = data.FindLindHigh;
                zbkdTextBox.Text = data.FindLineWide;
                bkdTextBox.Text = data.FindLineEdge;
                zbyzTextBox.Text = data.FindLineThreshold;
                ewmxzTextBox.Text = data.BarCodeX;
                ewmyzTextBox.Text = data.BarCodeY;
                ewmgdTextBox.Text = data.BarCodeHigh;
                ewmkdTextBox.Text = data.BarCodeWide;

                zbx100TextBox.Text = data.FindLineX_100;
                zby100TextBox.Text = data.FindLineY_100;
                zbgd100TextBox.Text = data.FindLindHigh_100;
                zbkd100TextBox.Text = data.FindLineWide_100;
                pgzbyz100TextBox.Text = data.FindLineTs_100;
                pgbkd100TextBox.Text = data.FindLineEdge_100;
                bqbyz100TextBox.Text = data.FindLineTs_100L;
                bqbkd100TextBox.Text = data.FindLineEdge_100L;
                bqsxyzTextBox.Text = data.Limit;
                bqxxyzTextBox.Text = data.LowerLimit;

                IsAdd = false;
                editIndex = list.IndexOf(data);
            }
            else
            {
                data = new MaterielData();
                IsAdd = true;
                editIndex = list.Count;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cameraIp = CameraIpTextBox.Text.Trim();
            if (cameraIp.Length < 1)
            {
                MessageBox.Show("相机Ip不能为空!");
                return;
            }
            string matNo = wlhTextBox.Text.Trim();
            if (cameraIp.Length < 1)
            {
                MessageBox.Show("物料编号不能为空!");
                return;
            }
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == editIndex) continue;
                    if (list[i].CameraAddress.Equals(cameraIp) && list[i].MatNo.Equals(matNo))
                    {
                        MessageBox.Show("该相机Ip在当前物料号中已存在！");
                        return;
                    }
                }
            }
            if (!IsAdd)
            {
                list.RemoveAt(editIndex);
            }
            SaveData();
            list.Insert(editIndex, data);
            editAction(data, editIndex);
            this.Close();
        }

        private void SaveData()
        {
            data.MatNo = wlhTextBox.Text.Trim();
            data.Info = InfoTextBox.Text.Trim();
            data.CameraAddress = CameraIpTextBox.Text.Trim();
            data.BarCode = ewmTextBox.Text.Trim();
            data.Exposure = bgsjTextBox.Text.Trim();
            data.Gain = zyTextBox.Text.Trim();
            data.FindLineX = zbxTextBox.Text.Trim();
            data.FindLineY = zbyTextBox.Text.Trim();
            data.FindLindHigh = zbgdTextBox.Text.Trim();
            data.FindLineWide = zbkdTextBox.Text.Trim();
            data.FindLineEdge = bkdTextBox.Text.Trim();
            data.FindLineThreshold = zbyzTextBox.Text.Trim();
            data.BarCodeX = ewmxzTextBox.Text.Trim();
            data.BarCodeY = ewmyzTextBox.Text.Trim();
            data.BarCodeHigh = ewmgdTextBox.Text.Trim();
            data.BarCodeWide = ewmkdTextBox.Text.Trim();

            //100ml物料表
            data.FindLineX_100 = zbx100TextBox.Text.Trim();
            data.FindLineY_100 = zby100TextBox.Text.Trim();
            data.FindLindHigh_100 = zbgd100TextBox.Text.Trim();
            data.FindLineWide_100 = zbkd100TextBox.Text.Trim();
            data.FindLineTs_100 = pgzbyz100TextBox.Text.Trim();
            data.FindLineEdge_100 = pgbkd100TextBox.Text.Trim();
            data.FindLineTs_100L = bqbyz100TextBox.Text.Trim();
            data.FindLineEdge_100L = bqbkd100TextBox.Text.Trim();
            data.Limit = bqsxyzTextBox.Text.Trim();
            data.LowerLimit = bqxxyzTextBox.Text.Trim();
        }
    }
}
