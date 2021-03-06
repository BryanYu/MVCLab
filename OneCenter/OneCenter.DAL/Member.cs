//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneCenter.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.ActivityRecord = new HashSet<ActivityRecord>();
            this.ProductRecord = new HashSet<ProductRecord>();
            this.TicketRecord = new HashSet<TicketRecord>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Mobile { get; set; }
        public string Note { get; set; }
        public Nullable<int> RecommandId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityRecord> ActivityRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductRecord> ProductRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketRecord> TicketRecord { get; set; }
    }
}
