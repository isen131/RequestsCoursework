using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Requests_Coursework
{
    public class Request
    {
        public int number;
        public DateTime startTime;
        public DateTime endTime;
        public Request(int number, DateTime startTime, DateTime endTime)
        {
            this.number = number;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }

    class Program
    {
        static void FillRequests(StreamReader sr, List<Request> requests)
        {
            string[] lines = sr.ReadToEnd().Split(new char[] { '\n' });
            for (int i = 0; i < lines.Length; i++)
            {
                string[] tmp = lines[i].Split();
                Request rq = new Request(int.Parse(tmp[0]), DateTime.Parse(tmp[1]), DateTime.Parse(tmp[2]));
                requests.Add(rq);
            }
        }

        static List<Request> GreedyAlgo(List<Request> requests)
        {
            List<Request> sortedRequests = requests;
            DateTime earliestEnd = sortedRequests[0].endTime;
            for (int i = 0; i < sortedRequests.Count; i++)
            {
                if (sortedRequests[i].endTime < earliestEnd)
                    earliestEnd = sortedRequests[i].endTime;
            }
        }

        static void Main(string[] args)
        {
            List<Request> requests = new List<Request>();
            StreamReader sr = new StreamReader("requests.txt");
            FillRequests(sr, requests);
            GreedyAlgo();
        }
    }
}
