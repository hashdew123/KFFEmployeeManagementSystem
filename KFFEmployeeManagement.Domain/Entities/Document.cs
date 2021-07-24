using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Domain.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string DocumentType { get; set; }
        public byte[] imageUrl { get; set; }
    }
}
