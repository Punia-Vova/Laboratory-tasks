using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Папа_мама
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько всего сообщений вы хотите вывести?");
            PapaMama.num_of_repeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько тредов вы хотите создать?");
            int numThr = int.Parse(Console.ReadLine());
            Thread[] threads = new Thread[numThr];
            for (int i = 0; i < numThr; i++)
            {
                Console.WriteLine("Какое сообщение вы хотите вывести в " + (i + 1).ToString() + " треде?");
                string message = Console.ReadLine();
                Console.WriteLine("Сколько раз вы хотите вывести сообщение в " + (i + 1).ToString() + " треде?");
                int rep = int.Parse(Console.ReadLine());
                Console.WriteLine("С каким интервалом вы хотите выводить сообщения в " + (i + 1).ToString() + " треде(в миллисекундах)?");
                int inter = int.Parse(Console.ReadLine());
                PapaMama papa = new PapaMama(message, rep, inter);
                threads[i] = new Thread(papa.Say);
            }
            foreach (var x in threads)
            {
                x.Start();
            }
            foreach (var x in threads)
            {
                x.Join();
            }
        }
    }
}