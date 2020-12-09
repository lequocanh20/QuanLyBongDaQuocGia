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
    public partial class ThemDoiBong : Form
    {
        public ThemDoiBong()
        {
            InitializeComponent();
        }

        QLDoiBong ql = new QLDoiBong();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbdadd = new QLGVDBDQGEntities();
            QLGVDBDQGEntities qlbdadd1 = new QLGVDBDQGEntities();
            string madoibong = "";
            DOIBONG DB = qlbdadd.DOIBONGs.Where(db => db.MaDB == madoibong).SingleOrDefault();
            if (DB == null)
            {
                DOIBONG item = new DOIBONG();
                BANGXEPHANG item1 = new BANGXEPHANG();
                item.MaDB = Convert.ToString(tBmaDB.Text);               
                item.TenDB = Convert.ToString(tBtenDB.Text);
                item.SanNha = Convert.ToString(tBsanNha.Text);
                item1.MaDB = item.MaDB;
                item1.Thang = 0;
                item1.Hoa = 0;
                item1.Thua = 0;
                item1.HieuSo = 0;
                item1.Diem = 0;
                qlbdadd.DOIBONGs.Add(item);
                qlbdadd1.BANGXEPHANGs.Add(item1);
                qlbdadd.SaveChanges();
                qlbdadd1.SaveChanges();
                MessageBox.Show("Đã nhập vào thành công", "Thông báo");
                tBmaDB.Text = "DB";
                tBtenDB.Text = "";
                tBsanNha.Text = "";
                ql.xemdulieu();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại....", "Lỗi");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void ThemDoiBong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
