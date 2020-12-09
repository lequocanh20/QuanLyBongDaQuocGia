
namespace QuanLyBongDaQuocGia
{
    partial class ThemCauThu
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
            this.dTPngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cBdoiBong = new System.Windows.Forms.ComboBox();
            this.cBloaiCT = new System.Windows.Forms.ComboBox();
            this.tBmaCT = new System.Windows.Forms.TextBox();
            this.lbMaCauThu = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.tBghiChu = new System.Windows.Forms.TextBox();
            this.tBtenCT = new System.Windows.Forms.TextBox();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbLoaiCauThu = new System.Windows.Forms.Label();
            this.lbDoiBong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenCT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dTPngaySinh
            // 
            this.dTPngaySinh.CustomFormat = "dd/MM/yyyy";
            this.dTPngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPngaySinh.Location = new System.Drawing.Point(327, 46);
            this.dTPngaySinh.Name = "dTPngaySinh";
            this.dTPngaySinh.Size = new System.Drawing.Size(154, 20);
            this.dTPngaySinh.TabIndex = 74;
            this.dTPngaySinh.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            // 
            // cBdoiBong
            // 
            this.cBdoiBong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBdoiBong.FormattingEnabled = true;
            this.cBdoiBong.Items.AddRange(new object[] {
            "Trong nước ",
            "Ngoài nước"});
            this.cBdoiBong.Location = new System.Drawing.Point(110, 85);
            this.cBdoiBong.Margin = new System.Windows.Forms.Padding(2);
            this.cBdoiBong.Name = "cBdoiBong";
            this.cBdoiBong.Size = new System.Drawing.Size(96, 21);
            this.cBdoiBong.TabIndex = 75;
            // 
            // cBloaiCT
            // 
            this.cBloaiCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBloaiCT.FormattingEnabled = true;
            this.cBloaiCT.Items.AddRange(new object[] {
            "Trong nước ",
            "Ngoài nước"});
            this.cBloaiCT.Location = new System.Drawing.Point(110, 46);
            this.cBloaiCT.Margin = new System.Windows.Forms.Padding(2);
            this.cBloaiCT.Name = "cBloaiCT";
            this.cBloaiCT.Size = new System.Drawing.Size(96, 21);
            this.cBloaiCT.TabIndex = 73;
            // 
            // tBmaCT
            // 
            this.tBmaCT.Location = new System.Drawing.Point(110, 11);
            this.tBmaCT.Margin = new System.Windows.Forms.Padding(2);
            this.tBmaCT.Name = "tBmaCT";
            this.tBmaCT.Size = new System.Drawing.Size(94, 20);
            this.tBmaCT.TabIndex = 71;
            this.tBmaCT.Text = "CT";
            this.tBmaCT.WordWrap = false;
            // 
            // lbMaCauThu
            // 
            this.lbMaCauThu.AutoSize = true;
            this.lbMaCauThu.Location = new System.Drawing.Point(22, 13);
            this.lbMaCauThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCauThu.Name = "lbMaCauThu";
            this.lbMaCauThu.Size = new System.Drawing.Size(64, 13);
            this.lbMaCauThu.TabIndex = 84;
            this.lbMaCauThu.Text = "Mã cầu thủ:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(327, 123);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 33);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(110, 123);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(61, 33);
            this.btnXacNhan.TabIndex = 77;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // tBghiChu
            // 
            this.tBghiChu.Location = new System.Drawing.Point(327, 86);
            this.tBghiChu.Margin = new System.Windows.Forms.Padding(2);
            this.tBghiChu.Name = "tBghiChu";
            this.tBghiChu.Size = new System.Drawing.Size(154, 20);
            this.tBghiChu.TabIndex = 76;
            // 
            // tBtenCT
            // 
            this.tBtenCT.Location = new System.Drawing.Point(327, 11);
            this.tBtenCT.Margin = new System.Windows.Forms.Padding(2);
            this.tBtenCT.Name = "tBtenCT";
            this.tBtenCT.Size = new System.Drawing.Size(154, 20);
            this.tBtenCT.TabIndex = 72;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(239, 49);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lbNgaySinh.TabIndex = 82;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // lbLoaiCauThu
            // 
            this.lbLoaiCauThu.AutoSize = true;
            this.lbLoaiCauThu.Location = new System.Drawing.Point(22, 48);
            this.lbLoaiCauThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoaiCauThu.Name = "lbLoaiCauThu";
            this.lbLoaiCauThu.Size = new System.Drawing.Size(69, 13);
            this.lbLoaiCauThu.TabIndex = 83;
            this.lbLoaiCauThu.Text = "Loại cầu thủ:";
            // 
            // lbDoiBong
            // 
            this.lbDoiBong.AutoSize = true;
            this.lbDoiBong.Location = new System.Drawing.Point(22, 88);
            this.lbDoiBong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoiBong.Name = "lbDoiBong";
            this.lbDoiBong.Size = new System.Drawing.Size(56, 13);
            this.lbDoiBong.TabIndex = 79;
            this.lbDoiBong.Text = "Đội bóng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Ghi chú:";
            // 
            // lbTenCT
            // 
            this.lbTenCT.AutoSize = true;
            this.lbTenCT.Location = new System.Drawing.Point(239, 14);
            this.lbTenCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenCT.Name = "lbTenCT";
            this.lbTenCT.Size = new System.Drawing.Size(50, 13);
            this.lbTenCT.TabIndex = 80;
            this.lbTenCT.Text = "Cầu thủ: ";
            // 
            // ThemCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 165);
            this.Controls.Add(this.dTPngaySinh);
            this.Controls.Add(this.cBdoiBong);
            this.Controls.Add(this.cBloaiCT);
            this.Controls.Add(this.tBmaCT);
            this.Controls.Add(this.lbMaCauThu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tBghiChu);
            this.Controls.Add(this.tBtenCT);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbLoaiCauThu);
            this.Controls.Add(this.lbDoiBong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTenCT);
            this.Name = "ThemCauThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập liệu cầu thủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemCauThu_FormClosing);
            this.Load += new System.EventHandler(this.ThemCauThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPngaySinh;
        private System.Windows.Forms.ComboBox cBdoiBong;
        private System.Windows.Forms.ComboBox cBloaiCT;
        private System.Windows.Forms.TextBox tBmaCT;
        private System.Windows.Forms.Label lbMaCauThu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox tBghiChu;
        private System.Windows.Forms.TextBox tBtenCT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbLoaiCauThu;
        private System.Windows.Forms.Label lbDoiBong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenCT;
    }
}