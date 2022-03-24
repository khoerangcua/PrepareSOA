
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SanPhamsForm {

    public SanPhamsForm() {
    }

    public List<POSService.SanPham> sanPhams;

    public POSService.SanPham sanPhamDaChon;

    public int soLuong;

    public void themSanPhamEvent;



    public void LoadSanPhams(List<POSService.SanPham> sanPhams ) {
        this.sanPhams = sanPhams;
        foreach (var sanPham in sanPhams)
        {
            SanPhamForm sanPhamForm = new SanPhamForm();
            sanPhamForm.themSanPhamEvent += OnThemSanPhamLintener;
            sanPhamForm.LoadSanPham(sanPham);

            // Load sanPhamForm lên giao diện
        }
    }

    public void OnThemSanPhamLintener(object sender, EventArgs e) {
        sanPhamDaChon = ((SanPhamForm) sender).sanPham;
        soLuong = ((SanPhamForm) sender).soLuong;
        themSanPhamEvent(this, new EventArgs());
    }

}