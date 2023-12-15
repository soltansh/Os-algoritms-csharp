using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OS
{
    class Process
    {
        public string ProcessName { get; set; }
        public int ProcessArriveTime { get; set; }
        public int ProcessServiceTime { get; set; }
        public int ProcessRemainingTime { get; set; }
        public int ProcessGetQTime { get; set; }
        public double ProcessWaitingTime { get; set; }
        public double ProcessTurnaroundTime { get; set; }
        public bool ProcessIsComplete { get; set; }
        public List<int> ProcessEnterTimeFromQueue { get; set; }
        public List<int> ProcessExitTimeFromQueue { get; set; }
        public bool is_null()
        {
            if (ProcessName == "")
                return true;
            return false;
        }
        public Process(string pn, int pa, int ps)
        {
            this.ProcessName = pn;
            this.ProcessArriveTime = pa;
            this.ProcessServiceTime = ps;
            this.ProcessWaitingTime = 0;
            this.ProcessTurnaroundTime = 0;
            this.ProcessRemainingTime = 0;
            this.ProcessGetQTime = 0;
            this.ProcessIsComplete = false;
            this.ProcessEnterTimeFromQueue = new List<int>();
            this.ProcessExitTimeFromQueue = new List<int>();
        }
        public Process()
        {
            this.ProcessName = "";
            this.ProcessArriveTime = 0;
            this.ProcessServiceTime = 0;
            this.ProcessWaitingTime = 0;
            this.ProcessTurnaroundTime = 0;
            this.ProcessRemainingTime = 0;
            this.ProcessGetQTime = 0;
            this.ProcessIsComplete = false;
            this.ProcessEnterTimeFromQueue = new List<int>();
            this.ProcessExitTimeFromQueue = new List<int>();
        }
    }
}
