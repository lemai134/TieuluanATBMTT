using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Ma_Hoa_AES
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }
        OpenFileDialog open;
        SaveFileDialog save;

        private void button3_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = open.FileName;
                StreamReader read = new StreamReader(open.FileName);
                txtNoiDung.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter(txtPath.Text.Trim());
            write.WriteLine(txtNoiDung.Text);
            write.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            // liệt kê tên đuôi được phép lưu
            save.Filter = "|*.txt";
            save.RestoreDirectory = true;
            //mở cửa sổ save thành công
            if(save.ShowDialog()== DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                // ghi dòng mới
                write.WriteLine(txtNoiDung.Text);
                write.Close();

            }
        }
    }
}
