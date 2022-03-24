
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LuaChonMailForm {

    public LuaChonMailForm() {
        guiMail = false;
    }

    public bool guiMail;

    public event EventHandler ChonGuiMailEvent;


    // Hàm này được gán với sự kiện chọn gửi mail
    public void OnChonGuiMailListener() {

        // Nếu như có chọn gửi mail
        if (true)
        {
            guiMail = true;
        }
        else
        {
            guiMail = false;
        }

        ChonGuiMailEvent(this, new EventArgs());
    }

}