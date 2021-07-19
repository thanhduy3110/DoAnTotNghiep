namespace DoAnQLKhachSan.dbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_LoaiDV { get; set; }

        public string TenDV { get; set; }

        public string MoTa { get; set; }

        public string HinhAnh { get; set; }

        public double? GiaTien { get; set; }

        public int? SLTon { get; set; }

        public string DVT { get; set; }

        public string GhiChu { get; set; }

        public bool? HieuLuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual LoaiDV LoaiDV { get; set; }
    }
}
