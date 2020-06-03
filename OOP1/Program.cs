using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    

    class Buyer
    {
        protected internal string surName;
        public string name;
        internal string patronymic;
        protected internal string address;
        internal string numCreditСard;
        public string numBankAccount;

    }

    class Subscriber
    {
        protected internal string surName;
        public string name;
        internal string patronymic;
        protected internal string address;
        internal string numCreditСard;
        public string numID;
        internal string timeIntercity;
        protected internal string timeCity;
    }

    class petShop
    {
        public string name;
        internal string price;
        protected internal string animal;
        internal string gender;
        public string quantity;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("            Покупатель");
            Console.Write("                 "); Console.WriteLine((char)8595);
            Buyer buyer1 = new Buyer();
            buyer1.surName = "Bazil9"; Console.WriteLine("Фамилия - " + buyer1.surName);
            buyer1.name = "Nikitka"; Console.WriteLine("Имя - "+buyer1.name);
            buyer1.patronymic = "Seregka"; Console.WriteLine("Отчество - "+buyer1.patronymic);
            buyer1.address = "Pozariha"; Console.WriteLine("Адрес - "+buyer1.address);
            buyer1.numCreditСard = "2200 3399 1166 3497"; Console.WriteLine("Номер кредитки - " + buyer1.numCreditСard);
            buyer1.numBankAccount = "52347 841 3 9778 0823555"; Console.WriteLine("Номер счета - " + buyer1.numBankAccount);
            Console.Write("                 "); Console.Write((char)8593);
            Console.WriteLine("\n Нажмите на Enter, чтобы продолжить");
            Console.ReadLine();


            Console.WriteLine("            Абонент");
            Console.Write("                 "); Console.WriteLine((char)8595);
            Subscriber subscriber1 = new Subscriber();
            Console.Write("Введите Фамилию - ");
            subscriber1.surName = Console.ReadLine();
            Console.Write("Введите Имя - ");
            subscriber1.name = Console.ReadLine();
            Console.Write("Введите Отчество - ");
            subscriber1.patronymic = Console.ReadLine();
            Console.Write("Введите Адрес - ");
            subscriber1.address = Console.ReadLine();
            Console.Write("Введите Номер Кредитки - ");
            subscriber1.numCreditСard = Console.ReadLine();
            Console.Write("Введите ID - ");
            subscriber1.numID = Console.ReadLine();
            Console.Write("Введите время междугородных переговоров - ");
            subscriber1.timeIntercity = Console.ReadLine();
            Console.Write("Введите время городских переговоров - ");
            subscriber1.timeCity = Console.ReadLine();
            Console.Write("                 "); Console.Write((char)8593);
            Console.WriteLine("\n Нажмите на Enter, чтобы продолжить");
            Console.ReadLine();


            Console.WriteLine("            Зоомагазин");
            Console.Write("                 "); Console.WriteLine((char)8595);
            petShop petShop1 = new petShop();
            Console.Write("Введите Животное - ");
            petShop1.animal = Console.ReadLine();
            Console.Write("Введите Пол - ");
            petShop1.gender = Console.ReadLine();
            Console.Write("Введите Количевство - ");
            petShop1.quantity = Console.ReadLine();
            Console.Write("Введите Цену - ");
            petShop1.price = Console.ReadLine();
            Console.Write("Введите Имя - ");
            petShop1.name = Console.ReadLine();
            Console.Write("                 "); Console.Write((char)8593);
            Console.WriteLine("\n Нажмите на Enter, чтобы выйти");
            Console.ReadLine();
        }
    }
}
