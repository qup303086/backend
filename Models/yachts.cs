namespace backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class yachts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public yachts()
        {
            yachts_Album = new HashSet<yachts_Album>();
        }

        public int id { get; set; }

        [Column("yachts")]
        [StringLength(50)]
        public string yachts1 { get; set; }

        [StringLength(50)]
        public string Shiptype { get; set; }

        [StringLength(50)]
        public string img { get; set; }

        public string overview { get; set; }

        public string layout { get; set; }

        public string specifivation { get; set; }

        [StringLength(5)]
        public string Newimg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yachts_Album> yachts_Album { get; set; }
    }
}
