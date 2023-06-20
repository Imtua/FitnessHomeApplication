using FitnessHomeApplication.BL.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace FitnessHomeApplication.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="user"></param> 
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {
            // TODO: Проверка входных параметров

            var gender = new Gender( genderName );
            User = new User(userName, gender, birthDay, weight, height);
        }

        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns> Пользователь приложения. </returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

                // TODO: Что-то делать если не удалось прочитать
            }
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fileStream = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, User);
            }
        }
    }
}
