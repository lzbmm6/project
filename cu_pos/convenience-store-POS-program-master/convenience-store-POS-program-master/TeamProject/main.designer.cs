namespace TeamProject
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.amount_del = new System.Windows.Forms.Button();
            this.amount_plus = new System.Windows.Forms.Button();
            this.cancel2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tapcontrol = new System.Windows.Forms.TabControl();
            this.tappage = new System.Windows.Forms.TabPage();
            this.food = new System.Windows.Forms.ListView();
            this.food_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.food_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.food_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drink = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.drink_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drink_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drink_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etc = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.etc_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etc_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etc_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soju = new System.Windows.Forms.TabPage();
            this.listView5 = new System.Windows.Forms.ListView();
            this.soju_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soju_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soju_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ciga = new System.Windows.Forms.TabPage();
            this.listView6 = new System.Windows.Forms.ListView();
            this.ciga_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ciga_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ciga_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pay_cash = new System.Windows.Forms.Button();
            this.pay_card = new System.Windows.Forms.Button();
            this.refund = new System.Windows.Forms.Button();
            this.product_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tapcontrol.SuspendLayout();
            this.tappage.SuspendLayout();
            this.drink.SuspendLayout();
            this.etc.SuspendLayout();
            this.soju.SuspendLayout();
            this.ciga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(428, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "판매";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(750, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "현재시각";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.amount_del);
            this.splitContainer1.Panel1.Controls.Add(this.amount_plus);
            this.splitContainer1.Panel1.Controls.Add(this.cancel2);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cancel1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tapcontrol);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(975, 369);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(151, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "원";
            // 
            // amount_del
            // 
            this.amount_del.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amount_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.amount_del.Location = new System.Drawing.Point(204, 308);
            this.amount_del.Name = "amount_del";
            this.amount_del.Size = new System.Drawing.Size(45, 50);
            this.amount_del.TabIndex = 6;
            this.amount_del.Text = "-";
            this.amount_del.UseVisualStyleBackColor = false;
            this.amount_del.Click += new System.EventHandler(this.amount_del_Click);
            // 
            // amount_plus
            // 
            this.amount_plus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amount_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.amount_plus.Location = new System.Drawing.Point(255, 307);
            this.amount_plus.Name = "amount_plus";
            this.amount_plus.Size = new System.Drawing.Size(45, 50);
            this.amount_plus.TabIndex = 5;
            this.amount_plus.Text = "+";
            this.amount_plus.UseVisualStyleBackColor = false;
            this.amount_plus.Click += new System.EventHandler(this.amount_plus_Click);
            // 
            // cancel2
            // 
            this.cancel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel2.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel2.Location = new System.Drawing.Point(380, 307);
            this.cancel2.Name = "cancel2";
            this.cancel2.Size = new System.Drawing.Size(68, 50);
            this.cancel2.TabIndex = 4;
            this.cancel2.Text = "전체취소";
            this.cancel2.UseVisualStyleBackColor = false;
            this.cancel2.Click += new System.EventHandler(this.cancel2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(74, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "0";
            // 
            // cancel1
            // 
            this.cancel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel1.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel1.Location = new System.Drawing.Point(305, 307);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(68, 50);
            this.cancel1.TabIndex = 3;
            this.cancel1.Text = "지정취소";
            this.cancel1.UseVisualStyleBackColor = false;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "합계 : ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(-1, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(448, 303);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "/";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "내용";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 186;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수량";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "가격";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 134;
            // 
            // tapcontrol
            // 
            this.tapcontrol.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tapcontrol.Controls.Add(this.tappage);
            this.tapcontrol.Controls.Add(this.drink);
            this.tapcontrol.Controls.Add(this.etc);
            this.tapcontrol.Controls.Add(this.soju);
            this.tapcontrol.Controls.Add(this.ciga);
            this.tapcontrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.tapcontrol.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tapcontrol.ItemSize = new System.Drawing.Size(99, 70);
            this.tapcontrol.Location = new System.Drawing.Point(4, 4);
            this.tapcontrol.Multiline = true;
            this.tapcontrol.Name = "tapcontrol";
            this.tapcontrol.SelectedIndex = 0;
            this.tapcontrol.Size = new System.Drawing.Size(514, 456);
            this.tapcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tapcontrol.TabIndex = 0;
            // 
            // tappage
            // 
            this.tappage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tappage.Controls.Add(this.food);
            this.tappage.Font = new System.Drawing.Font("굴림", 9F);
            this.tappage.Location = new System.Drawing.Point(4, 74);
            this.tappage.Name = "tappage";
            this.tappage.Padding = new System.Windows.Forms.Padding(3);
            this.tappage.Size = new System.Drawing.Size(506, 378);
            this.tappage.TabIndex = 0;
            this.tappage.Text = "식품";
            // 
            // food
            // 
            this.food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.food.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.food_num,
            this.food_name,
            this.food_cost});
            this.food.FullRowSelect = true;
            this.food.GridLines = true;
            this.food.LabelEdit = true;
            this.food.Location = new System.Drawing.Point(0, 0);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(506, 279);
            this.food.TabIndex = 0;
            this.food.UseCompatibleStateImageBehavior = false;
            this.food.View = System.Windows.Forms.View.Details;
            this.food.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.food_ColumnWidthChanging);
            this.food.SelectedIndexChanged += new System.EventHandler(this.food_SelectedIndexChanged);
            // 
            // food_num
            // 
            this.food_num.Text = "/";
            // 
            // food_name
            // 
            this.food_name.Text = "상품이름";
            this.food_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.food_name.Width = 321;
            // 
            // food_cost
            // 
            this.food_cost.Text = "가격";
            this.food_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.food_cost.Width = 105;
            // 
            // drink
            // 
            this.drink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drink.Controls.Add(this.listView3);
            this.drink.Font = new System.Drawing.Font("굴림", 12F);
            this.drink.Location = new System.Drawing.Point(4, 74);
            this.drink.Name = "drink";
            this.drink.Padding = new System.Windows.Forms.Padding(3);
            this.drink.Size = new System.Drawing.Size(506, 378);
            this.drink.TabIndex = 1;
            this.drink.Text = "음료";
            // 
            // listView3
            // 
            this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.drink_num,
            this.drink_name,
            this.drink_cost});
            this.listView3.Font = new System.Drawing.Font("굴림", 9F);
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(500, 279);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView3_ColumnWidthChanging);
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // drink_num
            // 
            this.drink_num.Text = "/";
            // 
            // drink_name
            // 
            this.drink_name.Text = "상품이름";
            this.drink_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drink_name.Width = 325;
            // 
            // drink_cost
            // 
            this.drink_cost.Text = "가격";
            this.drink_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drink_cost.Width = 95;
            // 
            // etc
            // 
            this.etc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.etc.Controls.Add(this.listView4);
            this.etc.Font = new System.Drawing.Font("굴림", 12F);
            this.etc.Location = new System.Drawing.Point(4, 74);
            this.etc.Name = "etc";
            this.etc.Padding = new System.Windows.Forms.Padding(3);
            this.etc.Size = new System.Drawing.Size(506, 378);
            this.etc.TabIndex = 2;
            this.etc.Text = "생활용품";
            // 
            // listView4
            // 
            this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.etc_num,
            this.etc_name,
            this.etc_cost});
            this.listView4.Font = new System.Drawing.Font("굴림", 9F);
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(0, 0);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(500, 280);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView4_ColumnWidthChanging);
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // etc_num
            // 
            this.etc_num.Text = "/";
            // 
            // etc_name
            // 
            this.etc_name.Text = "상품이름";
            this.etc_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.etc_name.Width = 328;
            // 
            // etc_cost
            // 
            this.etc_cost.Text = "가격";
            this.etc_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.etc_cost.Width = 95;
            // 
            // soju
            // 
            this.soju.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soju.Controls.Add(this.listView5);
            this.soju.Font = new System.Drawing.Font("굴림", 12F);
            this.soju.Location = new System.Drawing.Point(4, 74);
            this.soju.Name = "soju";
            this.soju.Padding = new System.Windows.Forms.Padding(3);
            this.soju.Size = new System.Drawing.Size(506, 378);
            this.soju.TabIndex = 3;
            this.soju.Text = "주류";
            // 
            // listView5
            // 
            this.listView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.soju_num,
            this.soju_name,
            this.soju_cost});
            this.listView5.Font = new System.Drawing.Font("굴림", 9F);
            this.listView5.FullRowSelect = true;
            this.listView5.GridLines = true;
            this.listView5.Location = new System.Drawing.Point(0, 0);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(500, 279);
            this.listView5.TabIndex = 0;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            this.listView5.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView5_ColumnWidthChanging);
            this.listView5.SelectedIndexChanged += new System.EventHandler(this.listView5_SelectedIndexChanged);
            // 
            // soju_num
            // 
            this.soju_num.Text = "/";
            // 
            // soju_name
            // 
            this.soju_name.Text = "상품이름";
            this.soju_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soju_name.Width = 340;
            // 
            // soju_cost
            // 
            this.soju_cost.Text = "가격";
            this.soju_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soju_cost.Width = 95;
            // 
            // ciga
            // 
            this.ciga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ciga.Controls.Add(this.listView6);
            this.ciga.Font = new System.Drawing.Font("굴림", 12F);
            this.ciga.Location = new System.Drawing.Point(4, 74);
            this.ciga.Name = "ciga";
            this.ciga.Padding = new System.Windows.Forms.Padding(3);
            this.ciga.Size = new System.Drawing.Size(506, 378);
            this.ciga.TabIndex = 4;
            this.ciga.Text = "담배";
            // 
            // listView6
            // 
            this.listView6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ciga_num,
            this.ciga_name,
            this.ciga_cost});
            this.listView6.Font = new System.Drawing.Font("굴림", 9F);
            this.listView6.FullRowSelect = true;
            this.listView6.GridLines = true;
            this.listView6.Location = new System.Drawing.Point(0, 0);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(500, 279);
            this.listView6.TabIndex = 0;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            this.listView6.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView6_ColumnWidthChanging);
            this.listView6.SelectedIndexChanged += new System.EventHandler(this.listView6_SelectedIndexChanged);
            // 
            // ciga_num
            // 
            this.ciga_num.Text = "/";
            // 
            // ciga_name
            // 
            this.ciga_name.Text = "상품이름";
            this.ciga_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ciga_name.Width = 340;
            // 
            // ciga_cost
            // 
            this.ciga_cost.Text = "가격";
            this.ciga_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ciga_cost.Width = 95;
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(1, 407);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pay_cash);
            this.splitContainer2.Panel1.Controls.Add(this.pay_card);
            this.splitContainer2.Panel1.Controls.Add(this.refund);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.product_ok);
            this.splitContainer2.Size = new System.Drawing.Size(975, 123);
            this.splitContainer2.SplitterDistance = 450;
            this.splitContainer2.TabIndex = 3;
            // 
            // pay_cash
            // 
            this.pay_cash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pay_cash.Cursor = System.Windows.Forms.Cursors.Default;
            this.pay_cash.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_cash.Location = new System.Drawing.Point(154, 52);
            this.pay_cash.Name = "pay_cash";
            this.pay_cash.Size = new System.Drawing.Size(144, 68);
            this.pay_cash.TabIndex = 3;
            this.pay_cash.Text = "현금결제";
            this.pay_cash.UseVisualStyleBackColor = false;
            this.pay_cash.Click += new System.EventHandler(this.pay_cash_Click);
            // 
            // pay_card
            // 
            this.pay_card.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pay_card.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_card.Location = new System.Drawing.Point(4, 52);
            this.pay_card.Name = "pay_card";
            this.pay_card.Size = new System.Drawing.Size(144, 68);
            this.pay_card.TabIndex = 2;
            this.pay_card.Text = "카드결제";
            this.pay_card.UseVisualStyleBackColor = false;
            this.pay_card.Click += new System.EventHandler(this.pay_card_Click);
            // 
            // refund
            // 
            this.refund.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refund.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refund.Location = new System.Drawing.Point(303, 52);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(144, 68);
            this.refund.TabIndex = 1;
            this.refund.Text = "환불";
            this.refund.UseVisualStyleBackColor = false;
            this.refund.Click += new System.EventHandler(this.refund_Click);
            // 
            // product_ok
            // 
            this.product_ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product_ok.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_ok.Location = new System.Drawing.Point(9, 52);
            this.product_ok.Name = "product_ok";
            this.product_ok.Size = new System.Drawing.Size(506, 68);
            this.product_ok.TabIndex = 0;
            this.product_ok.Text = "등록";
            this.product_ok.UseVisualStyleBackColor = false;
            this.product_ok.Click += new System.EventHandler(this.product_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamProject.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(324, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 565);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "판매";
            this.Load += new System.EventHandler(this.main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tapcontrol.ResumeLayout(false);
            this.tappage.ResumeLayout(false);
            this.drink.ResumeLayout(false);
            this.etc.ResumeLayout(false);
            this.soju.ResumeLayout(false);
            this.ciga.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tapcontrol;
        private System.Windows.Forms.TabPage tappage;
        private System.Windows.Forms.TabPage drink;
        private System.Windows.Forms.TabPage etc;
        private System.Windows.Forms.TabPage soju;
        private System.Windows.Forms.TabPage ciga;
        private System.Windows.Forms.Button refund;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel2;
        private System.Windows.Forms.Button cancel1;
        private System.Windows.Forms.ListView food;
        private System.Windows.Forms.ColumnHeader food_num;
        private System.Windows.Forms.ColumnHeader food_name;
        private System.Windows.Forms.ColumnHeader food_cost;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader drink_num;
        private System.Windows.Forms.ColumnHeader drink_name;
        private System.Windows.Forms.ColumnHeader drink_cost;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader etc_num;
        private System.Windows.Forms.ColumnHeader etc_name;
        private System.Windows.Forms.ColumnHeader etc_cost;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader soju_num;
        private System.Windows.Forms.ColumnHeader soju_name;
        private System.Windows.Forms.ColumnHeader soju_cost;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader ciga_num;
        private System.Windows.Forms.ColumnHeader ciga_name;
        private System.Windows.Forms.ColumnHeader ciga_cost;
        private System.Windows.Forms.Button pay_cash;
        private System.Windows.Forms.Button pay_card;
        private System.Windows.Forms.Button product_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button amount_del;
        private System.Windows.Forms.Button amount_plus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}