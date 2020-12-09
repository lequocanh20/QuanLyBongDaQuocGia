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
    public partial class ChiTietKetQua : Form
    {
        public ChiTietKetQua()
        {
            InitializeComponent();
        }

        private QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();

        public void xemdulieu()
        {
            var dsctkq = from u in qlbd.CHITIETKETQUAs select new { STT = u.MaCTKQ, TenCT = u.CAUTHU.TenCT, TenDB = u.DOIBONG.TenDB, LoaiBT = u.LoaiBT, ThoiDiem = u.ThoiDiem, MaKQ = u.MaKQ };
            dGVketQua.DataSource = dsctkq.ToList();
            tBstt.DataBindings.Clear();
            tBstt.DataBindings.Add("Text", dGVketQua.DataSource, "STT");
            cBcauThu.DataSource = qlbd.CAUTHUs.ToList();
            cBcauThu.DisplayMember = "TenCT";
            cBcauThu.DataBindings.Clear();
            cBcauThu.DataBindings.Add("Text", dGVketQua.DataSource, "TenCT");
            cBdoiBong.DataSource = qlbd.DOIBONGs.ToList();
            cBdoiBong.DisplayMember = "TenDB";
            cBdoiBong.DataBindings.Clear();
            cBdoiBong.DataBindings.Add("Text", dGVketQua.DataSource, "TenDB");
            tBloaiBT.DataBindings.Clear();
            tBloaiBT.DataBindings.Add("Text", dGVketQua.DataSource, "LoaiBT");
            tBthoiDiem.DataBindings.Clear();
            tBthoiDiem.DataBindings.Add("Text", dGVketQua.DataSource, "ThoiDiem");
            cBmaKQ.DataSource = qlbd.KETQUATHIDAUs.ToList();
            cBmaKQ.DisplayMember = "MaKQ";
            cBmaKQ.DataBindings.Clear();
            cBmaKQ.DataBindings.Add("Text", dGVketQua.DataSource, "MaKQ");
        }

        public void changegridview()
        {
            dGVketQua.Columns[0].HeaderText = "STT";
            dGVketQua.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[1].HeaderText = "Cầu thủ";
            dGVketQua.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[2].HeaderText = "Đội bóng";
            dGVketQua.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[3].HeaderText = "Loại bàn thắng";
            dGVketQua.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[4].HeaderText = "Thời điểm";
            dGVketQua.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[5].HeaderText = "Mã kết quả";
            dGVketQua.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ChiTietKetQua_Load(object sender, EventArgs e)
        {
            xemdulieu();
            changegridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(tBstt.Text);
            CHITIETKETQUA CTKQ = qlbd.CHITIETKETQUAs.Where(ctkq => ctkq.MaCTKQ == stt).SingleOrDefault();
            if (CTKQ != null)
            {
                qlbd.CHITIETKETQUAs.Remove(CTKQ);
                qlbd.SaveChanges();
                MessageBox.Show("Đã xóa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(tBstt.Text);
            CHITIETKETQUA CTKQ = qlbd.CHITIETKETQUAs.Where(ctkq => ctkq.MaCTKQ == stt).SingleOrDefault();
            if (CTKQ != null)
            {
                CTKQ.MaCT = ((CAUTHU)cBcauThu.SelectedValue).MaCT;
                CTKQ.MaDB = ((DOIBONG)cBdoiBong.SelectedValue).MaDB;
                CTKQ.LoaiBT = tBloaiBT.Text;
                CTKQ.ThoiDiem = Convert.ToInt32(tBthoiDiem.Text);
                qlbd.SaveChanges();
                MessageBox.Show("Đã sửa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        private void ChiTietKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            KetQuaThiDau kq = new KetQuaThiDau();
            this.Hide();
            kq.Show();
        }
    }
}
