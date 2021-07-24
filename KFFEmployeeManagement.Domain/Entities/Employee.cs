using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KFFEmployeeManagement.Domain.Entities
{
    public class Employee
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
        public Salary Salary { get; set; }
        [Required]
        public DateTime JoinedDate { get; set; }
        public DateTime LastDate { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
        public string OtherDetails { get; set; }
        public ICollection<Document>? Document { get; set; }
        public ICollection<FamilyMember>? FamilyMember { get; set; }      
        public ICollection<Education>? Education { get; set; }
        public ICollection<Loan>? Loan { get; set; }
    }
}
