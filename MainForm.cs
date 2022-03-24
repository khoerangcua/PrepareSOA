
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using Service
using POSService;

public class MainForm {

    public MainForm() {
        // Tạo mới đối tượng
        danhMucsForm = new DanhMucsForm();
        sanPhamsForm = new SanPhamForm();
        hoaDonForm = new HoaDonForm();
        System_Layer = new System_Layer();

        // Load dữ liệu
        danhMucSanPhams = System_Layer.this.System_Layer.GetDanhMucSanPham();
        danhMucsForm.LoadDanhMucs(danhMucSanPhams);

        


    }

    public DanhMucsForm danhMucsForm;

    public SanPhamsForm sanPhamsForm;

    public HoaDonForm hoaDonForm;

    public List<POSService.DanhMucSanPham> danhMucSanPhams;

    private System_Layer System_Layer;

    




    public void OnChonDanhMucListener() {
        // TODO implement here
    }

    public void OnThemSanPhamListener() {
        // TODO implement here
    }

    public void LoadHoaDonMoi() {
        // TODO implement here
    }

}