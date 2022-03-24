
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PhuongThucThanhToanForm {

    public PhuongThucThanhToanForm() {
    }

    public event EventHandler ChonPhuongThucThanhToanEvent;

    public byte phuongThucThanhToan;


    // Hàm này sẽ được gán vào sự kiện chọn phương thức thanh toán
    public void OnChonPhuongThucThanhToanListener(object sender, EventArgs e) {
        
        // TODO: Nếu như phương thức thanh toán là tiền mặt
        if (true)
        {
            phuongThucThanhToan = 0;
        }
        // TODO: Nếu như phương thức thanh toán là thẻ
        if (true)
        {
            phuongThucThanhToan = 1;
        }

        ChonPhuongThucThanhToanEvent(this, new EventArgs());
    }

}