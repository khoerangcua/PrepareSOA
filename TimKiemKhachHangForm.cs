
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSService;

public class TimKiemKhachHangForm {

    public TimKiemKhachHangForm() {
        system_Layer = new System_Layer();
    }
    System_Layer system_Layer;

    public POSService.KhachHang khachHangTimThay;

    public EventHandler TimKiemKhachHangEvent;

    // Hàm này gán cho sự kiện khi người dùng nhấn nút tìm kiếm
    public void OnTimKiemKhachHangListener(object sender, EventArgs e) {
        String soDienThoai = "";
        // TODO: lấy số điện thoại người dùng đã nhập vào gán cho biến soDienThoai
        POSService.KhachHang khachhang = system_Layer.GetKhachHangByNumPhone(soDienThoai);
        TimKiemKhachHangEvent(this, new EventArgs());
    }

}