
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChuaCoKhachHangForm {

    public ChuaCoKhachHangForm() {
    }

    public POSService.KhachHang khachHangDaChon;

    public event EventHandler DaChonKhachHangEvent;


    // Hàm này được gán vào sự kiện nhân viên chọn khách hàng
    public void OnChonKhachHangListener() {
        ChonKhachHangForm chonKhachHangForm = new ChonKhachHangForm();
        chonKhachHangForm.ChonKhachHangEvent += OnDaChonKhachHangListener;
        chonKhachHangForm.ShowDialog();
    }

    
    public void OnDaChonKhachHangListener(object sender, EventArgs e) {
        khachHangDaChon = ((ChonKhachHangForm)sender).khachHangTimThay;
        DaChonKhachHangEvent(this, new EventArgs());
    }

}