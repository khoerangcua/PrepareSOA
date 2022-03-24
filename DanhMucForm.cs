
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DanhMucForm {

    public DanhMucForm() {
    }

    public void danhMuc;

    public void chonDanhMucEvent;


    public void LoadDanhMuc(POSService.DanhMuc danhMuc) {
        this.danhMuc = danhMuc;

        //TODO Load dữ liệu lên giao diện
    }

// Hàm này gán cho sự kiện nhấn nút thêm
    public void OnChonDanhMucListener() {
        // TODO implement here
    }

}