using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZB_kozmondasok
{
    internal class Program
    {
        static void elso ()
        {
            List<string> lista = new List<string>();
            List<string> listab = new List<string>();

            StreamReader be = new StreamReader("szoveg1.txt");
            
            string sor;
            string[] reszek;

            sor = be.ReadLine();
            while (sor != null) 
            {
                reszek = sor.Split('\n');
                lista.Add(reszek[0]);
                sor = be.ReadLine();
            }
            be.Close();


            StreamReader bee = new StreamReader("szoveg2.txt");

            string sorr;
            string[] reszekk;

            sorr = bee.ReadLine();
            while (sorr != null)
            {
                reszekk = sorr.Split('\n');
                listab.Add(reszekk[0]);
                sorr = bee.ReadLine();
            }
            bee.Close();


            //1.feladat
            Console.WriteLine("1. feladat:");
            Console.WriteLine($"{lista.Count} db sort tartalmaz.");
            Console.WriteLine($"{listab.Count} db sort tartalmaz.");



            //2.feladat
            Console.WriteLine("\n2. feladat:");
            string asd = lista.OrderByDescending(s => s.Length).First();
            string asdd = listab.OrderByDescending(s => s.Length).First();
            Console.WriteLine($"A leghosszabb sor: {asd}");
            Console.WriteLine($"A leghosszabb sor: {asdd}");



            //3.feladat
            List<string> osszes = new List<string>();
            osszes.AddRange(lista);
            osszes.AddRange(listab);

            //4.feladat
            osszes.Sort();
            Console.WriteLine("\n4. feladat:");
            foreach (var item in osszes)
            {
                Console.WriteLine(item);
            }



            //5.feladat
            Console.WriteLine("\n5. feladat:");
            int notspace = 0;
            foreach (var item in osszes)
            {
                foreach(var item2 in item)
                {
                    if (item2 != ' ')
                    {
                        notspace++;
                    }
                }
            }

            Console.WriteLine($"{notspace} db nem szóköz karakter.");



            //6.feladat
            StreamWriter ki = new StreamWriter("kozmondasok.txt");
            foreach (var item in osszes)
            {
                ki.WriteLine(item);
            }
            ki.Close();

        }
        static void Main(string[] args)
        {
            /* 
            Közmondasok
            SZB - 2025.01.28.
            */
            string fejlec = "Közmondasok";
            Console.WriteLine(fejlec);
            for (int i = 0; i < fejlec.Length; i++) Console.Write('-');
            Console.WriteLine();


            elso();


            Console.WriteLine("\nNyomj meg bármit a kilépéshez!");
            Console.ReadKey();
        }
    }
}
