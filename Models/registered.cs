namespace backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("registered")]
    public partial class registered
    {
        public int id { get; set; }

        [StringLength(50)]
        public string account { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        public string img { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string Authority { get; set; }
    }
}
