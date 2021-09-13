
namespace BasicControl
{
    partial class frnMathBasic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(166, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình toán học cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Thứ nhất";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(195, 150);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(416, 21);
            this.txtSoThuNhat.TabIndex = 3;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(195, 198);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(416, 21);
            this.txtSoThuHai.TabIndex = 3;
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(195, 243);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(90, 45);
            this.btncong.TabIndex = 4;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(316, 243);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(86, 45);
            this.btntru.TabIndex = 4;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(422, 243);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(81, 45);
            this.btnnhan.TabIndex = 4;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(538, 243);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(74, 45);
            this.btnchia.TabIndex = 4;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelKQ
            // 
            this.labelKQ.AutoSize = true;
            this.labelKQ.Location = new System.Drawing.Point(196, 318);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(12, 15);
            this.labelKQ.TabIndex = 1;
            this.labelKQ.Text = "0";
            this.labelKQ.Click += new System.EventHandler(this.label2_Click);
            // 
            // frnMathBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 520);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Minion Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frnMathBasic";
            this.Text = "Chương trình tính toán cơ bản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKQ;
    }
}

