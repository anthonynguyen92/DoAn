using Abp.Application.Services;
using Abp.Domain.Repositories;
using DA.ProjectManagement.Authorization;
using DA.ProjectManagement.Students.Dto;
using System;
using System.Linq;

namespace DA.ProjectManagement.Students
{
    public class StudentAppService : AsyncCrudAppService<Student
        , StudentDto, Guid, PagedStudentRequestDto, CreateStudentDto, UpdateStudentDto>,
        IStudentAppService
    {
        private readonly IRepository<Student, Guid> _repository;

        public StudentAppService(IRepository<Student, Guid> repository) : base(repository)
        {
            _repository = repository;
        }

        protected override string CreatePermissionName { get; set; } = StudentPermission.Create;
        protected override string UpdatePermissionName { get; set; } = StudentPermission.Update;
        protected override string DeletePermissionName { get; set; } = StudentPermission.Delete;
        protected override string GetAllPermissionName { get; set; } = StudentPermission.Default;


        protected override IQueryable<Student> CreateFilteredQuery(PagedStudentRequestDto input)
        {
            return base.CreateFilteredQuery(input);
        }
    }
}
