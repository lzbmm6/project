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
    public partial class day_print : Form
    {
        public event DataPushEventHandler DataSendEvent;

        public day_print()
        {
            InitializeComponent();
        }

        private void day_whole_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = day_whole_list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void day_card_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = day_card_list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void day_cash_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = day_cash_list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void day_print_ok_Click(object sender, EventArgs e)
        {
            DB database = new DB();
            List<Pay> pay_list = database.SelectPay("select distinct * from pay");
            database.Close();

            day_whole_list.Items.Clear();
            day_card_list.Items.Clear();
            day_cash_list.Items.Clear();

            int num = 1;
            int exist = 0;
            foreach (Pay p in pay_list)
            {
                String[] arr = new String[6];
                if (dateTimePicker1.Value.Year == p.time.Year && dateTimePicker1.Value.Month == p.time.Month && dateTimePicker1.Value.Day == p.time.Day)
                {
                    exist = 0;
                    foreach (ListViewItem item in day_whole_list.Items)
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
                        day_whole_list.Items.Add(lvt);
                        num++;
                    }
                }
            }

            int num2 = 1;
            foreach (Pay p in pay_list)
            {
                String[] arr = new String[6];
                if (dateTimePicker1.Value.Year == p.time.Year && dateTimePicker1.Value.Month == p.time.Month && dateTimePicker1.Value.Day == p.time.Day && p.type == "카드")
                {
                    exist = 0;
                    foreach (ListViewItem item in day_card_list.Items)
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
                        day_card_list.Items.Add(lvt);
                        num2++;
                    }
                }
            }

            int num3 = 1;
            foreach (Pay p in pay_list)
            {
                String[] arr = new String[6];
                if (dateTimePicker1.Value.Year == p.time.Year && dateTimePicker1.Value.Month == p.time.Month && dateTimePicker1.Value.Day == p.time.Day && p.type == "현금")
                {
                    exist = 0;
                    foreach (ListViewItem item in day_cash_list.Items)
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
                        day_cash_list.Items.Add(lvt);
                        num3++;
                    }
                }
            }
            day_check_SelectedIndexChanged(sender, e);
        }

        private void day_detail_Click(object sender, EventArgs e)
        {
            detail_print detailprint = new detail_print();
            this.DataSendEvent += new DataPushEventHandler(detailprint.RecieveView);

            if (day_whole_list.SelectedItems.Count == 1)
            {
                DataSendEvent(day_whole_list.SelectedItems[0].SubItems[2].Text);
            }
            else if (day_card_list.SelectedItems.Count == 1)
            {
                DataSendEvent(day_card_list.SelectedItems[0].SubItems[2].Text);
            }
            else if (day_cash_list.SelectedItems.Count == 1)
            {
                DataSendEvent(day_cash_list.SelectedItems[0].SubItems[2].Text);
            }

            day_whole_list.SelectedItems.Clear();
            day_card_list.SelectedItems.Clear();
            day_cash_list.SelectedItems.Clear();
            detailprint.Show();
        }

        private void day_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = 0;
            if (day_check.SelectedTab.Text == "전체내역")
            {
                foreach (ListViewItem lvt in day_whole_list.Items)
                {
                    String[] price = lvt.SubItems[4].Text.Split('원');
                    sum += int.Parse(price[0]);
                }

                label3.Text = Convert.ToString(sum) + "원";
                label3.Update();
            }
            else if (day_check.SelectedTab.Text == "카드내역")
            {
                foreach (ListViewItem lvt in day_card_list.Items)
                {
                    String[] price = lvt.SubItems[4].Text.Split('원');
                    sum += int.Parse(price[0]);
                }

                label3.Text = Convert.ToString(sum) + "원";
                label3.Update();
            }
            else if (day_check.SelectedTab.Text == "현금내역")
            {
                foreach (ListViewItem lvt in day_cash_list.Items)
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
