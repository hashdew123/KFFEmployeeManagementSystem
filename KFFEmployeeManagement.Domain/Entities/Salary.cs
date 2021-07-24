using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Domain.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public double Basic { get; set; }
        public double Allowance { get; set; }
    }
}
