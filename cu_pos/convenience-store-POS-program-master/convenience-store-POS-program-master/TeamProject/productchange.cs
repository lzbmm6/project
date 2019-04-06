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
    public partial class productchange : Form
    {
        public event DataGetEventHandler DataGetEvent;
        ListViewItem selectedP;
        string selectedPName = null;
        Boolean changeName = false;
        Boolean changePrice = false;
        Boolean changeAmount = false;
        Boolean changeE_date = false;

        DB database;

        public productchange()
        {
            InitializeComponent();
        }

        public void RecieveUpdateProduct(object sender)
        {        
            if (sender is ListViewItem)
            {
                selectedP = (ListViewItem)sender;
                selectedPName = ((ListViewItem)sender).SubItems[2].Text;
            }

            //선택한 상품 정보 셋팅
            textBox1.Text = selectedP.SubItems[2].Text;
            textBox2.Text = selectedP.SubItems[3].Text;
            numericUpDown1.Value = Convert.ToDecimal(selectedP.SubItems[4].Text);

            if (selectedP.SubItems[5].Text != "")
            {
                dateTimePicker1.Value = DateTime.Parse(selectedP.SubItems[5].Text);
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("변경을 취소 하시겠습니까?", "변경취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        //변경 클릭 이벤트
        private void UpdateProduct(object sender, EventArgs e)
        {
            database = new DB();
            if (changeName == true) { 
            database.NonQuery("update product set name = '" + textBox1.Text + "' where name = '" + selectedPName + "';");
        }
            if (changePrice == true){
                database.NonQuery("update product set price = '" + textBox2.Text + "' where name = '" + selectedPName + "';");
            }if(changeAmount == true){
                database.NonQuery("update product set amount = '" + numericUpDown1.Value.ToString() + "' where name = '" + selectedPName + "';");
            }if( changeE_date == true){
                database.NonQuery("update product set e_date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' where name = '" + selectedPName + "';");
            }MessageBox.Show("상품 정보가 변경되었씁니다^^!!!");
            database.Close();
            DataGetEvent(null, null);
            
            this.Close();
         
        }

        //이름 변경
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changeName = true;
        }

        //가격변경
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            changePrice = true;
        }
        //수량 변경
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            changeAmount = true;
        }
        //유통기한 변경
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            changeE_date = true;
        }
    }
}
