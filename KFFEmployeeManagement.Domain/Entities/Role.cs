using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KFFEmployeeManagement.Domain.Entities
{
    public class Role
    {
        [ForeignKey("User")]
        public int RoleId { get; set; }
        public string RoleType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual User User { get; set; }
    }
}
