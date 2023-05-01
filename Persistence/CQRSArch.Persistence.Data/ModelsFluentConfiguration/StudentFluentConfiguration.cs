using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StudentFluentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("tblStudents");
        builder.Property(s => s.FirstName).HasMaxLength(50);
        builder.Property(s => s.LastName).HasMaxLength(100).IsRequired();
        builder.Property(s => s.EntryDate).HasMaxLength(12).IsRequired();
        builder.HasOne(s => s.StudentCourses).WithMany(s => s.lstStudents).HasForeignKey(s => s.CourseId).HasPrincipalKey(s=> s.StudentId);

        //builder.HasOne(s => s.StudentCourses).WithMany(s => s.lstStudents).HasForeignKey(s => new { s.CourseId, s.StudentId });
    }
}
