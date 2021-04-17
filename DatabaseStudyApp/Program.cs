using DatabaseStudyApp.Dtos;
using DatabaseStudyApp.Services;
using System;

namespace DatabaseStudyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMusicGroupService _musicGroupService = new MusicGroupService();


            while (true)
            {
                var entities = _musicGroupService.GetList();

                foreach (var entity in entities) 
                    Console.WriteLine(entity);

                Console.WriteLine("\nВЫБЕРИТЕ ОПЕРАЦИЮ");
                Console.WriteLine("1. Добавить сущность");
                Console.WriteLine("2. Изменить сущность");
                Console.WriteLine("3. Удалить сущность");
                Console.WriteLine("4. Получить описание сущности");

                var consoleChoose = int.Parse(Console.ReadLine());

                switch (consoleChoose)
                {
                    case 1:
                        // Ввод данных с клавиатуры
                        Console.Write("Введите нвоое имя группы:");
                        var name = Console.ReadLine();
                        Console.Write("Введите новый год создания группы:");
                        var creationYear = new DateTime(int.Parse(Console.ReadLine()), 1, 1);

                        var dto = new MusicGroupDto
                        {
                            Name = name,
                            CreationYear = creationYear
                        };

                        // Сохранение изменений
                        _musicGroupService.Save(dto);
                        Console.WriteLine("Сущность сохранена");

                        break;

                    case 2:
                        Console.WriteLine("Введите ID сущности которую хотите изменить");
                        var chainheId = Guid.Parse(Console.ReadLine());
                        Console.Write("Введите нвоое имя группы:");
                        var nameNaw = Console.ReadLine();
                        Console.Write("Введите новый год создания группы:");
                        var creationYearNaw = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
                        var dto1 = new MusicGroupDto
                        {
                            Id = chainheId,
                            Name = nameNaw,
                            CreationYear = creationYearNaw
                        };
                        _musicGroupService.Save(dto1);


                        break;

                    case 3:
                        Console.WriteLine("Введите ID сущности");
                        var deletedId = Guid.Parse(Console.ReadLine());
                        _musicGroupService.Delete(deletedId);
                        Console.WriteLine($"Сущность с Id {deletedId} удалена");
                        break;

                    case 4:
                        Console.WriteLine("Введите ID сущности");
                        var getId = Guid.Parse(Console.ReadLine());
                        var _dto = _musicGroupService.GetById(getId);
                        Console.WriteLine(_dto);
                        break;

                    default:
                        Console.WriteLine("Пошел на хуй, мудила");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
