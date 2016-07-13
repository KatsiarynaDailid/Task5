using System;
using System.Numerics;


namespace Task5LINQ
{
    public static class ExtensionMethods
    {
        /*
         * Miller-Rabin primality test, iteration signifies the accuracy
         */

        public static bool IsPrime(this BigInteger p)
        {
            int iteration = 10;
            if (p < 2)
            {
                return false;
            }
            if (p != 2 && p % 2 == 0)
            {
                return false;
            }
            BigInteger s = p - 1;
            while (s % 2 == 0)
            {
                s /= 2;
            }
            Random rand = new Random();
            for (int i = 0; i < iteration; i++)
            {

                BigInteger a = rand.Next() % (p - 1) + 1, temp = s;
                BigInteger mod = Modulo(a, temp, p);
                while (temp != p - 1 && mod != 1 && mod != p - 1)
                {
                    mod = MulMod(mod, mod, p);
                    temp *= 2;
                }
                if (mod != p - 1 && temp % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static BigInteger MulMod(BigInteger a, BigInteger b, BigInteger mod)
        {
            BigInteger x = 0, y = a % mod;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    x = (x + y) % mod;
                }
                y = (y * 2) % mod;
                b /= 2;
            }
            return x % mod;
        }

        /* 
         * modular exponentiation
         */
        static BigInteger Modulo(BigInteger base1, BigInteger exponent, BigInteger mod)
        {
            BigInteger x = 1;
            BigInteger y = base1;
            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    x = (x * y) % mod;
                y = (y * y) % mod;
                exponent = exponent / 2;
            }
            return x % mod;
        }


    }
}
