namespace OS
{
    partial class AddProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProcess));
            this.label1 = new System.Windows.Forms.Label();
            this.pName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitAddProcess_btn = new System.Windows.Forms.Button();
            this.pArrive_txt = new System.Windows.Forms.NumericUpDown();
            this.pService_txt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pArrive_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pService_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام پردازه";
            // 
            // pName_txt
            // 
            this.pName_txt.BackColor = System.Drawing.SystemColors.Control;
            this.pName_txt.Location = new System.Drawing.Point(4, 2);
            this.pName_txt.Name = "pName_txt";
            this.pName_txt.ReadOnly = true;
            this.pName_txt.Size = new System.Drawing.Size(155, 23);
            this.pName_txt.TabIndex = 1;
            this.pName_txt.Text = "P";
            this.pName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "زمان رسیدن";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "زمان سرویس";
            // 
            // submitAddProcess_btn
            // 
            this.submitAddProcess_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.submitAddProcess_btn.Location = new System.Drawing.Point(4, 89);
            this.submitAddProcess_btn.Name = "submitAddProcess_btn";
            this.submitAddProcess_btn.Size = new System.Drawing.Size(245, 34);
            this.submitAddProcess_btn.TabIndex = 6;
            this.submitAddProcess_btn.Text = "اضافه کن";
            this.submitAddProcess_btn.UseVisualStyleBackColor = false;
            this.submitAddProcess_btn.Click += new System.EventHandler(this.addProcess_btn_Click);
            // 
            // pArrive_txt
            // 
            this.pArrive_txt.BackColor = System.Drawing.SystemColors.Window;
            this.pArrive_txt.Location = new System.Drawing.Point(4, 31);
            this.pArrive_txt.Name = "pArrive_txt";
            this.pArrive_txt.Size = new System.Drawing.Size(155, 23);
            this.pArrive_txt.TabIndex = 7;
            this.pArrive_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pService_txt
            // 
            this.pService_txt.Location = new System.Drawing.Point(4, 60);
            this.pService_txt.Name = "pService_txt";
            this.pService_txt.Size = new System.Drawing.Size(155, 23);
            this.pService_txt.TabIndex = 8;
            this.pService_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 126);
            this.Controls.Add(this.pService_txt);
            this.Controls.Add(this.pArrive_txt);
            this.Controls.Add(this.submitAddProcess_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pName_txt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddProcess";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن پردازه";
            this.Load += new System.EventHandler(this.AddProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pArrive_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pService_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitAddProcess_btn;
        private System.Windows.Forms.NumericUpDown pArrive_txt;
        private System.Windows.Forms.NumericUpDown pService_txt;
    }
}