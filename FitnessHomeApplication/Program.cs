using FitnessHomeApplication;
using FitnessHomeApplication.BL.Model;
using FitnessHomeApplication.BL.Controller;

Console.WriteLine("Вас приветствует приложение FitnessApplication");
Console.Write("Введите имя пользователя: ");

var name = Console.ReadLine();

var controller = new UserController(name);
if (controller.IsNewUser)
{
    Console.Write("Введите пол:");
    var gender = Console.ReadLine();
    var birthDate = ParseDateTime();
    var weight = ParseDouble("вес");
    var height = ParseDouble("рост");

    controller.SetNewUserData(gender, birthDate, weight, height);
}

Console.WriteLine(controller.CurrentUser);


static DateTime ParseDateTime()
{
    DateTime birthDate;
    while (true)
    {
        Console.Write("Введите дату рождения: (dd.MM.yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            return birthDate;
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
        }
    }
}

static double ParseDouble(string name)
{
    while (true)
    {
        Console.Write($"Введите {name}: ");
        if (double.TryParse(Console.ReadLine(), out double value))
        {
            return value;
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
        }
    }
}


