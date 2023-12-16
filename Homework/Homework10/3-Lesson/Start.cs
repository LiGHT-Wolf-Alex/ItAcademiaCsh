using System.Xml.Linq;

namespace ItAcademiaCsh.Homework.Homework10._3_Lesson;

class Start
{
    private List<Person> _people;

    public Start()
    {
        LoadData();

        while (true)
        {
            Console.WriteLine("1. Записать данные всех сотрудников в XML");
            Console.WriteLine("2. Просмотреть данные сотрудника по имени");
            Console.WriteLine("3. Фильтр по языку программирования");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        DisplayAllDataInXml();
                        break;
                    case 2:
                        DisplayPersonByName();
                        break;
                    case 3:
                        FilterByProgrammingLanguage();
                        break;
                    case 4:
                        SaveData();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
            }
        }
    }

    private void LoadData()
    {
        var json = File.ReadAllText("data.json");
        _people = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(json) ?? new List<Person>();
    }

    private void SaveData()
    {
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(_people);
        File.WriteAllText("data.json", json);
    }

    private void DisplayAllDataInXml()
    {
        var xmlData = new XElement("People",
            from person in _people
            select new XElement("Person",
                new XElement("Name", person.Name),
                new XElement("Birthday", person.Birthday),
                new XElement("Height", person.Height),
                new XElement("Weight", person.Weight),
                new XElement("Car", person.Car),
                new XElement("Languages",
                    from language in person.Languages
                    select new XElement("Language", language)
                )
            )
        );

        xmlData.Save("data.xml");

        Console.WriteLine("Данные сохранены в XML.");
    }

    private void DisplayPersonByName()
    {
        Console.WriteLine("Введите имя сотрудника:");
        var name = Console.ReadLine();

        var person = _people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (person != null)
        {
            Console.WriteLine($"Имя: {person.Name}");
            Console.WriteLine($"День рождения: {person.Birthday}");
            Console.WriteLine($"Рост: {person.Height}");
            Console.WriteLine($"Вес: {person.Weight}");
            Console.WriteLine($"Наличие автомобиля: {person.Car}");
            Console.WriteLine($"Языки программирования: {string.Join(", ", person.Languages)}");
        }
        else
        {
            Console.WriteLine("Сотрудник не найден.");
        }
    }

    private void FilterByProgrammingLanguage()
    {
        Console.WriteLine("Введите язык программирования:");
        var language = Console.ReadLine();

        var filteredPeople = _people.Where(p => p.Languages.Contains(language, StringComparer.OrdinalIgnoreCase))
            .ToList();

        if (filteredPeople.Any())
        {
            Console.WriteLine($"Сотрудники, использующие язык программирования {language}:");
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Имя: {person.Name}");
            }
        }
        else
        {
            Console.WriteLine($"Нет сотрудников, использующих язык программирования {language}.");
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public string Birthday { get; set; }
    public int Height { get; set; }
    public double Weight { get; set; }
    public bool Car { get; set; }
    public List<string> Languages { get; set; }
}