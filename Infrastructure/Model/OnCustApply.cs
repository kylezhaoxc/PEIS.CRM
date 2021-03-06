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
    
    public partial class OnCustApply
    {
        public string ID_Apply { get; set; }
        public Nullable<int> ID_Section { get; set; }
        public Nullable<long> ID_Customer { get; set; }
        public string ApplyTitle { get; set; }
        public string SpecimenName { get; set; }
        public string BatchNumber { get; set; }
        public string SectionName { get; set; }
        public string DeptName { get; set; }
        public string ExamNumber { get; set; }
        public Nullable<System.DateTime> AcquisitionTime { get; set; }
        public Nullable<System.DateTime> RecvTime { get; set; }
        public Nullable<System.DateTime> ReportTime { get; set; }
        public string ApplyDoctorName { get; set; }
        public string DetectionDoctorName { get; set; }
        public string CheckDoctorName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string ExamItems { get; set; }
        public string SendProjectIDs { get; set; }
        public string SendGroupParams { get; set; }
        public string SpecimenNo { get; set; }
        public Nullable<bool> Is_TypistFinish { get; set; }
        public Nullable<int> ID_Typist { get; set; }
        public string TypistName { get; set; }
        public Nullable<System.DateTime> TypistDate { get; set; }
        public Nullable<int> ID_DetectionDoctor { get; set; }
    }
}
