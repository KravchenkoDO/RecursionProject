using System;
using System.Collections.Generic;
using static RecursionProject.FirstStep;
namespace RecursionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> userFilmList = new List<Film>();
            int filmCount;
            Console.WriteLine("Добро пожаловать в программу составления расписания для кинотеатра!\nКинотеатр работает с 8:00\n");
            DateTime startTime = new DateTime(2021, 08, 05, 8, 00, 00);
            Console.WriteLine("Введите длительность работы кинотеатра в минутах:");
            int cinemaWorkingMinutes = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите количество фильмов в прокате:");
            filmCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Для каждого фильма из проката необходимо предоставить более подробную информацию о нем (название и продолжительности фильма в минутах):");
            for (int i = 1; i <= filmCount; i++)
            {
                Console.WriteLine($"Введите название фильма № {i}:");
                string fName = Console.ReadLine();
                Console.WriteLine($"Введите длительность фильма №{i} (в минутах):");
                int fDuration = Convert.ToInt32(Console.ReadLine());
                userFilmList.Add(new Film { Duration = fDuration, Name = fName });
            }

            Graph cinemaTable = new Graph(cinemaWorkingMinutes, userFilmList);
            cinemaTable.CreateTree();

            foreach (var film in cinemaTable.timeTable.listOfFilms)
            {
                Console.WriteLine(film.Name);
                Console.WriteLine(film.Duration);
            }

        }
    }
}
