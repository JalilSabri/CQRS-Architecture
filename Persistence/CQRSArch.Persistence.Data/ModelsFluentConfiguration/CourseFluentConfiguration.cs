using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CourseFluentConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("tblCourses");
        builder.Property(c => c.CourseTitle).HasMaxLength(100).IsRequired();
        builder.HasOne(c => c.CourseStudents).WithMany(c => c.lstCourses).HasForeignKey(c => c.StudentId).HasPrincipalKey(c => c.CourseId);
    }
}
