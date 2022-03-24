
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DanhMucForm {

    public DanhMucForm() {
    }

    public POSService.DanhMuc danhMuc;

    public event EventHandler chonDanhMucEvent;


    public void LoadDanhMuc(POSService.DanhMuc danhMuc) {
        this.danhMuc = danhMuc;

        //TODO: Load dữ liệu lên giao diện
    }

    // Hàm gán cho sự kiện chọn danh mục
    public void OnChonDanhMucListener() {
        chonDanhMucEvent(this, new EventArgs());
    }

}