//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    
    public partial class Employee_GetTimeWork_Result
    {
        public int WorkID { get; set; }
        public Nullable<System.DateTime> dateWork { get; set; }
        public Nullable<int> employeeID { get; set; }
        public Nullable<System.TimeSpan> timeIN { get; set; }
        public Nullable<System.TimeSpan> timeOUT { get; set; }
        public string note { get; set; }
        public string createBy { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
    }
}
