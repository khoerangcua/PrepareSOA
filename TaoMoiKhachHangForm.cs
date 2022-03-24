
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSService;

public class TaoMoiKhachHangForm {

    public TaoMoiKhachHangForm() {
        system_Layer = new System_Layer();
    }

    public POSService.KhachHang khachHangMoiThem;

    public event EventHandler themKhachHangThanhCongEvent;
    private System_Layer system_Layer;


    public void LoadForm() {
        // TODO implement here
    }

    // Hàm này được gán khi người dùng chấp nhận thêm mới khách hàng
    public void OnThemKhachHangListener() {
        POSService.KhachHang khachHangMoi;
        // TODO: Lấy thông tin người dùng nhập vào và gán váo biến khachHangMoi
        system_Layer.AddNewKhachHang(khachHangMoi);
        khachHangMoiThem = system_Layer.GetKhachHangByNumPhone(khachHangMoi.SoDienThoai);
        themKhachHangThanhCongEvent(this,new EventArgs());
    }

}