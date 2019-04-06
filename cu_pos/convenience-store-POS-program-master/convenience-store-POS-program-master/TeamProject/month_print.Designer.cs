namespace TeamProject
{
    partial class month_print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(month_print));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.month_print_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.month_detail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.month_check = new System.Windows.Forms.TabControl();
            this.month_whole = new System.Windows.Forms.TabPage();
            this.month_whole_list = new System.Windows.Forms.ListView();
            this.month_whole_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_whole_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_whole_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_whole_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_whole_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_whole_payment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_card = new System.Windows.Forms.TabPage();
            this.month_card_list = new System.Windows.Forms.ListView();
            this.month_card_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_card_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_card_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_card_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_card_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_cash = new System.Windows.Forms.TabPage();
            this.month_cash_list = new System.Windows.Forms.ListView();
            this.month_cash_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_cash_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_cash_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_cash_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.month_cash_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.month_check.SuspendLayout();
            this.month_whole.SuspendLayout();
            this.month_card.SuspendLayout();
            this.month_cash.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.month_print_ok);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.month_detail);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.month_check);
            this.splitContainer1.Size = new System.Drawing.Size(982, 483);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(382, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "2018년 1월 이후 부터 조회가능합니다.";
            // 
            // month_print_ok
            // 
            this.month_print_ok.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_print_ok.Location = new System.Drawing.Point(621, 23);
            this.month_print_ok.Name = "month_print_ok";
            this.month_print_ok.Size = new System.Drawing.Size(75, 27);
            this.month_print_ok.TabIndex = 5;
            this.month_print_ok.Text = "조회";
            this.month_print_ok.UseVisualStyleBackColor = true;
            this.month_print_ok.Click += new System.EventHandler(this.month_print_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(308, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "월 선택";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1월",
            "2월",
            "3월",
            "4월",
            "5월",
            "6월",
            "7월",
            "8월",
            "9월",
            "10월",
            "11월",
            "12월"});
            this.comboBox1.Location = new System.Drawing.Point(382, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // month_detail
            // 
            this.month_detail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.month_detail.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_detail.Location = new System.Drawing.Point(848, 332);
            this.month_detail.Name = "month_detail";
            this.month_detail.Size = new System.Drawing.Size(118, 41);
            this.month_detail.TabIndex = 3;
            this.month_detail.Text = "상세조회";
            this.month_detail.UseVisualStyleBackColor = false;
            this.month_detail.Click += new System.EventHandler(this.month_detail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(69, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "0원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "합계 :";
            // 
            // month_check
            // 
            this.month_check.Controls.Add(this.month_whole);
            this.month_check.Controls.Add(this.month_card);
            this.month_check.Controls.Add(this.month_cash);
            this.month_check.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_check.Location = new System.Drawing.Point(12, 3);
            this.month_check.Name = "month_check";
            this.month_check.SelectedIndex = 0;
            this.month_check.Size = new System.Drawing.Size(962, 314);
            this.month_check.TabIndex = 0;
            this.month_check.SelectedIndexChanged += new System.EventHandler(this.month_check_SelectedIndexChanged);
            // 
            // month_whole
            // 
            this.month_whole.BackColor = System.Drawing.SystemColors.Control;
            this.month_whole.Controls.Add(this.month_whole_list);
            this.month_whole.Location = new System.Drawing.Point(4, 29);
            this.month_whole.Name = "month_whole";
            this.month_whole.Padding = new System.Windows.Forms.Padding(3);
            this.month_whole.Size = new System.Drawing.Size(954, 281);
            this.month_whole.TabIndex = 0;
            this.month_whole.Text = "전체내역";
            // 
            // month_whole_list
            // 
            this.month_whole_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.month_whole_num,
            this.month_whole_date,
            this.month_whole_code,
            this.month_whole_index,
            this.month_whole_cost,
            this.month_whole_payment});
            this.month_whole_list.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_whole_list.FullRowSelect = true;
            this.month_whole_list.GridLines = true;
            this.month_whole_list.Location = new System.Drawing.Point(0, 0);
            this.month_whole_list.Name = "month_whole_list";
            this.month_whole_list.Size = new System.Drawing.Size(954, 280);
            this.month_whole_list.TabIndex = 0;
            this.month_whole_list.UseCompatibleStateImageBehavior = false;
            this.month_whole_list.View = System.Windows.Forms.View.Details;
            this.month_whole_list.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.month_whole_list_ColumnWidthChanging);
            // 
            // month_whole_num
            // 
            this.month_whole_num.Text = "/";
            this.month_whole_num.Width = 40;
            // 
            // month_whole_date
            // 
            this.month_whole_date.Text = "날짜";
            this.month_whole_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_whole_date.Width = 191;
            // 
            // month_whole_code
            // 
            this.month_whole_code.Text = "결제코드";
            this.month_whole_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_whole_code.Width = 95;
            // 
            // month_whole_index
            // 
            this.month_whole_index.Text = "내용";
            this.month_whole_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_whole_index.Width = 425;
            // 
            // month_whole_cost
            // 
            this.month_whole_cost.Text = "합계";
            this.month_whole_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_whole_cost.Width = 100;
            // 
            // month_whole_payment
            // 
            this.month_whole_payment.Text = "결제수단";
            this.month_whole_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_whole_payment.Width = 85;
            // 
            // month_card
            // 
            this.month_card.Controls.Add(this.month_card_list);
            this.month_card.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_card.Location = new System.Drawing.Point(4, 29);
            this.month_card.Name = "month_card";
            this.month_card.Padding = new System.Windows.Forms.Padding(3);
            this.month_card.Size = new System.Drawing.Size(954, 281);
            this.month_card.TabIndex = 1;
            this.month_card.Text = "카드내역";
            this.month_card.UseVisualStyleBackColor = true;
            // 
            // month_card_list
            // 
            this.month_card_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.month_card_num,
            this.month_card_date,
            this.month_card_code,
            this.month_card_index,
            this.month_card_cost});
            this.month_card_list.FullRowSelect = true;
            this.month_card_list.GridLines = true;
            this.month_card_list.Location = new System.Drawing.Point(0, 0);
            this.month_card_list.Name = "month_card_list";
            this.month_card_list.Size = new System.Drawing.Size(957, 275);
            this.month_card_list.TabIndex = 0;
            this.month_card_list.UseCompatibleStateImageBehavior = false;
            this.month_card_list.View = System.Windows.Forms.View.Details;
            this.month_card_list.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.month_card_list_ColumnWidthChanging);
            // 
            // month_card_num
            // 
            this.month_card_num.Text = "/";
            this.month_card_num.Width = 40;
            // 
            // month_card_date
            // 
            this.month_card_date.Text = "날짜";
            this.month_card_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_card_date.Width = 200;
            // 
            // month_card_code
            // 
            this.month_card_code.Text = "결제코드";
            this.month_card_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_card_code.Width = 160;
            // 
            // month_card_index
            // 
            this.month_card_index.Text = "내용";
            this.month_card_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_card_index.Width = 451;
            // 
            // month_card_cost
            // 
            this.month_card_cost.Text = "합계";
            this.month_card_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_card_cost.Width = 100;
            // 
            // month_cash
            // 
            this.month_cash.Controls.Add(this.month_cash_list);
            this.month_cash.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_cash.Location = new System.Drawing.Point(4, 29);
            this.month_cash.Name = "month_cash";
            this.month_cash.Padding = new System.Windows.Forms.Padding(3);
            this.month_cash.Size = new System.Drawing.Size(954, 281);
            this.month_cash.TabIndex = 2;
            this.month_cash.Text = "현금내역";
            this.month_cash.UseVisualStyleBackColor = true;
            // 
            // month_cash_list
            // 
            this.month_cash_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.month_cash_num,
            this.month_cash_date,
            this.month_cash_code,
            this.month_cash_index,
            this.month_cash_cost});
            this.month_cash_list.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_cash_list.FullRowSelect = true;
            this.month_cash_list.GridLines = true;
            this.month_cash_list.Location = new System.Drawing.Point(0, 0);
            this.month_cash_list.Name = "month_cash_list";
            this.month_cash_list.Size = new System.Drawing.Size(951, 285);
            this.month_cash_list.TabIndex = 0;
            this.month_cash_list.UseCompatibleStateImageBehavior = false;
            this.month_cash_list.View = System.Windows.Forms.View.Details;
            this.month_cash_list.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.month_cash_list_ColumnWidthChanging);
            // 
            // month_cash_num
            // 
            this.month_cash_num.Text = "/";
            this.month_cash_num.Width = 40;
            // 
            // month_cash_date
            // 
            this.month_cash_date.Text = "날짜";
            this.month_cash_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_cash_date.Width = 200;
            // 
            // month_cash_code
            // 
            this.month_cash_code.Text = "결제코드";
            this.month_cash_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_cash_code.Width = 160;
            // 
            // month_cash_index
            // 
            this.month_cash_index.Text = "내용";
            this.month_cash_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_cash_index.Width = 445;
            // 
            // month_cash_cost
            // 
            this.month_cash_cost.Text = "합계";
            this.month_cash_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_cash_cost.Width = 100;
            // 
            // month_print
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 483);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "month_print";
            this.Text = "월 별 매출조회";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.month_check.ResumeLayout(false);
            this.month_whole.ResumeLayout(false);
            this.month_card.ResumeLayout(false);
            this.month_cash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button month_print_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button month_detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl month_check;
        private System.Windows.Forms.TabPage month_whole;
        private System.Windows.Forms.TabPage month_card;
        private System.Windows.Forms.TabPage month_cash;
        private System.Windows.Forms.ListView month_whole_list;
        private System.Windows.Forms.ColumnHeader month_whole_num;
        private System.Windows.Forms.ColumnHeader month_whole_date;
        private System.Windows.Forms.ListView month_card_list;
        private System.Windows.Forms.ColumnHeader month_card_num;
        private System.Windows.Forms.ColumnHeader month_card_date;
        private System.Windows.Forms.ListView month_cash_list;
        private System.Windows.Forms.ColumnHeader month_cash_num;
        private System.Windows.Forms.ColumnHeader month_cash_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader month_whole_code;
        private System.Windows.Forms.ColumnHeader month_whole_index;
        private System.Windows.Forms.ColumnHeader month_whole_cost;
        private System.Windows.Forms.ColumnHeader month_whole_payment;
        private System.Windows.Forms.ColumnHeader month_card_code;
        private System.Windows.Forms.ColumnHeader month_card_index;
        private System.Windows.Forms.ColumnHeader month_card_cost;
        private System.Windows.Forms.ColumnHeader month_cash_code;
        private System.Windows.Forms.ColumnHeader month_cash_index;
        private System.Windows.Forms.ColumnHeader month_cash_cost;
    }
}