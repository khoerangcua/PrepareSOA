
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using Service
using POSService;

public class HoaDonForm {

    public HoaDonForm() {
        experience_Layer = new Experience_Layer();
        phuongThucThanhToanForm = new PhuongThucThanhToanForm();
        phuongThucThanhToanForm.ChonPhuongThucThanhToanEvent += OnChonPhuongThucThanhToanListener;
        luaChonMailForm = new LuaChonMailForm();
        luaChonMailForm.ChonGuiMailEvent += OnChonGuiMailListener;
        
        
    }

    public void chuaCoKhachHangForm;

    public void daCoKhachHangForm;

    public PhuongThucThanhToanForm phuongThucThanhToanForm;

    public LuaChonMailForm luaChonMailForm;

    public POSService.HoaDon hoaDon;

    public List<POSService.ChiTietHoaDon> chiTietHoaDon;

    public byte phuongThucThanhToan;

    public bool guiMail;

    public void khachHangDaChon;

    public void thanhToanThanhCongEvent;

    public void hoaDonMoi;
    Experience_Layer experience_Layer;







    public void ThemSanPham(POSService.SanPham sanPham, int soLuong) {
        hoaDon = experience_Layer.ThemSanPhamVaoHoaDon(hoaDon.IdHoaDon, hoaDon.IdSanPham, soLuong);
        CapNhatHoaDon();
        chiTietHoaDon = experience_Layer.GetHoaDonItems(hoaDon.IdHoaDon);
        CapNhatChiTietHoaDon();

    }

    public void CapNhatHoaDon() {
        // TODO: Cập nhật lại giao diện hóa đơn đã cập nhât
    }

    public void CapNhatChiTietHoaDon() {
        
        foreach (var cthd in chiTietHoaDon)
        {
            // Tạo giao diện hóa đơn item
            HoaDonIttemForm hoaDonIttemForm = new HoaDonIttemForm();
            hoaDonIttemForm.xoaSanPhamEvent += OnXoaSanPhamListener;
            hoaDonIttemForm.LoadHoaDonItem(cthd);

            //TODO: Load chi tiết hóa đơn lên hoadonPanel
        }
    }

    public void OnXoaSanPhamListener(object sender, EventArgs e) {
        POSService.ChiTietHoaDon chiTietHoaDon = ((HoaDonIttemForm) sender).chiTietHoaDon;
        hoaDon = experience_Layer.XoaSanPhamKhoiHoaDon(hoaDon.IdHoaDon, chiTietHoaDon.IdSanPham);
        CapNhatHoaDon();
        chiTietHoaDon = experience_Layer.GetHoaDonItems(hoaDon.IdHoaDon);
        CapNhatChiTietHoaDon();

    }

    public void OnChonPhuongThucThanhToanListener(object sender, EventArgs e) {
        phuongThucThanhToan = ((PhuongThucThanhToanForm) sender).phuongThucThanhToan;
    }

    public void OnChonGuiMailListener(object sender, EventArgs e) {
        guiMail = ((LuaChonMailForm) sender).guiMail;
    }

    public void OnChonKhachHangListener() {
        // TODO implement here
    }

    public void capNhatKhachHang() {
        // TODO implement here
    }

    public void OnThanhToanListener() {
        // TODO implement here
    }

}