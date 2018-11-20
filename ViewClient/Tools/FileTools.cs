﻿using System;
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
                    }
                }
                sr.Close();
                fs.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("读取设置文件失败,加载默认配置！");
                return false;
            }
            return true;
        }

       public static List<MaterielData> ReadExcelByText(string MatNo)
        {
            string path = AppSetting.EXCEL_PATH;
            if (!File.Exists(path))
            {
                MessageBox.Show("物料excel表不存在，请检查！");
                return null;
            }
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.GetEncoding("gb2312"));
            List<MaterielData> listDatas = new List<MaterielData>();
            try
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] cells = line.Split(',');
                        if (cells[0].Equals(MatNo))
                        {
                            MaterielData data = new MaterielData();
                            data.MatNo = MatNo;
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
                            data.Limit = cells[16];
                            data.LowerLimit = cells[17];

                            listDatas.Add(data);
                        }
                    }
                }
                sr.Close();
                fs.Close();
            }catch(Exception e)
            {
                MessageBox.Show("物料excel表读取失败:"+e);
                return null;
            }
            return listDatas;
        }

        public static void WriteExcelByText(MaterielData materielData)
        {
            if (materielData == null)
            {
                return;
            }
            string path = AppSetting.EXCEL_PATH;
            string tempPath = AppSetting.EXCEL_TEMP_PATH;
            FileStream fsRead=null;
            try
            {
                 fsRead = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Delete);
            }catch(Exception ex)
            {
                MessageBox.Show("保存到excel表格失败！请先关闭Excel表格占用进程!");
                return;
            }
            FileStream fsWrite = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fsRead, System.Text.Encoding.GetEncoding("gb2312"));
            StreamWriter sw = new StreamWriter(fsWrite, System.Text.Encoding.GetEncoding("gb2312"));
            string line = sr.ReadLine();
            if (line != null)
            {
                sw.Write(line);
                sw.WriteLine();
            }
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {  
                    string[] cells = line.Split(',');
                    if (cells[0].Equals(materielData.MatNo)&&cells[3].Equals(materielData.CameraAddress))
                    {
                        string newLine = Replace(materielData);
                        sw.Write(newLine);
                    }
                    else
                    { 
                        sw.Write(line);
                    }
                    sw.WriteLine();
                }
            }
            sw.Flush();
            sw.Close();
            sr.Close();
            fsRead.Close();
            fsWrite.Close();
            File.Delete(path);
            File.Move(tempPath, path);

        }
        static string Replace(MaterielData data)
        {
            StringBuilder sb = new StringBuilder();
            Append(sb,data.MatNo );
            Append(sb,data.BarCode );
            Append(sb,data.Info );
            Append(sb,data.CameraAddress );
            Append(sb,data.Exposure );
            Append(sb,data.Gain );
            Append(sb,data.FindLineX );
            Append(sb,data.FindLineY );
            Append(sb,data.FindLindHigh );
            Append(sb,data.FindLineWide );
            Append(sb,data.FindLineEdge );
            Append(sb,data.FindLineThreshold );
            Append(sb,data.BarCodeX );
            Append(sb,data.BarCodeY );
            Append(sb,data.BarCodeHigh );
            Append(sb,data.BarCodeWide );
            Append(sb,data.Limit );
            sb.Append(data.LowerLimit);
            return sb.ToString();
        }
        static void Append(StringBuilder sb,string cell)
        {
            sb.Append(cell);
            sb.Append(",");
        }

    }
}
