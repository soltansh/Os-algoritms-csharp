namespace OS
{
    partial class osForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osForm));
            this.fcfs_btn = new System.Windows.Forms.Button();
            this.srt_btn = new System.Windows.Forms.Button();
            this.sjf_btn = new System.Windows.Forms.Button();
            this.rr_btn = new System.Windows.Forms.Button();
            this.mcpu_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fcfs_btn
            // 
            this.fcfs_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fcfs_btn.Location = new System.Drawing.Point(4, 26);
            this.fcfs_btn.Name = "fcfs_btn";
            this.fcfs_btn.Size = new System.Drawing.Size(165, 44);
            this.fcfs_btn.TabIndex = 0;
            this.fcfs_btn.Text = "F.C.F.S";
            this.fcfs_btn.UseVisualStyleBackColor = false;
            this.fcfs_btn.Click += new System.EventHandler(this.fcfs_btn_Click);
            // 
            // srt_btn
            // 
            this.srt_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.srt_btn.Location = new System.Drawing.Point(175, 76);
            this.srt_btn.Name = "srt_btn";
            this.srt_btn.Size = new System.Drawing.Size(154, 44);
            this.srt_btn.TabIndex = 1;
            this.srt_btn.Text = "S.R.T";
            this.srt_btn.UseVisualStyleBackColor = false;
            this.srt_btn.Click += new System.EventHandler(this.srt_btn_Click);
            // 
            // sjf_btn
            // 
            this.sjf_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sjf_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sjf_btn.Location = new System.Drawing.Point(175, 26);
            this.sjf_btn.Name = "sjf_btn";
            this.sjf_btn.Size = new System.Drawing.Size(154, 44);
            this.sjf_btn.TabIndex = 2;
            this.sjf_btn.Text = "S.J.F";
            this.sjf_btn.UseVisualStyleBackColor = false;
            this.sjf_btn.Click += new System.EventHandler(this.sjf_btn_Click);
            // 
            // rr_btn
            // 
            this.rr_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rr_btn.Location = new System.Drawing.Point(5, 76);
            this.rr_btn.Name = "rr_btn";
            this.rr_btn.Size = new System.Drawing.Size(164, 44);
            this.rr_btn.TabIndex = 3;
            this.rr_btn.Text = "R.R";
            this.rr_btn.UseVisualStyleBackColor = false;
            this.rr_btn.Click += new System.EventHandler(this.rr_btn_Click);
            // 
            // mcpu_btn
            // 
            this.mcpu_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mcpu_btn.Location = new System.Drawing.Point(9, 126);
            this.mcpu_btn.Name = "mcpu_btn";
            this.mcpu_btn.Size = new System.Drawing.Size(320, 44);
            this.mcpu_btn.TabIndex = 4;
            this.mcpu_btn.Text = "M.CPU";
            this.mcpu_btn.UseVisualStyleBackColor = false;
            this.mcpu_btn.Click += new System.EventHandler(this.mcpu_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.srt_btn);
            this.groupBox2.Controls.Add(this.fcfs_btn);
            this.groupBox2.Controls.Add(this.mcpu_btn);
            this.groupBox2.Controls.Add(this.sjf_btn);
            this.groupBox2.Controls.Add(this.rr_btn);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 215);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "توابع";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // osForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(366, 233);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "osForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب روش اجرا";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fcfs_btn;
        private System.Windows.Forms.Button srt_btn;
        private System.Windows.Forms.Button sjf_btn;
        private System.Windows.Forms.Button rr_btn;
        private System.Windows.Forms.Button mcpu_btn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

