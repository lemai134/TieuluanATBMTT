﻿namespace Ma_Hoa_AES
{
    partial class Ma_HOa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ma_HOa));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtkey2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrsdecr = new System.Windows.Forms.TextBox();
            this.txtdecr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkey1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreencr = new System.Windows.Forms.TextBox();
            this.txtencr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdmahoa = new System.Windows.Forms.Button();
            this.cmdreset1 = new System.Windows.Forms.Button();
            this.cmdreset2 = new System.Windows.Forms.Button();
            this.cmddecr = new System.Windows.Forms.Button();
            this.cmdinfo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtkey2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtrsdecr);
            this.groupBox2.Controls.Add(this.txtdecr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải Mã";
            // 
            // txtkey2
            // 
            this.txtkey2.Location = new System.Drawing.Point(91, 49);
            this.txtkey2.Name = "txtkey2";
            this.txtkey2.Size = new System.Drawing.Size(549, 35);
            this.txtkey2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "KHÓA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kết quả";
            // 
            // txtrsdecr
            // 
            this.txtrsdecr.Location = new System.Drawing.Point(92, 82);
            this.txtrsdecr.Multiline = true;
            this.txtrsdecr.Name = "txtrsdecr";
            this.txtrsdecr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtrsdecr.Size = new System.Drawing.Size(549, 62);
            this.txtrsdecr.TabIndex = 6;
            // 
            // txtdecr
            // 
            this.txtdecr.Location = new System.Drawing.Point(91, 17);
            this.txtdecr.Name = "txtdecr";
            this.txtdecr.Size = new System.Drawing.Size(549, 35);
            this.txtdecr.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nội dung:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtkey1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtreencr);
            this.groupBox1.Controls.Add(this.txtencr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã Hóa";
            // 
            // txtkey1
            // 
            this.txtkey1.Location = new System.Drawing.Point(97, 51);
            this.txtkey1.Name = "txtkey1";
            this.txtkey1.Size = new System.Drawing.Size(549, 35);
            this.txtkey1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "KHÓA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả";
            // 
            // txtreencr
            // 
            this.txtreencr.Location = new System.Drawing.Point(97, 82);
            this.txtreencr.Multiline = true;
            this.txtreencr.Name = "txtreencr";
            this.txtreencr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtreencr.Size = new System.Drawing.Size(549, 62);
            this.txtreencr.TabIndex = 3;
            // 
            // txtencr
            // 
            this.txtencr.Location = new System.Drawing.Point(97, 19);
            this.txtencr.Name = "txtencr";
            this.txtencr.Size = new System.Drawing.Size(549, 35);
            this.txtencr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nội dung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÃ HÓA - GIẢI MÃ AES ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdmahoa
            // 
            this.cmdmahoa.BackColor = System.Drawing.Color.Red;
            this.cmdmahoa.Location = new System.Drawing.Point(217, 192);
            this.cmdmahoa.Name = "cmdmahoa";
            this.cmdmahoa.Size = new System.Drawing.Size(99, 50);
            this.cmdmahoa.TabIndex = 4;
            this.cmdmahoa.Text = "Mã Hóa";
            this.cmdmahoa.UseVisualStyleBackColor = false;
            this.cmdmahoa.Click += new System.EventHandler(this.cmdmahoa_Click);
            // 
            // cmdreset1
            // 
            this.cmdreset1.BackColor = System.Drawing.Color.Lime;
            this.cmdreset1.Location = new System.Drawing.Point(351, 192);
            this.cmdreset1.Name = "cmdreset1";
            this.cmdreset1.Size = new System.Drawing.Size(99, 50);
            this.cmdreset1.TabIndex = 5;
            this.cmdreset1.Text = "Làm Lại";
            this.cmdreset1.UseVisualStyleBackColor = false;
            this.cmdreset1.Click += new System.EventHandler(this.cmdreset1_Click);
            // 
            // cmdreset2
            // 
            this.cmdreset2.BackColor = System.Drawing.Color.Lime;
            this.cmdreset2.Location = new System.Drawing.Point(351, 408);
            this.cmdreset2.Name = "cmdreset2";
            this.cmdreset2.Size = new System.Drawing.Size(99, 50);
            this.cmdreset2.TabIndex = 7;
            this.cmdreset2.Text = "Làm Lại";
            this.cmdreset2.UseVisualStyleBackColor = false;
            this.cmdreset2.Click += new System.EventHandler(this.cmdreset2_Click);
            // 
            // cmddecr
            // 
            this.cmddecr.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmddecr.Location = new System.Drawing.Point(217, 408);
            this.cmddecr.Name = "cmddecr";
            this.cmddecr.Size = new System.Drawing.Size(99, 50);
            this.cmddecr.TabIndex = 6;
            this.cmddecr.Text = "Giải Mã";
            this.cmddecr.UseVisualStyleBackColor = false;
            this.cmddecr.Click += new System.EventHandler(this.cmddecr_Click);
            // 
            // cmdinfo
            // 
            this.cmdinfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdinfo.Image = global::Ma_Hoa_AES.Properties.Resources.file;
            this.cmdinfo.Location = new System.Drawing.Point(585, 400);
            this.cmdinfo.Name = "cmdinfo";
            this.cmdinfo.Size = new System.Drawing.Size(67, 66);
            this.cmdinfo.TabIndex = 8;
            this.cmdinfo.UseVisualStyleBackColor = false;
            this.cmdinfo.Click += new System.EventHandler(this.cmdinfo_Click);
            // 
            // Ma_HOa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 500);
            this.Controls.Add(this.cmdinfo);
            this.Controls.Add(this.cmdreset2);
            this.Controls.Add(this.cmddecr);
            this.Controls.Add(this.cmdreset1);
            this.Controls.Add(this.cmdmahoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Ma_HOa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mã Hóa - Giải Mã By Mai";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtreencr;
        private System.Windows.Forms.TextBox txtencr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrsdecr;
        private System.Windows.Forms.TextBox txtdecr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdmahoa;
        private System.Windows.Forms.Button cmdreset1;
        private System.Windows.Forms.Button cmdreset2;
        private System.Windows.Forms.Button cmddecr;
        private System.Windows.Forms.Button cmdinfo;
        private System.Windows.Forms.TextBox txtkey2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkey1;
        private System.Windows.Forms.Label label6;
    }
}