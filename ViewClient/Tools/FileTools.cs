using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ViewClient
{
    class FileTools
    {
        public static bool SaveUserSetting(List<User> users)
        {
            string path = AppSetting.EXCEL_SETTING_PATH;
            string tempPath = AppSetting.EXCEL_TEMP_PATH;
            if (!File.Exists(path))
            {
                MessageBox.Show("设置文件不存在！保存失败!");
                return false;
            }
            FileStream fsRead = null;
            try
            {
                fsRead = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存到excel表格失败！请先关闭Excel表格占用进程!");
                return false;
            }
            try
            {
                FileStream fsWrite = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fsRead, System.Text.Encoding.GetEncoding("gb2312"));
                StreamWriter sw = new StreamWriter(fsWrite, System.Text.Encoding.GetEncoding("gb2312"));
                string line = sr.ReadLine();
                if (line != null)
                {
                    sw.WriteLine(line);
                }
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] cells = line.Split(',');
                        if (!cells[0].Equals("管理员") && !cells[0].Equals("工作员"))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                foreach (User user in users)
                {
                    sw.WriteLine(Replace(user));
                }
                sw.WriteLine();
                sw.Flush();
                sw.Close();
                sr.Close();
                fsRead.Close();
                fsWrite.Close();
                File.Delete(path);
                File.Move(tempPath, path);
            }
            catch (Exception e)
            {
                MessageBox.Show("保存失败：" + e);
            }
            MessageBox.Show("保存成功！");
            return true;
        }

        public static bool LoadSetting()
        {
            string path = AppSetting.EXCEL_SETTING_PATH;
            if (!File.Exists(path))
            {
                MessageBox.Show("设置文件不存在,加载默认配置！");
                return false;
            }
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding("gb2312"));
            try
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] cells = line.Split(',');
                        if (cells.Length < 2)
                        {
                            continue;
                        }
                        if (cells[0].Equals("批号相机"))
                        {
                            AppSetting.BATCH_CAMERA_ADDRESS = cells[1];
                        }
                        if (cells[0].Equals("肩标相机"))
                        {
                            AppSetting.SHOULDER_CAMERA_ADDRESS = cells[1];
                        }
                        if (cells[0].Equals("前标相机"))
                        {
                            AppSetting.FRONT_CAMERA_ADDRESS = cells[1];
                        }
                        if (cells[0].Equals("背标相机"))
                        {
                            AppSetting.BACK_CAMERA_ADDRESS = cells[1];
                        }
                        if (cells[0].Equals("正标有无相机"))
                        {
                            AppSetting.ISFRONT_CAMERA_ADDRESS = cells[1];
                        }
                        if (cells[0].Equals("背标有无相机"))
                        {
                            AppSetting.ISBACK_CAMERA_ADDRESS = cells[1];
                        }
                        if (cells[0].Equals("100ML物料编号"))
                        {
                            for (int i = 1; i < cells.Length; i++)
                            {
                                AppSetting.MatNoList100ml.Add(cells[i].Trim());
                            }
                        }
                        if (cells[0].Equals("管理员"))
                        {
                            if (cells.Length < 3)
                            {
                                MessageBox.Show(cells[1] + "未设密码，已跳过");
                                continue;
                            }
                            User user = new User(cells[1], cells[2], true);
                            AppSetting.UserList.Add(user);
                        }
                        if (cells[0].Equals("工作员"))
                        {
                            if (cells.Length < 3)
                            {
                                MessageBox.Show(cells[1] + "未设密码，已跳过");
                                continue;
                            }
                            User user = new User(cells[1], cells[2], false);
                            AppSetting.UserList.Add(user);
                        }
                    }
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("读取设置文件失败,加载默认配置！");
                return false;
            }
            return true;
        }
        public static List<MaterielData> ReadExcelByText()
        {
            string path = AppSetting.EXCEL_PATH;
            if (!File.Exists(path))
            {
                MessageBox.Show("物料excel表不存在，请检查！");
                return null;
            }
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding("gb2312"));
            List<MaterielData> list = new List<MaterielData>();
            try
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] cells = line.Split(',');
                        if (cells[0].Equals("111"))
                        {
                            int a = 0;
                        }
                        if (cells.Length < 18)
                        {
                            continue;
                        }
                        MaterielData data = new MaterielData();
                        data.MatNo = cells[0];
                        data.BarCode = cells[1];
                        data.Info = cells[2];
                        data.CameraAddress = cells[3];
                        data.Exposure = cells[4];
                        data.Gain = cells[5];
                        data.FindLineX = cells[6];
                        data.FindLineY = cells[7];
                        data.FindLindHigh = cells[8];
                        data.FindLineWide = cells[9];
                        data.FindLineEdge = cells[10];
                        data.FindLineThreshold = cells[11];
                        data.BarCodeX = cells[12];
                        data.BarCodeY = cells[13];
                        data.BarCodeHigh = cells[14];
                        data.BarCodeWide = cells[15];


                        data.FindLineX_100 = cells[16];
                        data.FindLineY_100 = cells[17];
                        data.FindLindHigh_100 = cells[18];
                        data.FindLineWide_100 = cells[19];
                        data.FindLineTs_100 = cells[20];
                        data.FindLineEdge_100 = cells[21];
                        data.FindLineTs_100L = cells[22];
                        data.FindLineEdge_100L = cells[23];
                        data.Limit = cells[24];
                        data.LowerLimit = cells[25];


                        list.Add(data);
                    }
                }
                fs.Flush();
                sr.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("物料excel表读取失败:" + e);
                return null;
            }
            return list;
        }
        public static bool WriteExcelByText(List<MaterielData> materielDataMap)
        {
            if (materielDataMap == null)
            {
                return false;
            }
            string path = AppSetting.EXCEL_PATH;
            string tempPath = AppSetting.EXCEL_TEMP_PATH;
            FileStream fsRead = null;
            try
            {
                fsRead = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存到excel表格失败！请先关闭Excel表格占用进程!");
                return false;
            }
            try
            {
                FileStream fsWrite = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fsRead, System.Text.Encoding.GetEncoding("gb2312"));
                StreamWriter sw = new StreamWriter(fsWrite, System.Text.Encoding.GetEncoding("gb2312"));
                string line = sr.ReadLine();
                if (line != null)
                {
                    sw.WriteLine(line);
                }
                foreach (MaterielData data in materielDataMap)
                {
                    string newLine = Replace(data);
                    sw.WriteLine(newLine);
                }

                sw.Flush();
                sw.Close();
                sr.Close();
                fsRead.Close();
                fsWrite.Close();
                File.Delete(path);
                File.Move(tempPath, path);
            }
            catch (Exception e)
            {
                MessageBox.Show("保存失败：" + e);
                return false;
            }
            MessageBox.Show("保存成功！");
            return true;
        }
        public static void WriteExcelByText(MaterielData materielData)
        {
            if (materielData == null)
            {
                return;
            }
            string path = AppSetting.EXCEL_PATH;
            string tempPath = AppSetting.EXCEL_TEMP_PATH;
            FileStream fsRead = null;
            try
            {
                fsRead = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存到excel表格失败！请先关闭Excel表格占用进程!");
                return;
            }
            try
            {
                FileStream fsWrite = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fsRead, System.Text.Encoding.GetEncoding("gb2312"));
                StreamWriter sw = new StreamWriter(fsWrite, System.Text.Encoding.GetEncoding("gb2312"));
                string line = sr.ReadLine();
                if (line != null)
                {
                    sw.WriteLine(line);
                }
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] cells = line.Split(',');
                        if (cells[0].Equals(materielData.MatNo) && cells[3].Equals(materielData.CameraAddress))
                        {
                            string newLine = Replace(materielData);
                            sw.WriteLine(newLine);
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                sw.WriteLine();
                sw.Flush();
                sw.Close();
                sr.Close();
                fsRead.Close();
                fsWrite.Close();
                File.Delete(path);
                File.Move(tempPath, path);
            }
            catch (Exception e)
            {
                MessageBox.Show("保存失败：" + e);
            }
            MessageBox.Show("保存成功！");
        }
        static string Replace(User user)
        {
            StringBuilder sb = new StringBuilder();
            Append(sb, user.IsAdmin == true ? "管理员" : "工作员");
            Append(sb, user.UserName);
            sb.Append(user.Password);
            return sb.ToString();
        }
        static string Replace(MaterielData data)
        {
            StringBuilder sb = new StringBuilder();
            Append(sb, data.MatNo);
            Append(sb, data.BarCode);
            Append(sb, data.Info);
            Append(sb, data.CameraAddress);
            Append(sb, data.Exposure);
            Append(sb, data.Gain);
            Append(sb, data.FindLineX);
            Append(sb, data.FindLineY);
            Append(sb, data.FindLindHigh);
            Append(sb, data.FindLineWide);
            Append(sb, data.FindLineEdge);
            Append(sb, data.FindLineThreshold);
            Append(sb, data.BarCodeX);
            Append(sb, data.BarCodeY);
            Append(sb, data.BarCodeHigh);
            Append(sb, data.BarCodeWide);

            Append(sb, data.FindLineX_100);
            Append(sb, data.FindLineY_100);
            Append(sb, data.FindLindHigh_100);
            Append(sb, data.FindLineWide_100);
            Append(sb, data.FindLineTs_100);
            Append(sb, data.FindLineEdge_100);
            Append(sb, data.FindLineTs_100L);
            Append(sb, data.FindLineEdge_100L);
            Append(sb, data.Limit);
            sb.Append(data.LowerLimit);
            return sb.ToString();
        }
        static void Append(StringBuilder sb, string cell)
        {
            sb.Append(cell);
            sb.Append(",");
        }

    }
}
