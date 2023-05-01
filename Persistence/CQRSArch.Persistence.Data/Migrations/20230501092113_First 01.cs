using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRSArch.Persistence.Data.Migrations
{
    public partial class First01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCourseStudent",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCourseStudent", x => new { x.CourseId, x.StudentId });
                    table.UniqueConstraint("AK_tblCourseStudent_CourseId", x => x.CourseId);
                    table.UniqueConstraint("AK_tblCourseStudent_StudentId", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "tblCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCourses_tblCourseStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tblCourseStudent",
                        principalColumn: "CourseId");
                });

            migrationBuilder.CreateTable(
                name: "tblStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblStudents_tblCourseStudent_CourseId",
                        column: x => x.CourseId,
                        principalTable: "tblCourseStudent",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCourses_StudentId",
                table: "tblCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudents_CourseId",
                table: "tblStudents",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCourses");

            migrationBuilder.DropTable(
                name: "tblStudents");

            migrationBuilder.DropTable(
                name: "tblCourseStudent");
        }
    }
}
