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
    public partial class KetQuaThiDau : Form
    {
        public KetQuaThiDau()
        {
            InitializeComponent();
        }

        private QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
        public void xemdulieu()
        {
            var dsketqua = from u in qlbd.KETQUATHIDAUs select new { MaKQ = u.MaKQ, BTDoi1 = u.BTDoi1, BTDoi2 = u.BTDoi2, DoiChuNha = u.LICHTHIDAU.DOIBONG1.TenDB, DoiKhach = u.LICHTHIDAU.DOIBONG.TenDB, NgayGio = u.LICHTHIDAU.NgayThiDau, SanThiDau = u.LICHTHIDAU.SanThiDau };
            dGVketQua.DataSource = dsketqua.ToList();
            tBtiSoDoi1.DataBindings.Clear();
            tBtiSoDoi1.DataBindings.Add("Text", dGVketQua.DataSource, "BTDoi1");
            tBtiSoDoi2.DataBindings.Clear();
            tBtiSoDoi2.DataBindings.Add("Text", dGVketQua.DataSource, "BTDoi2");
            tBmaKetQua.DataBindings.Clear();
            tBmaKetQua.DataBindings.Add("Text", dGVketQua.DataSource, "MaKQ");
            tBngayGio.DataBindings.Clear();
            tBngayGio.DataBindings.Add("Text", dGVketQua.DataSource, "NgayGio");
            tBsanThiDau.DataBindings.Clear();
            tBsanThiDau.DataBindings.Add("Text", dGVketQua.DataSource, "SanThiDau");
            tBdoi1.DataBindings.Clear();
            tBdoi1.DataBindings.Add("Text", dGVketQua.DataSource, "DoiChuNha");
            tBdoi2.DataBindings.Clear();
            tBdoi2.DataBindings.Add("Text", dGVketQua.DataSource, "DoiKhach");
        }

        public void changegridview()
        {
            dGVketQua.Columns[0].HeaderText = "Mã kết quả";
            dGVketQua.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[1].HeaderText = "Bàn thắng đội chủ nhà";
            dGVketQua.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[2].HeaderText = "Bàn thắng đội khách";
            dGVketQua.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[3].HeaderText = "Đội chủ nhà";
            dGVketQua.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[4].HeaderText = "Đội khách";
            dGVketQua.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[5].HeaderText = "Ngày thi đấu";
            dGVketQua.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVketQua.Columns[6].HeaderText = "Sân thi đấu";
            dGVketQua.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void KetQuaThiDau_Load(object sender, EventArgs e)
        {
            xemdulieu();
            changegridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maketqua = tBmaKetQua.Text;
            KETQUATHIDAU KQ = qlbd.KETQUATHIDAUs.Where(kq => kq.MaKQ == maketqua).SingleOrDefault();
            if (KQ != null)
            {
                qlbd.KETQUATHIDAUs.Remove(KQ);
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
            string maketqua = tBmaKetQua.Text;
            KETQUATHIDAU KQ = qlbd.KETQUATHIDAUs.Where(kq => kq.MaKQ == maketqua).SingleOrDefault();
            if (KQ != null)
            {
                KQ.MaKQ = tBmaKetQua.Text;
                KQ.BTDoi1 = Convert.ToInt32(tBtiSoDoi1.Text);
                KQ.BTDoi2 = Convert.ToInt32(tBtiSoDoi2.Text);
                qlbd.SaveChanges();
                MessageBox.Show("Đã sửa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        private void KetQuaThiDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void dGVketQua_DoubleClick(object sender, EventArgs e)
        {
            ChiTietKetQua ctkq = new ChiTietKetQua();
            this.Hide();
            ctkq.Show();
        }
    }
}
