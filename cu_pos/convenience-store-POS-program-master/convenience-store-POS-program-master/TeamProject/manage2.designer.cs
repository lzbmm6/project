namespace TeamProject
{
    partial class manage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage2));
            this.month_print = new System.Windows.Forms.Button();
            this.day_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // month_print
            // 
            this.month_print.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.month_print.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_print.Location = new System.Drawing.Point(43, 206);
            this.month_print.Name = "month_print";
            this.month_print.Size = new System.Drawing.Size(145, 57);
            this.month_print.TabIndex = 0;
            this.month_print.Text = "월 별 조회";
            this.month_print.UseVisualStyleBackColor = false;
            this.month_print.Click += new System.EventHandler(this.month_print_Click);
            // 
            // day_print
            // 
            this.day_print.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.day_print.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day_print.Location = new System.Drawing.Point(211, 206);
            this.day_print.Name = "day_print";
            this.day_print.Size = new System.Drawing.Size(145, 57);
            this.day_print.TabIndex = 1;
            this.day_print.Text = "일 별 조회";
            this.day_print.UseVisualStyleBackColor = false;
            this.day_print.Click += new System.EventHandler(this.day_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamProject.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // manage2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(396, 292);
            this.Controls.Add(this.day_print);
            this.Controls.Add(this.month_print);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manage2";
            this.Text = "매출관리";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button month_print;
        private System.Windows.Forms.Button day_print;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}