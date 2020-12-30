using System;
using System.Collections.Generic;
using System.Text;
namespace task1
{

    class Teachers
    {
        public string Name { get; set; }
        public string Experience { get; set; }
        public string Year { get; set; }
        public string Subject { get; set; }
        public override string ToString()

        {
            return $"Name:{Name}\t Experience: {Experience}\t Year: {Year}\t Subject: {Subject}";
        }
        static void Main(string[] args)
        {
            var g = new Choise();
            var flag = true;
            while (flag)
            {
                Console.WriteLine("1 - найти вчителя по параметрам");
                Console.WriteLine("2 - вихід");
                Console.Write("Опція > ");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: g.SearchTeacherName(); g.SearchHeadphoneSubject(); g.SearchTeacherYear(); g.SearchTeacherExperience(); break;
                    case 2: flag = false; break;
                    default: Console.WriteLine("Упс"); break;
                }
            }
        }

    }
}
