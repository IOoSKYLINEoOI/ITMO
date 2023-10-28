using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

namespace FinalProject.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProgressContext(serviceProvider.GetRequiredService<
                DbContextOptions<ProgressContext>>()))
            {
                if (context == null || context.Students == null)
                {
                    throw new ArgumentNullException("Null ProgressContext");
                }
                // Если в базе данных уже есть студенты,
                // то возвращается инициализатор заполнения и студенты не добавляются
                if (context.Students.Any())
                {
                    return;
                }

                context.Subjects.Add(new Subject() { Name = "Алгебра" });
                context.Subjects.Add(new Subject() { Name = "Геометрия" });
                context.Subjects.Add(new Subject() { Name = "Иностраный язык" });
                context.Subjects.Add(new Subject() { Name = "Информатика" });
                context.Subjects.Add(new Subject() { Name = "Литература" });

                context.Teachers.Add(new Teacher() { FirstName = "Ярослав", LastName = "Федоров", SurName = "Витальевич", DateOfBirth = new DateTime(1976, 7, 20, 0, 0, 0) });
                context.Teachers.Add(new Teacher() { FirstName = "Георгий", LastName = "Гришин", SurName = "Сергееевич", DateOfBirth = new DateTime(1985, 4, 11, 0, 0, 0) });
                context.Teachers.Add(new Teacher() { FirstName = "Петр", LastName = "Петров", SurName = "Андреевич", DateOfBirth = new DateTime(1993, 1, 7, 0, 0, 0) });
                context.Teachers.Add(new Teacher() { FirstName = "Сергей", LastName = "Хохлов", SurName = "Алекеевич", DateOfBirth = new DateTime(1965, 7, 1, 0, 0, 0) });
                context.Teachers.Add(new Teacher() { FirstName = "Ярослав", LastName = "Путин", SurName = "Владимирович", DateOfBirth = new DateTime(1998, 7, 4, 0, 0, 0) });

                //context.Groups.Add(new Group() { GroupId = 1, NumberGroup = "124/05" });
                //context.Groups.Add(new Group() { GroupId = 2, NumberGroup = "123/07" });
                //context.Groups.Add(new Group() { GroupId = 3, NumberGroup = "125/03" });
                //context.Groups.Add(new Group() { GroupId = 4, NumberGroup = "189/01" });
                //context.Groups.Add(new Group() { GroupId = 5, NumberGroup = "174/08" });

                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 5, StudentId = 1, TeacherId = 1, SubjectID = 1 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 4, StudentId = 1, TeacherId = 2, SubjectID = 2 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 3, StudentId = 2, TeacherId = 3, SubjectID = 3 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 2, StudentId = 2, TeacherId = 4, SubjectID = 4 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 1, StudentId = 3, TeacherId = 5, SubjectID = 5 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 2, StudentId = 3, TeacherId = 1, SubjectID = 1 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 3, StudentId = 4, TeacherId = 2, SubjectID = 2 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 4, StudentId = 4, TeacherId = 3, SubjectID = 3 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 5, StudentId = 5, TeacherId = 4, SubjectID = 4 });
                //context.Grades.Add(new Grade() { DateOfGrade = new DateTime(2023, 10, 28), Score = 4, StudentId = 5, TeacherId = 5, SubjectID = 5 });

                context.Students.Add(new Student { FirstName = "Владислав", LastName = "Карелин", SurName = "Витальевич", DateOfBirth = new DateTime(1998, 7, 1, 0, 0, 0), GroupId = 1});
                context.Students.Add(new Student { FirstName = "Сергей", LastName = "Живицкий", SurName = "Дмитриевич", DateOfBirth = new DateTime(1999, 5, 11, 0, 0, 0), GroupId = 2 });
                context.Students.Add(new Student { FirstName = "Максим", LastName = "Молотов", SurName = "Иванович", DateOfBirth = new DateTime(2000, 7, 15, 0, 0, 0), GroupId = 3 });
                context.Students.Add(new Student { FirstName = "Денис", LastName = "Денисов", SurName = "Витальевич", DateOfBirth = new DateTime(1998, 9, 21, 0, 0, 0), GroupId = 1 });
                context.Students.Add(new Student { FirstName = "Святослав", LastName = "Егоров", SurName = "Валерьевич", DateOfBirth = new DateTime(1998, 6, 3, 0, 0, 0), GroupId = 2 });

                context.SaveChanges();
            }
        }
    }
}