using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

абстрактное свойство - название животного.
В классе Animal нужно определить следующие методы:

конструктор, устанавливающий значение по умолчанию для названия;
абстрактный метод Say(), который выводит звук, который издает животное;
неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

свойство – название животного;
метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
 */

namespace Zadanie_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat ();
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.ShowInfo();
            Cat cat1 = new Cat ("Мурка");
            cat1.ShowInfo();
            Dog dog1 = new Dog("Жучка");
            dog1.ShowInfo();
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write(Name+" - ");
            Say();
        }

    }

    class Cat: Animal
    {
        string name;

        public Cat()
            :base("Кошка")
        {
        }

        public Cat(string name)
            : base(name)
        { }

        public override string Name
        { get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }    class Dog: Animal
    {
        string name;

        public Dog()
            :base("Собака")
        {
        }

        public Dog(string name)
            : base(name)
        { }

        public override string Name
        { get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
