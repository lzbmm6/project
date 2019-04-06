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
    public partial class manage1 : Form
    {
        public manage1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ProductAdd productadd = new ProductAdd();
            productadd.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            ProductDel productDel = new ProductDel();
            productDel.DataGetEvent += new DataGetEventHandler(manage_list_Load);
            productDel.Show();
        }

        private void manage_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = manage_list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

       

        private void manage_list_Load(object sender, EventArgs e)
        {
            DB database = new DB();

            manage_list.Items.Clear();                          //리스트뷰초기화
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
                    arr[5] = p.price.ToString();
                    arr[3] = p.amount.ToString();
                    if (p is Food)
                    {
                        arr[4] = ((Food)p).e_date.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    else
                    {
                        arr[4] = "";
                    }

                    lvt = new ListViewItem(arr);
                    manage_list.Items.Add(lvt);
                }

            }
            else
            {
                MessageBox.Show("검색된 상품이 없습니다.");
            }
            database.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
