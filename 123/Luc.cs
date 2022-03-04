using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace Mersen_Luk
{
    class Program
    {
        public static BigInteger getRandom(int length, BigInteger bottom, BigInteger upper)
        {
            Random random = new Random();
            byte[] data = new byte[length];
            random.NextBytes(data);
            BigInteger bi = new BigInteger(data);
            if (bi < 0)
            {
                bi *= -1;
            }
            
            BigInteger minus = upper - bottom + 1;
            if(minus == 0)
            {
                return bi;
            }
            bi = bi % minus;
            bi += bottom;
            return bi;
        }

        public static BigInteger Pows(BigInteger a, BigInteger b)
        {
            BigInteger temp = a;
            for (BigInteger i = 0; i < b - 1; ++i)
            {
                a *= temp;
            }
            return a;
        }

        public static BigInteger getRandom(int length)
        {
            Random random = new Random();
            byte[] data = new byte[length];
            random.NextBytes(data);
            BigInteger bi = new BigInteger(data);
            return bi;
        }

        public static BigInteger nod(BigInteger m, BigInteger n)
        {
            while (m != 0 && n != 0)
            {
                if (m >= n)
                    m %= n;
                else
                    n %= m;
            }
            return m + n;
        }
        public static bool MillerRabinTest(BigInteger n, int k)
        {
            if (n % 2 == 0)
            {
                return false;
            }
            BigInteger t = n - 1;
            int s = 0;

            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }

            for (int i = 0; i < k; i++)
            {
                

                BigInteger hight = n - 2;

                BigInteger a = getRandom(1, new BigInteger(2), hight);

                BigInteger temp = new BigInteger(1);
                if (nod(a, n) != temp)
                {
                    return false;
                }

                BigInteger x = BigInteger.ModPow(a, t, n);

        
                if (x == 1 || x == n - 1)
                    continue;

      
                for (int r = 1; r < s; r++)
                {
             
                    x = BigInteger.ModPow(x, 2, n);

            
                    if (x == 1)
                    {
                        return false;
                    }


                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                {
                    return false;
                }
                
            }
            return true;
        }


        public static BigInteger GetMin(int numu)
        {
            BigInteger start = 1;

            for (int i = 1; i < numu; ++i)
            {
                start *= 2;
            }
            return start;
        }

        

        public static BigInteger GetMax(int numu)
        {
            BigInteger start = 1;

            for (int i = 1; i < numu; ++i)
            {
                start *= 2;
                start++;
            }
            return start;
        }

        private static Boolean isMersennePrime(int p)
        {
            if (p % 2 == 0) { 
                return (p == 2); 
            }
            else
            {
                for (int i = 3; i <= (int)Math.Sqrt(p); i += 2)
                {
                    if (p % i == 0)
                    { 
                        return false; //not prime
                    }
                }
               // Console.WriteLine("regregregergergregerg");
                BigInteger m_p = BigInteger.Pow(2, p) - 1;
                //Console.WriteLine(m_p);
                BigInteger s = 4;
                BigInteger k = new BigInteger(1);
                while (k != p - 1)
                {
                    s = BigInteger.ModPow((s * s - 2), 1, m_p);
                    //Console.WriteLine(s);
                    ++k;
                }
                //for (int i = 1;  i <= p-2 ; i++)
                //{
                //    s = BigInteger.ModPow((s*s - 2), 1, m_p);
                //    Console.WriteLine(s);
                //}
                return s == 0;
            }
        }

        static void Main(string[] args)
        {
           // int ty = Convert.ToInt32(Console.ReadLine());

            BigInteger max = new BigInteger(25);
            
            
            BigInteger num = getRandom(1, 3, max);
            //Console.WriteLine(list[(int)num]);


             do
             {
                 while (MillerRabinTest(num, (int)(Math.Log(0.0000001) / Math.Log(0.25)) + 1) != true)
                 {
                     num = getRandom(1, 3, max);
                 }
             } while (isMersennePrime((int)num) != true);

           
            Console.WriteLine("Сгенерированная степень: ");
            Console.WriteLine(num);
            BigInteger bi = new BigInteger(2);
            Console.WriteLine("Сгенерированное число мерсена: ");
            BigInteger mersen_num = Pows(bi, num) - 1;
            Console.WriteLine(mersen_num);

           
        }
        

        

        


    }
}
