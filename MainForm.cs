
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
        danhMucsForm.chonDanhMucEvent += OnChonDanhMucListener;

        sanPhamsForm = new SanPhamsForm();
        sanPhamsForm.themSanPhamEvent += OnThemSanPhamListener;

        hoaDonForm = new HoaDonForm();
        hoaDonForm.thanhToanThanhCongEvent += LoadHoaDonMoi;

        system_Layer = new System_Layer();

        // TODO: Load 3 form lên 3 panel

        // Load dữ liệu
        danhMucSanPhams = system_Layer.GetDanhMucSanPham();
        danhMucsForm.LoadDanhMucs(danhMucSanPhams);
        hoaDonForm.hoaDon = system_Layer.TaoHoaDonMoi();

        


    }

    public DanhMucsForm danhMucsForm;

    public SanPhamsForm sanPhamsForm;

    public HoaDonForm hoaDonForm;

    public List<POSService.DanhMucSanPham> danhMucSanPhams;

    private System_Layer system_Layer;

    




    public void OnChonDanhMucListener(object sender, EventArgs e) {
        POSService.DanhMuc danhMuc = ((DanhMucsForm) sender).danhMucDangChon;
        List<POSService.SanPham> sanPhams = system_Layer.GetSanPhams(danhMuc);
        sanPhamsForm.LoadSanPhams(sanPhams);
    }

    public void OnThemSanPhamListener(object sender, EventArgs e) {
        POSService.SanPham sanPham = ((SanPhamsForm) sender).sanPhamDaChon;
        int soLuong = ((SanPhamsForm) sender).soLuong;
        hoaDonForm.ThemSanPham(sanPham, soLuong);
    }

    public void LoadHoaDonMoi(object sender, EventArgs e) {
        hoaDonForm = ((HoaDonForm)sender).hoaDonMoi;
    }

}