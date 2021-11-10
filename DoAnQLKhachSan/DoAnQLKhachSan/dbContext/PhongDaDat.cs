namespace DoAnQLKhachSan.dbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongDaDat")]
    public partial class PhongDaDat
    {
        public int ID { get; set; }

        public int? ID_PhieuDP { get; set; }

        public int? ID_Phong { get; set; }

        public DateTime? NgayDen { get; set; }

        public DateTime? NgayDi { get; set; }

        public virtual PhieuDatPhong PhieuDatPhong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
