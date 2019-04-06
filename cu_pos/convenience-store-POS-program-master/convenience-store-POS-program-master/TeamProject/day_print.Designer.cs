namespace TeamProject
{
    partial class day_print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(day_print));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.day_print_ok = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.day_detail = new System.Windows.Forms.Button();
            this.day_check = new System.Windows.Forms.TabControl();
            this.day_whole = new System.Windows.Forms.TabPage();
            this.day_whole_list = new System.Windows.Forms.ListView();
            this.day_whole_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_whole_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_whole_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_whole_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_whole_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_whole_payment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_card = new System.Windows.Forms.TabPage();
            this.day_card_list = new System.Windows.Forms.ListView();
            this.day_card_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_card_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_card_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_card_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_card_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_cash = new System.Windows.Forms.TabPage();
            this.day_cash_list = new System.Windows.Forms.ListView();
            this.day_cash_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_cash_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_cash_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_cash_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day_cash_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.day_check.SuspendLayout();
            this.day_whole.SuspendLayout();
            this.day_card.SuspendLayout();
            this.day_cash.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.day_print_ok);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.day_detail);
            this.splitContainer1.Panel2.Controls.Add(this.day_check);
            this.splitContainer1.Size = new System.Drawing.Size(982, 483);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // day_print_ok
            // 
            this.day_print_ok.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day_print_ok.Location = new System.Drawing.Point(655, 23);
            this.day_print_ok.Name = "day_print_ok";
            this.day_print_ok.Size = new System.Drawing.Size(75, 27);
            this.day_print_ok.TabIndex = 2;
            this.day_print_ok.Text = "조회";
            this.day_print_ok.UseVisualStyleBackColor = true;
            this.day_print_ok.Click += new System.EventHandler(this.day_print_ok_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(392, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 28);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(300, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜 선택";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(89, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "0원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "합계 : ";
            // 
            // day_detail
            // 
            this.day_detail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.day_detail.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day_detail.Location = new System.Drawing.Point(848, 357);
            this.day_detail.Name = "day_detail";
            this.day_detail.Size = new System.Drawing.Size(118, 41);
            this.day_detail.TabIndex = 1;
            this.day_detail.Text = "상세조회";
            this.day_detail.UseVisualStyleBackColor = false;
            this.day_detail.Click += new System.EventHandler(this.day_detail_Click);
            // 
            // day_check
            // 
            this.day_check.Controls.Add(this.day_whole);
            this.day_check.Controls.Add(this.day_card);
            this.day_check.Controls.Add(this.day_cash);
            this.day_check.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day_check.Location = new System.Drawing.Point(10, 19);
            this.day_check.Name = "day_check";
            this.day_check.SelectedIndex = 0;
            this.day_check.Size = new System.Drawing.Size(964, 318);
            this.day_check.TabIndex = 0;
            this.day_check.SelectedIndexChanged += new System.EventHandler(this.day_check_SelectedIndexChanged);
            // 
            // day_whole
            // 
            this.day_whole.BackColor = System.Drawing.SystemColors.Control;
            this.day_whole.Controls.Add(this.day_whole_list);
            this.day_whole.Location = new System.Drawing.Point(4, 29);
            this.day_whole.Name = "day_whole";
            this.day_whole.Padding = new System.Windows.Forms.Padding(3);
            this.day_whole.Size = new System.Drawing.Size(956, 285);
            this.day_whole.TabIndex = 0;
            this.day_whole.Text = "전체내역";
            // 
            // day_whole_list
            // 
            this.day_whole_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.day_whole_num,
            this.day_whole_date,
            this.day_whole_code,
            this.day_whole_index,
            this.day_whole_cost,
            this.day_whole_payment});
            this.day_whole_list.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day_whole_list.FullRowSelect = true;
            this.day_whole_list.GridLines = true;
            this.day_whole_list.Location = new System.Drawing.Point(0, 4);
            this.day_whole_list.Name = "day_whole_list";
            this.day_whole_list.Size = new System.Drawing.Size(952, 280);
            this.day_whole_list.TabIndex = 0;
            this.day_whole_list.UseCompatibleStateImageBehavior = false;
            this.day_whole_list.View = System.Windows.Forms.View.Details;
            this.day_whole_list.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.day_whole_list_ColumnWidthChanging);
            // 
            // day_whole_num
            // 
            this.day_whole_num.Text = "/";
            this.day_whole_num.Width = 40;
            // 
            // day_whole_date
            // 
            this.day_whole_date.Text = "날짜";
            this.day_whole_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_whole_date.Width = 200;
            // 
            // day_whole_code
            // 
            this.day_whole_code.Text = "결제코드";
            this.day_whole_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_whole_code.Width = 95;
            // 
            // day_whole_index
            // 
            this.day_whole_index.Text = "내용";
            this.day_whole_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_whole_index.Width = 425;
            // 
            // day_whole_cost
            // 
            this.day_whole_cost.Text = "합계";
            this.day_whole_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_whole_cost.Width = 100;
            // 
            // day_whole_payment
            // 
            this.day_whole_payment.Text = "결제수단";
            this.day_whole_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_whole_payment.Width = 85;
            // 
            // day_card
            // 
            this.day_card.Controls.Add(this.day_card_list);
            this.day_card.Location = new System.Drawing.Point(4, 29);
            this.day_card.Name = "day_card";
            this.day_card.Padding = new System.Windows.Forms.Padding(3);
            this.day_card.Size = new System.Drawing.Size(956, 285);
            this.day_card.TabIndex = 1;
            this.day_card.Text = "카드내역";
            this.day_card.UseVisualStyleBackColor = true;
            // 
            // day_card_list
            // 
            this.day_card_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.day_card_num,
            this.day_card_date,
            this.day_card_code,
            this.day_card_index,
            this.day_card_cost});
            this.day_card_list.FullRowSelect = true;
            this.day_card_list.GridLines = true;
            this.day_card_list.Location = new System.Drawing.Point(0, 0);
            this.day_card_list.Name = "day_card_list";
            this.day_card_list.Size = new System.Drawing.Size(956, 282);
            this.day_card_list.TabIndex = 0;
            this.day_card_list.UseCompatibleStateImageBehavior = false;
            this.day_card_list.View = System.Windows.Forms.View.Details;
            this.day_card_list.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.day_card_list_ColumnWidthChanging);
            // 
            // day_card_num
            // 
            this.day_card_num.Text = "/";
            this.day_card_num.Width = 40;
            // 
            // day_card_date
            // 
            this.day_card_date.Text = "날짜";
            this.day_card_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_card_date.Width = 200;
            // 
            // day_card_code
            // 
            this.day_card_code.Text = "결제코드";
            this.day_card_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_card_code.Width = 160;
            // 
            // day_card_index
            // 
            this.day_card_index.Text = "내용";
            this.day_card_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_card_index.Width = 448;
            // 
            // day_card_cost
            // 
            this.day_card_cost.Text = "합계";
            this.day_card_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_card_cost.Width = 100;
            // 
            // day_cash
            // 
            this.day_cash.Controls.Add(this.day_cash_list);
            this.day_cash.Location = new System.Drawing.Point(4, 29);
            this.day_cash.Name = "day_cash";
            this.day_cash.Padding = new System.Windows.Forms.Padding(3);
            this.day_cash.Size = new System.Drawing.Size(956, 285);
            this.day_cash.TabIndex = 2;
            this.day_cash.Text = "현금내역";
            this.day_cash.UseVisualStyleBackColor = true;
            // 
            // day_cash_list
            // 
            this.day_cash_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.day_cash_num,
            this.day_cash_date,
            this.day_cash_code,
            this.day_cash_index,
            this.day_cash_cost});
            this.day_cash_list.FullRowSelect = true;
            this.day_cash_list.GridLines = true;
            this.day_cash_list.Location = new System.Drawing.Point(0, 0);
            this.day_cash_list.Name = "day_cash_list";
            this.day_cash_list.Size = new System.Drawing.Size(960, 285);
            this.day_cash_list.TabIndex = 0;
            this.day_cash_list.UseCompatibleStateImageBehavior = false;
            this.day_cash_list.View = System.Windows.Forms.View.Details;
            this.day_cash_list.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.day_cash_list_ColumnWidthChanging);
            // 
            // day_cash_num
            // 
            this.day_cash_num.Text = "/";
            this.day_cash_num.Width = 40;
            // 
            // day_cash_date
            // 
            this.day_cash_date.Text = "날짜";
            this.day_cash_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_cash_date.Width = 200;
            // 
            // day_cash_code
            // 
            this.day_cash_code.Text = "결제코드";
            this.day_cash_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_cash_code.Width = 160;
            // 
            // day_cash_index
            // 
            this.day_cash_index.Text = "내용";
            this.day_cash_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_cash_index.Width = 452;
            // 
            // day_cash_cost
            // 
            this.day_cash_cost.Text = "합계";
            this.day_cash_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_cash_cost.Width = 100;
            // 
            // day_print
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 483);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "day_print";
            this.Text = "일 별 매출조회";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.day_check.ResumeLayout(false);
            this.day_whole.ResumeLayout(false);
            this.day_card.ResumeLayout(false);
            this.day_cash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button day_print_ok;
        private System.Windows.Forms.TabControl day_check;
        private System.Windows.Forms.TabPage day_whole;
        private System.Windows.Forms.TabPage day_card;
        private System.Windows.Forms.TabPage day_cash;
        private System.Windows.Forms.ListView day_whole_list;
        private System.Windows.Forms.ColumnHeader day_whole_num;
        private System.Windows.Forms.ColumnHeader day_whole_date;
        private System.Windows.Forms.ListView day_card_list;
        private System.Windows.Forms.ColumnHeader day_card_num;
        private System.Windows.Forms.ColumnHeader day_card_date;
        private System.Windows.Forms.ListView day_cash_list;
        private System.Windows.Forms.ColumnHeader day_cash_num;
        private System.Windows.Forms.ColumnHeader day_cash_date;
        private System.Windows.Forms.Button day_detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader day_whole_code;
        private System.Windows.Forms.ColumnHeader day_whole_index;
        private System.Windows.Forms.ColumnHeader day_whole_cost;
        private System.Windows.Forms.ColumnHeader day_whole_payment;
        private System.Windows.Forms.ColumnHeader day_card_code;
        private System.Windows.Forms.ColumnHeader day_card_index;
        private System.Windows.Forms.ColumnHeader day_card_cost;
        private System.Windows.Forms.ColumnHeader day_cash_code;
        private System.Windows.Forms.ColumnHeader day_cash_index;
        private System.Windows.Forms.ColumnHeader day_cash_cost;
    }
}