using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Start_Close_Manager
{
    public partial class Form1 : Form
    {

        #region Var

        string scheduleTimeTxtFile  = "ScheduleTime.txt";
        string logTxtFile           = "ActivityLog.txt";

        List<SchedulTimer> exeStartTimes    = new List<SchedulTimer>();
        List<SchedulTimer> exeEndTimes      = new List<SchedulTimer>();

        #endregion vars

        public Form1()
        {
            InitializeComponent();
            FillExeStartEndTimeListFromTextFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CreatingNewTimerThread();
            CheckExeIsOpen(tbExeName.Text);
        }

        #region CustomMethods

        private void CreatingNewTimerThread()
        {
            Thread thred = new Thread(new ThreadStart(MyTimer));
            thred.Start();
            thred.IsBackground = true;
        }

        private void MyTimer()
        {
            DateTime time;

            while (true)
            {

                time = DateTime.Now;
                int hour = time.Hour;
                int minute = time.Minute;

                //testing condition
                /*if (hour == 10 && minute == 33)
                {

                    //ShowEventTimeOnLable(time.ToString());//setting value of lable, Thread example

                    if (CheckExeIsOpen(tbExeName.Text) == false)
                    {
                        Process.Start(tbExeLocation.Text + tbExeName.Text);
                    }

                }*/
                try
                {

                    //This loop wil check the timing.
                    for (int i = 0; i < exeStartTimes.Count; i++)
                    {
                        if (hour == exeStartTimes[i].hour && minute == exeStartTimes[i].minute)
                        {
                            if (CheckExeIsOpen(tbExeName.Text) == false)
                            {
                                Process p = new Process();
                                p.StartInfo.FileName = (tbExeLocation.Text + tbExeName.Text);
                                p.Start();
                                AppendLogFile("Started " + tbExeLocation.Text + tbExeName.Text + " on " + time);
                            }
                        }

                        if (hour == exeEndTimes[i].hour && minute == exeEndTimes[i].minute)
                        {
                            if (CheckExeIsOpen(tbExeName.Text) == true)
                            {
                                CloseExe(tbExeName.Text);
                                AppendLogFile("Closed " + tbExeName.Text + time);

                            }
                        }

                    }

                    /*
                    for (int i = 0; i < exeEndTimes.Count; i++)
                    {
                        if (hour == exeEndTimes[i].hour && minute == exeEndTimes[i].minute)
                        {
                            if (CheckExeIsOpen(tbExeName.Text) == true)
                            {
                                //Process.Start(tbExeLocation.Text + tbExeName.Text);
                                CloseExe(tbExeName.Text);
                                AppendLogFile("Closed " + tbExeName.Text + time);

                            }
                        }

                    }*/

                }
                catch (Win32Exception w) {
                    MessageBox.Show("Error occured : " + w.Message);
                    AppendLogFile("message      :   " + w.Message);
                    AppendLogFile("ErrorCode    :   " + w.ErrorCode.ToString());
                    AppendLogFile("Native       :   " +w.NativeErrorCode.ToString());
                    AppendLogFile("StackTrace   :   " + w.StackTrace);
                    AppendLogFile("Source       :   " + w.Source);
                    Exception e = w.GetBaseException();
                    AppendLogFile(e.Message);
                }
            }
        }

        private bool CheckExeIsOpen(string exeName)
        {
            string name = exeName.Split('.')[0];
            foreach (var process in Process.GetProcesses())
            {

                if (process.ProcessName == name)//process name matched return true appliation is open
                {
                    return true;
                }

            }
            return false;//process name not matched return false appliation is closed
        }

        private void CloseExe(string exeName)
        {
            string name = exeName.Split('.')[0];
            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName == name)
                {
                    process.Kill();
                    process.WaitForExit();
                    AppendLogFile(tbExeName.Text + " Closed on " + DateTime.Now);
                }
            }
        }

        /// <summary>
        /// Get  Applicaton start/close time from the text file and fill this data into array.
        /// </summary>
        private void FillExeStartEndTimeListFromTextFile()
        {


            string[] scheduleData = File.ReadAllLines(scheduleTimeTxtFile);
            tbExeLocation.Text = scheduleData[0];
            tbExeName.Text = scheduleData[1];

            for (int i = 2; i < scheduleData.Length; i++)
            {
                if (scheduleData[i].Contains(","))
                {
                    string[] time = scheduleData[i].Split(',');

                    string[] exeStartHourMin = time[0].Split(':');
                    SchedulTimer timerStartExe = new SchedulTimer(int.Parse(exeStartHourMin[0]), int.Parse(exeStartHourMin[1]));

                    string[] exeEndHourMin = time[1].Split(':');
                    SchedulTimer timerEndExe = new SchedulTimer(int.Parse(exeEndHourMin[0]), int.Parse(exeEndHourMin[1]));

                    exeStartTimes.Add(timerStartExe);
                    exeEndTimes.Add(timerEndExe);

                    //For display purpose only
                    lbApplicationStartTime.Items.Add(time[0]);
                    lbApplicationEndTime.Items.Add(time[1]);



                }
                else
                {
                    MessageBox.Show("Schedule Time in text file (" + scheduleTimeTxtFile + ") not in a correct format. Application Quit");
                    Application.Exit();
                }

            }

            //lbApplicationStartTime.DataSource = exeStartTimes;


            //lbApplicationEndTime.DataSource = exeEndTimes;
        }

        /// <summary>
        /// Append text in text file
        /// </summary>
        /// <param name="fileContent"></param>
        private void AppendLogFile(string fileContent)
        {
            File.AppendAllText(logTxtFile, fileContent + Environment.NewLine);
        }

        /*delegate void MyDelegate(string str);

        private void ShowEventTimeOnLable(string time)
        {
            if (lblTimeTest.InvokeRequired)
            {
                this.label1.Invoke(new MyDelegate(ShowEventTimeOnLable), new object[] { time });
            }
            else
            {
                lblTimeTest.Text += time.ToString();
                lbApplicationStartTime.Items.Add(time.ToString());
            }

        }*/

        #endregion

        class SchedulTimer
        {

            public int hour;
            public int minute;

            public SchedulTimer(int hour, int minute)
            {
                this.hour = hour;
                this.minute = minute;
            }
        }

    }
}
