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
    public partial class detail_print : Form
    {
        string paynum;
        public detail_print()
        {
            InitializeComponent();
        }

        public void load(object sender, EventArgs e)
        {
            DB database = new DB();
            List<Pay> pay_list = database.SelectPay("select distinct * from pay");
            database.Close();

            int sum = 0;
            string product_list = "";
            Pay pay = new Pay();
            foreach (Pay p in pay_list)
            {
                if (int.Parse(paynum) == p.paynum)
                {
                    pay.paynum = p.paynum;
                    sum += p.price;
                    product_list += p.pname;
                    product_list += "\t " + p.amount + "\r\n";
                    pay.type = p.type;
                    pay.time = p.time;
                    continue;
                }
            }
            textBox1.Text = "[ 결제 코드 ]\r\n" + pay.paynum
                        + "\r\n\r\n[ 결제 내역 ]\r\n" + product_list
                        + "\r\n\r\n[ 결제 금액 ]\r\n" + sum + "원"
                        + "\r\n\r\n[ 결제 방법 ]\r\n" + pay.type
                        + "\r\n\r\n[ 결제 날짜 ]\r\n" + pay.time.ToString("yyyy-MM-dd HH:mm:ss");
            textBox1.Update();
        }

        public void RecieveView(object obj)
        {
            if (obj is string) paynum = (string)obj;
        }

        private void detail_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
