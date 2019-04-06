namespace TeamProject
{
    partial class pay_cashform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pay_cashform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cash_ok = new System.Windows.Forms.Button();
            this.cash_cancel = new System.Windows.Forms.Button();
            this.cash_change = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "받은 금액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "거스름돈";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(179, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 30);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(175, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(333, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "원";
            // 
            // cash_ok
            // 
            this.cash_ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cash_ok.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cash_ok.Location = new System.Drawing.Point(147, 173);
            this.cash_ok.Name = "cash_ok";
            this.cash_ok.Size = new System.Drawing.Size(98, 36);
            this.cash_ok.TabIndex = 5;
            this.cash_ok.Text = "결제";
            this.cash_ok.UseVisualStyleBackColor = false;
            this.cash_ok.Click += new System.EventHandler(this.cash_ok_Click);
            // 
            // cash_cancel
            // 
            this.cash_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cash_cancel.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cash_cancel.Location = new System.Drawing.Point(263, 173);
            this.cash_cancel.Name = "cash_cancel";
            this.cash_cancel.Size = new System.Drawing.Size(98, 36);
            this.cash_cancel.TabIndex = 6;
            this.cash_cancel.Text = "취소";
            this.cash_cancel.UseVisualStyleBackColor = false;
            this.cash_cancel.Click += new System.EventHandler(this.cash_cancel_Click);
            // 
            // cash_change
            // 
            this.cash_change.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cash_change.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cash_change.Location = new System.Drawing.Point(367, 55);
            this.cash_change.Name = "cash_change";
            this.cash_change.Size = new System.Drawing.Size(58, 34);
            this.cash_change.TabIndex = 7;
            this.cash_change.Text = "확인";
            this.cash_change.UseVisualStyleBackColor = false;
            this.cash_change.Click += new System.EventHandler(this.cash_change_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(333, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "원";
            // 
            // pay_cashform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 269);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cash_change);
            this.Controls.Add(this.cash_cancel);
            this.Controls.Add(this.cash_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pay_cashform";
            this.Text = "현금결제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cash_ok;
        private System.Windows.Forms.Button cash_cancel;
        private System.Windows.Forms.Button cash_change;
        private System.Windows.Forms.Label label5;
    }
}