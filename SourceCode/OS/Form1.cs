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
    public partial class osForm : Form
    {
        public osForm()
        {
            InitializeComponent();
        }
        private void fcfs_btn_Click(object sender, EventArgs e)
        {
            excuteForm frm = new excuteForm();
            frm.form_type = 1;
            frm.ShowDialog();
        }
        private void srt_btn_Click(object sender, EventArgs e)
        {
            excuteForm frm = new excuteForm();
            frm.form_type = 2;
            frm.ShowDialog();
        }
        private void sjf_btn_Click(object sender, EventArgs e)
        {
            excuteForm frm = new excuteForm();
            frm.form_type = 3;
            frm.ShowDialog();
        }
        private void rr_btn_Click(object sender, EventArgs e)
        {
            q_time frm = new q_time();
            frm.ShowDialog();
        }

        private void mcpu_btn_Click(object sender, EventArgs e)
        {
            CpuCounter frm = new CpuCounter();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
