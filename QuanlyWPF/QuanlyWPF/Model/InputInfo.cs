namespace QuanlyWPF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InputInfo")]
    public partial class InputInfo
    {
        public int Id { get; set; }

        public int? IdObject { get; set; }

        public int? IdInput { get; set; }

        public int? Cout { get; set; }

        public decimal? InputPrice { get; set; }

        public decimal? OutputPrice { get; set; }

        public int? Status { get; set; }
    }
}
