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
    public partial class BangXepHang : Form
    {
        public BangXepHang()
        {
            InitializeComponent();
        }
        private QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
        public void xemdulieu()
        {
            var bangxephang = from u in qlbd.BANGXEPHANGs
                              orderby u.Diem descending
                              select new {MaXH = u.MaXH, MaDB = u.DOIBONG.TenDB, Thang = u.Thang, Hoa = u.Hoa, Thua = u.Thua, HieuSo = u.HieuSo, Diem = u.Diem };
            dataGridView1.DataSource = bangxephang.ToList();
        }

        public void changegridview()
        {
            dataGridView1.Columns[1].HeaderText = "Đội bóng";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Thắng";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Hòa";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].HeaderText = "Thua";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].HeaderText = "Hiệu số";
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].HeaderText = "Điểm";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BangXepHang_Load(object sender, EventArgs e)
        {
            xemdulieu();
            changegridview();
        }

        private void BangXepHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
