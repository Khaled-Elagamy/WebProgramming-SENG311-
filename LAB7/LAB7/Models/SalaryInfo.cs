using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LAB7.Models
{
    public class SalaryInfo
    {
        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal? Net { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal? Gross { get; set; }
    }
}
