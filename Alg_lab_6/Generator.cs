using System;
using System.Linq;

namespace Alg_lab_6
{
    public class Generator
    {
        public static Random random = new Random();
        //Generate random car number
        public static string NumGenerator()
        {
            int[] nums = new int[4];
            string symb = null;
            int regeon = 0;

            for (int i = 0; i < nums.Length; i++)
                nums[i] = random.Next(0, 9);
            symb = RandonString();
            regeon = random.Next(1, 7);
            string numStr = string.Join("", nums);

            return numStr + symb + "-" + regeon + "BY";
        }
        //Generate random car
        public static string CarGenerator()
        {
            string[] car = { "Lada", "Volvo", "Ford", "Toyota", "Nissan", "Volga", "BMW", "Mersedess", "Dewoo", "Shewrolete", "Opel", "SAS", "Seat" };
            return car[random.Next(car.Length)];
        }
        //Generate random owner name
        public static string OwnerGenerator()
        {
            string[] name = { "Харитон","Артемий","Елисей","Александр","Дмитрий","Виктор","Изяслав","Ярослав","Ростислав","Фадей","Богдан","Сергей",
        "Пахом","Вадим","Макар","Марк","Митофан","Остап","Потап","Прохор","Радислав","Андрей","Артем","Олег","Валерий","Виталий","Владимир","Влас",
        "Вячеслав","Геннадий","Георгий","Герман","Глеб","Григорий","Давид","Данила","Дементий","Дмитрий","Денис","Евгений","Евдоким","Егор","Евстафий",
        "Елисей","Емельян","Игорь","Игнатий","Захар","Измаил","Илья","Иннокентий","Иосиф","Карл","Кирилл","Константин","Ян","Якуб","Юрий","Фома",
        "Тимофей","Тимур","Тимур","Тихон","Ульян","Федор", "Антон", "Иван"};

            return name[random.Next(name.Length)];
        }
        //Generate random dates
        public static DateTime LastDateGenerator()
        {
            DateTime start = new DateTime(2000, 1, 1);
            int renge = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(renge));
        }

        public static DateTime EndDateGenerator(DateTime date)
        {
            int renge = (DateTime.Today - date).Days;
            return date.AddDays(random.Next(renge / 9));
        }

        private static Random random1 = new Random();
        //Generate random char part car number
        public static string RandonString(int length = 2)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random1.Next(s.Length)]).ToArray());
        }
    }
}
