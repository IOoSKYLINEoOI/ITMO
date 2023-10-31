using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using System;
using System.Linq;
using System.Collections.Concurrent;

namespace FinalProject.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalContext(serviceProvider.GetRequiredService<
                DbContextOptions<FinalContext>>()))
            {
                if (context == null || context.Grades == null)
                {
                    throw new ArgumentNullException("Null CreditContext");
                }

                if (context.Grades.Any())
                {
                    return;
                }

                var Students = new List<Student>
                {
                new Student { FirstName = "Владислав", LastName = "Карелин", SurName = "Витальевич"},
                new Student { FirstName = "Сергей", LastName = "Живицкий", SurName = "Дмитриевич"},
                new Student { FirstName = "Максим", LastName = "Молотов", SurName = "Иванович"},
                new Student { FirstName = "Денис", LastName = "Денисов", SurName = "Витальевич"},
                new Student { FirstName = "Святослав", LastName = "Егоров", SurName = "Валерьевич"},
                new Student { FirstName = "Ярослав", LastName = "Федоров", SurName = "Витальевич"},
                new Student { FirstName = "Георгий", LastName = "Гришин", SurName = "Сергееевич"},
                new Student { FirstName = "Петр", LastName = "Петров", SurName = "Андреевич"},
                new Student { FirstName = "Сергей", LastName = "Хохлов", SurName = "Алекеевич"},
                new Student { FirstName = "Ярослав", LastName = "Путин", SurName = "Владимирович"}
                };

                foreach (Student e in Students)
                {
                    context.Students.Add(e);
                }

                context.SaveChanges();

                var Grades = new List<Grade>
                {
                new Grade { Score = 5, StudentId = Students.Single(s => s.LastName == "Карелин").StudentId },
                new Grade { Score = 4, StudentId = Students.Single(s => s.LastName == "Карелин").StudentId },
                new Grade { Score = 3, StudentId = Students.Single(s => s.LastName == "Карелин").StudentId },
                new Grade { Score = 2, StudentId = Students.Single(s => s.LastName == "Живицкий").StudentId },
                new Grade { Score = 1, StudentId = Students.Single(s => s.LastName == "Живицкий").StudentId },
                new Grade { Score = 2, StudentId = Students.Single(s => s.LastName == "Гришинн").StudentId },
                new Grade { Score = 3, StudentId = Students.Single(s => s.LastName == "Гришин").StudentId },
                new Grade { Score = 4, StudentId = Students.Single(s => s.LastName == "Гришин").StudentId },
                new Grade { Score = 5, StudentId = Students.Single(s => s.LastName == "Хохлов").StudentId },
                new Grade { Score = 4, StudentId = Students.Single(s => s.LastName == "Хохлов").StudentId },
                new Grade { Score = 2, StudentId = Students.Single(s => s.LastName == "Гришинн").StudentId },
                new Grade { Score = 3, StudentId = Students.Single(s => s.LastName == "Егоров").StudentId },
                new Grade { Score = 4, StudentId = Students.Single(s => s.LastName == "Гришин").StudentId },
                new Grade { Score = 5, StudentId = Students.Single(s => s.LastName == "Егоров").StudentId },
                new Grade { Score = 4, StudentId = Students.Single(s => s.LastName == "Хохлов").StudentId }
                };
                foreach (Grade e in Grades)
                {
                    var enrollmentInDataBase = context.Grades.Where(
                        s =>
                        s.Student.StudentId == e.StudentId).SingleOrDefault();

                    if (enrollmentInDataBase == null)
                    {
                        context.Grades.Add(e);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
