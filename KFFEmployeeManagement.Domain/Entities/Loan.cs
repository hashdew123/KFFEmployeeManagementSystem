using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public double Remaining { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}
