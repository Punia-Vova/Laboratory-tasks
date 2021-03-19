using System;

namespace птицы
{
    interface Ifluing
    {
        void Flaing();
    }
    interface Iswin
    {
        void Swim();
    }
    abstract class Ibird:Ifluing,Iswin
    {
        private string flai = "Птица летит";
        private string swi = "Птица плывет";
        protected bool swim;
        protected bool flain;
        protected string name;
        public void move()
        {
            Console.WriteLine(name+"::"+flai + ":"+ flain + ", " +swi + ":" + swim);
        }
        public void Swim()
        {
            Console.WriteLine(name+"::"+swi + ":" + swim);
        }
        public void Flaing()
        {
            Console.WriteLine(name+"::"+flai + ":" + flain);
        }
    }

    class Kivi:Ibird
    {
        public Kivi()
        {
            name = "Киви";
            swim = false;
            flain = false;
        }
    }
    class Duck:Ibird
    {
        public Duck()
        {
            name = "Утка";
            swim = true;
            flain = true;
        }
    }
    class Penguin :Ibird
    {
        public Penguin()
        {
            name = "Пенгвин";
            swim = true;
            flain = false;
        }
    }
    class Budgerigar :Ibird
    {
        public Budgerigar()
        {
            name = "Попугай";
            swim = false;
            flain = false;
        }
    }
}
