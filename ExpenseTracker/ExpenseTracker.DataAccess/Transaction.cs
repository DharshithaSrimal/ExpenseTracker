//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseTracker.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public System.DateTime DateTime { get; set; }
        public bool SysGenerated { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual FinancialAccount FinancialAccount { get; set; }
        public virtual Payee Payee { get; set; }
    }
}
