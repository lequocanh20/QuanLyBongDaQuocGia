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
    public partial class QLLichThiDau : Form
    {
        public QLLichThiDau()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            var dslichthidau = from u in qlbd.LICHTHIDAUs select new { MaTD = u.MaTD, DoiChuNha = u.DOIBONG1.TenDB, DoiKhach = u.DOIBONG.TenDB, NgayThiDau = u.NgayThiDau, SanThiDau = u.SanThiDau, VongDau = u.VONGDAU.TenVD };
            dGVlichThiDau.DataSource = dslichthidau.ToList();
            tBmaTD.DataBindings.Clear();
            tBmaTD.DataBindings.Add("Text", dGVlichThiDau.DataSource, "MaTD");
            cBdoi1.DataSource = qlbd.DOIBONGs.ToList();
            cBdoi1.DisplayMember = "TenDB";
            cBdoi1.DataBindings.Clear();
            cBdoi1.DataBindings.Add("Text", dGVlichThiDau.DataSource, "DoiChuNha");
            cBdoi2.DataSource = qlbd.DOIBONGs.ToList();
            cBdoi2.DisplayMember = "TenDB";
            cBdoi2.DataBindings.Clear();
            cBdoi2.DataBindings.Add("Text", dGVlichThiDau.DataSource, "DoiKhach");
            tBngayGio.DataBindings.Clear();
            tBngayGio.DataBindings.Add("Text", dGVlichThiDau.DataSource, "NgayThiDau");
            tBsanThiDau.DataBindings.Clear();
            tBsanThiDau.DataBindings.Add("Text", dGVlichThiDau.DataSource, "SanThiDau");
            cBvongDau.DataBindings.Clear();
            cBvongDau.DataBindings.Add("Text", dGVlichThiDau.DataSource, "VongDau");
        }

        public void changegridview()
        {
            dGVlichThiDau.Columns[0].HeaderText = "Mã trận đấu";
            dGVlichThiDau.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVlichThiDau.Columns[1].HeaderText = "Đội chủ nhà";
            dGVlichThiDau.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVlichThiDau.Columns[2].HeaderText = "Đội khách";
            dGVlichThiDau.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVlichThiDau.Columns[3].HeaderText = "Ngày thi đấu";
            dGVlichThiDau.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVlichThiDau.Columns[4].HeaderText = "Sân thi đấu";
            dGVlichThiDau.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVlichThiDau.Columns[5].HeaderText = "Vòng đấu";
            dGVlichThiDau.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void QLLichThiDau_Load(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            xemdulieu();
            changegridview();
            cBvongDau.DataSource = qlbd.VONGDAUs.ToList();
            cBvongDau.DisplayMember = "TenVD";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbddel = new QLGVDBDQGEntities();
            string matrandau = tBmaTD.Text;
            LICHTHIDAU LTD = qlbddel.LICHTHIDAUs.Where(ltd => ltd.MaTD == matrandau).SingleOrDefault();
            if (LTD != null)
            {
                qlbddel.LICHTHIDAUs.Remove(LTD);
                qlbddel.SaveChanges();
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
            QLGVDBDQGEntities qlbdedit = new QLGVDBDQGEntities();
            string matrandau = tBmaTD.Text;
            LICHTHIDAU LTD = qlbdedit.LICHTHIDAUs.Where(ltd => ltd.MaTD == matrandau).SingleOrDefault();
            if (LTD != null)
            {
                LTD.DoiChuNha = ((DOIBONG)cBdoi1.SelectedValue).MaDB;
                LTD.DoiKhach = ((DOIBONG)cBdoi2.SelectedValue).MaDB;
                LTD.NgayThiDau = Convert.ToDateTime(tBngayGio.Text);
                LTD.SanThiDau = Convert.ToString(tBsanThiDau.Text);
                LTD.MaVD = ((VONGDAU)cBvongDau.SelectedValue).MaVD;
                qlbdedit.SaveChanges();
                MessageBox.Show("Đã sửa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        private void QLLichThiDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void cBdoi1_SelectedValueChanged(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            foreach (var item in qlbd.DOIBONGs)
            {
                if (((DOIBONG)cBdoi1.SelectedValue).MaDB == item.MaDB)
                {
                    tBsanThiDau.Text = item.SanNha;
                }
            }
        }
    }
}
