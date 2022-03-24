
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HoaDonIttemForm {

    public HoaDonIttemForm() {
    }

    public POSService.ChiTietHoaDon chiTietHoaDon;

    public event EventHandler xoaSanPhamEvent;


    public void LoadHoaDonItem(POSService.ChiTietHoaDon chiTietHoaDon) {
        this.chiTietHoaDon = chiTietHoaDon;
        // TODO: load giao diện chi tiết hóa đơn
    }

    // Hàm này gán cho sự kiện nhấn nút xóa
    public void OnXoaSanPhamListener(object sender, EventArgs e) {
        xoaSanPhamEvent(this, new EventArgs());
    }

}