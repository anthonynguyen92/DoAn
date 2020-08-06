using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DA.ProjectManagement.Students.Dto
{
    public class UpdateStudentDto:EntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Faculty { get; set; }
        public string Branch { get; set; }
        public string CourseYear { get; set; }
        public string StundentCode { get; set; }
    }
}
