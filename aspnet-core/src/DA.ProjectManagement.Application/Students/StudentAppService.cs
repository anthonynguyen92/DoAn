using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using DA.ProjectManagement.Authorization;
using DA.ProjectManagement.Students.Dto;
using System;
using System.Linq;
using System.Threading.Tasks;

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
            return _repository.GetAll().WhereIf(string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword)
            || x.PhoneNumber.Contains(input.Keyword)
            || x.Address.Contains(input.Keyword)
            || x.Branch.Contains(input.Keyword)
            || x.CourseYear.Contains(input.Keyword)
            || x.Email.Contains(input.Keyword));
        }

        public override Task<StudentDto> CreateAsync(CreateStudentDto input)
        {
            if (_repository.GetAll().Any(x => x.PhoneNumber == input.PhoneNumber))
            {
                throw new UserFriendlyException("Phone Number arealy Exists");
            }

            if (_repository.GetAll().Any(x => x.PhoneNumber == input.Email))
            {
                throw new UserFriendlyException("Email arealy Exists");
            }

            return base.CreateAsync(input);
        }

        public override Task<StudentDto> UpdateAsync(UpdateStudentDto input)
        {
            if (_repository.GetAll().Any(x => x.PhoneNumber == input.PhoneNumber))
            {
                throw new UserFriendlyException("Phone Number arealy Exists");
            }

            if (_repository.GetAll().Any(x => x.PhoneNumber == input.Email))
            {
                throw new UserFriendlyException("Email arealy Exists");
            }

            return base.UpdateAsync(input);
        }
    }
}
