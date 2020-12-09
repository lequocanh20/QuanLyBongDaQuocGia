using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBongDaQuocGia.DAL;

namespace QuanLyBongDaQuocGia
{
    public partial class ThemLichThiDau : Form
    {
        public ThemLichThiDau()
        {
            InitializeComponent();
        }

        QLLichThiDau ql = new QLLichThiDau();
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-EHFOHPL\LEQUOCANH;Initial Catalog=QLGVDBDQG;Integrated Security=True");

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command = connection.CreateCommand();
            try
            {
                connection.Open();
                Command.CommandText = "CREATE TABLE #DOICHUNHA(STT INT IDENTITY, TENDOICHUNHA NVARCHAR(50))";
                Command.ExecuteNonQuery();
                Command.CommandText = "CREATE TABLE #DOIKHACH(STT INT IDENTITY, TENDOIKHACH NVARCHAR(50))";
                Command.ExecuteNonQuery();
                Command.CommandText = "INSERT LICHTHIDAU(MaTD) VALUES('" + tBmaTD.Text + "')";
                Command.ExecuteNonQuery();
                Command.CommandText = "UPDATE LICHTHIDAU SET DoiChuNha = (SELECT TOP 1 MaDB FROM DOIBONG WHERE NOT EXISTS(SELECT TENDOICHUNHA FROM #DOICHUNHA WHERE #DOICHUNHA.TENDOICHUNHA = DOIBONG.TenDB) ORDER BY NEWID()), DoiKhach = (SELECT TOP 1 MaDB FROM DOIBONG WHERE NOT EXISTS(SELECT TENDOIKHACH FROM #DOIKHACH WHERE #DOIKHACH.TENDOIKHACH = DOIBONG.TenDB) ORDER BY NEWID()), NgayThiDau = '" + dTPlichThiDau.Value + "', MaVD = '" + ((VONGDAU)cBvongDau.SelectedValue).MaVD + "' WHERE MaTD = '" + tBmaTD.Text + "'";
                Command.ExecuteNonQuery();
                Command.CommandText = "UPDATE LICHTHIDAU SET SanThiDau = (SELECT DISTINCT SanNha FROM DOIBONG D, LICHTHIDAU L WHERE D.MaDB = L.DoiChuNha AND L.DoiChuNha = (SELECT DoiChuNha FROM LICHTHIDAU WHERE MaTD = '" + tBmaTD.Text + "')) WHERE MaTD = '" + tBmaTD.Text + "'";
                Command.ExecuteNonQuery();
                MessageBox.Show("Tạo trận đấu thành công", "Thông báo");
                tBmaTD.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi");
            }
            ql.xemdulieu();
            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void ThemLichThiDau_Load(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            cBvongDau.DataSource = qlbd.VONGDAUs.ToList();
            cBvongDau.DisplayMember = "TenVD";
        }

        private void ThemLichThiDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
