
namespace QuanLyBongDaQuocGia
{
    partial class QLCauThu
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
            this.dGVcauThu = new System.Windows.Forms.DataGridView();
            this.tBmaCT = new System.Windows.Forms.TextBox();
            this.lbMaCauThu = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tBghiChu = new System.Windows.Forms.TextBox();
            this.tBtenCT = new System.Windows.Forms.TextBox();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbLoaiCauThu = new System.Windows.Forms.Label();
            this.lbDoiBong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenCT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVcauThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dTPngaySinh
            // 
            this.dTPngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPngaySinh.Location = new System.Drawing.Point(408, 49);
            this.dTPngaySinh.Name = "dTPngaySinh";
            this.dTPngaySinh.Size = new System.Drawing.Size(154, 20);
            this.dTPngaySinh.TabIndex = 60;
            // 
            // cBdoiBong
            // 
            this.cBdoiBong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBdoiBong.FormattingEnabled = true;
            this.cBdoiBong.Items.AddRange(new object[] {
            "Trong nước ",
            "Ngoài nước"});
            this.cBdoiBong.Location = new System.Drawing.Point(109, 88);
            this.cBdoiBong.Margin = new System.Windows.Forms.Padding(2);
            this.cBdoiBong.Name = "cBdoiBong";
            this.cBdoiBong.Size = new System.Drawing.Size(154, 21);
            this.cBdoiBong.TabIndex = 61;
            // 
            // cBloaiCT
            // 
            this.cBloaiCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBloaiCT.FormattingEnabled = true;
            this.cBloaiCT.ItemHeight = 13;
            this.cBloaiCT.Items.AddRange(new object[] {
            "Trong nước ",
            "Ngoài nước"});
            this.cBloaiCT.Location = new System.Drawing.Point(109, 49);
            this.cBloaiCT.Margin = new System.Windows.Forms.Padding(2);
            this.cBloaiCT.Name = "cBloaiCT";
            this.cBloaiCT.Size = new System.Drawing.Size(154, 21);
            this.cBloaiCT.TabIndex = 59;
            // 
            // dGVcauThu
            // 
            this.dGVcauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVcauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcauThu.Location = new System.Drawing.Point(14, 136);
            this.dGVcauThu.Margin = new System.Windows.Forms.Padding(2);
            this.dGVcauThu.Name = "dGVcauThu";
            this.dGVcauThu.RowTemplate.Height = 28;
            this.dGVcauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVcauThu.Size = new System.Drawing.Size(629, 303);
            this.dGVcauThu.TabIndex = 72;
            // 
            // tBmaCT
            // 
            this.tBmaCT.Enabled = false;
            this.tBmaCT.Location = new System.Drawing.Point(109, 17);
            this.tBmaCT.Margin = new System.Windows.Forms.Padding(2);
            this.tBmaCT.Name = "tBmaCT";
            this.tBmaCT.Size = new System.Drawing.Size(154, 20);
            this.tBmaCT.TabIndex = 57;
            // 
            // lbMaCauThu
            // 
            this.lbMaCauThu.AutoSize = true;
            this.lbMaCauThu.Location = new System.Drawing.Point(11, 21);
            this.lbMaCauThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCauThu.Name = "lbMaCauThu";
            this.lbMaCauThu.Size = new System.Drawing.Size(64, 13);
            this.lbMaCauThu.TabIndex = 71;
            this.lbMaCauThu.Text = "Mã cầu thủ:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(582, 14);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 33);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(582, 76);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 33);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tBghiChu
            // 
            this.tBghiChu.Location = new System.Drawing.Point(408, 89);
            this.tBghiChu.Margin = new System.Windows.Forms.Padding(2);
            this.tBghiChu.Name = "tBghiChu";
            this.tBghiChu.Size = new System.Drawing.Size(154, 20);
            this.tBghiChu.TabIndex = 62;
            // 
            // tBtenCT
            // 
            this.tBtenCT.Location = new System.Drawing.Point(408, 14);
            this.tBtenCT.Margin = new System.Windows.Forms.Padding(2);
            this.tBtenCT.Name = "tBtenCT";
            this.tBtenCT.Size = new System.Drawing.Size(154, 20);
            this.tBtenCT.TabIndex = 58;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(320, 52);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lbNgaySinh.TabIndex = 69;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // lbLoaiCauThu
            // 
            this.lbLoaiCauThu.AutoSize = true;
            this.lbLoaiCauThu.Location = new System.Drawing.Point(11, 52);
            this.lbLoaiCauThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoaiCauThu.Name = "lbLoaiCauThu";
            this.lbLoaiCauThu.Size = new System.Drawing.Size(69, 13);
            this.lbLoaiCauThu.TabIndex = 70;
            this.lbLoaiCauThu.Text = "Loại cầu thủ:";
            // 
            // lbDoiBong
            // 
            this.lbDoiBong.AutoSize = true;
            this.lbDoiBong.Location = new System.Drawing.Point(11, 92);
            this.lbDoiBong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoiBong.Name = "lbDoiBong";
            this.lbDoiBong.Size = new System.Drawing.Size(56, 13);
            this.lbDoiBong.TabIndex = 66;
            this.lbDoiBong.Text = "Đội bóng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ghi chú:";
            // 
            // lbTenCT
            // 
            this.lbTenCT.AutoSize = true;
            this.lbTenCT.Location = new System.Drawing.Point(320, 17);
            this.lbTenCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenCT.Name = "lbTenCT";
            this.lbTenCT.Size = new System.Drawing.Size(50, 13);
            this.lbTenCT.TabIndex = 67;
            this.lbTenCT.Text = "Cầu thủ: ";
            // 
            // QLCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.dTPngaySinh);
            this.Controls.Add(this.cBdoiBong);
            this.Controls.Add(this.cBloaiCT);
            this.Controls.Add(this.dGVcauThu);
            this.Controls.Add(this.tBmaCT);
            this.Controls.Add(this.lbMaCauThu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tBghiChu);
            this.Controls.Add(this.tBtenCT);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbLoaiCauThu);
            this.Controls.Add(this.lbDoiBong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTenCT);
            this.Name = "QLCauThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cầu Thủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLCauThu_FormClosing);
            this.Load += new System.EventHandler(this.QLCauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcauThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPngaySinh;
        private System.Windows.Forms.ComboBox cBdoiBong;
        private System.Windows.Forms.ComboBox cBloaiCT;
        private System.Windows.Forms.DataGridView dGVcauThu;
        private System.Windows.Forms.TextBox tBmaCT;
        private System.Windows.Forms.Label lbMaCauThu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tBghiChu;
        private System.Windows.Forms.TextBox tBtenCT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbLoaiCauThu;
        private System.Windows.Forms.Label lbDoiBong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenCT;
    }
}