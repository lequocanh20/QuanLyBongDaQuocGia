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
    public partial class VongDau : Form
    {
        public VongDau()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            var dsvongdau = from u in qlbd.VONGDAUs select new { MaVD = u.MaVD, TenVD = u.TenVD};
            dGVvongDau.DataSource = dsvongdau.ToList();
            tBmaVD.DataBindings.Clear();
            tBmaVD.DataBindings.Add(new Binding("Text", dGVvongDau.DataSource, "MaVD"));
            tBtenVD.DataBindings.Clear();
            tBtenVD.DataBindings.Add(new Binding("Text", dGVvongDau.DataSource, "TenVD"));
        }

        public void changegridview()
        {
            dGVvongDau.Columns[0].HeaderText = "Mã vòng đấu";
            dGVvongDau.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVvongDau.Columns[1].HeaderText = "Tên vòng đấu";
            dGVvongDau.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbdadd = new QLGVDBDQGEntities();
            string mavongdau = "";
            VONGDAU VD = qlbdadd.VONGDAUs.Where(vd=> vd.MaVD == mavongdau).SingleOrDefault();
            if (VD == null)
            {
                VONGDAU item = new VONGDAU();
                item.MaVD = Convert.ToString(tBmaVD.Text);
                item.TenVD = Convert.ToString(tBtenVD.Text);
                qlbdadd.VONGDAUs.Add(item);
                qlbdadd.SaveChanges();
                MessageBox.Show("Đã nhập vào thành công", "Thông báo");
                tBmaVD.Text = "VD";
                tBtenVD.Text = "";
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại...", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbddel = new QLGVDBDQGEntities();
            string mavongdau = tBmaVD.Text;
            VONGDAU VD = qlbddel.VONGDAUs.Where(vd => vd.MaVD == mavongdau).SingleOrDefault();
            if (VD != null)
            {
                qlbddel.VONGDAUs.Remove(VD);
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
            string mavongdau = tBmaVD.Text;
            VONGDAU VD = qlbdedit.VONGDAUs.Where(vd => vd.MaVD == mavongdau).SingleOrDefault();
            if (VD != null)
            {
                VD.MaVD = Convert.ToString(tBmaVD.Text);
                VD.TenVD = Convert.ToString(tBtenVD.Text);
                qlbdedit.SaveChanges();
                MessageBox.Show("Đã sửa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        private void LoaiCauThu_Load(object sender, EventArgs e)
        {
            xemdulieu();
            changegridview();
        }

        private void VongDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
