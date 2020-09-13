using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class EmployeeDetail
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Role { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Department { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string SkillSets { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string DOB { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string DOJ { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
