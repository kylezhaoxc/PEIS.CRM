//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OnArcCust
    {
        public int ID_ArcCustomer { get; set; }
        public Nullable<int> ID_Gender { get; set; }
        public Nullable<int> ID_Marriage { get; set; }
        public Nullable<int> ID_Nation { get; set; }
        public Nullable<int> ID_Cultrul { get; set; }
        public Nullable<int> ID_Vocation { get; set; }
        public string CustomerName { get; set; }
        public string IDCard { get; set; }
        public string ExamCard { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string GenderName { get; set; }
        public string MarriageName { get; set; }
        public string NationName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string CultrulName { get; set; }
        public string VocationName { get; set; }
        public int FinishedNum { get; set; }
        public Nullable<int> UnfinishedNum { get; set; }
        public Nullable<System.DateTime> FirstDatePE { get; set; }
        public Nullable<System.DateTime> LatestDatePE { get; set; }
    }
}