using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomWork
{
    class Program
    {
        public delegate void SumDelegate(int n);
        static void Main(string[] args)
        {
            SumDelegate check = MinusPlus;
            check += AloneDouble;
            check += Simple;
            check(11);

            #region ATM
            //ATM atm = new ATM(5);
            //atm.TakeMoney += delegate (int n, int m)
            //  {
            //      if (m > n)
            //      {
            //          Console.WriteLine("Zehmet olmasa pulunuzu goturun!!!");
            //      }
            //      else
            //      {
            //          Console.WriteLine("Ay kasib balansin yoxdu");
            //      }
            //  };
            //atm.ATMnum(8);
            #endregion

        }
        static void Simple(int k)
        {
            int count = 0;
            for (int i = 1; i <= k; i++)
            {

                if (k % i == 0)
                {
                    count++;
                }

            }


            if (count > 2)
            {
                Console.WriteLine("Sade eded deyil");
            }
            else
            {
                Console.WriteLine("Sade ededdir");
            }
        }
        static void AloneDouble(int m)
        {
            if (m % 2 == 0)
            {
                Console.WriteLine("cut ededdir");
            }
            else
            {
                Console.WriteLine("tek ededdir");
            }
        }
        static void MinusPlus(int n)
        {
            if (n < 0)
            {
                Console.WriteLine( "menfidir");
            }
            else
            {
                Console.WriteLine("musbetdir");
                
            }
        }
    }

    #region ATM
    //class ATM
    //{
    //    public event Action<int, int> TakeMoney;
    //    public int m { get; private set; }
    //    public ATM(int n)
    //    {
    //        m = n;
    //    }

    //    public void ATMnum(int n)
    //    {
    //        TakeMoney?.Invoke(n, m);
    //    }
    //}
    #endregion
}
