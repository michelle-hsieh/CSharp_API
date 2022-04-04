using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Addition_API.Data
{

    [Table("Dept")]
    public class Dept
    {
        [Key]
        [Required]
        public int deptid { get; set; }
        [StringLength(50)]
        public String dname { get; set; }
        [StringLength(50)]
        public String location { get; set; }
    }
}