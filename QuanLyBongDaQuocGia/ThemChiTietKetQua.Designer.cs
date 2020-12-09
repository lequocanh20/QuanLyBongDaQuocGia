
namespace QuanLyBongDaQuocGia
{
    partial class ThemChiTietKetQua
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cBdoiBong = new System.Windows.Forms.ComboBox();
            this.cBmaKQ = new System.Windows.Forms.ComboBox();
            this.cBcauThu = new System.Windows.Forms.ComboBox();
            this.tBloaiBT = new System.Windows.Forms.TextBox();
            this.tBthoiDiem = new System.Windows.Forms.TextBox();
            this.lbMaKQ = new System.Windows.Forms.Label();
            this.lbThoiDiem = new System.Windows.Forms.Label();
            this.lbLoaiBanThang = new System.Windows.Forms.Label();
            this.lbDoiBong = new System.Windows.Forms.Label();
            this.lbCauThu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(375, 138);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(247, 138);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 16;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cBdoiBong
            // 
            this.cBdoiBong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBdoiBong.FormattingEnabled = true;
            this.cBdoiBong.Location = new System.Drawing.Point(453, 12);
            this.cBdoiBong.Name = "cBdoiBong";
            this.cBdoiBong.Size = new System.Drawing.Size(212, 21);
            this.cBdoiBong.TabIndex = 11;
            // 
            // cBmaKQ
            // 
            this.cBmaKQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBmaKQ.FormattingEnabled = true;
            this.cBmaKQ.Location = new System.Drawing.Point(453, 61);
            this.cBmaKQ.Name = "cBmaKQ";
            this.cBmaKQ.Size = new System.Drawing.Size(101, 21);
            this.cBmaKQ.TabIndex = 13;
            // 
            // cBcauThu
            // 
            this.cBcauThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBcauThu.FormattingEnabled = true;
            this.cBcauThu.Location = new System.Drawing.Point(120, 12);
            this.cBcauThu.Name = "cBcauThu";
            this.cBcauThu.Size = new System.Drawing.Size(202, 21);
            this.cBcauThu.TabIndex = 10;
            // 
            // tBloaiBT
            // 
            this.tBloaiBT.Location = new System.Drawing.Point(120, 55);
            this.tBloaiBT.Name = "tBloaiBT";
            this.tBloaiBT.Size = new System.Drawing.Size(100, 20);
            this.tBloaiBT.TabIndex = 12;
            // 
            // tBthoiDiem
            // 
            this.tBthoiDiem.Location = new System.Drawing.Point(120, 95);
            this.tBthoiDiem.Name = "tBthoiDiem";
            this.tBthoiDiem.Size = new System.Drawing.Size(56, 20);
            this.tBthoiDiem.TabIndex = 14;
            // 
            // lbMaKQ
            // 
            this.lbMaKQ.AutoSize = true;
            this.lbMaKQ.Location = new System.Drawing.Point(372, 64);
            this.lbMaKQ.Name = "lbMaKQ";
            this.lbMaKQ.Size = new System.Drawing.Size(64, 13);
            this.lbMaKQ.TabIndex = 15;
            this.lbMaKQ.Text = "Mã kết quả:";
            // 
            // lbThoiDiem
            // 
            this.lbThoiDiem.AutoSize = true;
            this.lbThoiDiem.Location = new System.Drawing.Point(19, 102);
            this.lbThoiDiem.Name = "lbThoiDiem";
            this.lbThoiDiem.Size = new System.Drawing.Size(57, 13);
            this.lbThoiDiem.TabIndex = 17;
            this.lbThoiDiem.Text = "Thời điểm:";
            // 
            // lbLoaiBanThang
            // 
            this.lbLoaiBanThang.AutoSize = true;
            this.lbLoaiBanThang.Location = new System.Drawing.Point(19, 58);
            this.lbLoaiBanThang.Name = "lbLoaiBanThang";
            this.lbLoaiBanThang.Size = new System.Drawing.Size(81, 13);
            this.lbLoaiBanThang.TabIndex = 19;
            this.lbLoaiBanThang.Text = "Loại bàn thắng:";
            // 
            // lbDoiBong
            // 
            this.lbDoiBong.AutoSize = true;
            this.lbDoiBong.Location = new System.Drawing.Point(372, 15);
            this.lbDoiBong.Name = "lbDoiBong";
            this.lbDoiBong.Size = new System.Drawing.Size(53, 13);
            this.lbDoiBong.TabIndex = 20;
            this.lbDoiBong.Text = "Đội bóng:";
            // 
            // lbCauThu
            // 
            this.lbCauThu.AutoSize = true;
            this.lbCauThu.Location = new System.Drawing.Point(19, 15);
            this.lbCauThu.Name = "lbCauThu";
            this.lbCauThu.Size = new System.Drawing.Size(47, 13);
            this.lbCauThu.TabIndex = 21;
            this.lbCauThu.Text = "Cầu thủ:";
            // 
            // ThemChiTietKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 170);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cBdoiBong);
            this.Controls.Add(this.cBmaKQ);
            this.Controls.Add(this.cBcauThu);
            this.Controls.Add(this.tBloaiBT);
            this.Controls.Add(this.tBthoiDiem);
            this.Controls.Add(this.lbMaKQ);
            this.Controls.Add(this.lbThoiDiem);
            this.Controls.Add(this.lbLoaiBanThang);
            this.Controls.Add(this.lbDoiBong);
            this.Controls.Add(this.lbCauThu);
            this.Name = "ThemChiTietKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập liệu chi tiết kết quả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemChiTietKetQua_FormClosing);
            this.Load += new System.EventHandler(this.ThemChiTietKetQua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cBdoiBong;
        private System.Windows.Forms.ComboBox cBmaKQ;
        private System.Windows.Forms.ComboBox cBcauThu;
        private System.Windows.Forms.TextBox tBloaiBT;
        private System.Windows.Forms.TextBox tBthoiDiem;
        private System.Windows.Forms.Label lbMaKQ;
        private System.Windows.Forms.Label lbThoiDiem;
        private System.Windows.Forms.Label lbLoaiBanThang;
        private System.Windows.Forms.Label lbDoiBong;
        private System.Windows.Forms.Label lbCauThu;
    }
}