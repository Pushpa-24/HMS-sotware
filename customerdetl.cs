//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuestEaseHMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class customerdetl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customerdetl()
        {
            this.reservdetls = new HashSet<reservdetl>();
        }
    
        public int c_id { get; set; }
        public long c_idproof { get; set; }
        public string c_name { get; set; }
        public string c_address { get; set; }
        public long c_phoneno { get; set; }
        public string c_nationality { get; set; }
        public string c_gender { get; set; }
        public string check_in { get; set; }
        public string checkout { get; set; }
        public int room_id { get; set; }
    
        public virtual roomdetl roomdetl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservdetl> reservdetls { get; set; }
    }
}
