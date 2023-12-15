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
    public partial class q_time : Form
    {
        public q_time()
        {
            InitializeComponent();
        }

        private void q_time_btn_Click(object sender, EventArgs e)
        {
            excuteForm frm = new excuteForm();
            frm.qtime = (int)q_time_txt.Value;
            frm.cn_switch = (int)cn_switch_txt.Value;
            frm.form_type = 4;
            frm.ShowDialog();
        }

        private void q_time_txt_ValueChanged(object sender, EventArgs e)
        {
            if (q_time_txt.Value != 0)
            {
                q_time_btn.Enabled = true;
            }
            else
            {
                q_time_btn.Enabled = false;
            }
        }
    }
}
