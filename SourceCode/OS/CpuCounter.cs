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
    public partial class CpuCounter : Form
    {
        public CpuCounter()
        {
            InitializeComponent();
        }

        private void c_cpu_btn_Click(object sender, EventArgs e)
        {
            excuteForm frm = new excuteForm();
            frm.c_cpu = (int)c_cpu_txt.Value;
            frm.form_type = 5;
            frm.ShowDialog();
        }

        private void c_cpu_txt_ValueChanged(object sender, EventArgs e)
        {
            if (c_cpu_txt.Value != 0)
            {
                c_cpu_btn.Enabled = true;
            }
            else
            {
                c_cpu_btn.Enabled = false;
            }
        }
    }
}
