//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPRD.LHD.SD.MailReceive
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERS
    {
        public string UserID { get; set; }
        public string LoginPassword { get; set; }
        public Nullable<int> AccountState { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Nullable<byte> AccountType { get; set; }
        public string ThirdpartyLoginProvider { get; set; }
        public string ThirdpartyAccountID { get; set; }
        public string Remarks { get; set; }
        public Nullable<byte> RecordState { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string LastOperator { get; set; }
        public string Role { get; set; }
        public string BUName { get; set; }
        public string NewComments { get; set; }
        public string WaitForDispose { get; set; }
        public string WaitForConfirm { get; set; }
        public string WaitForOtherBinDispose { get; set; }
        public string EQALots { get; set; }
    }
}
