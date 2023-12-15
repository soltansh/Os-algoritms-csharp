namespace OS
{
    partial class q_time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q_time));
            this.label1 = new System.Windows.Forms.Label();
            this.q_time_txt = new System.Windows.Forms.NumericUpDown();
            this.q_time_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cn_switch_txt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.q_time_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cn_switch_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "کوانتوم زمانی";
            // 
            // q_time_txt
            // 
            this.q_time_txt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.q_time_txt.Location = new System.Drawing.Point(3, 5);
            this.q_time_txt.Margin = new System.Windows.Forms.Padding(4);
            this.q_time_txt.Name = "q_time_txt";
            this.q_time_txt.ReadOnly = true;
            this.q_time_txt.Size = new System.Drawing.Size(161, 27);
            this.q_time_txt.TabIndex = 1;
            this.q_time_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.q_time_txt.ValueChanged += new System.EventHandler(this.q_time_txt_ValueChanged);
            // 
            // q_time_btn
            // 
            this.q_time_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.q_time_btn.Enabled = false;
            this.q_time_btn.Location = new System.Drawing.Point(3, 71);
            this.q_time_btn.Margin = new System.Windows.Forms.Padding(4);
            this.q_time_btn.Name = "q_time_btn";
            this.q_time_btn.Size = new System.Drawing.Size(281, 39);
            this.q_time_btn.TabIndex = 2;
            this.q_time_btn.Text = "ادامه";
            this.q_time_btn.UseVisualStyleBackColor = false;
            this.q_time_btn.Click += new System.EventHandler(this.q_time_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(172, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "تعویض متن";
            // 
            // cn_switch_txt
            // 
            this.cn_switch_txt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cn_switch_txt.Location = new System.Drawing.Point(3, 37);
            this.cn_switch_txt.Name = "cn_switch_txt";
            this.cn_switch_txt.ReadOnly = true;
            this.cn_switch_txt.Size = new System.Drawing.Size(161, 27);
            this.cn_switch_txt.TabIndex = 4;
            this.cn_switch_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 112);
            this.Controls.Add(this.cn_switch_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.q_time_btn);
            this.Controls.Add(this.q_time_txt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "q_time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "q_time";
            ((System.ComponentModel.ISupportInitialize)(this.q_time_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cn_switch_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown q_time_txt;
        private System.Windows.Forms.Button q_time_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cn_switch_txt;
    }
}