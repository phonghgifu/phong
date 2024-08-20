using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            MessageBox.Show("chon giới tinh Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
            MessageBox.Show("chon giới tinh Nữ", "Thông báo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked) 
                txtHopMau.BackColor = Color.Red;
            else txtHopMau.BackColor = Color.Blue;
        }
    }
}
