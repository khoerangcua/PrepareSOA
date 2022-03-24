
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SanPhamForm {

    public SanPhamForm() {
    }

    public POSService.SanPham sanPham;

    public event EventHandler themSanPhamEvent;

    public int soLuong;


    public void LoadSanPham(POSService.SanPham sanPham) {
        this.sanPham = sanPham;

        // TODO: Load dữ liệu lên giao diện
    }

    // Sự kiện được gán vào nút nhấn thêm sản phẩm
    public void OnThemSanPhamListener(Object sender, EventArgs e) {
        themSanPhamEvent(this, new EventArgs());
    }

}