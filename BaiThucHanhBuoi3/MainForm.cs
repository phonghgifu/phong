using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = textTen.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNhap}. rất vui được gặp bạn","Thông điệp chào mừng");
        }

        private void btnsaoChep_Click(object sender, EventArgs e)
        {
            txtsaoChep.Text = textTen.Text;
        }

        

        private void textTen_TextChanged(object sender, EventArgs e)
        {
            txtsaoChep.Text = textTen.Text;
        }
    }
}
