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
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //취소버튼
        {
            if (MessageBox.Show("등록을 취소 하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //상품이름 넣는 부분
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //가격넣는 부분
        {

        }

        private void ok_Click(object sender, EventArgs e) //등록버튼
        {
            DB database = new DB();

            if(add_type.Text == "담배" || add_type.Text == "생활용품")    //비식품
            {
                database.NonQuery("insert into product values('"
                        + textBox1.Text +                                                 //상품이름
                   "'," + textBox2.Text +                                                 //가격
                    ",null" +                                                             //유통기한
                    "," + numericUpDown1.Value +                                          //수량 
                    ",'" + add_type.Text +                                                  //카테고리
                    "');");
            }
            else
            {                                                           //식품
                database.NonQuery("insert into product values('"
                        + textBox1.Text +                                                 //상품이름
                   "'," + textBox2.Text +                                                 //가격
                    ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00'" +  //유통기한
                    "," + numericUpDown1.Value +                                          //수량 
                    ",'" + add_type.Text +                                                  //카테고리
                    "');");                 
  
            }
            MessageBox.Show("상품이 등록되었습니당ㅎㅎㅋㅋ");
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            add_type.Text = "0";

        }
        
        private void add_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (add_type.Text == "담배" || add_type.Text =="생활용품")
                dateTimePicker1.Visible = false;
            else if (add_type.Text == "식품" || add_type.Text == "음료" || add_type.Text == "주류")
                dateTimePicker1.Visible = true;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
