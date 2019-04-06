namespace TeamProject
{
    partial class ProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.product_type = new System.Windows.Forms.Label();
            this.add_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "등록 할 상품 정보를 입력하세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "상품이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(40, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "가격";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(140, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(140, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(350, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "원";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ok.Location = new System.Drawing.Point(161, 334);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 40);
            this.ok.TabIndex = 8;
            this.ok.Text = "등록";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(254, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // product_type
            // 
            this.product_type.AutoSize = true;
            this.product_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_type.Location = new System.Drawing.Point(40, 87);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(72, 25);
            this.product_type.TabIndex = 10;
            this.product_type.Text = "상품종류";
            // 
            // add_type
            // 
            this.add_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.add_type.FormattingEnabled = true;
            this.add_type.Items.AddRange(new object[] {
            "식품",
            "음료",
            "생활용품",
            "주류",
            "담배"});
            this.add_type.Location = new System.Drawing.Point(140, 82);
            this.add_type.Name = "add_type";
            this.add_type.Size = new System.Drawing.Size(237, 30);
            this.add_type.TabIndex = 11;
            this.add_type.SelectedIndexChanged += new System.EventHandler(this.add_type_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(40, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "수량";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(40, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "유통기한";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(140, 224);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(237, 25);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 25);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 414);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_type);
            this.Controls.Add(this.product_type);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductAdd";
            this.Text = "상품등록";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label product_type;
        private System.Windows.Forms.ComboBox add_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}