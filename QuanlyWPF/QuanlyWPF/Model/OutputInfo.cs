namespace QuanlyWPF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutputInfo")]
    public partial class OutputInfo
    {
        public int Id { get; set; }

        public int? IdObject { get; set; }

        public int? IdInput { get; set; }

        public int? Count { get; set; }

        public int? IdCustomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOutput { get; set; }

        public int? Status { get; set; }
    }
}
