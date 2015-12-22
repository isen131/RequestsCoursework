using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Requests_Coursework
{
    public partial class MainForm : Form
    {
        string outputLine = "";
        List<Request> requests;
        List<Request> sortedRequests;
        List<Request> requestsCopy;
        Request request;
        DateTime startTime;
        DateTime endTime;
        int endMinute;
        int endHour;
        bool act = false;
        BackgroundWorker bw;

        public MainForm()
        {
            InitializeComponent();
            requests = new List<Request>();
            sortedRequests = new List<Request>();
            requestsCopy = new List<Request>();
        }

        private void GreedyAlgo(List<Request> requests, List<Request> sortedRequests)
        {
            DateTime earliestEnd = requests[0].endTime;
            int indexOfEarliest = 0;
            for (int i = 0; i < requests.Count; i++)
            {
                if (requests[i].endTime < earliestEnd)
                {
                    earliestEnd = requests[i].endTime;
                    indexOfEarliest = i;
                }
            }
            sortedRequests.Add(requests[indexOfEarliest]);
            for (int i = 0; i < requests.Count; i++)
            {
                if (requests[i].startTime < earliestEnd)
                {
                    requests.RemoveAt(i);
                    i--;
                }
            }
            if (requests.Count == 0)
                return;
            GreedyAlgo(requests, sortedRequests);
        }

        private void monotypeActions1()
        {
            sortedRequests.Clear();
            unsortedRequests_textBox.Clear();
            sortedRequests_textBox.Clear();
        }

        private void monotypeActions2()
        {
            requests.Add(request);
            for (int i = 0; i < requests.Count; i++)
            {
                requestsCopy.Add(requests[i]);
            }
            for (int i = 0; i < requests.Count; i++)
            {
                outputLine = (i + 1) + ")   " + requests[i].startTime.TimeOfDay + "  -  " + requests[i].endTime.TimeOfDay;
                unsortedRequests_textBox.Text += outputLine + Environment.NewLine;
            }
            GreedyAlgo(requestsCopy, sortedRequests);
            for (int i = 0; i < sortedRequests.Count; i++)
            {
                outputLine = (i + 1) + ")   " + sortedRequests[i].startTime.TimeOfDay + "  -  " + sortedRequests[i].endTime.TimeOfDay;
                sortedRequests_textBox.Text += outputLine + Environment.NewLine;
            }
        }

        private void AddRequest_button_Click(object sender, EventArgs e)
        {
            monotypeActions1();
            Random rnd = new Random();
            startTime = new DateTime(2015, 1, 1, rnd.Next(0, 24), rnd.Next(0, 60), 0);
            endHour = rnd.Next(startTime.Hour, 24);
            if (startTime.Hour == 23)
                endMinute = rnd.Next(startTime.Minute + 1, 61);
            else
                endMinute = rnd.Next(0, 60);
            if ((startTime.Minute >= endMinute) && (startTime.Hour == endHour) && (startTime.Hour != 23))
                endHour++;
            endTime = new DateTime(2015, 1, 1, endHour, endMinute, 0);
            request = new Request(startTime, endTime);
            monotypeActions2();
        }

        private void AddCustomRequest_button_Click(object sender, EventArgs e)
        {
            monotypeActions1();
            startTime = DateTime.Parse("2015/01/01 " + startTime_textBox.Text);
            endTime = DateTime.Parse("2015/01/01 " + endTime_textBox.Text);
            if (endTime < startTime)
                throw new Exception("Время окончания не может быть меньше начального, так как перенос на следующие сутки не допускается");
            request = new Request(startTime, endTime);
            monotypeActions2();
        }

        private void Stream()
        {
            for (int i = 0; act; i++)
            {
                monotypeActions1();
                Random rnd = new Random();
                startTime = new DateTime(2015, 1, 1, rnd.Next(0, 24), rnd.Next(0, 60), 0);
                endHour = rnd.Next(startTime.Hour, 24);
                if (startTime.Hour == 23)
                    endMinute = rnd.Next(startTime.Minute + 1, 61);
                else
                    endMinute = rnd.Next(0, 60);
                if ((startTime.Minute >= endMinute) && (startTime.Hour == endHour) && (startTime.Hour != 23))
                    endHour++;
                endTime = new DateTime(2015, 1, 1, endHour, endMinute, 0);
                request = new Request(startTime, endTime);
                monotypeActions2();
                Thread.Sleep(new TimeSpan(0, 0, 3));
                Application.DoEvents();
            }
        }

        private void startEmulator_button_Click(object sender, EventArgs e)
        {
            act = true;
            Stream();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            act = false;
        }
    }
}
