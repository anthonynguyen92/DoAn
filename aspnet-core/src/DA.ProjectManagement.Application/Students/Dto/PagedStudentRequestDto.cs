using Abp.Application.Services.Dto;

namespace DA.ProjectManagement.Students.Dto
{
    public class PagedStudentRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        //public bool? IsActive { get; set; }
    }
}
