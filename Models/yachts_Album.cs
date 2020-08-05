namespace backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class yachts_Album
    {
        public int id { get; set; }

        public string img { get; set; }

        public int? yachtsid { get; set; }

        public virtual yachts yachts { get; set; }
    }
}
