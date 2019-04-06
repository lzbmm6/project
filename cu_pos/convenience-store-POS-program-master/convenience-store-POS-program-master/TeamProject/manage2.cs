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
    public partial class manage2 : Form
    {
        public manage2()
        {
            InitializeComponent();
        }

        private void month_print_Click(object sender, EventArgs e)
        {
            month_print month_print = new month_print();
            month_print.Show();
        }

        private void day_print_Click(object sender, EventArgs e)
        {
            day_print day_print = new day_print();
            day_print.Show();
        }
    }
}
