
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChonKhachHangForm {

    public ChonKhachHangForm() {
        timKiemKhachHangForm = new TimKiemKhachHangForm();
        timKiemKhachHangForm += OnTimKiemKhachHangListener;
        thongTinKhachHangForm = new ThongTinKhachHangForm();
        
        
        // TODO: Hiển thị 2 form lên 2 panel

        // TODO: Vô hiệu hóa nút chọn khách hàng


    }

    public TimKiemKhachHangForm timKiemKhachHangForm;

    public TaoMoiKhachHangForm taoMoiKhachHangForm;
    public POSService.KhachHang khachHangTimThay;

    public ThongTinKhachHangForm thongTinKhachHangForm;

    public event EventHandler ChonKhachHangEvent;





    public void LoadForm() {
        // TODO implement here
    }

    public void OnTimKiemKhachHangListener(object sender, EventArgs e) {

        if (sender is TimKiemKhachHangForm)
        {
            khachHangTimThay = ((TimKiemKhachHangForm)sender).khachHangTimThay;
        }
        else
        {
            khachHangTimThay = ((TaoMoiKhachHangForm)sender).khachHangMoiThem;
        }
        

        
        if (khachHang == null)
        {
            // Nếu không tìm thấy khách hàng
            thongTinKhachHangForm.HienThiGiaoDienMacDinh();
            // Vô hiệu hóa nút chọn khách hàng
        }
        else
        {
            // Nếu như tìm thấy khách hàng
            thongTinKhachHangForm.HienThiThongTinKhachHang(khachHang);
            // Thôi vô hiệu hóa nút chọn khách hàng
        }
    }

    // Hàm này được gán vào sự kiện người dùng nhấn nút chọn khách hàng
    public void OnChonKhachHangListener(object sender, EventArgs e) {
        ChonKhachHangEvent(this, new EventArgs());
    }

    // Hàm này được gán vào sự kiện người dùng nhấn nút thêm khách hàng
    public void OnThemMoiKhachHangListener() {
        taoMoiKhachHangForm = new TaoMoiKhachHangForm();
        taoMoiKhachHangForm.showDialog();
    }

}