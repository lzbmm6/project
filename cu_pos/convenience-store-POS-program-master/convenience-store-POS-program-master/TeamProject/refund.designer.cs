namespace TeamProject
{
    partial class refund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(refund));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.paycode_ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.refund_ok = new System.Windows.Forms.Button();
            this.refund_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.paycode_ok);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Size = new System.Drawing.Size(605, 489);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 3;
            // 
            // paycode_ok
            // 
            this.paycode_ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paycode_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paycode_ok.Location = new System.Drawing.Point(483, 36);
            this.paycode_ok.Name = "paycode_ok";
            this.paycode_ok.Size = new System.Drawing.Size(104, 27);
            this.paycode_ok.TabIndex = 5;
            this.paycode_ok.Text = "확인";
            this.paycode_ok.UseVisualStyleBackColor = false;
            this.paycode_ok.Click += new System.EventHandler(this.paycode_ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "결제코드입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "결제내역";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(8, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(588, 345);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // refund_ok
            // 
            this.refund_ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refund_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refund_ok.Location = new System.Drawing.Point(203, 501);
            this.refund_ok.Name = "refund_ok";
            this.refund_ok.Size = new System.Drawing.Size(91, 58);
            this.refund_ok.TabIndex = 4;
            this.refund_ok.Text = "환불";
            this.refund_ok.UseVisualStyleBackColor = false;
            this.refund_ok.Click += new System.EventHandler(this.refund_ok_Click);
            // 
            // refund_cancel
            // 
            this.refund_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refund_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refund_cancel.Location = new System.Drawing.Point(310, 501);
            this.refund_cancel.Name = "refund_cancel";
            this.refund_cancel.Size = new System.Drawing.Size(91, 58);
            this.refund_cancel.TabIndex = 5;
            this.refund_cancel.Text = "취소";
            this.refund_cancel.UseVisualStyleBackColor = false;
            this.refund_cancel.Click += new System.EventHandler(this.refund_cancel_Click);
            // 
            // refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 572);
            this.Controls.Add(this.refund_cancel);
            this.Controls.Add(this.refund_ok);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "refund";
            this.Text = "환불";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button paycode_ok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button refund_ok;
        private System.Windows.Forms.Button refund_cancel;
    }
}