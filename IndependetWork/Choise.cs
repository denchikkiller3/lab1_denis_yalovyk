using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace task1
{
    class Choise
    {
        List<Teachers> teachers = new List<Teachers>()
        {
            new Teachers() { Name = "Алла", Experience="2 роки",  Year="1993", Subject="Укр. Літ."},
            new Teachers() { Name = "Вікторія", Experience = "8 років",  Year = "1984", Subject = "С++"},
            new Teachers() { Name = "Світлана", Experience = "25 років",  Year = "1967", Subject = "філософія"},
            new Teachers() { Name = "Надія", Experience = "13 років",  Year = "1974", Subject = "Вища математика"},
        };
        public void SearchTeacherName()
        {
            Console.WriteLine("Імя викладача:");
            string name = Console.ReadLine();
            var teacher = teachers.FirstOrDefault(d => d.Name == name);
            if (teacher == null) Console.WriteLine("Такого вчителя немає в нашому університеті");
            else
                Console.WriteLine($"Name:{teacher.Name}\t Experience: {teacher.Experience}\t Year: {teacher.Year}\t Subjects: { teacher.Subjects}");
        }
        public void SearchTeacherSubject()
        {
            Console.WriteLine("Предмет, що викладає вчитель:");
            string subject = Console.ReadLine();
            var teacher = teachers.FirstOrDefault(d => d.Subject == subject);
            if (teacher == null)
            {
                Console.WriteLine("Такого вчителя немає в нашому університеті");
                return;
            }
            else
                Console.WriteLine($"Name:{teacher.Name}\t Experience: {teacher.Experience}\t Year: {teacher.Year}\t Subjects: { teacher.Subjects}");
        }
        public void SearchTeacherYear()
        {
            Console.WriteLine("рік:");
            string year = Console.ReadLine();
            var teacher = teachers.FirstOrDefault(d => d.Year == year);
            if (teacher == null)
            {
                Console.WriteLine("Такого вчителя немає в нашому університеті");
                return;
            }
            else
                Console.WriteLine($"Name:{teacher.Name}\t Experience: {teacher.Experience}\t Year: {teacher.Year}\t Subjects: { teacher.Subjects}");
        }
        public void SearchTeacherExperience()
        {
            Console.WriteLine("Стаж:");
            string color = Console.ReadLine();
            var teacher = teachers.FirstOrDefault(d => d.Experience == experience);
            if (teacher == null)
            {
                Console.WriteLine("Такого вчителя немає в нашому університеті");
                return;
            }
            else
                 Console.WriteLine($"Name:{teacher.Name}\t Experience: {teacher.Experience}\t Year: {teacher.Year}\t Subjects: { teacher.Subjects}");
        }
    }
}
