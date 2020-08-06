using Abp.Domain.Entities.Auditing;
using System;

namespace DA.ProjectManagement.Students
{
    public class Student:FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Faculty { get; set; }
        public string Branch { get; set; }
        public string CourseYear { get; set; }
        public string StudentCode { get; set; }
    }
}
