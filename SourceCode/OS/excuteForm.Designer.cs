namespace OS
{
    partial class excuteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(excuteForm));
            this.process_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.turnTime_s_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.turnTime_m_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.waiting_time_s_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.waiting_time_m_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sort_by_alg_btn = new System.Windows.Forms.Button();
            this.addProcess_btn = new System.Windows.Forms.Button();
            this.deleteProcess_btn = new System.Windows.Forms.Button();
            this.refreesh_btn = new System.Windows.Forms.Button();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PArrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRemain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PComplsteSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessGetQTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.process_dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // process_dgv
            // 
            this.process_dgv.AllowUserToAddRows = false;
            this.process_dgv.AllowUserToDeleteRows = false;
            this.process_dgv.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.process_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.process_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.PArrive,
            this.PService,
            this.PWait,
            this.PRemain,
            this.PComplsteSt,
            this.ProcessGetQTime,
            this.TTime});
            this.process_dgv.GridColor = System.Drawing.SystemColors.Control;
            this.process_dgv.Location = new System.Drawing.Point(0, -2);
            this.process_dgv.Name = "process_dgv";
            this.process_dgv.ReadOnly = true;
            this.process_dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.process_dgv.Size = new System.Drawing.Size(330, 374);
            this.process_dgv.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox3.Controls.Add(this.turnTime_s_lbl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.turnTime_m_lbl);
            this.groupBox3.Location = new System.Drawing.Point(336, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 89);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "زمان گردش کار";
            // 
            // turnTime_s_lbl
            // 
            this.turnTime_s_lbl.AutoSize = true;
            this.turnTime_s_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnTime_s_lbl.ForeColor = System.Drawing.Color.Green;
            this.turnTime_s_lbl.Location = new System.Drawing.Point(57, 26);
            this.turnTime_s_lbl.Name = "turnTime_s_lbl";
            this.turnTime_s_lbl.Size = new System.Drawing.Size(16, 16);
            this.turnTime_s_lbl.TabIndex = 6;
            this.turnTime_s_lbl.Text = "0";
            this.turnTime_s_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "__________";
            // 
            // turnTime_m_lbl
            // 
            this.turnTime_m_lbl.AutoSize = true;
            this.turnTime_m_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnTime_m_lbl.ForeColor = System.Drawing.Color.Green;
            this.turnTime_m_lbl.Location = new System.Drawing.Point(59, 60);
            this.turnTime_m_lbl.Name = "turnTime_m_lbl";
            this.turnTime_m_lbl.Size = new System.Drawing.Size(16, 16);
            this.turnTime_m_lbl.TabIndex = 6;
            this.turnTime_m_lbl.Text = "0";
            this.turnTime_m_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.waiting_time_s_lbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.waiting_time_m_lbl);
            this.groupBox2.Location = new System.Drawing.Point(336, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 89);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "میانگین زمان انتظار";
            // 
            // waiting_time_s_lbl
            // 
            this.waiting_time_s_lbl.AutoSize = true;
            this.waiting_time_s_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiting_time_s_lbl.ForeColor = System.Drawing.Color.Green;
            this.waiting_time_s_lbl.Location = new System.Drawing.Point(57, 26);
            this.waiting_time_s_lbl.Name = "waiting_time_s_lbl";
            this.waiting_time_s_lbl.Size = new System.Drawing.Size(16, 16);
            this.waiting_time_s_lbl.TabIndex = 6;
            this.waiting_time_s_lbl.Text = "0";
            this.waiting_time_s_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "__________";
            // 
            // waiting_time_m_lbl
            // 
            this.waiting_time_m_lbl.AutoSize = true;
            this.waiting_time_m_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiting_time_m_lbl.ForeColor = System.Drawing.Color.Green;
            this.waiting_time_m_lbl.Location = new System.Drawing.Point(59, 61);
            this.waiting_time_m_lbl.Name = "waiting_time_m_lbl";
            this.waiting_time_m_lbl.Size = new System.Drawing.Size(16, 16);
            this.waiting_time_m_lbl.TabIndex = 6;
            this.waiting_time_m_lbl.Text = "0";
            this.waiting_time_m_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sort_by_alg_btn);
            this.groupBox1.Controls.Add(this.addProcess_btn);
            this.groupBox1.Controls.Add(this.deleteProcess_btn);
            this.groupBox1.Controls.Add(this.calculate_btn);
            this.groupBox1.Controls.Add(this.refreesh_btn);
            this.groupBox1.Location = new System.Drawing.Point(336, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "امکانات";
            // 
            // sort_by_alg_btn
            // 
            this.sort_by_alg_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.sort_by_alg_btn.Location = new System.Drawing.Point(5, 82);
            this.sort_by_alg_btn.Name = "sort_by_alg_btn";
            this.sort_by_alg_btn.Size = new System.Drawing.Size(120, 28);
            this.sort_by_alg_btn.TabIndex = 5;
            this.sort_by_alg_btn.Text = "مرتب سازی با الگو";
            this.sort_by_alg_btn.UseVisualStyleBackColor = false;
            this.sort_by_alg_btn.Click += new System.EventHandler(this.sort_by_alg_btn_Click);
            // 
            // addProcess_btn
            // 
            this.addProcess_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addProcess_btn.Location = new System.Drawing.Point(5, 14);
            this.addProcess_btn.Name = "addProcess_btn";
            this.addProcess_btn.Size = new System.Drawing.Size(120, 28);
            this.addProcess_btn.TabIndex = 1;
            this.addProcess_btn.Text = "افزودن پردازه";
            this.addProcess_btn.UseVisualStyleBackColor = false;
            this.addProcess_btn.Click += new System.EventHandler(this.addProcess_btn_Click);
            // 
            // deleteProcess_btn
            // 
            this.deleteProcess_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteProcess_btn.Enabled = false;
            this.deleteProcess_btn.Location = new System.Drawing.Point(5, 48);
            this.deleteProcess_btn.Name = "deleteProcess_btn";
            this.deleteProcess_btn.Size = new System.Drawing.Size(120, 28);
            this.deleteProcess_btn.TabIndex = 2;
            this.deleteProcess_btn.Text = "حذف پردازه";
            this.deleteProcess_btn.UseVisualStyleBackColor = false;
            this.deleteProcess_btn.Click += new System.EventHandler(this.deleteProcess_btn_Click);
            // 
            // refreesh_btn
            // 
            this.refreesh_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.refreesh_btn.Location = new System.Drawing.Point(5, 116);
            this.refreesh_btn.Name = "refreesh_btn";
            this.refreesh_btn.Size = new System.Drawing.Size(120, 28);
            this.refreesh_btn.TabIndex = 4;
            this.refreesh_btn.Text = "تازه سازی";
            this.refreesh_btn.UseVisualStyleBackColor = false;
            this.refreesh_btn.Click += new System.EventHandler(this.refreesh_btn_Click);
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.calculate_btn.Enabled = false;
            this.calculate_btn.Location = new System.Drawing.Point(5, 150);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(120, 28);
            this.calculate_btn.TabIndex = 10;
            this.calculate_btn.Text = "اجرای الگوریتم";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // PName
            // 
            this.PName.DataPropertyName = "ProcessName";
            this.PName.HeaderText = "پردازه";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PName.Width = 47;
            // 
            // PArrive
            // 
            this.PArrive.DataPropertyName = "ProcessArriveTime";
            this.PArrive.FillWeight = 50F;
            this.PArrive.HeaderText = "زمان رسیدن";
            this.PArrive.Name = "PArrive";
            this.PArrive.ReadOnly = true;
            this.PArrive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PArrive.Width = 60;
            // 
            // PService
            // 
            this.PService.DataPropertyName = "ProcessServiceTime";
            this.PService.FillWeight = 50F;
            this.PService.HeaderText = "زمان سرویس";
            this.PService.Name = "PService";
            this.PService.ReadOnly = true;
            this.PService.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PService.Width = 60;
            // 
            // PWait
            // 
            this.PWait.DataPropertyName = "ProcessWaitingTime";
            this.PWait.FillWeight = 50F;
            this.PWait.HeaderText = "زمان انتظار";
            this.PWait.Name = "PWait";
            this.PWait.ReadOnly = true;
            this.PWait.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PWait.Width = 60;
            // 
            // PRemain
            // 
            this.PRemain.DataPropertyName = "ProcessRemainingTime";
            this.PRemain.HeaderText = "زمان باقی مانده";
            this.PRemain.Name = "PRemain";
            this.PRemain.ReadOnly = true;
            this.PRemain.Visible = false;
            // 
            // PComplsteSt
            // 
            this.PComplsteSt.DataPropertyName = "ProcessIsComplete";
            this.PComplsteSt.HeaderText = "وضعیت تکمیل";
            this.PComplsteSt.Name = "PComplsteSt";
            this.PComplsteSt.ReadOnly = true;
            this.PComplsteSt.Visible = false;
            // 
            // ProcessGetQTime
            // 
            this.ProcessGetQTime.DataPropertyName = "ProcessGetQTime";
            this.ProcessGetQTime.HeaderText = "کواننتوم دریافتی";
            this.ProcessGetQTime.Name = "ProcessGetQTime";
            this.ProcessGetQTime.ReadOnly = true;
            this.ProcessGetQTime.Visible = false;
            // 
            // TTime
            // 
            this.TTime.DataPropertyName = "ProcessTurnaroundTime";
            this.TTime.FillWeight = 70F;
            this.TTime.HeaderText = "گردش کار";
            this.TTime.Name = "TTime";
            this.TTime.ReadOnly = true;
            this.TTime.Width = 60;
            // 
            // excuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(466, 372);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.process_dgv);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "excuteForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم پردازه ها";
            this.Load += new System.EventHandler(this.excuteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.process_dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView process_dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label turnTime_s_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label turnTime_m_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label waiting_time_s_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label waiting_time_m_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sort_by_alg_btn;
        private System.Windows.Forms.Button addProcess_btn;
        private System.Windows.Forms.Button deleteProcess_btn;
        private System.Windows.Forms.Button refreesh_btn;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PArrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PService;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWait;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRemain;
        private System.Windows.Forms.DataGridViewTextBoxColumn PComplsteSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessGetQTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTime;
    }
}