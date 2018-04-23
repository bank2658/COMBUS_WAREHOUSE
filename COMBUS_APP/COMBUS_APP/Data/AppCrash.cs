using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMBUS_APP.Data
{
    public static class AppCrash
    {
        private static string _Login = string.Empty;
        public static string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        private static string _StatusLogin = string.Empty;
        public static string StatusLogin
        {
            get { return _StatusLogin; }
            set { _StatusLogin = value; }
        }
                 
    }

    public static class Messge
    {
        public static string WRN_Error = "PROCESS ERROR PLEASE CALL SYSTEM ADMINISTRATOR !!!";
        public static string WRN_Date_FromMoreTo = "เวลาช่วงหลังน้อยกว่าช่วงแรก";
        public static string WRN_NumberOnly = "กรุณากรอกข้อมูลที่เป้นตัวเลข 0-9 เท่านั้น";
        public static string WRN_NotData = "ไม่พบข้อมูล";

        public static string INF_Save = "บันทึกเสร็จสิ้น";
        public static string INF_Delete = "ลบข้อมูลเสร็จสิ้น";
        public static string INF_Edit = "บันทึกข้อมูลเสร็จสิ้น";
        public static string INF_Cancel = "ยกเลิกรายการสำเร็จ";
    }
}
