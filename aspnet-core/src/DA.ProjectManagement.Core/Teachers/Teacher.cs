using Abp.Domain.Entities.Auditing;
using System;

namespace DA.ProjectManagement.Teachers
{
    public class Teacher : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Degree { get; set; }
        public string Faculty { get; set; }
        public string Position { get; set; }
    }
}
