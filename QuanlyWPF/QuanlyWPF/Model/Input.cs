namespace QuanlyWPF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Input")]
    public partial class Input
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateInput { get; set; }
    }
}
