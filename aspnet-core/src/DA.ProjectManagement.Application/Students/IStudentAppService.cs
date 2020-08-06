using Abp.Application.Services;
using DA.ProjectManagement.Students.Dto;
using System;

namespace DA.ProjectManagement.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<
        StudentDto, Guid, PagedStudentRequestDto, 
        CreateStudentDto, UpdateStudentDto>
    {
    }
}
