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

    public partial class month_print : Form
    {
        public event DataPushEventHandler DataSendEvent;

        public month_print()
        {
            InitializeComponent();
        }

        private void month_whole_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = month_whole_list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void month_card_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = month_card_list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void month_cash_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = month_cash_list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void month_print_ok_Click(object sender, EventArgs e)
        {
            DB database = new DB();
            List<Pay> pay_list = database.SelectPay("select distinct * from pay");
            database.Close();

            month_whole_list.Items.Clear();
            month_card_list.Items.Clear();
            month_cash_list.Items.Clear();

            int num = 1;
            int exist = 0;

            foreach (Pay p in pay_list)
            {
                String[] arr = new String[6];
                String[] result = comboBox1.Text.Split('월');
                if (int.Parse(result[0]) == p.time.Month)
                {
                    exist = 0;
                    foreach (ListViewItem item in month_whole_list.Items)
                    {
                        if (int.Parse(item.SubItems[2].Text) == p.paynum)
                        {
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
                        arr[0] = Convert.ToString(num);
                        arr[1] = Convert.ToString(p.time);
                        arr[2] = Convert.ToString(p.paynum);

                        foreach (Pay p2 in pay_list)
                        {
                            if (int.Parse(arr[2]) == p2.paynum)
                            {
                                arr[3] += p2.pname + "(" + p2.amount + ") ";
                            }
                        }

                        int sum = 0;
                        foreach (Pay p2 in pay_list)
                        {
                            if (int.Parse(arr[2]) == p2.paynum)
                            {
                                sum += p2.price;
                            }
                        }

                        arr[4] = Convert.ToString(sum) + "원";
                        arr[5] = p.type;

                        ListViewItem lvt = new ListViewItem(arr);
                        month_whole_list.Items.Add(lvt);
                        num++;
                    }
                }
            }

            int num2 = 1;
            foreach (Pay p in pay_list)
            {
                String[] arr = new String[6];
                String[] result = comboBox1.Text.Split('월');
                if (int.Parse(result[0]) == p.time.Month && p.type == "카드")
                {
                    exist = 0;
                    foreach (ListViewItem item in month_card_list.Items)
                    {
                        if (int.Parse(item.SubItems[2].Text) == p.paynum)
                        {
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
                        arr[0] = Convert.ToString(num2);
                        arr[1] = Convert.ToString(p.time);
                        arr[2] = Convert.ToString(p.paynum);

                        foreach (Pay p2 in pay_list)
                        {
                            if (int.Parse(arr[2]) == p2.paynum)
                            {
                                arr[3] += p2.pname + "(" + p2.amount + ") ";
                            }
                        }

                        int sum = 0;
                        foreach (Pay p2 in pay_list)
                        {
                            if (int.Parse(arr[2]) == p2.paynum)
                            {
                                sum += p2.price;
                            }
                        }
                        arr[4] = Convert.ToString(sum) + "원";
                        arr[5] = p.type;

                        ListViewItem lvt = new ListViewItem(arr);
                        month_card_list.Items.Add(lvt);
                        num2++;
                    }
                }
            }

            int num3 = 1;
            foreach (Pay p in pay_list)
            {
                String[] arr = new String[6];
                String[] result = comboBox1.Text.Split('월');
                if (int.Parse(result[0]) == p.time.Month && p.type == "현금")
                {
                    exist = 0;
                    foreach (ListViewItem item in month_cash_list.Items)
                    {
                        if (int.Parse(item.SubItems[2].Text) == p.paynum)
                        {
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
                        arr[0] = Convert.ToString(num3);
                        arr[1] = Convert.ToString(p.time);
                        arr[2] = Convert.ToString(p.paynum);

                        foreach (Pay p2 in pay_list)
                        {
                            if (int.Parse(arr[2]) == p2.paynum)
                            {
                                arr[3] += p2.pname + "(" + p2.amount + ") ";
                            }
                        }

                        int sum = 0;
                        foreach (Pay p2 in pay_list)
                        {
                            if (int.Parse(arr[2]) == p2.paynum)
                            {
                                sum += p2.price;
                            }
                        }
                        arr[4] = Convert.ToString(sum) + "원";
                        arr[5] = p.type;

                        ListViewItem lvt = new ListViewItem(arr);
                        month_cash_list.Items.Add(lvt);
                        num3++;
                    }
                }
            }
            month_check_SelectedIndexChanged(sender, e);
        }

        private void month_detail_Click(object sender, EventArgs e)


        {
            detail_print detailprint = new detail_print();
            this.DataSendEvent += new DataPushEventHandler(detailprint.RecieveView);

            if (month_whole_list.SelectedItems.Count == 1)
            {
                DataSendEvent(month_whole_list.SelectedItems[0].SubItems[2].Text);
            }
            else if (month_card_list.SelectedItems.Count == 1)
            {
                DataSendEvent(month_card_list.SelectedItems[0].SubItems[2].Text);
            }
            else if (month_cash_list.SelectedItems.Count == 1)
            {
                DataSendEvent(month_cash_list.SelectedItems[0].SubItems[2].Text);
            }

            month_whole_list.SelectedItems.Clear();
            month_card_list.SelectedItems.Clear();
            month_cash_list.SelectedItems.Clear();
            detailprint.Show();
        }



        private void month_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = 0;
            if (month_check.SelectedTab.Text == "전체내역")
            {
                foreach(ListViewItem lvt in month_whole_list.Items)
                {
                    String[] price = lvt.SubItems[4].Text.Split('원');
                    sum += int.Parse(price[0]);
                }

                label3.Text = Convert.ToString(sum) + "원";
                label3.Update();
            }
            else if (month_check.SelectedTab.Text == "카드내역")
            {
                foreach (ListViewItem lvt in month_card_list.Items)
                {
                    String[] price = lvt.SubItems[4].Text.Split('원');
                    sum += int.Parse(price[0]);
                }

                label3.Text = Convert.ToString(sum) + "원";
                label3.Update();
            }
            else if (month_check.SelectedTab.Text == "현금내역")
            {
                foreach (ListViewItem lvt in month_cash_list.Items)
                {
                    String[] price = lvt.SubItems[4].Text.Split('원');
                    sum += int.Parse(price[0]);
                }

                label3.Text = Convert.ToString(sum) + "원";
                label3.Update();
            }
        }
    }
}
