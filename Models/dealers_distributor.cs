namespace backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dealers_distributor
    {
        public int countryid { get; set; }

        public int areaid { get; set; }

        public int id { get; set; }

        public string img { get; set; }

        [StringLength(50)]
        public string distributor { get; set; }

        public string content { get; set; }

        public virtual dealers_area dealers_area { get; set; }
    }
}
