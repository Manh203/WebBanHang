using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Contact")]
    public class Contact:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Tên không được để trống")]
        [StringLength(150,ErrorMessage ="độ dài không quá 150")]
        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "độ dài không quá 150")]
        public string Email { get; set; }
        
        public string Website { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        public int IsRead { get; set; }
        
    }
}