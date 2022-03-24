
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SanPhamForm {

    public SanPhamForm() {
    }

    public POSService.SanPham sanpham;

    public void themSanPhamEvent;

    public void soLuong;


    public void LoadSanPham(POSService.SanPham sanpham) {
        this.sanpham = sanpham;
    }

    public void OnThemSanPhamListener() {
        // TODO implement here
    }

}