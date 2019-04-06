using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Pay
    {
        public static int pre_paynum;          //DB에 저장된 마지막 결제 번호 
        public int paynum;                     
        public string pname;        //결제상품이름
        public int price;          //결제상품금액
        public string type;        // 카드or현금
        public DateTime time;      //결제시간
        public int amount;

        public Pay()
        {
        }

        public Pay(int paynum, string pname, int price, string type, string time, int amount){
            this.paynum = paynum;
            this.pname = pname;
            this.price = price;
            this.type = type;
            this.time = DateTime.Parse(time);
            this.amount = amount; 
        }

        public static void MakePaynum()
        {
            DB database = new DB();
            pre_paynum = database.ReturnPrePaynum();         
        }

    }
}
