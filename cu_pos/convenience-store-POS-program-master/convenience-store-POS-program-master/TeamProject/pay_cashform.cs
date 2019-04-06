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
    public partial class pay_cashform : Form
    {


        ListView payListView = null;                    //main.cs listView1
        Label paySum = null;                            //main.cs label4
        public pay_cashform()
        {
            InitializeComponent();
           
        }

        //main의 폼 정보를 받아올거예욘 ㅋㅋ
        public void RecievePayList(object sender)
        {
            if (sender is ListView)
            {
                payListView = ((ListView)sender);
            } else if (sender is Label)
            {
                paySum = (Label)sender;
            }
        }

        //현금결제 이벤트
        protected void cash_ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("결제를 하시겠습니까?", "현금결제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DB database;
                Pay.pre_paynum++;                                       //결제코드생성(지난 결제코드 +1)
                foreach (ListViewItem lvt in payListView.Items)
                {
                    string[] result = lvt.SubItems[3].Text.Split('원');
                    int price = int.Parse(result[0]);

                    database = new DB();
                    database.NonQuery("INSERT INTO pay values(" +
                       Pay.pre_paynum +                                                   //결제코드
                       "," + price +                                              //가격
                        ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") +    //결제시간
                        "','현금'" +                                             //결제타입
                           ",'" + lvt.SubItems[1].Text +                        //상품이름
                              "'," + lvt.SubItems[2].Text +                      //상품수량
                       ");");
                    database.Close();
                    database = new DB();
                    database.NonQuery("update product set amount = amount-" + lvt.SubItems[2].Text + " where name ='" + lvt.SubItems[1].Text + "';");
                    database.Close();
                }
                MessageBox.Show("[ 결제코드:"+Pay.pre_paynum+" ]결제가 완료되었습니다. ", "현금결제 완료");
                payListView.Items.Clear();                                      //메인창 판매리스트 클리어
                paySum.Text = "0";                                              //메인창 합계 클리어

                this.Close();
            }
            else
            {
                MessageBox.Show("결제가 취소되었습니다.", "현금결제 취소");
                this.Close();
            }
        }

        //결제취소 이벤트
        protected void cash_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 취소되었습니다.", "현금결제 취소");
            this.Close();
        }

        //받은돈 확인 클릭 시 이벤트
        protected void cash_change_Click(object sender, EventArgs e)
        {
            label3.Text = (int.Parse(textBox1.Text) - int.Parse(paySum.Text)).ToString();
            label3.Update(); 
        }


        //거스름돈 반환 메소드
        /**

        protected int ChargeReturn()
        {
            return int.Parse(textBox1.Text) - paySum;
        }
    **/
    }
}
