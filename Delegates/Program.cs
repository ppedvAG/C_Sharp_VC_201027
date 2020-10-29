using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Delegates
{
    public delegate int MeinDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MeinDelegate delegateVariable;

            delegateVariable = Addiere;

            int erg = delegateVariable(5, 10);

            Console.WriteLine(erg);

            delegateVariable = Subtrahiere;
            Console.WriteLine(delegateVariable(5,10));

            delegateVariable += Addiere;

            Console.WriteLine(delegateVariable(5,10));

            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;

            foreach (var item in delegateVariable.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable -= Subtrahiere;

            delegateVariable = null;

            Func<int, int, int> MeinFunc = Subtrahiere;
            MeinFunc += Addiere;

            Console.WriteLine(MeinFunc(12,78));

            FühreAus(Addiere);

            BaueFunc()(45, 12);

            List<string> Städteliste = new List<string>() { "München", "Berlin", "Hamburg", "Hannover", "Köln" };

            Console.WriteLine(Städteliste.Find(SucheStadtMitB));

            string gefundeneStadt = Städteliste.Find
                (
                    delegate (string stadt)
                    {
                        return stadt.StartsWith('B');
                    }
                );
            Console.WriteLine(gefundeneStadt);

            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith('B'); });
            gefundeneStadt = Städteliste.Find(stadt => stadt.StartsWith('B'));

            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }
        }

        public static bool SucheStadtMitB(string stadt)
        {
            return stadt.StartsWith('B');
        }

        public static void FühreAus(MeinDelegate method)
        {
            Console.WriteLine(10 + method(10, 78));
        }

        public static Func<int,int,int> BaueFunc()
        {
            return Subtrahiere;
        }

        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}
