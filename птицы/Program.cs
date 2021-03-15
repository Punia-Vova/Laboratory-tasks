using System;

namespace птицы
{
    class Program
    {
        static void Main(string[] args)
        {
            Kivi a = new Kivi();
            Duck b = new Duck();
            Penguin c = new Penguin();
            Budgerigar d = new Budgerigar();
            a.move();
            b.move();
            c.move();
            d.move();
        }
    }
}
