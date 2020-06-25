namespace QuanlyWPF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Suplier")]
    public partial class Suplier
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string DisplayName { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Column(TypeName = "text")]
        public string MoreInfo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractDate { get; set; }
    }
}
