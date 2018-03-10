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
    
    public partial class BusFeeItem
    {
        public int FeeItemID { get; set; }
        public Nullable<int> SectionID { get; set; }
        public Nullable<int> SpecimenID { get; set; }
        public string FeeItemName { get; set; }
        public Nullable<int> ForGender { get; set; }
        public string ReportFeeName { get; set; }
        public string FeeItemCode { get; set; }
        public Nullable<decimal> FeeItemPrice { get; set; }
        public string InputCode { get; set; }
        public string SectionName { get; set; }
        public string SpecimenName { get; set; }
        public string WorkGroupCode { get; set; }
        public string WorkStationCode { get; set; }
        public string WorkBenchCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<bool> IsDel { get; set; }
        public Nullable<int> DelOprID { get; set; }
        public string DelDescribe { get; set; }
        public Nullable<int> DispOrder { get; set; }
        public string Note { get; set; }
        public Nullable<int> BreakfastOrder { get; set; }
        public Nullable<bool> IsFeeNonPrintInReport { get; set; }
        public string InterfaceName { get; set; }
        public Nullable<bool> ISFeeReportMerger { get; set; }
        public Nullable<int> FeeReportMergerID { get; set; }
        public string OperationalDate { get; set; }
    }
}