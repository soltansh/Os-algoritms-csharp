using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OS
{
    public partial class excuteForm : Form
    {
        private int _form_type = 0;
        private int _qtime = 0;
        private int _cn_switch = 0;
        private int _c_cpu = 0;
        public int form_type { get { return _form_type; } set { _form_type = value; } }
        public int qtime { get { return _qtime; } set { _qtime = value; } }
        public int cn_switch { get { return _cn_switch; } set { _cn_switch = value; } }
        public int c_cpu { get { return _c_cpu; } set { _c_cpu = value; } }

        List<Process> process_list = new List<Process>();
        public excuteForm()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            var data = from t in process_list orderby t.ProcessName select t;
            process_list = data.ToList();
            process_dgv.DataSource = data.ToList();
            process_dgv.AutoGenerateColumns = false;
            waiting_time_m_lbl.Text = $"{process_list.Count}";
            turnTime_m_lbl.Text = $"{process_list.Count}";
        }
        private void addProcess_btn_Click(object sender, EventArgs e)
        {
            AddProcess addfrm = new AddProcess();
            addfrm.pName = $"P{process_list.Count + 1}";
            addfrm.ShowDialog();
            if (addfrm.DialogResult == DialogResult.OK)
            {
                calculate_btn.Enabled = true;
                deleteProcess_btn.Enabled = true;
                Process p = new Process(addfrm.pName, addfrm.pArrive, addfrm.pService);
                process_list.Add(p);
                BindGrid();
            };
        }
        private void excuteForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            waiting_time_s_lbl.Text = "0";
            waiting_time_m_lbl.Text = "0";
            turnTime_s_lbl.Text = "0";
            turnTime_m_lbl.Text = "0";
            switch (form_type)
            {
                case 1:
                    Text = "First Come First Service";
                    break;
                case 2:
                    Text = "Shortest Remaining Time";
                    break;
                case 3:
                    Text = "Shortest Job First";
                    break;
                case 4:
                    Text = "Round Robin";
                    break;
                case 5:
                    Text = "Multi CPU";
                    break;
            }
        }
        private void refreesh_btn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void deleteProcess_btn_Click(object sender, EventArgs e)
        {
            if (process_dgv.CurrentCell.Selected)
            {
                var temp_pros_list = from x in process_list orderby x.ProcessName select x;
                process_list = temp_pros_list.ToList();
                string processName = process_dgv.CurrentRow.Cells[0].Value.ToString();
                var process = process_list.Find(item => item.ProcessName == processName);
                int item_index = process_list.IndexOf(process);
                for (int i = item_index + 1; i < process_list.Count; i++)
                {
                    process_list[i].ProcessName = $"P{i}";
                }
                process_list.Remove(process);
                BindGrid();
            }
            if (process_list.Count == 0)
            {
                calculate_btn.Enabled = false;
                deleteProcess_btn.Enabled = false;
            }
            else
            {
                deleteProcess_btn.Enabled = true;
            }
        }
        private void calculate_btn_Click(object sender, EventArgs e)
        {
            calculate_btn.Enabled = false;
            switch (form_type)
            {
                case 1:
                    FCFS();
                    break;
                case 2:
                    SRT();
                    break;
                case 3:
                    SJF();
                    break;
                case 4:
                    RR();
                    break;
                case 5:
                    MCPU();
                    break;
            }
        }
        private void FCFS()
        {
            var temp_list = (
                from x in process_list
                where x.ProcessIsComplete == false
                orderby x.ProcessArriveTime, x.ProcessName
                select x
            ).ToList();
            foreach (var item in temp_list)
            {
                item.ProcessRemainingTime = item.ProcessServiceTime;
            }
            int current_time = temp_list[0].ProcessArriveTime;
            foreach (var item in temp_list)
            {
                item.ProcessWaitingTime = current_time - item.ProcessArriveTime;
                current_time += item.ProcessServiceTime;
                item.ProcessIsComplete = true;
                item.ProcessRemainingTime = 0;
            }
            // witing time calculated
            double total_waiting_time = 0;
            int total_service_time = 0;
            foreach (var item in process_list)
            {
                total_waiting_time += (double)item.ProcessWaitingTime;
                total_service_time += (int)item.ProcessServiceTime;
                item.ProcessTurnaroundTime = (double)item.ProcessWaitingTime + (double)item.ProcessServiceTime;
            }
            waiting_time_s_lbl.Text = $"{total_waiting_time}";
            turnTime_s_lbl.Text = $"{total_service_time + total_waiting_time}";
            BindGrid();
        }
        private void SRT()
        {
            var temp_list = (
                from x in process_list
                where x.ProcessIsComplete == false
                orderby x.ProcessArriveTime, x.ProcessServiceTime, x.ProcessName
                select x
            ).ToList();
            int total_runtime = 0;
            foreach (var item in temp_list)
            {
                item.ProcessRemainingTime = item.ProcessServiceTime;
                total_runtime += item.ProcessServiceTime;
                item.ProcessEnterTimeFromQueue.Add(item.ProcessArriveTime);
            }
            List<Process> temp_process_time_line = new List<Process>();
            bool check_remain_runtime = false;
            Process current_process = new Process();

            for (int i = 0; i < total_runtime; i++)
            {
                int before_count_temp_list = temp_process_time_line.Count;
                foreach (var item in temp_list)
                {
                    if (item.ProcessArriveTime == i)
                    {
                        temp_process_time_line.Add(item);
                        check_remain_runtime = true;
                    }
                }
                if (temp_process_time_line.Count == before_count_temp_list)
                {
                    check_remain_runtime = false;
                }
                var x = temp_process_time_line.Find(p => p.ProcessName == current_process.ProcessName);
                if (x == null)
                {
                    check_remain_runtime = true;
                }
                if (check_remain_runtime)
                {
                    if (temp_process_time_line.Count != 0)
                    {
                        int min_rimain_time = temp_process_time_line[0].ProcessRemainingTime;
                        var current_process_before_change = temp_process_time_line[0];

                        var process_after_change = temp_process_time_line[0];
                        for (int j = 0; j < temp_process_time_line.Count; j++)
                        {
                            var temp_pro = temp_process_time_line[j];
                            if (temp_pro.ProcessRemainingTime < min_rimain_time)
                            {
                                min_rimain_time = temp_pro.ProcessRemainingTime;
                                process_after_change = temp_pro;
                            }

                        }
                        foreach (var pro in temp_process_time_line)
                        {
                            if (pro.ProcessName != process_after_change.ProcessName)
                            {
                                temp_list.Find(p => p.ProcessName == pro.ProcessName).ProcessExitTimeFromQueue.Add(i);
                            }
                        }
                        temp_list.Find(p => p.ProcessName == process_after_change.ProcessName).ProcessEnterTimeFromQueue.Add(i);
                        if (current_process_before_change != process_after_change)
                        {
                            if (current_process.ProcessIsComplete == false)
                            {
                                temp_list.Find(p => p.ProcessName == current_process.ProcessName).ProcessExitTimeFromQueue.Add(i);
                            }
                            current_process = process_after_change;
                        }
                        else
                        {
                            current_process = process_after_change;
                        }
                        current_process.ProcessRemainingTime -= 1;

                        if (current_process.ProcessRemainingTime == 0)
                        {
                            current_process.ProcessIsComplete = true;
                            temp_process_time_line.Remove(current_process);
                            temp_list.Find(p => p.ProcessName == current_process.ProcessName).ProcessExitTimeFromQueue.Add(i + 1);
                        }
                    }
                }
                else
                {
                    if (current_process.ProcessName != "")
                    {
                        current_process.ProcessRemainingTime -= 1;
                        if (current_process.ProcessRemainingTime == 0)
                        {
                            current_process.ProcessIsComplete = true;
                            temp_process_time_line.Remove(current_process);
                            temp_list.Find(p => p.ProcessName == current_process.ProcessName).ProcessExitTimeFromQueue.Add(i + 1);
                        }
                    }
                }
            }
            foreach (var item in temp_list)
            {
                item.ProcessEnterTimeFromQueue = item.ProcessEnterTimeFromQueue.Distinct().ToList();
                item.ProcessExitTimeFromQueue = item.ProcessExitTimeFromQueue.Distinct().ToList();
            }
            foreach (var process in temp_list)
            {
                var wait = 0;
                for (int i = 0; i < process.ProcessEnterTimeFromQueue.Count; i++)
                {
                    try
                    {
                        wait += process.ProcessEnterTimeFromQueue[i + 1] - process.ProcessExitTimeFromQueue[i];
                    }
                    catch (Exception)
                    {
                        ;
                    }
                }
                process_list.Find(p => p.ProcessName == process.ProcessName).ProcessWaitingTime = wait;
            }
            // witing time calculated
            double total_waiting_time = 0;
            int total_service_time = 0;
            foreach (var item in process_list)
            {
                total_waiting_time += (double)item.ProcessWaitingTime;
                total_service_time += (int)item.ProcessServiceTime;
                item.ProcessTurnaroundTime = (double)item.ProcessWaitingTime + (double)item.ProcessServiceTime;
            }
            waiting_time_s_lbl.Text = $"{total_waiting_time}";
            turnTime_s_lbl.Text = $"{total_service_time + total_waiting_time}";
            BindGrid();
        }
        private void SJF()
        {
            var temp_list = (
                from x in process_list
                where x.ProcessIsComplete == false
                orderby x.ProcessArriveTime, x.ProcessServiceTime
                select x
            ).ToList();
            foreach (var item in temp_list)
            {
                item.ProcessRemainingTime = item.ProcessServiceTime;
            }
            int current_time = temp_list[0].ProcessArriveTime;
            foreach (var item in temp_list)
            {
                item.ProcessWaitingTime = current_time - item.ProcessArriveTime;
                current_time += item.ProcessServiceTime;
                item.ProcessIsComplete = true;
                item.ProcessRemainingTime = 0;
            }
            // witing time calculated
            double total_waiting_time = 0;
            int total_service_time = 0;
            foreach (var item in process_list)
            {
                total_waiting_time += (double)item.ProcessWaitingTime;
                total_service_time += (int)item.ProcessServiceTime;
                item.ProcessTurnaroundTime = (double)item.ProcessWaitingTime + (double)item.ProcessServiceTime;
            }
            waiting_time_s_lbl.Text = $"{total_waiting_time}";
            turnTime_s_lbl.Text = $"{total_service_time + total_waiting_time}";
            BindGrid();
        }
        private void RR()
        {
            var temp_list = (
                from x in process_list
                where x.ProcessIsComplete == false
                orderby x.ProcessArriveTime, x.ProcessName
                select x
            ).ToList();
            foreach (var item in temp_list)
            {
                item.ProcessRemainingTime = item.ProcessServiceTime;
                item.ProcessEnterTimeFromQueue.Add(item.ProcessArriveTime);
            }

            List<Process> temp_process_time_line_list = new List<Process>();
            Process temp_process = new Process();
            Process curennt_process = new Process();

            // my time line
            int time_line = 0;

            double total_waiting_time = 0;
            int total_service_time = 0;
            bool is_complate = false;

            while (!is_complate)
            {
                bool is_rev = false;
                bool is_add_more_than_one_item = false;
                int count_add_item = 0;
                if (temp_process_time_line_list.Count != 0)
                {
                    temp_process_time_line_list.Reverse();
                    is_rev = true;
                }
                foreach (var item in temp_list)
                    if (item.ProcessArriveTime <= time_line)
                    {
                        temp_process_time_line_list.Add(item);
                        count_add_item += 1;
                    }
                if (is_rev)
                    temp_process_time_line_list.Reverse();

                if (count_add_item > 1)
                {
                    is_add_more_than_one_item = true;
                    count_add_item = 0;
                }

                if (is_add_more_than_one_item)
                {
                    for (int i = 1; i < temp_process_time_line_list.Count; i++)
                    {
                        temp_process_time_line_list[i].ProcessExitTimeFromQueue.Add(time_line);
                        temp_process_time_line_list[i].ProcessGetQTime = 0;
                    }
                }

                foreach (var i in temp_process_time_line_list)
                {
                    var tt = temp_list.FirstOrDefault(item => i.ProcessName == item.ProcessName);
                    if (tt != null)
                        temp_list.Remove(tt);
                }

                if (!curennt_process.is_null() && temp_process_time_line_list.Count != 0)
                {
                    if (temp_process_time_line_list[0] != curennt_process)
                    {
                        // add (context_switch) second to all the process
                        for (int i = 0; i < temp_process_time_line_list.Count; i++)
                        {
                            temp_process_time_line_list[i].ProcessWaitingTime += _cn_switch;
                        }
                        temp_process_time_line_list[0].ProcessEnterTimeFromQueue.Add(time_line);
                        curennt_process.ProcessExitTimeFromQueue.Add(time_line);
                        curennt_process.ProcessGetQTime = 0;
                        temp_process_time_line_list[0].ProcessGetQTime = 0;
                        time_line += _cn_switch;
                    }
                }
                // 1 second later
                time_line += 1;
                // ############### /////////////////////////////////////// before context_switch
                if (temp_process_time_line_list.Count != 0)
                {
                    curennt_process = temp_process_time_line_list[0];

                    temp_process_time_line_list[0].ProcessRemainingTime -= 1;
                    temp_process_time_line_list[0].ProcessGetQTime += 1;

                    // Process Remaining Time is 0
                    if (temp_process_time_line_list[0].ProcessRemainingTime == 0)
                    {
                        temp_process_time_line_list[0].ProcessIsComplete = true;
                        temp_process_time_line_list[0].ProcessGetQTime = 0;
                        temp_process_time_line_list.Remove(temp_process_time_line_list[0]);
                        if (temp_process_time_line_list.Count == 0 && temp_list.Count == 0)
                        {
                            curennt_process.ProcessExitTimeFromQueue.Add(time_line);
                            is_complate = true;
                            break;
                        }
                    }
                    else // Process Remaining Time is not 0 yet
                    {
                        if (temp_process_time_line_list[0].ProcessGetQTime % qtime == 0) // Process shift To End of The List
                        {
                            temp_process = temp_process_time_line_list[0];
                            temp_process.ProcessGetQTime = 0;
                            temp_process_time_line_list.RemoveAt(0);
                            temp_process_time_line_list.Add(temp_process);
                            temp_process = new Process();
                        }
                    }
                }

            } // End While

            foreach (var item in process_list)
            {
                item.ProcessEnterTimeFromQueue = item.ProcessEnterTimeFromQueue.Distinct().ToList();
                item.ProcessExitTimeFromQueue = item.ProcessExitTimeFromQueue.Distinct().ToList();
            }
            foreach (var process in process_list)
            {
                var wait = 0;
                if (process.ProcessExitTimeFromQueue.Count == 1)
                {
                    wait += process.ProcessEnterTimeFromQueue.Last();
                }
                else
                {
                    for (int i = 0; i < process.ProcessEnterTimeFromQueue.Count; i++)
                    {
                        try
                        {
                            wait += process.ProcessEnterTimeFromQueue[i + 1] - process.ProcessExitTimeFromQueue[i];
                        }
                        catch (Exception)
                        {
                            ;
                        }
                    }
                }

                process_list.Find(p => p.ProcessName == process.ProcessName).ProcessWaitingTime += wait;
            }

            // witing time calculated
            foreach (var item in process_list)
            {
                total_waiting_time += (double)item.ProcessWaitingTime;
                total_service_time += (int)item.ProcessServiceTime;
                item.ProcessTurnaroundTime = (double)item.ProcessWaitingTime + (double)item.ProcessServiceTime;
            }
            waiting_time_s_lbl.Text = $"{total_waiting_time}";
            turnTime_s_lbl.Text = $"{total_service_time + total_waiting_time}";
            BindGrid();
        }
        private void MCPU()
        {
            var temp_list = (
                from x in process_list
                where x.ProcessIsComplete == false
                orderby x.ProcessArriveTime, x.ProcessName
                select x
            ).ToList();
            foreach (var item in temp_list)
            {
                item.ProcessRemainingTime = item.ProcessServiceTime;
            }

            List<List<Process>> cpus_list = new List<List<Process>>();

            for (int i = 0; i < c_cpu; i++)
            {
                List<Process> cpu = new List<Process>();
                cpus_list.Add(cpu);
            }
            // cpus_list[0] => cpu_0 ..... cpus_list[n] => cpu_n

            int timeline = 0;
            bool is_all_cpu_empty = false;
            while (true)
            {
                var temp_current_process = new Process();

                for (int i = 0; i < cpus_list.Count; i++)
                {
                    foreach (var item in temp_list)
                    {
                        if (item.ProcessArriveTime <= timeline)
                        {
                            if (cpus_list[i].Count == 0)
                            {
                                cpus_list[i].Add(item);
                                temp_current_process = item;
                                break;
                            }
                        }
                    }
                    try
                    {
                        temp_list.Remove(temp_current_process);
                        temp_current_process = new Process();
                    }
                    catch (Exception)
                    {
                        ;
                    }
                }
                foreach (var item in temp_list)
                {
                    if (item.ProcessArriveTime <= timeline)
                    {
                        item.ProcessWaitingTime += 1;
                    }
                }

                for (int i = 0; i < cpus_list.Count; i++)
                {
                    try
                    {
                        cpus_list[i][0].ProcessRemainingTime -= 1;
                        if (cpus_list[i][0].ProcessRemainingTime == 0)
                        {
                            cpus_list[i][0].ProcessIsComplete = true;
                            cpus_list[i].RemoveAt(0);
                        }
                    }
                    catch (Exception)
                    {
                        ;
                    }
                }

                timeline += 1;

                for (int i = 0; i < cpus_list.Count; i++)
                {
                    if (cpus_list[i].Count == 0)
                    {
                        is_all_cpu_empty = true;
                    }
                    else
                    {
                        is_all_cpu_empty = false;
                    }
                }
                if (temp_list.Count == 0 && is_all_cpu_empty)
                {
                    break; // break while loop
                }
            } // end while

            double total_waiting_time = 0;
            int total_service_time = 0;
            foreach (var item in process_list)
            {
                total_waiting_time += (double)item.ProcessWaitingTime;
                total_service_time += (int)item.ProcessServiceTime;
                item.ProcessTurnaroundTime = (double)item.ProcessWaitingTime + (double)item.ProcessServiceTime;
            }
            waiting_time_s_lbl.Text = $"{total_waiting_time}";
            turnTime_s_lbl.Text = $"{total_service_time + total_waiting_time}";
            BindGrid();

        }
        private void sort_by_alg_btn_Click(object sender, EventArgs e)
        {
            switch (form_type)
            {
                case 1:
                    var data = from t in process_list orderby t.ProcessArriveTime, t.ProcessName select t;
                    process_dgv.DataSource = data.ToList();
                    process_dgv.AutoGenerateColumns = false;
                    break;
                case 2:
                    var data1 = from t in process_list orderby t.ProcessArriveTime, t.ProcessServiceTime, t.ProcessName select t;
                    process_dgv.DataSource = data1.ToList();
                    process_dgv.AutoGenerateColumns = false;
                    break;
                case 3:
                    var data2 = from t in process_list orderby t.ProcessArriveTime, t.ProcessServiceTime select t;
                    process_dgv.DataSource = data2.ToList();
                    process_dgv.AutoGenerateColumns = false;
                    break;
                case 4:
                    var data3 = from t in process_list orderby t.ProcessArriveTime, t.ProcessName select t;
                    process_dgv.DataSource = data3.ToList();
                    process_dgv.AutoGenerateColumns = false;
                    break;
                case 5:
                    var data4 = from t in process_list orderby t.ProcessArriveTime, t.ProcessName select t;
                    process_dgv.DataSource = data4.ToList();
                    process_dgv.AutoGenerateColumns = false;
                    break;
            }
        }
    }
}
