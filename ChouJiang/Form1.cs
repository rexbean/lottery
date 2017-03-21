using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChouJiang
{
    public partial class MainForm : Form
    {
        int i = 0;
        int j = 0;

        string DepAName = null;
        string DepBName = null;
        string DepCName = null;
        string DepDName = null;

        List<String> DepAStaff = new List<string>();
        List<String> DepBStaff = new List<string>();
        List<String> DepCStaff = new List<string>();
        List<String> DepDStaff = new List<string>();

        List<String> CurrentList;

        List<Label> RewardLabelList = new List<Label>();

        Label CurrentLabel;

        List<List<String>> allList = new List<List<string>>();

        public MainForm()
        {
            InitializeComponent();
            SetForm();
            SetLabel();
            ReadFileIn();
            SetComboBox();
            SetList();
        }

        private void SetForm()
        {
            string path = Application.StartupPath+"\\bg.jpg";
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            int windowWidth = rect.Width;
            int windowHeight = rect.Height;
            this.Width = windowWidth;
            this.Height = windowHeight;
            this.BackgroundImage = System.Drawing.Image.FromFile(path);
        }

        private void SetLabel()
        {
            

            DepLabel.Location = new Point(this.Width / 4,this.Height/6);
            DepLabel.Font = new Font(DepLabel.Font.FontFamily, 40, FontStyle.Bold);

            TitleLabel.Location = new Point(DepLabel.Location.X - 170, DepLabel.Location.Y - 100);
            TitleLabel.Font = new Font(DepLabel.Font.FontFamily, 55, FontStyle.Bold);

            CurrentStaffLabel.Location=new Point(DepLabel.Location.X,DepLabel.Location.Y+90);
            CurrentStaffLabel.Font = new Font(DepLabel.Font.FontFamily, 40, FontStyle.Bold);

            AllLabel.Location = new Point(CurrentStaffLabel.Location.X+370, CurrentStaffLabel.Location.Y);
            AllLabel.Font= new Font(DepLabel.Font.FontFamily, 40, FontStyle.Bold);

            RewardStaffLabel.Location = new Point(CurrentStaffLabel.Location.X, CurrentStaffLabel.Location.Y+90);
            RewardStaffLabel.Font=new Font(DepLabel.Font.FontFamily, 40, FontStyle.Bold);

            FirstLabel.Location = new Point(AllLabel.Location.X, AllLabel.Location.Y + 90);
            SecondLabel.Location = new Point(FirstLabel.Location.X, FirstLabel.Location.Y + 90);
            ThirdLabel.Location = new Point(SecondLabel.Location.X, SecondLabel.Location.Y + 90);

            StartButton.Location = new Point(CurrentStaffLabel.Location.X, ThirdLabel.Location.Y + 90);
            StartButton.Font = new Font(DepLabel.Font.FontFamily, 30, FontStyle.Bold);
            StartButton.Size = new Size(150, 60);

            StopButton.Location = new Point(StartButton.Location.X + 600, ThirdLabel.Location.Y + 90);
            StopButton.Font = new Font(DepLabel.Font.FontFamily, 30, FontStyle.Bold);
            StopButton.Size = new Size(150, 60);

 
        }

        private void ReadFileIn()
        {
            string path = Application.StartupPath+"\\Staff.txt";
            string strLine=null;
            string[] readArray=null;
            string[] readArraySub = null;
            string titleName = null;
            try
            {
                FileStream aFile = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(aFile);

                strLine = sr.ReadLine();
                titleName = strLine;
                this.TitleLabel.Text = titleName;
                
                strLine = sr.ReadLine();
                readArray = strLine.Split(' ');
                
                this.DepAName = readArray[0];
                this.DepBName = readArray[1];
                this.DepCName = readArray[2];
                this.DepDName = readArray[3];

                strLine = sr.ReadLine();

                while (strLine != null)
                {
                    readArraySub = strLine.Split(',');
                    if(readArraySub[1]==DepAName)
                    {
                        DepAStaff.Add(readArraySub[0]);   
                    }
                    if(readArraySub[1]==DepBName)
                    {
                        DepBStaff.Add(readArraySub[0]);   
                    }
                    if(readArraySub[1]==DepCName)
                    {
                        DepCStaff.Add(readArraySub[0]);   
                    }
                    if(readArraySub[1]==DepDName)
                    {
                        DepDStaff.Add(readArraySub[0]);   
                    }
                    strLine = sr.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("读取错误！");
            }
            allList.Add(DepAStaff);
            allList.Add(DepBStaff);
            allList.Add(DepCStaff);
            allList.Add(DepDStaff);

        }

        private void SetComboBox()
        {
            DepComBox.Location = new Point(DepLabel.Location.X + 380, DepLabel.Location.Y);
            DepComBox.Font = new Font(DepLabel.Font.FontFamily, 38, FontStyle.Bold);
            DepComBox.Items.Add(DepAName);
            DepComBox.Items.Add(DepBName);
            DepComBox.Items.Add(DepCName);
            DepComBox.Items.Add(DepDName);

            DepComBox.SelectedIndex = 0;
            this.CurrentList = DepAStaff;

        }

        private void SetList()
        {
            RewardLabelList.Add(FirstLabel);
            RewardLabelList.Add(SecondLabel);
            RewardLabelList.Add(ThirdLabel);

            foreach (Label lb in RewardLabelList)
            {
                lb.Font = new Font(DepLabel.Font.FontFamily, 40, FontStyle.Bold);
            }

        }

        void timer1_Tick(object sender, EventArgs e)
        {
            
            if (this.i >= this.CurrentList.Count-1)
            {
                this.i = 0;
            }
            else
            {
                this.i++;
            }
            AllLabel.Text = this.CurrentList[this.i];

        }

        

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            StartButton.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.j++;
            if (this.j != 3)
            {
                this.CurrentLabel = RewardLabelList[j - 1];
                this.CurrentLabel.Text = CurrentList[i];
                this.CurrentList.RemoveAt(i);
                
            }
            else
            {
                this.CurrentLabel = RewardLabelList[j - 1];
                this.CurrentLabel.Text = CurrentList[i];
                this.CurrentList.RemoveAt(i);
                timer1.Stop();
                StopButton.Enabled = false;
            }

        }

        private void DepComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.i = 0;
            this.j = 0;
            int index = DepComBox.SelectedIndex;
            CurrentList = allList[index];
            StartButton.Enabled = true;
            StopButton.Enabled = true;

            AllLabel.Text = "";
            foreach (Label tb in RewardLabelList)
            {
                tb.Text = "";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DepComBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = true;

        }
    }
}
