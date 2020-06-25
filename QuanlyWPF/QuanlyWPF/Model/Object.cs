namespace QuanlyWPF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Object")]
    public partial class Object
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string DisplayName { get; set; }

        public int? IdUnit { get; set; }

        public int? IdSuplier { get; set; }

        [Column(TypeName = "text")]
        public string QRCode { get; set; }

        [Column(TypeName = "text")]
        public string BarCode { get; set; }
    }
}
