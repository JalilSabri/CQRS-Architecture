using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CourseStudentFluentConfiguration : IEntityTypeConfiguration<CourseStudent>
{
    public void Configure(EntityTypeBuilder<CourseStudent> builder)
    {
        builder.ToTable("tblCourseStudent");
        builder.HasKey(cs => new { cs.CourseId, cs.StudentId });
        //builder.HasMany(cs => cs.lstStudents).WithOne(c => c.StudentCourses).HasForeignKey(cs => cs.Id).HasPrincipalKey(cs => cs.StudentId);
    }
}
