using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss ");
            
        }

        private void button1_Click(object sender, EventArgs e) //판매버튼
        {
            main main = new main();

            main.Show();
        }

        private void button4_Click(object sender, EventArgs e) //종료버튼
        {
            if(MessageBox.Show("종료하시겠습니까?","종료확인",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e) //재고관리버튼
        {
            manage1 manage1 = new manage1();
            manage1.Show();
        }

        private void button3_Click(object sender, EventArgs e) //매출관리버튼
        {
            manage2 manage2 = new manage2();
            manage2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
