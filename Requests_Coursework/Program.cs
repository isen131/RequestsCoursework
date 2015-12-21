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
                Request rq = new Request(int.Parse(tmp[0]), DateTime.Parse(tmp[1] + " " + tmp[2]), DateTime.Parse(tmp[3] + " " + tmp[4]));
                requests.Add(rq);
            }
        }

        static void GreedyAlgo(List<Request> requests, List<Request> sortedRequests)
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

        static void Main(string[] args)
        {
            List<Request> requests = new List<Request>();
            StreamReader sr = new StreamReader("requests.txt");
            FillRequests(sr, requests);
            for (int i = 0; i < requests.Count; i++)
            {
                Console.WriteLine(requests[i].number + " " + requests[i].startTime + "  -  " + requests[i].endTime);
            }
            Console.WriteLine();
            List<Request> sortedRequests = new List<Request>();
            GreedyAlgo(requests, sortedRequests);
            for (int i = 0; i < sortedRequests.Count; i++)
            {
                Console.WriteLine(sortedRequests[i].number + " " + sortedRequests[i].startTime + "  -  " + sortedRequests[i].endTime);
            }
            Console.ReadKey();
        }
    }
}
