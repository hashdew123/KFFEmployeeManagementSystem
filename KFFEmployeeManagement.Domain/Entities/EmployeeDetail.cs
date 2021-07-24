using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KFFEmployeeManagement.Domain.Entities
{
    public class EmployeeDetail
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Department { get; set; }
        [Required]
        public string Status { get; set; }
        public string EPFNo { get; set; }
        [Required]
        public string NIC { get; set; }
        [Required]
        public string Religion { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
    }
}
