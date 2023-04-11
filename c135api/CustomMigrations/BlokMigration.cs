using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;

namespace c135api.CustomMigrations
{
    public static class BlokMigration
    {
        public static void Seed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into ""BLoks"" values(3,'3')");
        }
    }

    public class Employee
    {
        public int Id { get; set; } 
        public int Year { get; set; }
    }

    public record EmployeeToListDto
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public bool IsExperienced { get; set; }



    }


    class A
    {
        int Id { get; set; } //5
        string Name { get; set; }

    }

    class B
    {
        int Id { get; set; }
        public required string Name { get; set; }


        void Test()
        {
            B b = new B() { Name = Name };
        }
    }

    public record EmployeeToAddDto
    {
        public int Year { get; set; }

        void Add()
        {
            Employee employee = new()
            {
                Year = Year,
            };
        }
    }
}
