//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FORUM_WEB_2._0.Models.FrameWorks
{
    using System;
    using System.Collections.Generic;
    
    public partial class BinhLuan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BinhLuan()
        {
            this.Img_BinhLuan = new HashSet<Img_BinhLuan>();
            this.Top_BinhLuan = new HashSet<Top_BinhLuan>();
        }
    
        public int ID_BinhLuan { get; set; }
        public Nullable<int> ID_BaiDang { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> NgayBinhLuan { get; set; }
        public string TenDangNhap { get; set; }
    
        public virtual BaiDang BaiDang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Img_BinhLuan> Img_BinhLuan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Top_BinhLuan> Top_BinhLuan { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
