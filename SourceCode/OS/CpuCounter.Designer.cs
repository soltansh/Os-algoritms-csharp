namespace OS
{
    partial class CpuCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CpuCounter));
            this.c_cpu_btn = new System.Windows.Forms.Button();
            this.c_cpu_txt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_cpu_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // c_cpu_btn
            // 
            this.c_cpu_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.c_cpu_btn.Enabled = false;
            this.c_cpu_btn.Location = new System.Drawing.Point(3, 38);
            this.c_cpu_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.c_cpu_btn.Name = "c_cpu_btn";
            this.c_cpu_btn.Size = new System.Drawing.Size(403, 48);
            this.c_cpu_btn.TabIndex = 7;
            this.c_cpu_btn.Text = "ادامه";
            this.c_cpu_btn.UseVisualStyleBackColor = false;
            this.c_cpu_btn.Click += new System.EventHandler(this.c_cpu_btn_Click);
            // 
            // c_cpu_txt
            // 
            this.c_cpu_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.c_cpu_txt.Location = new System.Drawing.Point(3, 4);
            this.c_cpu_txt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.c_cpu_txt.Name = "c_cpu_txt";
            this.c_cpu_txt.ReadOnly = true;
            this.c_cpu_txt.Size = new System.Drawing.Size(215, 22);
            this.c_cpu_txt.TabIndex = 6;
            this.c_cpu_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_cpu_txt.ValueChanged += new System.EventHandler(this.c_cpu_txt_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "تعداد سی پی یو";
            // 
            // CpuCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(409, 90);
            this.Controls.Add(this.c_cpu_btn);
            this.Controls.Add(this.c_cpu_txt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CpuCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CpuCounter";
            ((System.ComponentModel.ISupportInitialize)(this.c_cpu_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button c_cpu_btn;
        private System.Windows.Forms.NumericUpDown c_cpu_txt;
        private System.Windows.Forms.Label label1;
    }
}