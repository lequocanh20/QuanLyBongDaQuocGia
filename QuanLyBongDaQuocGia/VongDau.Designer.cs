
namespace QuanLyBongDaQuocGia
{
    partial class VongDau
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
            this.lbMaVD = new System.Windows.Forms.Label();
            this.lbTenVD = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tBmaVD = new System.Windows.Forms.TextBox();
            this.tBtenVD = new System.Windows.Forms.TextBox();
            this.dGVvongDau = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVvongDau)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaVD
            // 
            this.lbMaVD.AutoSize = true;
            this.lbMaVD.Location = new System.Drawing.Point(13, 13);
            this.lbMaVD.Name = "lbMaVD";
            this.lbMaVD.Size = new System.Drawing.Size(77, 13);
            this.lbMaVD.TabIndex = 0;
            this.lbMaVD.Text = "Mã vòng đấu :";
            // 
            // lbTenVD
            // 
            this.lbTenVD.AutoSize = true;
            this.lbTenVD.Location = new System.Drawing.Point(230, 13);
            this.lbTenVD.Name = "lbTenVD";
            this.lbTenVD.Size = new System.Drawing.Size(78, 13);
            this.lbTenVD.TabIndex = 0;
            this.lbTenVD.Text = "Tên vòng đấu:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 47);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(175, 47);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(339, 47);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tBmaVD
            // 
            this.tBmaVD.Location = new System.Drawing.Point(94, 10);
            this.tBmaVD.Name = "tBmaVD";
            this.tBmaVD.Size = new System.Drawing.Size(100, 20);
            this.tBmaVD.TabIndex = 2;
            // 
            // tBtenVD
            // 
            this.tBtenVD.Location = new System.Drawing.Point(314, 10);
            this.tBtenVD.Name = "tBtenVD";
            this.tBtenVD.Size = new System.Drawing.Size(100, 20);
            this.tBtenVD.TabIndex = 2;
            // 
            // dGVvongDau
            // 
            this.dGVvongDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVvongDau.Location = new System.Drawing.Point(15, 79);
            this.dGVvongDau.Name = "dGVvongDau";
            this.dGVvongDau.Size = new System.Drawing.Size(399, 150);
            this.dGVvongDau.TabIndex = 3;
            // 
            // VongDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 241);
            this.Controls.Add(this.dGVvongDau);
            this.Controls.Add(this.tBtenVD);
            this.Controls.Add(this.tBmaVD);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbTenVD);
            this.Controls.Add(this.lbMaVD);
            this.Name = "VongDau";
            this.Text = "Vòng đấu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VongDau_FormClosing);
            this.Load += new System.EventHandler(this.LoaiCauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVvongDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaVD;
        private System.Windows.Forms.Label lbTenVD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox tBmaVD;
        private System.Windows.Forms.TextBox tBtenVD;
        private System.Windows.Forms.DataGridView dGVvongDau;
    }
}