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
    public partial class main : Form
    {
        public event DataPushEventHandler DataSendEvent;                // 하위 생성 폼으로 현재 폼 데이터 전달

        public main()
        {
            InitializeComponent();
            label2.Text = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss ");
            pictureBox1.Load(@"..\..\Resources\Untitled-1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void main_Load(object sender, EventArgs e)
        {
            DB database = new DB();
            List<Product> list = database.SelectProduct("select distinct * from product");
            database.Close();

            int food_num = 1;
            int drink_num = 1;
            int supply_num = 1;
            int cigar_num = 1;
            int alcohol_num = 1;

            foreach (Product p in list)
            {
                if (p.category == "식품")
                {
                    String[] arr = new String[3];
                    String str = Convert.ToString(food_num);
                    arr[0] = str;
                    arr[1] = p.name;
                    String str2 = Convert.ToString(p.price);
                    arr[2] = str2 + "원";

                    ListViewItem lvt = new ListViewItem(arr);
                    food.Items.Add(lvt);

                    food_num++;
                }
                else if (p.category == "음료")
                {
                    String[] arr = new String[3];
                    String str = Convert.ToString(drink_num);
                    arr[0] = str;
                    arr[1] = p.name;
                    String str2 = Convert.ToString(p.price);
                    arr[2] = str2 + "원";

                    ListViewItem lvt = new ListViewItem(arr);
                    listView3.Items.Add(lvt);

                    drink_num++;
                }
                else if (p.category == "담배")
                {
                    String[] arr = new String[3];
                    String str = Convert.ToString(cigar_num);
                    arr[0] = str;
                    arr[1] = p.name;
                    String str2 = Convert.ToString(p.price);
                    arr[2] = str2 + "원";

                    ListViewItem lvt = new ListViewItem(arr);
                    listView6.Items.Add(lvt);

                    cigar_num++;
                }
                else if (p.category == "주류")
                {
                    String[] arr = new String[3];
                    String str = Convert.ToString(alcohol_num);
                    arr[0] = str;
                    arr[1] = p.name;
                    String str2 = Convert.ToString(p.price);
                    arr[2] = str2 + "원";

                    ListViewItem lvt = new ListViewItem(arr);
                    listView5.Items.Add(lvt);

                    alcohol_num++;
                }
                else if (p.category == "생활용품")
                {
                    String[] arr = new String[3];
                    String str = Convert.ToString(supply_num);
                    arr[0] = str;
                    arr[1] = p.name;
                    String str2 = Convert.ToString(p.price);
                    arr[2] = str2 + "원";

                    ListViewItem lvt = new ListViewItem(arr);
                    listView4.Items.Add(lvt);

                    supply_num++;
                }
            }
            list.Clear();
        }


        //카드결제 이벤트
        private void pay_card_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("결제를 하시겠습니까?", "카드결제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB database;
                Pay.pre_paynum++;                                                   //결제코드생성(지난 결제코드 +1)
                foreach (ListViewItem lvt in listView1.Items)
                {
                    string[] result = lvt.SubItems[3].Text.Split('원');
                    int price = int.Parse(result[0]);

                    database = new DB();
                    database.NonQuery("INSERT INTO pay values(" +
                       Pay.pre_paynum +                                             //결제코드
                       "," + price +                                                //가격
                        ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") +       //결제시간
                        "','카드'" +                                                //결제타입
                           ",'" + lvt.SubItems[1].Text +                            //상품이름
                              "'," + lvt.SubItems[2].Text +                         //상품수량
                       ");");
                    database.Close();
                    database = new DB();

                    //상품 재고 변경
                    database.NonQuery("update product set amount = amount-" + lvt.SubItems[2].Text + " where name ='" + lvt.SubItems[1].Text + "';");
                    database.Close();
                }

                MessageBox.Show("[ 결제코드:" + Pay.pre_paynum + " ]결제가 완료되었습니다.", "카드결제 완료");
                listView1.Items.Clear();
                label4.Text = "0";
            }
            else
            {
                MessageBox.Show("결제가 취소되었습니다.", "카드결제 취소");

            }
        }

        //현금 결제 이벤트
        private void pay_cash_Click(object sender, EventArgs e)
        {
            pay_cashform pay_Cashform = new pay_cashform();
            this.DataSendEvent += new DataPushEventHandler(pay_Cashform.RecievePayList);
            DataSendEvent(listView1);
            DataSendEvent(label4);
            pay_Cashform.Show();
        }




        private void cancel1_Click(object sender, EventArgs e) //지정취소 이벤트
        {
            for(int i=0; i<listView1.SelectedItems.Count; i++)
            {
                listView1.SelectedItems[i].Remove();
            }
            int sum = 0;

            foreach (ListViewItem lvt in listView1.Items)
            {
                String[] result = lvt.SubItems[3].Text.Split('원');
                sum += int.Parse(result[0]);
            }

            string sum_str = Convert.ToString(sum);
            label4.Text = sum_str;

            int count = 1;
            foreach(ListViewItem lvt in listView1.Items)
            {
                lvt.SubItems[0].Text = Convert.ToString(count);
                count++;
            }
        }

        private void cancel2_Click(object sender, EventArgs e) //전체취소 이벤트
        {
            listView1.Items.Clear();


            int sum = 0;

            foreach (ListViewItem lvt in listView1.Items)
            {
                String[] result = lvt.SubItems[3].Text.Split('원');
                sum += int.Parse(result[0]);
            }

            string sum_str = Convert.ToString(sum);
            label4.Text = sum_str;
        }  

        private void product_ok_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            listView1.View = View.Details;
            int exist = 0;
            if (food.SelectedItems.Count > 0)
            {
                for (int i = 0; i < food.SelectedItems.Count; i++)
                {
                    exist = 0;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if(item.SubItems[1].Text == food.SelectedItems[i].SubItems[1].Text)
                        {
                            int amount = int.Parse(item.SubItems[2].Text) + 1;
                            item.SubItems[2].Text = Convert.ToString(amount);
                            String[] price = food.SelectedItems[i].SubItems[2].Text.Split('원');
                            int sum2 = int.Parse(price[0]) * amount;
                            item.SubItems[3].Text = Convert.ToString(sum2) + "원";
                            exist = 1;
                            break;
                        }
                    }
                    if (exist == 1)
                    {
                        continue;
                    }
                    else if (exist == 0)
                    {
                        String product = food.SelectedItems[i].SubItems[1].Text;
                        String price = food.SelectedItems[i].SubItems[2].Text;

                        String[] arr = new String[4];
                        String str = Convert.ToString(listView1.Items.Count + 1);
                        arr[0] = str;
                        arr[1] = food.SelectedItems[i].SubItems[1].Text;
                        arr[2] = "1";
                        arr[3] = food.SelectedItems[i].SubItems[2].Text;

                        ListViewItem lvt = new ListViewItem(arr);
                        listView1.Items.Add(lvt);
                    }
                }
                food.SelectedItems.Clear();
            }
            else if (listView3.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView3.SelectedItems.Count; i++)
                {
                    exist = 0;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[1].Text == listView3.SelectedItems[i].SubItems[1].Text)
                        {
                            int amount = int.Parse(item.SubItems[2].Text) + 1;
                            item.SubItems[2].Text = Convert.ToString(amount);
                            String[] price = listView3.SelectedItems[i].SubItems[2].Text.Split('원');
                            int sum2 = int.Parse(price[0]) * amount;
                            item.SubItems[3].Text = Convert.ToString(sum2) + "원";
                            exist = 1;
                            break;
                        }
                    }
                    if (exist == 1)
                    {
                        continue;
                    }
                    else if (exist == 0)
                    {
                        String product = listView3.SelectedItems[i].SubItems[1].Text;
                        String price = listView3.SelectedItems[i].SubItems[2].Text;

                        String[] arr = new String[4];
                        String str = Convert.ToString(listView1.Items.Count + 1);
                        arr[0] = str;
                        arr[1] = listView3.SelectedItems[i].SubItems[1].Text;
                        arr[2] = "1";
                        arr[3] = listView3.SelectedItems[i].SubItems[2].Text;

                        ListViewItem lvt = new ListViewItem(arr);
                        listView1.Items.Add(lvt);
                    }
                }
                listView3.SelectedItems.Clear();
            }
            else if (listView4.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView4.SelectedItems.Count; i++)
                {
                    exist = 0;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[1].Text == listView4.SelectedItems[i].SubItems[1].Text)
                        {
                            int amount = int.Parse(item.SubItems[2].Text) + 1;
                            item.SubItems[2].Text = Convert.ToString(amount);
                            String[] price = listView4.SelectedItems[i].SubItems[2].Text.Split('원');
                            int sum2 = int.Parse(price[0]) * amount;
                            item.SubItems[3].Text = Convert.ToString(sum2) + "원";
                            exist = 1;
                            break;
                        }
                    }
                    if (exist == 1)
                    {
                        continue;
                    }
                    else if (exist == 0)
                    {
                        String product = listView4.SelectedItems[i].SubItems[1].Text;
                        String price = listView4.SelectedItems[i].SubItems[2].Text;

                        String[] arr = new String[4];
                        String str = Convert.ToString(listView1.Items.Count + 1);
                        arr[0] = str;
                        arr[1] = listView4.SelectedItems[i].SubItems[1].Text;
                        arr[2] = "1";
                        arr[3] = listView4.SelectedItems[i].SubItems[2].Text;

                        ListViewItem lvt = new ListViewItem(arr);
                        listView1.Items.Add(lvt);
                    }
                }
                listView4.SelectedItems.Clear();
            }
            else if (listView5.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView5.SelectedItems.Count; i++)
                {
                    exist = 0;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[1].Text == listView5.SelectedItems[i].SubItems[1].Text)
                        {
                            int amount = int.Parse(item.SubItems[2].Text) + 1;
                            item.SubItems[2].Text = Convert.ToString(amount);
                            String[] price = listView5.SelectedItems[i].SubItems[2].Text.Split('원');
                            int sum2 = int.Parse(price[0]) * amount;
                            item.SubItems[3].Text = Convert.ToString(sum2) + "원";
                            exist = 1;
                            break;
                        }
                    }
                    if (exist == 1)
                    {
                        continue;
                    }
                    else if (exist == 0)
                    {
                        String product = listView5.SelectedItems[i].SubItems[1].Text;
                        String price = listView5.SelectedItems[i].SubItems[2].Text;

                        String[] arr = new String[4];
                        String str = Convert.ToString(listView1.Items.Count + 1);
                        arr[0] = str;
                        arr[1] = listView5.SelectedItems[i].SubItems[1].Text;
                        arr[2] = "1";
                        arr[3] = listView5.SelectedItems[i].SubItems[2].Text;

                        ListViewItem lvt = new ListViewItem(arr);
                        listView1.Items.Add(lvt);
                    }
                }
                listView5.SelectedItems.Clear();
            }
            else if (listView6.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView6.SelectedItems.Count; i++)
                {
                    exist = 0;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[1].Text == listView6.SelectedItems[i].SubItems[1].Text)
                        {
                            int amount = int.Parse(item.SubItems[2].Text) + 1;
                            item.SubItems[2].Text = Convert.ToString(amount);
                            String[] price = listView6.SelectedItems[i].SubItems[2].Text.Split('원');
                            int sum2 = int.Parse(price[0]) * amount;
                            item.SubItems[3].Text = Convert.ToString(sum2) + "원";
                            exist = 1;
                            break;
                        }
                    }
                    if (exist == 1)
                    {
                        continue;
                    }
                    else if (exist == 0)
                    {
                        String product = listView6.SelectedItems[i].SubItems[1].Text;
                        String price = listView6.SelectedItems[i].SubItems[2].Text;

                        String[] arr = new String[4];
                        String str = Convert.ToString(listView1.Items.Count + 1);
                        arr[0] = str;
                        arr[1] = listView6.SelectedItems[i].SubItems[1].Text;
                        arr[2] = "1";
                        arr[3] = listView6.SelectedItems[i].SubItems[2].Text;

                        ListViewItem lvt = new ListViewItem(arr);
                        listView1.Items.Add(lvt);
                    }
                }
                listView6.SelectedItems.Clear();
            }
            else
            {
                MessageBox.Show("항목을 선택하세요!");
            }
            db.Close();

            int sum = 0;

            foreach (ListViewItem lvt in listView1.Items)
            {
                String[] result = lvt.SubItems[3].Text.Split('원');
                sum += int.Parse(result[0]);
            }

            string sum_str = Convert.ToString(sum);
            label4.Text = sum_str;
        }

        private void amount_plus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                int amount = int.Parse(listView1.SelectedItems[i].SubItems[2].Text) + 1;
                listView1.SelectedItems[i].SubItems[2].Text = Convert.ToString(amount);
                String[] price = listView1.SelectedItems[i].SubItems[3].Text.Split('원');
                int sum2 = int.Parse(price[0]) / (amount - 1) * amount;
                listView1.SelectedItems[i].SubItems[3].Text = Convert.ToString(sum2) + "원";
            }

            int sum = 0;

            foreach (ListViewItem lvt in listView1.Items)
            {
                String[] result = lvt.SubItems[3].Text.Split('원');
                sum += int.Parse(result[0]);
            }

            string sum_str = Convert.ToString(sum);
            label4.Text = sum_str;
            listView1.SelectedItems.Clear();
        }

        private void amount_del_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                if (int.Parse(listView1.SelectedItems[i].SubItems[2].Text) > 1)
                {
                    int amount = int.Parse(listView1.SelectedItems[i].SubItems[2].Text) - 1;
                    listView1.SelectedItems[i].SubItems[2].Text = Convert.ToString(amount);
                    String[] price = listView1.SelectedItems[i].SubItems[3].Text.Split('원');
                    int sum2 = int.Parse(price[0]) / (amount + 1) * amount;
                    listView1.SelectedItems[i].SubItems[3].Text = Convert.ToString(sum2) + "원";
                }
                else
                {
                    MessageBox.Show("수량은 최소 1개 이상이어야 합니다.");
                }
            }

            int sum = 0;

            foreach (ListViewItem lvt in listView1.Items)
            {
                String[] result = lvt.SubItems[3].Text.Split('원');
                sum += int.Parse(result[0]);
            }

            string sum_str = Convert.ToString(sum);
            label4.Text = sum_str;
            listView1.SelectedItems.Clear();
        }


        //환불 폼 생성
        private void refund_Click(object sender, EventArgs e)
        {
            refund refund = new refund();
            refund.Show();
        }



        //자동생성코드
        private void listView3_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView3.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void food_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = food.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void listView4_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView4.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void listView5_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView5.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void listView6_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView6.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e) { }    
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listView4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listView3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void food_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listView5_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listView6_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}

