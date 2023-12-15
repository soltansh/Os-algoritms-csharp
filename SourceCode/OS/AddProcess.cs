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
    public partial class AddProcess : Form
    {
        public string pName;
        public int pArrive;
        public int pService;
        public AddProcess()
        {
            InitializeComponent();
        }
        private void addProcess_btn_Click(object sender, EventArgs e)
        {
            if (pService_txt.Text != "0")
            {
                pArrive = (int)pArrive_txt.Value;
                pService = (int)pService_txt.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("زمان سرویس نمی تواند 0 باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddProcess_Load(object sender, EventArgs e)
        {
            pName_txt.Text = pName;
        }
    }
}
