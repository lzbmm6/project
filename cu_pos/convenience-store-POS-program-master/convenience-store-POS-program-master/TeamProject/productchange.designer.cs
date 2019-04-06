namespace TeamProject
{
    partial class productchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productchange));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.change_ok = new System.Windows.Forms.Button();
            this.change_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "변경할 상품 정보를 입력하세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "변경할 상품이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "변경할 상품가격";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(366, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "원";
            // 
            // change_ok
            // 
            this.change_ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.change_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.change_ok.Location = new System.Drawing.Point(144, 291);
            this.change_ok.Name = "change_ok";
            this.change_ok.Size = new System.Drawing.Size(76, 40);
            this.change_ok.TabIndex = 6;
            this.change_ok.Text = "변경";
            this.change_ok.UseVisualStyleBackColor = false;
            this.change_ok.Click += new System.EventHandler(this.UpdateProduct);
            // 
            // change_cancel
            // 
            this.change_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.change_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.change_cancel.Location = new System.Drawing.Point(240, 291);
            this.change_cancel.Name = "change_cancel";
            this.change_cancel.Size = new System.Drawing.Size(76, 40);
            this.change_cancel.TabIndex = 7;
            this.change_cancel.Text = "취소";
            this.change_cancel.UseVisualStyleBackColor = false;
            this.change_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(48, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "변경할 상품수량";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(48, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "변경할 유통기한";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(191, 195);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(202, 25);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // productchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(458, 362);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.change_cancel);
            this.Controls.Add(this.change_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "productchange";
            this.Text = "상품정보변경";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button change_ok;
        private System.Windows.Forms.Button change_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}