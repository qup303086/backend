namespace backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dealers_area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dealers_area()
        {
            dealers_distributor = new HashSet<dealers_distributor>();
        }

        public int countryid { get; set; }

        public int id { get; set; }

        [StringLength(50)]
        public string area { get; set; }

        public virtual dealers_country dealers_country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dealers_distributor> dealers_distributor { get; set; }
    }
}
