using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class Program
    {
        //public delegate void Welcome(string s);
        public delegate string Information(string str,int n);
        static void Main(string[] args)
        {
            #region delegate
            //Information info = (s,n) =>
            //  {
            //      Console.WriteLine($"{s} {n} yashindadir");
            //  };

            //info("Cavid", 5);
            //Program p = new Program();
            //Welcome welcome = new Welcome(p.Hello);

            //Welcome welcome = str =>
            //{
            //    Console.WriteLine($"Are you okey,{str} ?");
            //};
            //welcome += How;
            //welcome += Hello;
            //welcome("Cavid");

            //Action<string, string> welcome = (str1, str2) =>
            // {
            //     Console.WriteLine($"{str1} yaxshi oglandir,{str2}");
            // };

            //welcome += Hello;
            //welcome("Cavid", "alqish");

            //Func<int, int, string> info = (i, j) =>
            //  {
            //      return $"{i + j} ededdir";
            //  };

            //info += LastMethod;

            //info -= LastMethod;

            //Console.WriteLine(info(5, 8));
            #endregion

            Compare compare = new Compare(5);
            compare.CompareEvent += delegate (int n, int m)
            {
                Console.WriteLine($"{n} ededi {m} ededinden boyukdur");
            };

            compare.CompareNumbers(6);
           
        }

        #region delegate
        //static string LastMethod(int n,int i)
        //{
        //    return "14 ededdir";
        //}

        //static void Hello(string str,string s)
        //{
        //    Console.WriteLine($"Hello {str} {s}");
        //}

        //static void How(string str)
        //{
        //    Console.WriteLine($"How are you, {str} ?");
        //}
        #endregion

        

    }

    class Compare
    {
        public event Action<int,int> CompareEvent;
        public int Myint { get;private set; }

        public Compare(int n)
        {
            Myint = n;
        }

        public void CompareNumbers(int n)
        {
            if (Myint > n)
            {
                Console.WriteLine("boyukdur");
            }
            else
            {
                CompareEvent?.Invoke(n,Myint);
            }
        }
    }
}
