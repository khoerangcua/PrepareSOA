
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using Service
using POSService;

public class DanhMucsForm {

    public DanhMucsForm() {
    }
    public List<POSService.DanhMucSanPham> danhMucs;

    public POSService.DanhMuc danhMucDangChon;

    public event EventHandler chonDanhMucEvent;



    public void LoadDanhMucs(List<POSService.DanhMucSanPham> danhMucSanPhams) {
        this.danhMucs = danhMucSanPhams;
        foreach (var danhMuc in danhMucs)
        {
            // Tạo giao diện cho mỗi danh mục
            DanhMucForm danhMucForm = new DanhMucForm();
            danhMucForm.chonDanhMucEvent += OnChonDanhMucListener;
            danhMucForm.LoadDanhMuc(danhMuc);

            // TODO: Load danhMuc lên panel
        }
    }

    public void OnChonDanhMucListener(object sender, EventArgs e) {
        danhMucDangChon = ((DanhMucForm) sender).danhMuc;
        chonDanhMucEvent(this, new EventArgs());
    }

}