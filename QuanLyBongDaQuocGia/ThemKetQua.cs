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
    public partial class ThemKetQua : Form
    {
        public ThemKetQua()
        {
            InitializeComponent();
        }

        private QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
        private QLGVDBDQGEntities qlbd1 = new QLGVDBDQGEntities();
        private QLGVDBDQGEntities qlbd2 = new QLGVDBDQGEntities();
        private KetQuaThiDau kqtd = new KetQuaThiDau();

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string maketqua = "";
            KETQUATHIDAU KQ = qlbd.KETQUATHIDAUs.Where(kq => kq.MaKQ == maketqua).SingleOrDefault();
            if (KQ == null)
            {
                KETQUATHIDAU item = new KETQUATHIDAU();
                item.MaKQ = tBmaKetQua.Text;
                item.BTDoi1 = Convert.ToInt32(tBtiSoDoi1.Text);
                item.BTDoi2 = Convert.ToInt32(tBtiSoDoi2.Text);
                item.MaTD = ((LICHTHIDAU)cBmaTD.SelectedValue).MaTD;
                qlbd.KETQUATHIDAUs.Add(item);
                qlbd.SaveChanges();
                MessageBox.Show("Đã nhập vào thành công", "Thông báo");
                tBmaKetQua.Text = "KQ";
                tBtiSoDoi1.Text = "";
                tBtiSoDoi2.Text = "";
                kqtd.xemdulieu();
                BangXepHang xh = new BangXepHang();

                BANGXEPHANG BXH = qlbd1.BANGXEPHANGs.Where(bxh => bxh.DOIBONG.TenDB == tBdoi1.Text).Single();
                {
                    if (BXH != null)
                    {
                        if (item.BTDoi1 > item.BTDoi2)
                        {
                            BXH.Thang += 1;
                            BXH.Thua += 0;
                            BXH.Hoa += 0;
                            BXH.HieuSo += item.BTDoi1 - item.BTDoi2;
                            BXH.Diem += 3;
                            qlbd1.SaveChanges();
                            xh.xemdulieu();
                        }
                        else if (item.BTDoi1 < item.BTDoi2)
                        {
                            BXH.Thang += 0;
                            BXH.Thua += 1;
                            BXH.Hoa += 0;
                            BXH.HieuSo += item.BTDoi1 - item.BTDoi2;
                            BXH.Diem += 0;
                            qlbd1.SaveChanges();
                            xh.xemdulieu();
                        }    
                        else if (item.BTDoi1 == item.BTDoi2)
                        {
                            BXH.Thang += 0;
                            BXH.Thua += 0;
                            BXH.Hoa += 1;
                            BXH.HieuSo += item.BTDoi1 - item.BTDoi2;
                            BXH.Diem += 1;
                            qlbd1.SaveChanges();
                            xh.xemdulieu();
                        }   
                    }
                }
                BANGXEPHANG BXH1 = qlbd2.BANGXEPHANGs.Where(bxh => bxh.DOIBONG.TenDB == tBdoi2.Text).Single();
                {
                    if (BXH1 != null)
                    {
                        if (item.BTDoi1 < item.BTDoi2)
                        {
                            BXH1.Thang += 1;
                            BXH1.Thua += 0;
                            BXH1.Hoa += 0;
                            BXH1.HieuSo += item.BTDoi2 - item.BTDoi1;
                            BXH1.Diem += 3;
                            qlbd2.SaveChanges();
                            xh.xemdulieu();
                        }
                        else if (item.BTDoi1 > item.BTDoi2)
                        {
                            BXH1.Thang += 0;
                            BXH1.Thua += 1;
                            BXH1.Hoa += 0;
                            BXH1.HieuSo += item.BTDoi2 - item.BTDoi1;
                            BXH1.Diem += 0;
                            qlbd2.SaveChanges();
                            xh.xemdulieu();
                        }
                        else if (item.BTDoi1 == item.BTDoi1)
                        {
                            BXH1.Thang += 0;
                            BXH1.Thua += 0;
                            BXH1.Hoa += 1;
                            BXH1.HieuSo += item.BTDoi1 - item.BTDoi2;
                            BXH1.Diem += 1;
                            qlbd2.SaveChanges();
                            xh.xemdulieu();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }


        private void ThemKetQua_Load(object sender, EventArgs e)
        {
            cBmaTD.DataSource = qlbd.LICHTHIDAUs.ToList();
            cBmaTD.DisplayMember = "MaTD";
        }

        private void ThemKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void cBmaTD_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in qlbd.LICHTHIDAUs)
            {
                if (((LICHTHIDAU)cBmaTD.SelectedValue).MaTD == item.MaTD)
                {
                    tBdoi1.Text = item.DOIBONG1.TenDB;
                    tBdoi2.Text = item.DOIBONG.TenDB;
                }
            }
        }
    }
}
