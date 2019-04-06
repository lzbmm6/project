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
    public partial class ProductDel : Form
    {
        public event DataPushEventHandler DataSendEvent;            // ProductDel -> productchange
        public event DataGetEventHandler DataGetEvent;              //productDel -> manage1
      
        DB database;
        public ProductDel()
        {
            InitializeComponent();
        }
       
        
        //리스트뷰 생성
        protected void listView1_Load(object sender, EventArgs e)
        {
            DataGetEvent(null, null);               //재고관리창 리스트 재로드
            database = new DB();

            listView1.Items.Clear();                          //리스트뷰초기화
            List<Product> selectResult = database.SelectProduct("select * from product;");


            if (selectResult != null)
            {
                ListViewItem lvt;
                int count = 0;

                string[] arr = new String[6];
                foreach (Product p in selectResult)
                {
                    arr[0] = (++count).ToString();
                    arr[1] = p.category;
                    arr[2] = p.name;
                    arr[3] = p.price.ToString();
                    arr[4] = p.amount.ToString();
                    if(p is Food) {
                        arr[5] = ((Food)p).e_date.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    else
                    {
                        arr[5] = "";
                    }

                   lvt = new ListViewItem(arr);
                    listView1.Items.Add(lvt);
                }

            }
            else
            {
                MessageBox.Show("검색된 상품이 없습니다.");
            }
            database.Close();


        }

        //삭제 버튼 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB();
            if (listView1.SelectedItems.Count > 0)
            {
                string selectPro;
                for (int i = 0; i < listView1.SelectedItems.Count; i++) {
                    selectPro = listView1.SelectedItems[i].SubItems[2].Text;
                    database.NonQuery("delete from product where name ='" + selectPro + "';");
                        }
            MessageBox.Show("상품이 삭제되었습니다.");
            this.listView1_Load(this, null);            //리스트 재로드          
            }
                else
                {
                    MessageBox.Show("상품 삭제에 실패했습니다.");
                }
            
        }

        //변경 버튼 이벤트
        private void button2_Click(object sender, EventArgs e)
        {
            productchange productchange = new productchange();
            DataSendEvent += new DataPushEventHandler(productchange.RecieveUpdateProduct);
            if (listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("헉 한 상품만 선택해서 변경하세요!");
                return;
            }
            else
            {
                DataSendEvent(listView1.SelectedItems[0]);
                productchange.DataGetEvent += new DataGetEventHandler(listView1_Load);
                productchange.Show();
            }
        }
        

           

            //검색 버튼 이벤트
            private void button3_Click(object sender, EventArgs e)
            {
            database = new DB();

            List<Product> selectResult = database.SelectProduct("select * from product where name like '%" + textBox1.Text + "%';");

            if (selectResult != null)
            {
                listView1.Items.Clear();

                ListViewItem lvt;
                int count = 1;
                string[] arr = new String[6];
                foreach (Product p in selectResult)
                {
                    arr[0] = count.ToString();
                    count += 1;
                    arr[1] = p.category;
                    arr[2] = p.name.ToString();
                    arr[3] = p.price.ToString();
                    arr[4] = p.amount.ToString();
                    if (p is Food)
                    {
                        arr[5] = ((Food)p).e_date.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    else
                    {
                        arr[5] = "";
                    }

                    lvt = new ListViewItem(arr);
                    listView1.Items.Add(lvt);
                }
            }
            else
            {
                MessageBox.Show("검색된 상품이 없습니다.");
            }
            database.Close();
        }




        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
 
}

