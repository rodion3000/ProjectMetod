using System;
namespace ProjectMetod
{
    class Programm
    {
        static void Main(string[] args)
        {
            UserName();


        }

        static string[] CreateArroyPet(int num)
        {
            var result = new string[num];

            for (int i = 0; i < result.Length; i++)

            {
                Console.WriteLine("Назовите клички питомцев");
                result[i] = Console.ReadLine();
            }
            return result;
        }

        static string[] favcolors(int col)
        {

            var result = new string[col];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static bool ChekNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                Console.WriteLine("цифра введена неккоректно, введите заново");
                return true;

            }
        }
        static (string name, string lastname, int age, string pet, int arrpet, int colors) BBUser()
        {
            (string name, string lastname, int age, string pet, int arrpet, int colors) User = ("", "", 0, "", 0, 0);
            string Colorist;
            string Age;
            int intcolor;
            int intage;
            int intpet;
            string Arrpet;
            Console.WriteLine("Введите имя");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.lastname = Console.ReadLine();


            do
            {
                Console.WriteLine("Введите возраст");
                Age = (Console.ReadLine());
            } while (ChekNum(Age, out intage));
            User.age = intage;


            Console.WriteLine("Есть ли питомец, да или нет?");
            User.pet = Console.ReadLine();
            if (User.pet == "да")


            {
                do
                {
                    Console.WriteLine("Укажите колличество питомцев");
                    Arrpet = Console.ReadLine();
                    CreateArroyPet(int.Parse(Arrpet));
                } while (ChekNum(Arrpet, out intpet));
                User.arrpet = intpet;

            }


            do
            {
                Console.WriteLine("Напишите колличество любимых цветов и перечислите их");
                Colorist = Console.ReadLine();
                favcolors(int.Parse(Colorist));
            } while (ChekNum(Colorist, out intcolor));
            User.colors = intcolor;

            return User;
        }
        static void UserName()
        {
            (string name, string lastname, int age, string pet, int arrpet, int colors) User = ("", "", 0, "", 0, 0);
            BBUser();




        }
    }

}

