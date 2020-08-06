using AutoMapper;

namespace DA.ProjectManagement.Students.Dto
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Student, CreateStudentDto>();
            CreateMap<Student, UpdateStudentDto>();

            CreateMap<StudentDto, Student>();
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStudentDto, StudentDto>();
        }
    }
}
