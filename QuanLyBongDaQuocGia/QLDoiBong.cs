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
    public partial class QLDoiBong : Form
    {
        public QLDoiBong()
        {
            InitializeComponent();
        }
        QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
        public void xemdulieu()
        {           
            var dsdoibong = from u in qlbd.DOIBONGs select new { MaDB = u.MaDB, TenDB = u.TenDB, SanNha = u.SanNha };
            dGVdoiBong.DataSource = dsdoibong.ToList();
            tBmaDB.DataBindings.Clear();
            tBmaDB.DataBindings.Add(new Binding("Text", dGVdoiBong.DataSource, "MaDB"));
            tBtenDB.DataBindings.Clear();
            tBtenDB.DataBindings.Add(new Binding("Text", dGVdoiBong.DataSource, "TenDB"));
            tBsanNha.DataBindings.Clear();
            tBsanNha.DataBindings.Add(new Binding("Text", dGVdoiBong.DataSource, "SanNha"));
        }

        public void changegridview()
        {
            dGVdoiBong.Columns[0].HeaderText = "Mã đội bóng";
            dGVdoiBong.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVdoiBong.Columns[1].HeaderText = "Tên đội bóng";
            dGVdoiBong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVdoiBong.Columns[2].HeaderText = "Sân nhà";
            dGVdoiBong.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void QLDoiBong_Load(object sender, EventArgs e)
        {
            xemdulieu();
            changegridview();
        }

        private void QLDoiBong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbddel = new QLGVDBDQGEntities();
            string madoibong = tBmaDB.Text;
            DOIBONG DB = qlbddel.DOIBONGs.Where(db => db.MaDB == madoibong).SingleOrDefault();
            if (DB != null)
            {
                qlbddel.DOIBONGs.Remove(DB);
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
            string madoibong = tBmaDB.Text;
            DOIBONG DB = qlbdedit.DOIBONGs.Where(db => db.MaDB == madoibong).SingleOrDefault();
            if (DB != null)
            {
                DB.MaDB = Convert.ToString(tBmaDB.Text);
                DB.TenDB = Convert.ToString(tBtenDB.Text);
                DB.SanNha = Convert.ToString(tBsanNha.Text);
                qlbdedit.SaveChanges();
                MessageBox.Show("Đã sửa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        public void timdoibong()
        {
            var timkiem = from u in qlbd.DOIBONGs
                          where u.MaDB.StartsWith(tBtimKiem.Text) || u.TenDB.Contains(tBtimKiem.Text) || u.SanNha.Contains(tBtimKiem.Text)
                          select new { u.MaDB, u.TenDB, u.SanNha };
            dGVdoiBong.DataSource = timkiem.ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            timdoibong();
        }
    }
}
