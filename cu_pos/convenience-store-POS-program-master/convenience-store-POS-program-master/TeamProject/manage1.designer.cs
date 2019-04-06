namespace TeamProject
{
    partial class manage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage1));
            this.manage_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manage_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manage_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manage_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manage_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manage_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품현황 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manage_list
            // 
            this.manage_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.manage_type,
            this.manage_name,
            this.manage_num,
            this.manage_date,
            this.manage_cost});
            this.manage_list.GridLines = true;
            this.manage_list.Location = new System.Drawing.Point(12, 66);
            this.manage_list.Name = "manage_list";
            this.manage_list.Size = new System.Drawing.Size(686, 407);
            this.manage_list.TabIndex = 0;
            this.manage_list.UseCompatibleStateImageBehavior = false;
            this.manage_list.View = System.Windows.Forms.View.Details;
            this.manage_list.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.manage_list_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "/";
            this.columnHeader1.Width = 36;
            // 
            // manage_type
            // 
            this.manage_type.Text = "분류";
            this.manage_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manage_type.Width = 83;
            // 
            // manage_name
            // 
            this.manage_name.Text = "상품명";
            this.manage_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manage_name.Width = 214;
            // 
            // manage_num
            // 
            this.manage_num.Text = "남은수량";
            this.manage_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manage_num.Width = 80;
            // 
            // manage_date
            // 
            this.manage_date.Text = "유통기한";
            this.manage_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manage_date.Width = 150;
            // 
            // manage_cost
            // 
            this.manage_cost.Text = "가격";
            this.manage_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manage_cost.Width = 105;
            // 
            // 상품현황
            // 
            this.상품현황.AutoSize = true;
            this.상품현황.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품현황.Location = new System.Drawing.Point(12, 27);
            this.상품현황.Name = "상품현황";
            this.상품현황.Size = new System.Drawing.Size(89, 29);
            this.상품현황.TabIndex = 1;
            this.상품현황.Text = "상품현황";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.add.Location = new System.Drawing.Point(714, 66);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(173, 66);
            this.add.TabIndex = 2;
            this.add.Text = "상품등록";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.del.Location = new System.Drawing.Point(714, 149);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(173, 66);
            this.del.TabIndex = 3;
            this.del.Text = "상품변경/삭제";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // manage1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(901, 497);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.상품현황);
            this.Controls.Add(this.manage_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manage1";
            this.Text = "재고관리";
            this.Load += new System.EventHandler(this.manage_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView manage_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader manage_type;
        private System.Windows.Forms.ColumnHeader manage_name;
        private System.Windows.Forms.ColumnHeader manage_num;
        private System.Windows.Forms.ColumnHeader manage_date;
        private System.Windows.Forms.ColumnHeader manage_cost;
        private System.Windows.Forms.Label 상품현황;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
    }
}