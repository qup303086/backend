namespace backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class news
    {
        public int id { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        public string img { get; set; }

        [StringLength(50)]
        public string datetime { get; set; }

        [StringLength(50)]
        public string subject { get; set; }

        public string contents { get; set; }

        public DateTime? initDate { get; set; }

        [StringLength(5)]
        public string Topnews { get; set; }
    }
}
