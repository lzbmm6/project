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
    public partial class refund : Form
    {
        List<Pay> list = null;
        public refund()
        {
            InitializeComponent();
        }

        private void refund_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("환불을 취소 하시겠습니까?", "환불취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        //결제코드검색 이벤트
        private void paycode_ok_Click(object sender, EventArgs e)
        {
            DB database = new DB();

            
            int sum = 0;
            string product_list = "";
            
            list = database.SelectPay("select * from pay where paynum =" +textBox1.Text+";");
            foreach(Pay pay in list)
            {
                sum += pay.price;
                product_list += pay.pname;
                product_list += "\t "+pay.amount+"\r\n";
            }
           
            textBox2.Text = "[ 결제 코드 ]\r\n" + list[0].paynum
                    + "\r\n\r\n[ 결제 내역 ]\r\n" + product_list
                    + "\r\n\r\n[ 결제 금액 ]\r\n" + sum
                    + "\r\n\r\n[ 결제 방법 ]\r\n" + list[0].type
                    + "\r\n\r\n[ 결제 날짜 ]\r\n" + list[0].time.ToString("yyyy-MM-dd HH:mm:ss");
            textBox2.Update();

            database.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //환불 실행 이벤트
        private void refund_ok_Click(object sender, EventArgs e)
        {
            DB database = new DB();

            if (database.NonQuery("delete from pay where paynum = " + textBox1.Text + ";"))                         //결제내역 삭제
                database.Close();
            database = new DB();

            foreach (Pay p in list)
            {
                database.NonQuery("update product set amount = amount + " + p.amount + " where name ='" + p.pname + "';");         //환불한 product 재고 수정     
            }
            MessageBox.Show("환불되었습니다!!");
            textBox2.Text = "";
            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
