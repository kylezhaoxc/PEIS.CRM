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
    
    public partial class BusSymptom
    {
        public int ID_Symptom { get; set; }
        public Nullable<int> ID_ExamItem { get; set; }
        public Nullable<int> ID_Conclusion { get; set; }
        public string SymptomName { get; set; }
        public string SymptomDescribe { get; set; }
        public Nullable<int> DiseaseLevel { get; set; }
        public Nullable<bool> Is_Default { get; set; }
        public string NumOperSign { get; set; }
        public Nullable<double> NumMale { get; set; }
        public Nullable<double> NumFemale { get; set; }
        public string InputCode { get; set; }
        public Nullable<int> DispOrder { get; set; }
        public Nullable<bool> IS_Banned { get; set; }
        public Nullable<int> ID_BanOpr { get; set; }
        public string BanOperator { get; set; }
        public Nullable<System.DateTime> BanDate { get; set; }
    }
}