using System;

namespace птицы
{
    interface Ibird
    {
       string Fluing();
       string Swim();
        
    }
    abstract class Birds:Ibird
    {
        public string Fluing()
        {
            return ("Птица летит");
        }
        public string Swim()
        {
           return ("Птица плывет");
        }
    }
    class Kivi :Birds
    {
       public void move()
        {
            Console.WriteLine("Птица класса киви умеет:" + Swim());
        }
    }
    class Duck:Birds
    {
        public void move()
        {
            Console.WriteLine("Птица класса утка умеет:" + Swim() + " " + Fluing());
        }
    }
    class Penguin : Birds
    {
        public void move()
        {
            Console.WriteLine("Птица класса пенгвин умеет:" + Swim());
        }
    }
    class Budgerigar : Birds
    {
        public void move()
        {
            Console.WriteLine("Птица класса волнистый попугай умеет:" + Swim());
        }
    }
}
