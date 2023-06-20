using FitnessHomeApplication;
using FitnessHomeApplication.BL.Model;
using FitnessHomeApplication.BL.Controller;

Console.WriteLine("Вас приветствует приложение FitnessApplication");
Console.Write("Введите имя пользователя: "); 

var name = Console.ReadLine();

Console.Write("Введите пол: ");
var gender = Console.ReadLine();

Console.Write("Введите дату рождения: ");
var birthdate = DateTime.Parse(Console.ReadLine()); // TODO: переписать

Console.WriteLine("Введите вес");
var weight = double.Parse(Console.ReadLine());

Console.WriteLine("Введите вес");
var height = double.Parse(Console.ReadLine());

var controller = new UserController(name, gender, birthdate, weight, height);
controller.Save();



