
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SanPhamsForm {

    public SanPhamsForm() {
    }

    public List<POSService.SanPham> sanphams;

    public void sanPhamDaChon;

    public void themSanPhamEvent;



    public void LoadSanPhams(List<POSService.SanPham> sanphams ) {
        this.sanphams = sanphams;
        foreach (var sanpham in sanphams)
        {
            SanPhamForm sanPhamForm = new SanPhamForm();
            sanPhamForm.LoadSanPham(sanpham);

            // Load sanPhamForm lên giao diện
        }
    }

    public void OnThemSanPhamLintener() {
        // TODO implement here
    }

}