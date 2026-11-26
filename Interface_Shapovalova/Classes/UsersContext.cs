using System.Collections.Generic;
using Interface_Shapovalova.Models;
using Interface_Shapovalova.Interfaces;

namespace Interface_Shapovalova.Classes
{
    public class UsersContext : Users, IUsers
    {
        public List<Users> AllUsers;

        public UsersContext() : base(0, "")
        {
            AllUsers = new List<Users>();
            this.All(out AllUsers);
        }

        public void All(out List<Users> Users)
        {
            Users = new List<Users>();
            Users.Add(new Users(1, "Аликина Ольга"));
            Users.Add(new Users(2, "Бояркин Данил"));
            Users.Add(new Users(3, "Бурманитов Владислав"));
            Users.Add(new Users(4, "Дылдин Максим"));
            Users.Add(new Users(5, "Евдокимов Даниил"));
            Users.Add(new Users(6, "Костюкин Никита"));
            Users.Add(new Users(7, "Кучин Данил"));
            Users.Add(new Users(8, "Мотырев Александр"));
            Users.Add(new Users(9, "Мухридинов Далер"));
            Users.Add(new Users(10, "Олейник Владимир"));
            Users.Add(new Users(11, "Саблин Константин"));
            Users.Add(new Users(12, "Субботин Валерий"));
            Users.Add(new Users(13, "Сукрушев Егор"));
            Users.Add(new Users(14, "Торсунов Даниил"));
            Users.Add(new Users(15, "Хабибрахманов Никита"));
            Users.Add(new Users(16, "Хикматулин Григорий"));
            Users.Add(new Users(17, "Черенев Сергей"));
            Users.Add(new Users(18, "Чупин Дмитрий"));
            Users.Add(new Users(19, "Шилов Дмитрий"));
        }
    }
}