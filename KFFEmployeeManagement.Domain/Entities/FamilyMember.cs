using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Domain.Entities
{
    public class FamilyMember
    {
        public int Id { get; set; }
        public string Relationship { get; set; }
        public string FullName { get; set; }
    }
}
