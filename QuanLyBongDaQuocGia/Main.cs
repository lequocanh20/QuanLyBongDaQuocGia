using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBongDaQuocGia
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void độiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDoiBong db = new QLDoiBong();
            this.Hide();
            db.Show();
        }

        private void cầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLCauThu ct = new QLCauThu();
            this.Hide();
            ct.Show();
        }

        private void danhSáchCácCầuThủGhiBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lịchThiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLLichThiDau ltd = new QLLichThiDau();
            this.Hide();
            ltd.Show();
        }

        private void kếtQuảThiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KetQuaThiDau kq = new KetQuaThiDau();
            this.Hide();
            kq.Show();
        }

        private void bảngXếpHạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangXepHang bxh = new BangXepHang();
            this.Hide();
            bxh.Show();
        }

        private void cầuThủToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemCauThu tct = new ThemCauThu();
            this.Hide();
            tct.Show();
        }

        private void độiBóngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemDoiBong tdb = new ThemDoiBong();
            this.Hide();
            tdb.Show();
        }

        private void vòngĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VongDau vd = new VongDau();
            this.Hide();
            vd.Show();
        }

        private void lịchThiĐấuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemLichThiDau tltd = new ThemLichThiDau();
            this.Hide();
            tltd.Show();
        }

        private void kếtQuảThiĐấuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemKetQua tkq = new ThemKetQua();
            this.Hide();
            tkq.Show();
        }

        private void chiTiếtKếtQuảThiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemChiTietKetQua tctkq = new ThemChiTietKetQua();
            this.Hide();
            tctkq.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                Application.ExitThread();
            }  
        }
    }
}
