using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBongDaQuocGia.DAL;

namespace QuanLyBongDaQuocGia
{
    public partial class ThemChiTietKetQua : Form
    {
        public ThemChiTietKetQua()
        {
            InitializeComponent();
        }

        private QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();

        private ChiTietKetQua ct = new ChiTietKetQua();

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int stt = 0;
            CHITIETKETQUA CTKQ = qlbd.CHITIETKETQUAs.Where(ctkq => ctkq.MaCTKQ == stt).SingleOrDefault();
            if (CTKQ == null)
            {
                CHITIETKETQUA item = new CHITIETKETQUA();
                item.MaCT = ((CAUTHU)cBcauThu.SelectedValue).MaCT;
                item.MaDB = ((DOIBONG)cBdoiBong.SelectedValue).MaDB;
                item.LoaiBT = tBloaiBT.Text;
                item.ThoiDiem = Convert.ToInt32(tBthoiDiem.Text);
                item.MaKQ = ((KETQUATHIDAU)cBmaKQ.SelectedValue).MaKQ;
                qlbd.CHITIETKETQUAs.Add(item);
                qlbd.SaveChanges();
                MessageBox.Show("Đã thêm vào", "Thông báo");
                ct.xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        private void ThemChiTietKetQua_Load(object sender, EventArgs e)
        {
            cBcauThu.DataSource = qlbd.CAUTHUs.ToList();
            cBcauThu.DisplayMember = "TenCT";
            cBdoiBong.DataSource = qlbd.DOIBONGs.ToList();
            cBdoiBong.DisplayMember = "TenDB";
            cBmaKQ.DataSource = qlbd.KETQUATHIDAUs.ToList();
            cBmaKQ.DisplayMember = "MaKQ";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void ThemChiTietKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
