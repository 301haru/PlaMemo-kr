using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PlamemoTransTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        List<string> nameCSV;
        List<string> nickCSV;
        List<string> lineCSV;

        List<string> nameCSVkr;
        List<string> nickCSVkr;
        List<string> lineCSVkr;

        int i; //줄 수


        int iTransFinish; //줄 번역끝난수

        string o_thisText; //최초 파일이름

        private void openFilecsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            string[] data;

            

            nameCSV = new List<string>();
            nickCSV = new List<string>();
            lineCSV = new List<string>();

            nameCSVkr = new List<string>();
            nickCSVkr = new List<string>();
            lineCSVkr = new List<string>();

            listBox1.Items.Clear();
            tb_line.Text = null; //대사
            tB_name.Text = null; //이름
            tB_nick.Text = null; //닉네임

            tB_lineKR.Text = null; //대사kr
            tB_nickKR.Text = null; //닉네임kr
            tB_nameKR.Text = null; //이름kr

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog1.OpenFile();
                lable_fileName.Text = openFileDialog1.SafeFileName;

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    i = 0;
                    iTransFinish = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        data = CSVParser.Split(line);

                        if (data[5].Equals("\"\""))
                        {
                            listBox1.Items.Add(i + " " + data[2].Replace("\"", ""));
                        }
                        else
                        {
                            iTransFinish++;
                            listBox1.Items.Add(i + " " + data[5].Replace("\"", ""));
                        }

                        nameCSV.Add(data[0]);
                        nickCSV.Add(data[1]);
                        lineCSV.Add(data[2]);

                        nameCSVkr.Add(data[3]);
                        nickCSVkr.Add(data[4]);
                        lineCSVkr.Add(data[5]);

                        i++;
                    }

                    o_thisText = Text;

                    Text = o_thisText + " [" + iTransFinish + "/" + i + "] " + (double)iTransFinish / (double)i * 100 + "%";
                }
            }
        }

        int index;

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                index = listBox1.SelectedIndex;

                tb_line.Text = lineCSV[index].Replace("\"", "");
                tB_name.Text = nameCSV[index].Replace("\"", "");
                tB_nick.Text = nickCSV[index].Replace("\"", "");

                tB_lineKR.Text = lineCSVkr[index].Replace("\"", "");
                tB_nameKR.Text = nameCSVkr[index].Replace("\"", "");
                tB_nickKR.Text = nickCSVkr[index].Replace("\"", "");

                //Console.WriteLine("SELECTED");
                //Console.WriteLine("name::" + nameCSV[index] + " nick::" + nickCSV[index] + " line::" + lineCSV[index]);
                //Console.WriteLine("krname::" + nameCSVkr[index] + " krnick::" + nickCSVkr[index] + " krline::" + lineCSVkr[index]);
            }
        }

        //적용버튼 눌렀을 때
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lineCSVkr[index] = "\"" + tB_lineKR.Text + "\"";
                nameCSVkr[index] = "\"" + tB_nameKR.Text + "\"";
                nickCSVkr[index] = "\"" + tB_nickKR.Text + "\"";


                if(!tB_lineKR.Text.Equals(""))
                {
                    iTransFinish++;
                    listBox1.Items[listBox1.SelectedIndex] = listBox1.SelectedIndex + " " + tB_lineKR.Text;

                    Text = o_thisText + " [" + iTransFinish + "/" + i + "] " + (double)iTransFinish / (double)i * 100 + "%";
                }
                else
                {
                    iTransFinish--;
                    listBox1.Items[listBox1.SelectedIndex] = listBox1.SelectedIndex + " " + tb_line.Text;

                    Text = o_thisText + " [" + iTransFinish + "/" + i + "] " + (double)iTransFinish / (double)i * 100 + "%";
                }
                


                //Console.WriteLine("CHANGED");
                //Console.WriteLine("name::" + nameCSV[index] + " nick::" + nickCSV[index] + " line::" + lineCSV[index]);
                //Console.WriteLine("krname::" + nameCSVkr[index] + " krnick::" + nickCSVkr[index] + " krline::" + lineCSVkr[index]);
            }
        }
        private void saveFilecsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openFileDialog1.FileName.Equals("openFileDialog1"))
            {
                using (StreamWriter writer = new StreamWriter(openFileDialog1.FileName))
                {
                    for (int i=0; i<this.i; i++)
                    {
                        writer.WriteLine(nameCSV[i] + "," + nickCSV[i] + "," + lineCSV[i] + "," + nameCSVkr[i] + "," + nickCSVkr[i] + "," + lineCSVkr[i]);
                    }

                    MessageBox.Show("저장 완료: " + openFileDialog1.FileName, "알림");
                    //Console.WriteLine("Save Complete!");
                }
            }
        }

        ChromiumWebBrowser br;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Cef.IsInitialized)
            {
                CefSettings cefSet = new CefSettings();

                cefSet.Locale = "kr";
                Cef.Initialize(cefSet);
            }
            br = new ChromiumWebBrowser("https://papago.naver.com/");
            
            groupBox3.Controls.Add(br);
        }
    }
}
