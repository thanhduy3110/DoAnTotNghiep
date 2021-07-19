namespace DoAnQLKhachSan.dbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDatPhong")]
    public partial class PhieuDatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuDatPhong()
        {
            PhongDaDats = new HashSet<PhongDaDat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_KH { get; set; }

        public DateTime? NgayDen { get; set; }

        public DateTime? NgayDi { get; set; }

        public bool? HinhThucThue { get; set; }

        public int? SoKhach { get; set; }

        public string GhiChu { get; set; }

        public bool? DaXuLy { get; set; }

        public bool? HieuLuc { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongDaDat> PhongDaDats { get; set; }
    }
}
