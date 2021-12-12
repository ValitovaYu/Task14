using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowInfo();
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal()
        {
            
        }
        public abstract void Say();        
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

   
    class Cat:Animal
    {
        string name = "кошка";
        public override string Name
        {
            get
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
    }
    class Dog:Animal
    {
        string name = "собака";
        public override string Name
        {
            get
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
