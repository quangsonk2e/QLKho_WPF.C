namespace QuanlyWPF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Output")]
    public partial class Output
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOutput { get; set; }
    }
}
