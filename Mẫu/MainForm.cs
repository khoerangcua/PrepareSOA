using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSService;
using POSDataModel;


namespace POSApplication
{
    public partial class MainForm : Form
    {
        Experience_Layer Experience_Layer;
        Task_Layer Task_Layer;
        System_Layer System_Layer;
        public MainForm()
        {
            InitializeComponent();
            this.Experience_Layer = new Experience_Layer();
            this.Task_Layer = new Task_Layer();
            this.System_Layer = new System_Layer();

            Testfunction();
        }


        void Testfunction()
        {
            List<POSService.DanhMucSanPham> danhmucs = this.System_Layer.GetDanhMucSanPham();
            int danhmucdachon = danhmucs[0].IdDanhMuc;
            List<POSService.SanPham> sanphams = this.System_Layer.GetSanPhams(danhmucdachon);
            POSService.HoaDon hoaDon = this.System_Layer.TaoHoaDonMoi();
            // Them 1 xoa 1 to hoa don
            hoaDon = this.Experience_Layer.ThemSanPhamVaoHoaDon(hoaDon.IdHoaDon, sanphams[0].IdHangHoa,1);
            hoaDon = this.Experience_Layer.XoaSanPhamKhoiHoaDon(hoaDon.IdHoaDon, sanphams[0].IdHangHoa);
            // them 2 xoa 1 to hoa don
            hoaDon = this.Experience_Layer.ThemSanPhamVaoHoaDon(hoaDon.IdHoaDon, sanphams[0].IdHangHoa, 2);
            hoaDon = this.Experience_Layer.XoaSanPhamKhoiHoaDon(hoaDon.IdHoaDon, sanphams[0].IdHangHoa);
            // tim kiem khach hang
            POSService.KhachHang khachhang = this.System_Layer.GetKhachHangByNumPhone("012345678");
            // tao moi khach hang
            bool themthanhcong = this.System_Layer.AddNewKhachHang(new POSService.KhachHang(0, "Thiên Phúc", "thienphuc@gmail.com", "111222333", "1/2/3/4"));
            POSService.KhachHang khachhangmoi = this.System_Layer.GetKhachHangByNumPhone("111222333");
            // Thêm khách hàng vào hóa đơn
            themthanhcong = System_Layer.UpdateKhachHangToHoaDon(hoaDon.IdHoaDon, khachhangmoi.IdKhachHang);
            hoaDon = System_Layer.GetHoaDonInfor(hoaDon.IdHoaDon);
            // Tiến hành thanh toán
            POSService.HoaDon hoaDon1 = this.Experience_Layer.ThanhToanHoaDon(hoaDon.IdHoaDon, 0, true);
            POSService.HoaDon hoaDon2 = this.Experience_Layer.ThanhToanHoaDon(hoaDon.IdHoaDon, 0, false);
            POSService.HoaDon hoaDon3 = this.Experience_Layer.ThanhToanHoaDon(hoaDon.IdHoaDon, 1, true);
            POSService.HoaDon hoaDon4 = this.Experience_Layer.ThanhToanHoaDon(hoaDon.IdHoaDon, 1, false);


        }

        
    }
}
