using AutoMapper;

public class CustomeProfile : Profile
{
    public CustomeProfile()
    {
        CreateMap<Student,StudentDto>().ReverseMap();
        CreateMap<Course,CourseDto>().ReverseMap();
        CreateMap<CourseStudent,CourseStudentDto>().ReverseMap();
    }
}