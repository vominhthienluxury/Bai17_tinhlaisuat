namespace Bai17_tinhlaisuat
{
    partial class Form1
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
            this.textTIEN = new System.Windows.Forms.TextBox();
            this.hjkhk = new System.Windows.Forms.TextBox();
            this.hkihjk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TINH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbxlai = new System.Windows.Forms.ComboBox();
            this.Sonam = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Sonam)).BeginInit();
            this.SuspendLayout();
            // 
            // textTIEN
            // 
            this.textTIEN.Location = new System.Drawing.Point(105, 75);
            this.textTIEN.Name = "textTIEN";
            this.textTIEN.Size = new System.Drawing.Size(100, 20);
            this.textTIEN.TabIndex = 0;
            // 
            // hjkhk
            // 
            this.hjkhk.Location = new System.Drawing.Point(778, 436);
            this.hjkhk.Name = "hjkhk";
            this.hjkhk.Size = new System.Drawing.Size(10, 20);
            this.hjkhk.TabIndex = 0;
            // 
            // hkihjk
            // 
            this.hkihjk.Location = new System.Drawing.Point(762, 436);
            this.hkihjk.Name = "hkihjk";
            this.hkihjk.Size = new System.Drawing.Size(10, 20);
            this.hkihjk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Năm";
            // 
            // TINH
            // 
            this.TINH.Location = new System.Drawing.Point(247, 101);
            this.TINH.Name = "TINH";
            this.TINH.Size = new System.Drawing.Size(75, 23);
            this.TINH.TabIndex = 2;
            this.TINH.Text = "Tính";
            this.TINH.UseVisualStyleBackColor = true;
            this.TINH.Click += new System.EventHandler(this.TINH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết quả";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 173);
            this.listBox1.TabIndex = 5;
            // 
            // cbxlai
            // 
            this.cbxlai.FormattingEnabled = true;
            this.cbxlai.Location = new System.Drawing.Point(105, 100);
            this.cbxlai.Name = "cbxlai";
            this.cbxlai.Size = new System.Drawing.Size(100, 21);
            this.cbxlai.TabIndex = 6;
            // 
            // Sonam
            // 
            this.Sonam.Location = new System.Drawing.Point(105, 132);
            this.Sonam.Name = "Sonam";
            this.Sonam.Size = new System.Drawing.Size(100, 20);
            this.Sonam.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.Sonam);
            this.Controls.Add(this.cbxlai);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TINH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hkihjk);
            this.Controls.Add(this.hjkhk);
            this.Controls.Add(this.textTIEN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sonam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTIEN;
        private System.Windows.Forms.TextBox hjkhk;
        private System.Windows.Forms.TextBox hkihjk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TINH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbxlai;
        private System.Windows.Forms.NumericUpDown Sonam;
    }
}

